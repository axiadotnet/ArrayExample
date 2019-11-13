using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArrayEx
{
    class PlayerComparer : IComparer<Player>
    {

        public OrderType OrderType { get; set; }

        public PlayerComparer(OrderType orderType)
        {
            OrderType = orderType;
        }
        public int Compare([AllowNull] Player p1, [AllowNull] Player p2)
        {
            if (OrderType == OrderType.Name)
            {
                return p1.Name.CompareTo(p2.Name);
            }
            else
            {
                return p1.Points.CompareTo(p2.Points);
            }
            
        }


    }

    enum OrderType: int
    {
        Name = 0, Points = 1
    }
}
