using SimpleMenu.Model;
using System;
 


namespace SimpleMenu
{
    class Program
    {        
        public static bool finish = false;                   
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (!finish)
            {            
                Console.Clear();
                Console.WriteLine("S -> Summe berechnen \nF -> Fakultät berechnen \nG -> Größten gemeinsamen Teiler berechnen \nM -> Meilen berechnen \nE -> Programm beenden");
                menu.ShowMenu(Console.ReadLine());
            }
        }                    
    }
}

