using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] students = new string[3];// var1
            students[0] = "Vlad";
            students[1] = "Sergey";
            students[2] = "Oleg";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] daysOfWeek = { "Monday", "Sunday" };// var2

            string[] daysOfWeek1 = new string[] { "Monday", "Sunday" };//var3*/

            /*int[] number = new int[5];
            int number1 = 1;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = number1;
                number1++;
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }*/

            /*string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }*/



            //string[] daysOfWeek1 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Firday", "Saturday", "Sunday" };


            /*string a = "!";
            string[] array1 = { "One", "Two", "Three"};
            string[] array2 = new string[3];

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i] + a;
                Console.WriteLine(array2[i]); 
            }*/

            int[,] arrayMatrix = new int[4,3];
            Random random = new Random();
            //int t = random.Next(10,20);

            for (int i = 0; i < arrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMatrix.GetLength(1); j++)
                {
                    arrayMatrix[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < arrayMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < arrayMatrix.GetLength(1); j++)
                {
                    Console.Write(arrayMatrix[i,j] + " ");
                }
                Console.WriteLine();
                
            }

        }
    
    }
}
