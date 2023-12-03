using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Challenges.Advent
{
    public class Day2
    {
        public decimal GetNumberValidGames(string[] list)
        {
            decimal count = 0;
            foreach (var item in list)
            {
                var games = item.Split(':');
                var number = games[0].Split(' ');
                var colors = games[1].Split(';');
                decimal limitRed = 0;
                decimal limitGreen = 0;
                decimal limitBlue = 0;
                var breakTheRules = false;
                foreach (var color in colors)
                {
                    
                    var cubes = color.Split(',');
                    foreach (var c in cubes)
                    {
                        var info = c.Split(' ');
                        if (info[2]== "blue")
                        {
                            limitBlue = Convert.ToDecimal(info[1]);
                        } else if (info[2]== "red")
                        {
                            limitRed = Convert.ToDecimal(info[1]);
                        } else if (info[2]== "green"){
                            limitGreen = Convert.ToDecimal(info[1]);
                        }
                        if (limitGreen > 13 || limitRed > 12 || limitBlue > 14)
                        {
                            breakTheRules = true;
                        }
                    }
                    
                }
                if (breakTheRules==false)
                {
                    count = Convert.ToDecimal(number[1]) + count;
                }
            }
            return count;
        }

        public decimal GetCombinationGames(string[] list)
        {
            decimal count = 0;
            foreach (var item in list)
            {
                List<decimal> result = new List<decimal>();
                var games = item.Split(':');
                var number = games[0].Split(' ');
                var colors = games[1].Split(';');
                List<decimal> red = new List<decimal>();
                List<decimal> blue = new List<decimal>();
                List<decimal> green = new List<decimal>();
                foreach (var color in colors)
                {
                    var cubes = color.Split(',');
                    foreach (var c in cubes)
                    {
                        var info = c.Split(' ');
                        if (info[2] == "blue")
                        {
                            blue.Add(Convert.ToDecimal(info[1]));
                        }
                        else if (info[2] == "red")
                        {
                            red.Add(Convert.ToDecimal(info[1]));
                        }
                        else if (info[2] == "green")
                        {
                            green.Add(Convert.ToDecimal(info[1]));
                        }
                    }

                }
                count = blue.Max() * red.Max() * green.Max() + count;
            }
            return count;
        }
    }
}
