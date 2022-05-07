namespace SingleResponsibility
{
    public static class Program
    {
        public static void Main()
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                System.Console.WriteLine("You did not give us a valid first name!");
                StandardMessages.EndApplication();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                System.Console.WriteLine("You did not give us a valid last name!");
                StandardMessages.EndApplication();
                return;
            }

            System.Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");
            StandardMessages.EndApplication();
        }
    }
}

