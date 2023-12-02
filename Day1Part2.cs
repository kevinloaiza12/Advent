using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Challenges
{
    public class Day1Part2
    {
        public decimal TranslateMachine(string[] list)
        {
            decimal count = 0;
            foreach (var item in list)
            {
                List<decimal> listNumber = new List<decimal>();
                var letters = item.ToCharArray();
                for (int i = 0; i < letters.Length; i++)
                {
                    var posibleNumber = letters[i].ToString();
                    bool isNumeric = int.TryParse(posibleNumber, out _);

                    if (isNumeric)
                    {
                        listNumber.Add(Convert.ToDecimal(posibleNumber));
                    }
                    else if (i + 2 < letters.Length)
                    {
                    
                        if (letters[i].ToString() == "o" && letters[i + 1].ToString() == "n" && letters[i + 2].ToString() == "e")
                        {
                            listNumber.Add(1);
                        }
                        else if (letters[i].ToString() == "t" && letters[i + 1].ToString() == "w" && letters[i + 2].ToString() == "o")
                        {
                            listNumber.Add(2);
                        }
                        else if (letters[i].ToString() == "s" && letters[i + 1].ToString() == "i" && letters[i + 2].ToString() == "x")
                        {
                            listNumber.Add(6);
                        }
                        else if (i + 3 < letters.Length ) {
                            if (letters[i].ToString() == "f" && letters[i + 1].ToString() == "o" && letters[i + 2].ToString() == "u" && letters[i + 3].ToString() == "r")
                            {
                                listNumber.Add(4);
                                i += 2;
                            }
                            else if (letters[i].ToString() == "f" && letters[i + 1].ToString() == "i" && letters[i + 2].ToString() == "v" && letters[i + 3].ToString() == "e")
                            {
                                listNumber.Add(5);
                                i += 2;
                            }
                            else if (letters[i].ToString() == "n" && letters[i + 1].ToString() == "i" && letters[i + 2].ToString() == "n" && letters[i + 3].ToString() == "e")
                            {
                                listNumber.Add(9);
                                i += 2;
                            }
                            else if (i + 4 < letters.Length) {
                                if (letters[i].ToString() == "t" && letters[i + 1].ToString() == "h" && letters[i + 2].ToString() == "r" && letters[i + 3].ToString() == "e" && letters[i + 4].ToString() == "e")
                                {
                                    listNumber.Add(3);
                                    i += 3;
                                }
                                else if (letters[i].ToString() == "s" && letters[i + 1].ToString() == "e" && letters[i + 2].ToString() == "v" && letters[i + 3].ToString() == "e" && letters[i + 4].ToString() == "n")
                                {
                                    listNumber.Add(7);
                                    i += 3;
                                }
                                else if (letters[i].ToString() == "e" && letters[i + 1].ToString() == "i" && letters[i + 2].ToString() == "g" && letters[i + 3].ToString() == "h" && letters[i + 4].ToString() == "t")
                                {
                                    listNumber.Add(8);
                                    i += 3;
                                }
                            }
                        }
                    }
                    
                }
                var n = listNumber.Count;

                if (n > 0)
                {
                    var number = listNumber[0].ToString() + listNumber[n - 1].ToString();
                    count = count + Convert.ToDecimal(number);
                }
                
            }
            return count;
        }
    }
}
