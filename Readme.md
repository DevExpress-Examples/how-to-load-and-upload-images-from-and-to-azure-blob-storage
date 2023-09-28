<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/223129392/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T834743)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms PictureEdit - Download and upload images from (to) Azure Blob Storage

This example demonstrates how to do the following:

* Download images from [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/) and use them in a Windows Forms application.
* Customize the [WinForms PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) to allow users to upload local images to [Azure Blob Storage](https://azure.microsoft.com/en-us/services/storage/blobs/).

Follow the steps below to run the example:

* Install the [Azure.Storage.Blobs](https://www.nuget.org/packages/Azure.Storage.Blobs) NuGet package and follow step-by-step instructions from [Quickstart: Azure Blob storage client library v12 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet#download-blobs).
* Specify connection settings in the `Main` method:

  ![Code Sample](code.png)

This example fetches images asynchronously. The example uses the [UnboundSource](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.UnboundSource) component to display loaded images in the WinForms GridControl:

![WinForms Data Grid - DevExpress](grid.png)

Users can use the customized context menu of the [PictureEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PictureEdit) context to upload images to **Azure Blob Storage**.

![Customized Context Menu - WinForms Picture Editor](menu.png)
