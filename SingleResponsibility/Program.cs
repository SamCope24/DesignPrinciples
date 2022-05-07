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

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}

