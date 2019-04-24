using SimpleMenu.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu.Model
{
    public class Calculations
    {
        public static int i, j;
        Checkings checkings = new Checkings(); 
        
        public int GetLargeDivider()
        {
            checkings.CheckNumbers();
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
            checkings.CheckNumbers();
            return i + j;
        }
        public int GetFaculty()
        {
            checkings.CheckNumber();

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
            checkings.CheckNumber();
            return 1.6009344 * i;
        }
        
    }
}
