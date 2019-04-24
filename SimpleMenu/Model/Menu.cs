using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu.Model
{
    public class Menu
    {
        Calculations calc = new Calculations();
        public void ShowMenu(string input)
        {
            switch (input.ToUpper())
            {
                case "S":
                    Console.WriteLine(calc.GetSumme());
                    break;
                case "F":
                    Console.WriteLine("{0:###,#}", calc.GetFaculty());
                    break;
                case "G":
                    Console.WriteLine(calc.GetLargeDivider());
                    break;
                case "M":
                    Console.WriteLine("{0:n}", calc.GetMile());
                    break;
                case "E":
                    break;
                case "Q":
                    Program.finish = true;
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }
    }
}
