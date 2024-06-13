using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHCheck__Initial_Health_Check_.IHCheck_Main;

namespace IHCheck__Initial_Health_Check_
{
    internal class Program
    {
        static void Main()
        {
            // inisiasi objek pasien 
            PatientManager manager = new PatientManager();
            bool running = true;

            while (running)
            {
                // -- MENU -- //
                Console.WriteLine("\n- - - - - - - - - -");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. List Patients");
                Console.WriteLine("3. Remove Patient");
                Console.WriteLine("4. Exit");
                // -- Tambahkan variasi menu disini -- //
                Console.WriteLine("- - - - - - - - - -");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddPatient();
                        break;
                    case 2:
                        manager.ListPatients();
                        break;
                    case 3:
                        Console.Write("Enter ID of patient to remove: ");
                        int id = int.Parse(Console.ReadLine());
                        manager.RemovePatientByID(id);
                        break;
                        // -- Tambahkan Case tambahan untuk variasi menu disini -- //
                    case 4:
                        running = false;
                        break; // close program
                    default: 
                        Console.WriteLine("Invalid option. Please try again."); // throw invalid exception
                        break;
                }
            }
        }
    }
}

/* NOTE : Penghapusan class Menu dan IHcheck dikarenakan untuk mempermudah 
 * dalam membaca alur konsep / mekanisme program yang di jalankan.
 * memindahkan method Run main menu di Program.cs untuk memudahkan dalam mengedit
 * variasi menu didalam nya.
 * Semua mekanisme program terdapat pada file Patient.cs pada class PatientManager
 */
