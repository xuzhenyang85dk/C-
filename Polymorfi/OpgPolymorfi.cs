namespace Polymorfi
{
    internal partial class OpgPolymorfi
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
            t.Ryst();
            t.Skriv();

            LudoTerning l = new LudoTerning();
            l.Skriv();
            Console.WriteLine(l.ErGlobus());
            Console.WriteLine(l.ErStjerne());

            // Hold console åben ved debug (kun nødvendigt ved .NET Framework - ikke .NET Core)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}