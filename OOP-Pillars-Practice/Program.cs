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
        static void DisplayFinalPrice(List<Product> products)
        {
            foreach (Product p in products)
            {
                double tax = 0;

                if (p is ITaxable taxableProduct)
                {
                    tax = taxableProduct.CalculateTax();
                }

                double discount = p.CalculateDiscount();
                double finalPrice = p.Price + tax - discount;

                Console.WriteLine("Product Name : " + p.Name);
                Console.WriteLine("Base Price  : " + p.Price);
                Console.WriteLine("Discount    : " + discount);
                Console.WriteLine("Tax         : " + tax);
                Console.WriteLine("Final Price : " + finalPrice);
                Console.WriteLine();
            }
        }

        List<Product> products = new List<Product>();

        products.Add(new Electronics(1, "Laptop", 50000));
        products.Add(new Clothing(2, "Shirt", 2000));
        products.Add(new Groceries(3, "Rice", 1000));

        DisplayFinalPrice(products);
        Console.ReadKey();
    }
}
