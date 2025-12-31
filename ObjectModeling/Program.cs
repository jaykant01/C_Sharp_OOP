namespace ObjectModeling;

class Program
{
    static void Main(string[] args)
    {
        // Aggregation
        //Book book1 = new Book("Dune", "Frank Herbert");
        //Book book2 = new Book("1984", "George Orwell");
        //Book book3 = new Book("Clean Code", "Robert C. Martin");

        //Library cityLibrary = new Library("City Central Library");
        //Library universityLibrary = new Library("University Main Library");

        //cityLibrary.AddBook(book1);
        //cityLibrary.AddBook(book2);
        //// Same book in another library (Aggretion)
        //universityLibrary.AddBook(book2); 
        //universityLibrary.AddBook(book3);

        //cityLibrary.DisplayBooks();
        //universityLibrary.DisplayBooks();


        // Association
        //Bank sbi = new Bank("State Bank of India");
        //Customer customer1 = new Customer("Jay");

        //Account acc1 = sbi.OpenAccount(customer1, 1001);
        //acc1.Deposit(5000);

        //Account acc2 = sbi.OpenAccount(customer1, 1002);
        //acc2.Deposit(12000);

        //customer1.ViewBalance();



        // Association and Aggregation
        //var mySchool = new School("GLA University");

        //var student1 = new Student(101, "Alice Johnson");
        //var student2 = new Student(102, "Bob Smith");
        //var student3 = new Student(103, "Charlie Brown");

        //var courseA = new Course("Introduction to C#", "CS101");
        //var courseB = new Course("Data Structures", "CS201");
        //var courseC = new Course("Web Development", "WD301");


        //mySchool.AddStudent(student1);
        //mySchool.AddStudent(student2);
        //mySchool.AddStudent(student3);
        //mySchool.AddCourse(courseA);
        //mySchool.AddCourse(courseB);
        //mySchool.AddCourse(courseC);

        //student1.EnrollInCourse(courseA);
        //student1.EnrollInCourse(courseC);

        //student2.EnrollInCourse(courseA);
        //student2.EnrollInCourse(courseB);

        //student3.EnrollInCourse(courseB);

        //mySchool.DisplaySchoolDetails();

        //student1.ViewEnrolledCourses();
        //student2.ViewEnrolledCourses();

        //courseA.DisplayEnrolledStudents();
        //courseB.DisplayEnrolledStudents();


        // (Association and Communication)
        //Hospital.Doctor drSmith = new Hospital.Doctor("Smith");
        //Hospital.Doctor drLee = new Hospital.Doctor("Lee");

        //Hospital.Patient alice = new Hospital.Patient("Alice");
        //Hospital.Patient bob = new Hospital.Patient("Bob");

        //drSmith.Consult(alice);
        //drSmith.Consult(bob);
        //drLee.Consult(alice);  
        //drLee.Consult(bob);

        //drSmith.ShowPatients();
        //drLee.ShowPatients();

        //alice.ShowDoctors();
        //bob.ShowDoctors();



        // Commuincation and aggregation E-commerce
        //Product laptop = new Product("Laptop", 999.99);
        //Product mouse = new Product("Wireless Mouse", 25.50);
        //Product keyboard = new Product("Mechanical Keyboard", 129.99);

        //Customer1 alice = new Customer1("Alice Wonder", "alice@email.com");

        //Order order1 = alice.PlaceOrder(1001);
        //order1.AddProduct(laptop);
        //order1.AddProduct(mouse);

        //Order order2 = alice.PlaceOrder(1002);
        //order2.AddProduct(keyboard);
        //order2.AddProduct(mouse);

        //order1.ShowOrderDetails();
        //order2.ShowOrderDetails();

        //alice.ShowMyOrders();


        // Company (Composition)
        //Company myCompany = new Company("Google India");

        //myCompany.AddDepartment("HR");
        //myCompany.AddDepartment("IT");

        //myCompany.AddEmployeeToDepartment("HR", "Bob");
        //myCompany.AddEmployeeToDepartment("IT", "Charlie");
        //myCompany.AddEmployeeToDepartment("IT", "Diana");

        //myCompany.ShowStructure();

        //Console.WriteLine("Company object is no longer referenced.");
        //Console.WriteLine("All departments and employees will be deleted automatically (garbage collected).");



        // Agreggation and Composition
        var faculty1 = new Faculty("Dr. Alice");
        var faculty2 = new Faculty("Prof. Bob");
        var faculty3 = new Faculty("Dr. Carol");

        Console.WriteLine(" Before university destruction ");

        var university = new University("GLA University");

        var csDepartment = university.CreateDepartment("Computer Science");
        var mathDepartment = university.CreateDepartment("Mathematics");

        csDepartment.AddFaculty(faculty1);
        csDepartment.AddFaculty(faculty2);
        mathDepartment.AddFaculty(faculty3);

        university.ShowInfo();

        Console.WriteLine("\nStandalone faculty still exists (aggregation):");
        faculty1.ShowInfo();
        faculty2.ShowInfo();

        Console.WriteLine("\n Deleting university ");
        university = null;


        // For demonstration purposes only
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("\nAfter university is gone:");
        Console.WriteLine("Faculty members still exist:");
        faculty1.ShowInfo();
        faculty2.ShowInfo();
        faculty3.ShowInfo();

        Console.WriteLine("\nDepartments disappeared with university (composition)");

    Console.ReadKey();
    }
}
