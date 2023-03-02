using System; 

namespace HelloMethods
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string message = Message.GetMessage("nl");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
