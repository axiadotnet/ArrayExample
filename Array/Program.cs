using System;

namespace ArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = { new Player("pippo", 79), new Player("pluto", 41), new Player("paperino", 67), new Player("paperina", 78) };

            //Array.Sort(players);

            Array.Sort(players, (p1, p2) => p1.Points.CompareTo(p2.Points));

            PlayerComparer comparer = new PlayerComparer(OrderType.Points);

            Array.Sort(players, comparer);

            foreach (var item in players)
            {
                Console.WriteLine(item);
            }

            int[,,,] pippo = new int[3, 4, 6, 9];
            pippo[0, 0, 0, 0] = 5;


            int[][] pluto = new int[3][];

            pluto[0] = new int[2];
            pluto[1] = new int[4];
            pluto[2] = new int[1];

            pluto[0][0] = 5;
        }

    }
}
