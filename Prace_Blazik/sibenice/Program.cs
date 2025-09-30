using System.Xml.Xsl;

namespace sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] obsah = File.ReadAllLines("slova.txt");
            string slovo = obsah[rnd.Next(obsah.Length)].ToLower();
            char[] pismena = slovo.ToCharArray();
            char[] zkryte_slovo= new char[slovo.Length];

            for (int i = 0; i < slovo.Length; i++)
            {
                zkryte_slovo[i] = '_';
            }

            int pokusy = 6;
            while (pokusy > 0)
            {
                Console.WriteLine("Napište písmeno co chcete hrát");
                string input = Console.ReadLine().ToLower(); ;

                for (int i = 0; i < pismena.Length; i++)
                {
                    if (input[0] == pismena[i])
                    {
                        zkryte_slovo[i] = input[0];
                    }


                }
                Console.WriteLine(zkryte_slovo);
                if (!slovo.Contains(input[0]))
                {
                    pokusy--;
                    Console.WriteLine($"Špatně, zbývá {pokusy} pokusů");
                }
                if (!zkryte_slovo.Contains('_'))
                {
                    Console.WriteLine("Vyhrál jsi");
                    Console.WriteLine("Nyní můžete přidat slovo do slovníku");
                    string noveslovo=Console.ReadLine();
                    File.AppendAllText("slova.txt", Environment.NewLine + noveslovo);
                    break;
                }
            }
        }
    }
}
