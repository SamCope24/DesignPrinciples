namespace SingleResponsibility
{
    public static class Program
    {
        public static void Main()
        {
            StandardMessages.WelcomeMessage();
            Person user = PersonDataCapture.Capture();
            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            System.Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");
            StandardMessages.EndApplication();
        }
    }
}

