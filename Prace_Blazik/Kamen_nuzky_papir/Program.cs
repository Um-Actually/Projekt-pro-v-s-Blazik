namespace Kamen_nuzky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] moznosti = { "kamen", "nuzky", "papir" };
            Random rnd = new Random();
            int hracBody = 0;
            int botBody = 0;

            while (hracBody<3 && botBody <3)
            {

                int index = rnd.Next(moznosti.Length);
                string bot = moznosti[index].ToLower();
                Console.WriteLine("Co chcete hrát (kamen,nuzky,papir)?");
                string hrac = Console.ReadLine()?.ToLower() ?? "";

                if (hrac == bot)
                {
                    Console.WriteLine("Remiza");
                }
                else if ((hrac == "kamen" && bot == "nuzky") || (hrac == "nuzky" && bot == "papir") || (hrac == "papir" && bot == "kamen"))
                {
                    Console.WriteLine("Vyhral jsi");
                    hracBody+=1;
                    Console.WriteLine("Skore bot: " + botBody + " Skore hrac:" + hracBody);
                }
                else
                {
                    Console.WriteLine("Prohral jsi");
                    botBody += 1;
                    Console.WriteLine("Skore bot: " + botBody + " Skore hrac: " + hracBody);
                }
            }
        }
    }

}
