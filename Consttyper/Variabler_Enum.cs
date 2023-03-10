namespace Consttyper
{
    internal partial class Variabler_Enum
    {
        static void Main(string[] args)
        {
            // Til alle der læser koden...
            // Kulør 0 = Spar
            // Kulør 1 = Hjerter
            // Kulør 2 = Ruder
            // Kulør 3 = Klør


            // Hjerter 2
            int kort1Værdi = 2;                          // værdi
            KortKulør kort1Kulør = KortKulør.Hjerter;   // kulør

            // Skriver "Hjerter 2"
            Console.WriteLine(kort1Kulør.ToString() + "" + kort1Værdi);

            // Ruder 2
            int kort2Værdi = 2;
            KortKulør kort2Kulør = KortKulør.Ruder;

            // Skriver "Ruder 2"
            Console.WriteLine(kort2Kulør.ToString() + "" + kort2Værdi);

            // udskriv tallet der svarer til ruder 
            Console.WriteLine(Convert.ToInt32(kort2Kulør));     // 2
        }
    }
}