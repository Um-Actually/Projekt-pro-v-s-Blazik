namespace piskvorky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            char[] pole = new char[9];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = '-';
            }
            int[][] kombinace = new int[][]
            {
                new int[] {0, 1, 2}, 
                new int[] {3, 4, 5}, 
                new int[] {6, 7, 8}, 
                new int[] {0, 3, 6}, 
                new int[] {1, 4, 7}, 
                new int[] {2, 5, 8}, 
                new int[] {0, 4, 8}, 
                new int[] {2, 4, 6}  
            };

            while (true)
            {

                Console.WriteLine(
                    pole[0] + "|" + pole[1] + "|" + pole[2] + "\n" +
                    pole[3] + "|" + pole[4] + "|" + pole[5] + "\n" +
                    pole[6] + "|" + pole[7] + "|" + pole[8] + "\n");
                Console.WriteLine("Zadej pozici 0-8:");
                int poziceHrac1;
                while (true)
                {
                    Console.WriteLine("Hráč X - zadej pozici 0-8:");
                    poziceHrac1 = Convert.ToInt32(Console.ReadLine());

                    if (poziceHrac1 >= 0 && poziceHrac1 < 9 && pole[poziceHrac1] == '-')
                    {
                        pole[poziceHrac1] = 'X';
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neplatná nebo obsazená pozice. Zkus to znovu.");
                    }
                }



                Console.WriteLine(
                    pole[0] + "|" + pole[1] + "|" + pole[2] + "\n" +
                    pole[3] + "|" + pole[4] + "|" + pole[5] + "\n" +
                    pole[6] + "|" + pole[7] + "|" + pole[8] + "\n");
                Console.WriteLine("Zadej pozici 0-8:");
                int poziceHrac2;
                while (true)
                {
                    Console.WriteLine("Hráč O - zadej pozici 0-8:");
                    poziceHrac2 = Convert.ToInt32(Console.ReadLine());

                    if (poziceHrac2 >= 0 && poziceHrac2 < 9 && pole[poziceHrac2] == '-')
                    {
                        pole[poziceHrac2] = 'O';
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neplatná nebo obsazená pozice. Zkus to znovu.");
                    }
                }

                foreach (int[] kombinaceJedna in kombinace)
                {
                    char a = pole[kombinaceJedna[0]];
                    char b = pole[kombinaceJedna[1]];
                    char c = pole[kombinaceJedna[2]];

                    if (a != '-' && a == b && b == c)
                    {
                        Console.WriteLine($"Vyhrál hráč {a}!");
                        return; 
                    }
                }
            }

        }
    }
}
