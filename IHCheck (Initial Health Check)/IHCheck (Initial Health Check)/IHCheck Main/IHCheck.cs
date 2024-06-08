using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCheck__Initial_Health_Check_.IHCheck_Main
{
    public class IHCheck
    {
        private List<Patient> patients;

        public IHCheck()
        {
            patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void ListPatients()
        {
            foreach (var patient in patients)
            {
                Console.WriteLine(patient);
                Console.WriteLine(); // Adding an empty line between patients
            }
        }
    }
}
