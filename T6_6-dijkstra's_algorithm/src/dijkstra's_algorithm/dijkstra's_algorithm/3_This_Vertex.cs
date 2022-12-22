using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dijkstra_s_algorithm
{
    // obliczanie podanego grafu przy użyciu Algorytmu Dijkstry
    // pomoc do egzaminu [użycie wcześniej przygotowanych algorytmów]
    // => 'Algorytmy i struktury danych' [ Łukasz W. Tworzydło ]
    internal class This_Vertex
    {
        public String name;
        public int
            status,
            predecessor,
            pathLength;

        public This_Vertex(String name)
        {
            this.name = name;
        }
    }
}