using System;

namespace Exercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        public Phone()
        {
            this.Company = "unknown";
            this.Model = "unknown";
            this.ReleaseDay = "unknown";
        }

        public Phone(string company, string model)
        {
            this.Company = company;
            this.Model = model;
        }

        public Phone(string company, string model, string releaseDate)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = releaseDate;
        }

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

    public class Run
    {
        public static void Main()
        {
            //Phone one = new Phone();
            //Phone two = new Phone("Apple", "IPhone 12");
            //Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

            //one.Introduce();
            //two.Introduce();
            //three.Introduce();

            Property property1 = new Property();
            Console.WriteLine($"Property 1 volume is {property1.Volume}");
            property1.Volume = 50;
            Console.WriteLine($"Property 1 volume is {property1.Volume}");

        }

    }
}
