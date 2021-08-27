<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/223129392/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T834743)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to download and upload images from (to) the Azure Blob Storage

This example illustrates how to solve two separate tasks:

* download images from the [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) and use them in your WinForms app;
* modify the [PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) to be able to upload local images to the [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/).

To run this example:

* install the [Azure.Storage.Blobs](https://www.nuget.org/packages/Azure.Storage.Blobs) NuGet package and follow the steps from the [Quickstart: Azure Blob storage client library v12 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet#download-blobs) Microsoft topic;
* specify your connection settings in the **Main** method:
    ![alt text](code.png)

This example fetches images asynchronously, and uses the [UnboundSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.UnboundSource) component to send these loaded images into the [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl).

![Alt text](grid.png)

The modified [PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) context menu allows users to upload currently viewed images to **Azure Blob Storage**.

![alt text](menu.png)
