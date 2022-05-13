
using Microsoft.Azure;
using Azure.Storage.Blobs;
using System; 



namespace RedeSocial.CrossCutting
{
    public class AzureStorage
    {
        private BlobServiceClient blobServiceClient { get; set; }

        private BlobContainerClient containerClient { get; set; }

        public AzureStorage()
        {
            this.Setup();
        }

        private void Setup()
        {
            string? str = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");

            blobServiceClient = new BlobServiceClient(str);

            string containerName = "imagens";

            containerClient = blobServiceClient.GetBlobContainerClient("imagens");

            if (containerClient == null)
                containerClient = blobServiceClient.CreateBlobContainer(containerName);
        }

        public async Task<string> Save(Stream buffer,string fileName)
        {
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            await blobClient.UploadAsync(buffer);

            return $"https://storage0305diegoadias.blob.core.windows.net/imagens/{fileName}";
        }
    }   
}