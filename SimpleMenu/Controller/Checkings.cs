using SimpleMenu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu.Controller
{
    public class Checkings
    {
        
        public void CheckNumbers()
        {
            Console.WriteLine("Geben Sie zwei Zahlen ein");
            if (int.TryParse(Console.ReadLine(), out int firstNumber) && int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                Calculations.i = firstNumber;
                Calculations.j = secondNumber;
            }
        }
        public void CheckNumber()
        {
            Console.WriteLine("Geben Sie eine Zahl ein");
            if (!int.TryParse(Console.ReadLine(), out int number)) Console.WriteLine("Falsche Eingabe");
            else Calculations.i = number;
        }
    }
}
