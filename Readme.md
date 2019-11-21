# How to download and upload images from (to) the Azure Blob Storage

This example illustrates how to solve two separate tasks:

* download images from the [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) and use it in your WinForms app;
* modify the [PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) to be able to upload local images to the [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) and use it in your WinForms app.

To run this example:

* install the [Azure.Storage.Blobs](https://www.nuget.org/packages/Azure.Storage.Blobs) NuGet package and follow the steps from the [Quickstart: Azure Blob storage client library v12 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet#download-blobs) Microsoft topic;
* specify your connection settings in the **Main** method:
    ![alt text](code.png)

This example fetches images asynchronously, and uses the [UnboundSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.UnboundSource) component to send these loaded images into the [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl).

![Alt text](grid.png)

The [PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) context menu is used to upload images to **Azure Blob Storage**.

![alt text](menu.png)
