using System;
using System.Collections.Generic;
using System.Text;

namespace World
{
    class Map
    {
        string[] map;
        List<Player> pl = new List<Player>();
        public Map(int n)
        {
            map = new string[50]();
            for(int i = 1; i < n; i++)
            {
                Player p = new Player();
                pl.Add(p);
            }
            for (int i = 0; i <= 150; i++) 
            {
                pl[0][i]='#';
                pl[50][i]='#';
            }
            for (int i = 0; i < 50; i++)
            {
                pl[i][150] = '#';
                pl[i][0] = '#';
            }
        }
         public void takt()
        {


            print();
        }
         void print()
        {
            foreach(var a in map)
            {
                Console.WriteLine(a);
            }
        }

    }
}
