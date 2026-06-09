namespace Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cello cello1 = new Cello();
            cello1.Show();
            cello1.Desc();
            cello1.History();

            Console.WriteLine();
            Ukulele ukulele = new Ukulele();
            ukulele.Sound();
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();

            Console.WriteLine();
            President president1 = new President("George", "Washington", "12345678910", 50000);
            Console.WriteLine(president1.ToString());
            president1.Print();

            Console.WriteLine();
            Engineer engineer1 = new Engineer("Elene", "Morgoshia", "11111111111", 1000000);
            Console.WriteLine(engineer1.ToString());
            engineer1.Print();
        }
    }
}
