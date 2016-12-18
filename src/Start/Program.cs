using System;
using People;
using System.Collections.Generic;


namespace Start
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            var nikola = new Person("Nikola", "Stjelja", new DateTime(1981,12,1));
            var milica = new Person("Milica","Cuckovic", new DateTime(1991, 4,26));
            var family = new Family();
            family.AddFather(nikola);
            family.AddMother(milica);

            Console.WriteLine($"Hello {nikola}");
        }
    }
}
