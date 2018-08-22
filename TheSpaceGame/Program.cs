using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSpaceGame
{
    class Program
    {
        public static bool GameOver(int credits, double time)
        {
            bool gameOver;
            string input = "end";

            if (credits > 0)
            {
                gameOver = false;
            }
            else if (time <= 40)
            {
                gameOver = false;
            }
            else if (input == "end")
            {
                gameOver = true;
            }
            else
            {
                gameOver = true;
            }

            return gameOver;
        }

        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return distance;
        }

        static void Main(string[] args)
        {
            // Instantiation  
            //double distance = Distance(x1, y1, x2, y2);            
            int credits = 10000;
            double time = 0;            
            double currentLocation = 0.0;


            while (GameOver(credits, time) == false)
            {
                double x1 = 0;
                double y1 = 0;

                while ((x1 == 0) && (y1 == 0))
                {
                    Planets.Earth(credits, time, currentLocation);
                }
                while ((x1 == 0) && (y1 == 4.367))
                {
                    Planets.AlphaCentauri(credits, time, currentLocation);
                }
                while ((x1 == 1.0) && (y1 == 3.50))
                {
                    Planets.Trappist(credits, time, currentLocation);
                }     

            }
            
        }
    }
}
