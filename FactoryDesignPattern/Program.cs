using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard? cardDetails = CreditCardFactory.GetCreditCard("MoneyBack");
            
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

            Console.WriteLine("Select your storage provider (AmazonS3, AzureBlob, GoogleCloud): ");
            string? providerName = Console.ReadLine();
            try
            {
                if (string.IsNullOrWhiteSpace(providerName)) throw new ArgumentException("Provider name cannot be null or empty."); 
                IStorageProvider storageProvider = StorageProviderFactory.CreateStorageProvider(providerName);
                storageProvider.SaveFile("sample.txt", new byte[] { 0x01, 0x02 });
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
