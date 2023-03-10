using Newtonsoft.Json;

namespace OpgText
{
    internal class OpgText
    {
        static void Main(string[] args)
        {
            string fornavn = "Xu Zhen";
            string efternavn = "Yang";
            string samletNavn = fornavn + efternavn;
            
            Console.WriteLine($"Fullnavn: {samletNavn}");

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine($"navnStort: {navnStort}");

            string navnLille = samletNavn.ToLower();
            Console.WriteLine($"navnStort: {navnLille}");

            Console.WriteLine(samletNavn.Substring(0, 4));

            Console.WriteLine("Try escape \r\ncharacters");

            System.IO.File.WriteAllText("C:\\Kursus\\OpgVariabler\\OpgText\\saveFile.txt", "Hello world");

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2023, 12, 05);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);
        }
    }
}