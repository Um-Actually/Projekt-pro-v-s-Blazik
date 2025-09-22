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

            int pokusy = 6;
            while (pokusy > 0)
            {
                Console.WriteLine("Napište písmeno co chcete hrát");
                string input = Console.ReadLine().ToLower();
                char[] hrac= input.ToCharArray();

                for (int i = 0; i<pismena.Length;i++)
                { 
                if (hrac[0] == pismena[i])
                    {
                        pismena[i] = hrac[0];
                        Console.WriteLine(pismena[i]);
                    }
                else
                    {
                        Console.WriteLine("_");
                    }
                }
                
            }
        }
    }
}
