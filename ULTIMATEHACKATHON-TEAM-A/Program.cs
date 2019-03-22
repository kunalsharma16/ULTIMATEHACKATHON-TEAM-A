using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// angad singh :- c0732104
// Ashwinder singh :- c0725642
// Gurcharanjit singh :-c0731812
// Harjeet singh :- c0730468
// kunal sharma :- c0727250
// Sohit sharna :- c0730478

namespace ULTIMATEHACKATHON_TEAM_A
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array1 = { "kunal", "hajeet", "sohit", "Ashwinder singh", "Angad", "Gurcharanjit"," xy","rcc","peneaut","roxy","jatt"};
            for (int i = 0; i <= array1.Length; i++)

            {
                if (i == 0 || i == 3 || i == 7 || i == 11 || i == 15)
                {

                    Console.WriteLine("Team A: " + array1[i]);
                }
                else if (i == 1 || i == 4 || i == 8 || i == 12)
                {
                    Console.WriteLine("Team B: " + array1[i]);
                }
                else if (i == 2 || i == 5 || i == 9 || i == 13)
                {
                    Console.WriteLine("Team C: " + array1[i]);
                }
                else if (i == 3 || i == 6 || i == 10 || i == 14)
                {
                    Console.WriteLine("Team D: " + array1[i]);
                }

            }
        }
    }
}