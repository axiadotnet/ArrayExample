using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArrayEx
{
    class Player: IComparable<Player>
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public int CompareTo(Player other)
        {
            //if(Points%2 == 0 && other.Points % 2 == 0)
            //{
            //    return 0;
            //}
            //else if (Points % 2 != 0 && other.Points % 2 != 0)
            //{
            //    return 0;
            //}
            //else if (Points % 2 == 0 && other.Points % 2 != 0)
            //{
            //    return 1;
            //}
            //else if (Points % 2 != 0 && other.Points % 2 == 0)
            //{
            //    return -1;
            //}

            return Name.CompareTo(other.Name);

        }

        public override string ToString()
        {
            return "Giocatore: " + Name + " punti: " + Points;
        }


    }
}
