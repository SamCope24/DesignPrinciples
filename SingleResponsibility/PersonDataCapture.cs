namespace SingleResponsibility
{
    public static class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            System.Console.Write("What is your first name?");
            output.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your last name?");
            output.LastName = System.Console.ReadLine();

            return Person;
        }
    }
}