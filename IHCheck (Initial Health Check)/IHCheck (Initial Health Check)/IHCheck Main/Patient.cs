using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCheck__Initial_Health_Check_.IHCheck_Main
{   
    // Deklarasi Kelas dan atribut Patient
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodType { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string CurrentDisease { get; set; }
        public string Treatment { get; set; }

        // konversi menggunakan fungsi ToString
        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nGender: {Gender}\nBlood Type: {BloodType}\nWeight: {Weight}\nMedical History: {MedicalHistory}\nCurrent Disease: {CurrentDisease}\nTreatment: {Treatment}";
        }
    }

    // Class PatientManager Untuk seluruh konsep dan mekanisme program
    public class PatientManager
    {
        // penerapan Konsep Linked List dalam menambah, menyimpan, dan menghapus data
        private LinkedList<Patient> patients = new LinkedList<Patient>();

        // Method untuk menambahkan pasien beserta input atribut objek/class pasien
        public void AddPatient()
        {
            Patient newPatient = new Patient();

            newPatient.Id = InputPatient.GetIntInput("Masukan ID: ");

            Console.Write("Masukan Nama: ");
            newPatient.Name = Console.ReadLine();

            newPatient.Age = InputPatient.GetIntInput("Masukan Umur: ");

            newPatient.Gender = InputPatient.ValidateGenderInput();

            newPatient.BloodType = InputPatient.ValidateBloodTypeInput();

            newPatient.Weight = InputPatient.GetDoubleInput("Masukan Berat Badan: ");

            Console.Write("Masukan Riwayat Penyakit: ");
            newPatient.MedicalHistory = Console.ReadLine();

            Console.Write("Masukan penyakit saat ini: ");
            newPatient.CurrentDisease = Console.ReadLine();

            Console.Write("Masukan jenis penanganan: ");
            newPatient.Treatment = Console.ReadLine();

            patients.AddLast(newPatient);

            Console.WriteLine("Patient added successfully!");
        }

        // Method untuk menghapus Pasien Berdasarkan ID Pasien
        //Note : pngehapusan dilakukan dengan menghapus node dengan inisial tertentu

        public void RemovePatientByID(int id)
        {
            var currentNode = patients.First;

            while (currentNode != null)
            {
                if (currentNode.Value.Id == id)
                {
                    patients.Remove(currentNode);
                    Console.WriteLine("Patient Removed Successfully!");
                }
                else if (currentNode.Value.Id != id)
                {
                    Console.WriteLine("Patient with ID {0} Cannot be found.", id);
                }
                currentNode = currentNode.Next;
            } 
        }

        // Method untuk menampilkan Pasien yang ada
        public void ListPatients()
        {

            if (patients.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No patients found.");
            }
            else
            {
                foreach (var patient in patients)
                {
                    Console.WriteLine();
                    Console.WriteLine(patient);
                    Console.WriteLine();
                }
            }
        }

        public void FindPatient(int id)
        {
            var currentNode = patients.First;

            while (currentNode != null)
            {
                if (currentNode.Value.Id == id)
                {
                    Console.WriteLine();
                    Console.WriteLine("Patient found:");
                    Console.WriteLine(currentNode.Value); 
                    Console.WriteLine();
                    return;
                }
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Patient not found.");
        }

        private void QuickSort(List<Patient> list, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(list, left, right);
                QuickSort(list, left, pivotIndex - 1);
                QuickSort(list, pivotIndex + 1, right);
            }
        }

        private int Partition(List<Patient> list, int left, int right)
        {
            int pivot = list[right].Id;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j].Id <= pivot)
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, right);
            return i + 1;
        }

        private void Swap(List<Patient> list, int index1, int index2)
        {
            Patient temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public void SortPatientsByID()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("No patients found, Please add patients first!");                
                return;
            }

            List<Patient> patientList = new List<Patient>(patients);
            QuickSort(patientList, 0, patientList.Count - 1);

            patients = new LinkedList<Patient>(patientList);

            Console.WriteLine();
            Console.WriteLine("Patients sorted by ID successfully!");
        }
    }
}

/* NOTE : 
 * Pengubahan Konsep Menyimpan , menambah , dan menghapus dengan menggunakan Linkedlist 
 * dari pada List dikarenakan Dengan menggunakan LinkedList<T>, Kita mendapatkan keuntungan
 * kinerja yang signifikan untuk operasi penyisipan dan penghapusan di mana saja dalam daftar. 
 * Ini sangat berguna untuk aplikasi yang memerlukan pengelolaan dinamis data pasien, 
 * termasuk penambahan dan penghapusan yang sering terjadi.
 */