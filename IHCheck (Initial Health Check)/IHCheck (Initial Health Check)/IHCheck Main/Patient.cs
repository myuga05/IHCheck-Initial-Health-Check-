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

            Console.Write("Masukan ID: ");
            newPatient.Id = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nama: ");
            newPatient.Name = Console.ReadLine();

            Console.Write("Masukan Umur: ");
            newPatient.Age = int.Parse(Console.ReadLine());

            Console.Write("Masukan Golongan darah: ");
            newPatient.BloodType = Console.ReadLine();

            Console.Write("Masukan Berat Badan: ");
            newPatient.Weight = double.Parse(Console.ReadLine());

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
            foreach (var patient in patients)
            {
                Console.WriteLine();
                Console.WriteLine(patient);
                Console.WriteLine();
            }
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