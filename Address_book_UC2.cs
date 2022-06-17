namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Address Program");

            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();

            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.PerformAction(selection);
            }

            Console.ReadKey();
        }
    }
}