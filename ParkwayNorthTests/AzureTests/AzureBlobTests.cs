using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.AzureStorage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParkwayNorthTests.AzureTests
{
    [TestClass]
    public class AzureBlobTests
    {
        [TestMethod]
        public async Task BlobStuff()
        {
            AzureStorage storage = new AzureStorage();
            var idk = await storage.GetBlobs();
            string imagePath = @"C:\Users\Bryce\source\repos\ParkwayNorthEvents\ParkwayNorthTests\AzureTests\TestImage\ParkwayNorthNavBrand.jpg";
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                //var res = await storage.UploadImage(memoryStream);
            }
            int i = 0;
        }
    }
}