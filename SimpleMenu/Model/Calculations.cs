using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu.Model
{
    public class Calculations
    {
        int i, j;
        public int GetLargeDivider()
        {
            CheckNumbers();
            int counter = i;

            while (counter > 0)
            {

                if (i % counter == 0 && j % counter == 0) return counter;
                counter--;
            }
            return 1;
        }
        public int GetSumme()
        {
            CheckNumbers();
            return i + j;
        }
        public int GetFaculty()
        {
            CheckNumber();

            int faculty = 1;
            int count = 1;
            while (count <= i)
            {
                faculty *= count;
                count++;
            }

            return faculty;
        }
        public double GetMile()
        {
            CheckNumber();
            return 1.6009344 * i;
        }
        void CheckNumbers()
        {
            Console.WriteLine("Geben Sie zwei Zahlen ein");
            if (int.TryParse(Console.ReadLine(), out int firstNumber) && int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                this.i = firstNumber;
                this.j = secondNumber;
            }
        }
        void CheckNumber()
        {
            Console.WriteLine("Geben Sie eine Zahl ein");
            if (!int.TryParse(Console.ReadLine(), out int number)) Console.WriteLine("Falsche Eingabe");
            else this.i = number;
        }
    }
}
