namespace FactoryDesignPattern
{
    public interface IStorageProvider
    {
        void SaveFile(string fileName, byte[] fileData);
        byte[] RetrieveFile(string fileName);
    }
}