using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu
{
    class Program
    {
        static bool finish = false;
        int i, j;

        static void Main(string[] args)
        {
            Program p = new Program();
            while (!finish)
            {
                Console.Clear();
                Console.WriteLine("S -> Summe berechnen \nF -> Fakultät berechnen \nG -> Größten gemeinsamen Teiler berechnen \nM -> Meilen berechnen \nE -> Programm beenden");
                p.Menu(Console.ReadLine());
                Console.ReadKey();
            }
        }

        void Menu(string input)
        {
            switch (input.ToUpper())
            {
                case "S":
                    Console.WriteLine(GetSumme());
                    break;
                case "F":
                    Console.WriteLine("{0:###,#}", GetFaculty());
                    break;
                case "G":
                    Console.WriteLine(GetLargeDivider());
                    break;
                case "M":
                    Console.WriteLine("{0:n}", GetMile());
                    break;
                case "E":
                    break;
                case "Q":
                    finish = true;
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }

        int GetLargeDivider()
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
        int GetSumme()
        {
            CheckNumbers();
            return i + j;
        }
        int GetFaculty()
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
        double GetMile()
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

