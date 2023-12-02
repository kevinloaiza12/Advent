using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Challenges
{
    public class Day1
    {
        public decimal CalibrationMachine(string[] list)
        {
            decimal count = 0;
            foreach (var item in list)
            {
                List<decimal> listNumber = new List<decimal>();
                var letters = item.ToCharArray();
                
                foreach(var character in letters)
                {
                    var letter = character.ToString();
                    bool isNumeric = int.TryParse(letter, out _);
                    if (isNumeric)
                    {
                        listNumber.Add(Convert.ToDecimal(letter));
                    }
                    
                }
                var n = listNumber.Count;
                var number = listNumber[0].ToString() + listNumber[n - 1].ToString();
                count = count + Convert.ToDecimal(number);
            }
            return count;
        }
    }
}
