using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_echecs
{
    class Coordonee
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordonee(int i, int j)
        {
            x = i;
            y = j;
        }

    }
}
