using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using DevExpress.Data;
using DevExpress.Utils.Design;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace DXApplication {
    public partial class Main : DevExpress.XtraEditors.XtraForm {
        BlobContainerClient containerClient;
        List<Image> images;
        public Main() {
            InitializeComponent();

            InitContainerClient();

            unboundImageSource.Properties.Add(new UnboundSourceProperty("Image", typeof(Image)));
            gridControl.DataSource = unboundImageSource;
        }
        private void InitContainerClient() {
            var blobServiceClient = new BlobServiceClient(ConnectionSettings.ConnectionSring);
            containerClient = blobServiceClient.GetBlobContainerClient(ConnectionSettings.BlobContainerName);
        }
        async void OnLoadImagesButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            var fileNames = containerClient.GetBlobs().Select(item => item.Name).ToList();

            images = new List<Image>(fileNames.Count);
            unboundImageSource.SetRowCount(fileNames.Count);
            var palette = SvgPaletteHelper.GetSvgPalette(LookAndFeel, ObjectState.Normal);

            foreach(var fileName in fileNames) {
                BlobClient blobClient = containerClient.GetBlobClient(fileName);
                BlobDownloadInfo download = await blobClient.DownloadAsync();
                using(var stream = new MemoryStream()) {
                    await download.Content.CopyToAsync(stream);
                    images.Add(GetImage(stream, palette));
                    gridView.RefreshRow(images.Count - 1);
                }
            }
        }
        Image GetImage(MemoryStream stream, ISvgPaletteProvider palette) {
            Image img = null;
            try {
                stream.Position = 0;
                img = SvgImage.FromStream(stream).Render(palette);
            }
            catch { }
            return img;
        }
        private void OnValueNeeded(object sender, UnboundSourceValueNeededEventArgs e) {
            if(e.RowIndex < images.Count)
                e.Value = images[e.RowIndex];
        }
        private void OnPopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e) {
            e.RestoreMenu = true;
            e.PopupMenu.Items.Add(new DXMenuItem("Upload to Azure Blob Storage", OnMenuItemClick));
        }
        async void OnMenuItemClick(object sender, EventArgs e) {
            if(pictureEdit.Image != null) {
                string fileName = $"TestImage{Guid.NewGuid()}.png";
                BlobClient blobClient = containerClient.GetBlobClient(fileName);
                using(var uploadStream = new MemoryStream()) {
                    pictureEdit.Image.Save(uploadStream, ImageFormat.Png);
                    uploadStream.Position = 0;
                    await blobClient.UploadAsync(uploadStream);
                }
            }
        }
    }
}
