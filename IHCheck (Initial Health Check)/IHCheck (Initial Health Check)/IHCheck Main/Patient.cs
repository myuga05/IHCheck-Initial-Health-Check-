using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCheck__Initial_Health_Check_.IHCheck_Main
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string CurrentDisease { get; set; }
        public string Treatment { get; set; }      

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nAge: {Age}\nGender: {Gender}\nBlood Pressure: {BloodGroup}\nWeight: {Weight}\nMedical History: {MedicalHistory}\nCurrent Disease: {CurrentDisease}\nTreatment: {Treatment}";
        }
    }
}
