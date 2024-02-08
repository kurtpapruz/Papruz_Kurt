namespace Papruz_Kurt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int course;
            course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite  books: ");
            double price;
            price = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled course: " + course);
            Console.WriteLine("Price of my favorite book: " + price);
            
        }
    }
}