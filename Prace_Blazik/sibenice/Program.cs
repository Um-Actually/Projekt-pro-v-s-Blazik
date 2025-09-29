using System.Xml.Xsl;

namespace sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> slova = new List<string> { "Pepa"};
            string slovo = slova[rnd.Next(slova.Count)].ToLower();
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
                    pokusy = -125000165;
                }
            }
        }
    }
}
