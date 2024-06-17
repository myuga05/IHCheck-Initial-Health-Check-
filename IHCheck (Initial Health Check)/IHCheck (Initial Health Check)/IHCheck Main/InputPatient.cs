using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCheck__Initial_Health_Check_.IHCheck_Main
{
    public static class InputPatient
    {
        public static int GetIntInput(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {                    
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        public static double GetDoubleInput(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {                    
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        public static string ValidateGenderInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string genderInput = Console.ReadLine().Trim().ToUpper();
                if (genderInput == "L" || genderInput == "P")
                {
                    return genderInput;
                }
                else
                {                 
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        public static string ValidateBloodTypeInput(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string bloodTypeInput = Console.ReadLine().Trim().ToUpper();
                if (bloodTypeInput == "A" || bloodTypeInput == "B" || bloodTypeInput == "AB" || bloodTypeInput == "O")
                {
                    return bloodTypeInput;
                }
                else
                {                    
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}

/* NOTE : 
 * Penggunaan static pada class ini agar mempermudah akses, 
 * Dengan membuatnya statis, dapat mengaksesnya langsung 
 * kelas InputPatient tanpa perlu membuat objek dari kelas tersebut.
 */
