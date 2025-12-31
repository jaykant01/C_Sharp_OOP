namespace ObjectModeling;
/* Description: Model a Hospital where Doctor and Patient objects interact through
consultations. A doctor can see multiple patients, and each patient can consult multiple
doctors.
 */
public class Hospital
{
    public class Doctor
    {
        public string doctorName { get; }


        public List<Patient> patients = new List<Patient>();

        // Constructor
        public Doctor(string doctorName)
        {
            this.doctorName = doctorName;
        }

        // Consult Method
        public void Consult(Patient patient)
        {
            if(!patients.Contains(patient))
            {
                patients.Add(patient); 
                patient.AddDoctor(this);
            }
        }

        public void ShowPatients()
        {
            Console.WriteLine($"Dr. {doctorName} has seen: ");
            foreach (var p in patients)
            {
                Console.WriteLine($" -{p.patientName}");
            }
            Console.WriteLine();
        }
    }


    public class Patient
    {
        public string patientName { get; }

        public List<Doctor> doctors = new List<Doctor>();

        public Patient(string patientName)
        {
            this.patientName = patientName; 
        }

        internal void AddDoctor(Doctor doctor)
        {
            if (!doctors.Contains(doctor))
            {
                doctors.Add(doctor);
            }
        }

        public void ShowDoctors()
        {
            Console.WriteLine($"{patientName} has consulted:");
            foreach (var d in doctors)
            {
                Console.WriteLine($" - Dr. {d.doctorName}");
            }
            Console.WriteLine();
        }
    }
    
}

