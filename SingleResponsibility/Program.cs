namespace SingleResponsibility
{
    public static class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Welcome to my Application");

            Person user = new Person();

            System.Console.Write("What is your first name?");
            user.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            user.LastName = System.Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                System.Console.WriteLine("You did not give us a valid first name!");
                System.Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                System.Console.WriteLine("You did not give us a valid last name!");
                System.Console.ReadLine();
                return;
            }

            System.Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");
            System.Console.ReadLine();
        }
    }
}

