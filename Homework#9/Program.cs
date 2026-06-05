namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ1 = new Employ("Elene", "Morgoshia", new DateTime(2004, 7, 20), Country.Georgia, Gender.female, Contacts.email);
            Employ employ2 = new Employ("Elensio", "Morgoshiaaa", new DateTime(2004, 7, 20), Country.Georgia, Gender.female, Contacts.email);
            Employ employ3 = new Employ("Niko", "Morgoshia", new DateTime(2004, 7, 20), Country.Italy, Gender.male, Contacts.email);
            Employ employ4 = new Employ("Emily", "something", new DateTime(2004, 7, 20), Country.Italy, Gender.female, Contacts.email);
            Employ employ5 = new Employ("Sandra", "something", new DateTime(2004, 7, 20), Country.Spain, Gender.female, Contacts.email);
            Employ employ6 = new Employ("Alexsandra", "something", new DateTime(2004, 7, 20), Country.Spain, Gender.female, Contacts.email);
            Employ employ7 = new Employ("Marco", "something", new DateTime(2004, 7, 20), Country.Sweden, Gender.male, Contacts.email);
            Employ employ8 = new Employ("Linda", "something", new DateTime(2004, 7, 20), Country.Sweden, Gender.female, Contacts.email);


            Employ[] employs =
            {
                   employ1,
                   employ2,
                   employ3,
                   employ4,
                   employ5,
                   employ6,
                   employ7,
                   employ8
            };

            Console.WriteLine("Employs from Georgia: ");
            GetByCountry(employs, Country.Georgia);

            Console.WriteLine("Employs from Spain: ");
            GetByCountry(employs, Country.Spain);

        }

        public static void GetByCountry(Employ[] employs, Country country)
        {
            if (employs == null)
                throw new ArgumentNullException(nameof(employs));

            for(int i = 0; i < employs.Length; i++)
            {
                if (employs[i].Country == country)
                {
                    Console.WriteLine(employs[i].ToString());
                }
            }
        }
    }

    
}
