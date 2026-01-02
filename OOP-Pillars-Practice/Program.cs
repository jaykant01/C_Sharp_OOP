namespace OOP_Pillars_Practice;

class Program
{
    static void Main(string[] args)
    {
        // Polymorphism using Employee reference
        //List<Employee> employees = new List<Employee>();

        //Employee emp1 = new FullTimeEmployee(101, "Will", 50000);
        //emp1.AssignDepartment("HR");

        //Employee emp2 = new PartTimeEmployee(102, "Henry", 8000, 3, 300);
        //emp2.AssignDepartment("IT");

        //employees.Add(emp1);
        //employees.Add(emp2);

        //// Polymorphic behavior
        //foreach (Employee emp in employees)
        //{
        //    emp.DisplayDetails();
        //} 


        // Problem 2
        //static void DisplayFinalPrice(List<Product> products)
        //{
        //    foreach (Product p in products)
        //    {
        //        double tax = 0;

        //        if (p is ITaxable taxableProduct)
        //        {
        //            tax = taxableProduct.CalculateTax();
        //        }

        //        double discount = p.CalculateDiscount();
        //        double finalPrice = p.Price + tax - discount;

        //        Console.WriteLine("Product Name : " + p.Name);
        //        Console.WriteLine("Base Price  : " + p.Price);
        //        Console.WriteLine("Discount    : " + discount);
        //        Console.WriteLine("Tax         : " + tax);
        //        Console.WriteLine("Final Price : " + finalPrice);
        //        Console.WriteLine();
        //    }
        //}

        //List<Product> products = new List<Product>();

        //products.Add(new Electronics(1, "Laptop", 50000));
        //products.Add(new Clothing(2, "Shirt", 2000));
        //products.Add(new Groceries(3, "Rice", 1000));

        //DisplayFinalPrice(products);



        // Problem 3
        //List<Vehicle> vehicles = new List<Vehicle>();

        //vehicles.Add(new Car("CAR101", 2000, "CAR-INS-001"));
        //vehicles.Add(new Bike("BIKE202", 500, "BIKE-INS-002"));
        //vehicles.Add(new Truck("TRUCK303", 4000, "TRUCK-INS-003"));

        //int rentalDays = 3;

        //// Polymorphism demonstration
        //foreach (Vehicle v in vehicles)
        //{
        //    double rentalCost = v.CalculateRentalCost(rentalDays);
        //    double insuranceCost = 0;

        //    if (v is IInsurable insurableVehicle)
        //    {
        //        insuranceCost = insurableVehicle.CalculateInsurance();
        //    }

        //    Console.WriteLine("Vehicle Type   : " + v.Type);
        //    Console.WriteLine("Vehicle Number : " + v.VehicleNumber);
        //    Console.WriteLine("Rental Cost   : " + rentalCost);
        //    Console.WriteLine("Insurance     : " + insuranceCost);
        //    Console.WriteLine();
        //}


        // Problem 4
        //List<BankAccount> accounts = new List<BankAccount>();

        //BankAccount acc1 = new SavingsAccount(101, "Steve", 50000);
        //BankAccount acc2 = new CurrentAccount(102, "Jonathan", 80000);

        //accounts.Add(acc1);
        //accounts.Add(acc2);

        //// Polymorphism
        //foreach (BankAccount acc in accounts)
        //{
        //    Console.WriteLine("Account Holder : " + acc.HolderName);
        //    Console.WriteLine("Account Number : " + acc.AccountNumber);
        //    Console.WriteLine("Balance        : " + acc.Balance);
        //    Console.WriteLine("Interest       : " + acc.CalculateInterest());

        //    // Loan check
        //    if (acc is ILoanable loanAccount)
        //    {
        //        loanAccount.ApplyForLoan();
        //        Console.WriteLine("Loan Eligibility : " + loanAccount.CalculateLoanEligibility());
        //    }
        //    Console.WriteLine();
        //}


        // Problem 5
        List<LibraryItem> items = new List<LibraryItem>();

        items.Add(new Book(1, "C# Basics", "John"));
        items.Add(new Magazine(2, "Tech Monthly", "Editor"));
        items.Add(new DVD(3, "OOP Concepts", "Trainer"));

        // Polymorphism in action
        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();
            Console.WriteLine("Loan Days: " + item.GetLoanDuration());

            if (item is IReservable reservable)
            {
                Console.WriteLine("Can Reserve: " + reservable.CheckAvailability());
            }

            Console.WriteLine();
        }
        Console.ReadKey();
        
    }
}
