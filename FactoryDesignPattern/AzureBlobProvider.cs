namespace FactoryDesignPattern
{
    public class AzureBlobProvider : IStorageProvider
    {
        public void SaveFile(string fileName, byte[] fileData)
        {
            Console.WriteLine($"Saving {fileName} to Azure Blob Storage...");
        }
        public byte[] RetrieveFile(string fileName)
        {
            Console.WriteLine($"Retrieving {fileName} from Azure Blob Storage...");
            return new byte[0];
        }
    }
}