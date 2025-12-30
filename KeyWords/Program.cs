namespace KeyWords;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //BankSystem b1 = new BankSystem(101, "Nancy", 50000);
        //BankSystem b2 = new BankSystem(102, "Jonathan", 30000);

        //b1.DisplayDetails(b1);
        //b2.DisplayDetails(b2);
        //BankSystem.GetTotalAccounts();


        // Problem 2
        //LibrarySystem l1 = new LibrarySystem("Knowledge is Power", "Unknown", 4242);
        //l1.Display(l1);
        //LibrarySystem.DisplayLibraryName();


        // Problem 3
        //EmployeeSystem emp1 = new EmployeeSystem("Henry", "Junior Developer", 1001);
        //EmployeeSystem emp2 = new EmployeeSystem("Vecna", "Senior Develpoer", 1002);
        //emp1.DisplayDetails(emp1);
        //emp2.DisplayDetails(emp2);
        //EmployeeSystem.DisplayTotalEmployees();


        // Problem 4
        //ShoppingSystem s = new ShoppingSystem("Samsung Galaxy S25 Utlra", 135000, 10, 1);
        //ShoppingSystem.UpdateDiscount(25);
        //s.DisplayDetails(s);


        // Problem 5
        //UniversityStudent u1 = new UniversityStudent("Hopper", 13, 'A');
        //UniversityStudent u2 = new UniversityStudent("Byers", 14, 'B');
        //u1.DisplayDetails(u1);
        //u2.DisplayDetails(u2);
        //UniversityStudent.DisplayTotalStudents();


        // Problem 6
        //VehicleRegistration v = new VehicleRegistration("Robin", "Bus", 0203);
        //VehicleRegistration.UpdateRegistrationFee(2000);
        //v.DisplayDetails(v);


        // Problem 7
        HospitalSystem h1 = new HospitalSystem("Mrs Wheeler", 38, "Attacked", 01);
        HospitalSystem h2 = new HospitalSystem("Max", 20, "Comma", 02);
        h1.DisplayDetails(h1);
        h2.DisplayDetails(h2);
        HospitalSystem.GetTotalPatients();

        Console.ReadKey();
        
    }
}
