using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkwayNorthEvents.Data;
using Infrastructure.AppSettings;
using Azure;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Azure.Core;

namespace Infrastructure.Data.AzureStorage
{
    public class AzureStorage
    {
        private BlobServiceClient _blobServiceClient;

        public AzureStorage()
        {
            _blobServiceClient = new(AzureConnection.AzureStorageConnectionString);
        }

        public async Task<AsyncPageable<BlobContainerItem>> GetBlobs()
        {
            var idk = _blobServiceClient.GetBlobContainersAsync();
            return idk;
        }

        public async Task<string> UploadImageAsync(IFormFile image, Guid imageId, string containerName = "ENTER CONTAINER NAME")
        {
            try
            {
                var blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
                blobContainerClient.CreateIfNotExists();

                var blobClient = blobContainerClient.GetBlobClient(imageId.ToString()); 
                using (var stream = image.OpenReadStream())
                {
                    await blobClient.UploadAsync(stream, true);
                }
               


                //BlobHttpHeaders headers = new BlobHttpHeaders();
                //headers.ContentType = "image/jpg";
                //BlobUploadOptions options = new BlobUploadOptions()
                //{
                //    HttpHeaders = new() { ContentType = "image/jpeg" }
                //};
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                var name = ex.GetType().Name;
                int i = 0;
                throw;
            }
        }

        public async Task DeleteImageAsync(string imageName)
        {
            var blobContainerClient = _blobServiceClient.GetBlobContainerClient("ENTER CONTAINER NAME");
            blobContainerClient.CreateIfNotExists();

            var blobClient = blobContainerClient.GetBlobClient(imageName);
            var result = await blobClient.DeleteIfExistsAsync();
            var worked = result.Value;
            int i = 0;
        }
    }
}
