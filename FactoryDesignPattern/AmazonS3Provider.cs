namespace FactoryDesignPattern
{
    public class AmazonS3Provider : IStorageProvider
    {
        public void SaveFile(string fileName, byte[] fileData)
        {
            Console.WriteLine($"Saving {fileName} to Amazon S3...");
        }
        public byte[] RetrieveFile(string fileName)
        {
            Console.WriteLine($"Retrieving {fileName} from Amazon S3...");
            return new byte[0]; 
        }
    }
}