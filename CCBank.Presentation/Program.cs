class Program
{
    static void Main()
    {
        System.Console.WriteLine("**********CCBank**********");
        System.Console.WriteLine("::Login PAge::");

        string userName = null, password = null;

        System.Console.Write("Username:");
        userName = System.Console.ReadLine();

        if (userName != "")
        {

            System.Console.Write("Password:");
            password = System.Console.ReadLine();
        }

        if (userName == "system" && password == "manager")
        {
            int mainMenuChoice = -1;

            do
            {
                System.Console.WriteLine("\n:::Main menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Fund Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter Choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid Username or Password");
        }

        System.Console.WriteLine("Thank you! Visit again!");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
     int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add Customers");
            System.Console.WriteLine("2. Delete Customers");
            System.Console.WriteLine("3  Update Customers");
            System.Console.WriteLine("4. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            System.Console.Write("Enter Choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());

        } while (customerMenuChoice != 0);

    }

}