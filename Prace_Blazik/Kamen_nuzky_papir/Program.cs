namespace Kamen_nuzky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moznosti= { "kamen", "nuzky", "papir" };   
            Random rnd = new Random();
            int index = rnd.Next(moznosti.Length);
            string bot = moznosti[index].ToLower();
            Console.WriteLine(bot);
            Console.WriteLine("Co chcete hrát (kamen,nuzky,papir)?");
            string hrac = Console.ReadLine()?.ToLower()??"";
            
            if (hrac == bot)
            {
                Console.WriteLine("Remiza");
            }
            else if ((hrac == "kamen" && bot == "nuzky") || (hrac == "nuzky" && bot == "papir") || (hrac == "papir" && bot == "kamen"))
            {
                Console.WriteLine("Vyhral jsi");
            }
            else
            {
                Console.WriteLine("Prohral jsi");
            }
    }
}
