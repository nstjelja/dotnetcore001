using System;
using People;
using System.Collections.Generic;


namespace Start
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Requires.NotNull(args);

            if (args.Length < 2){
                throw new ArgumentException($"{nameof(args)} can't be less then two");
            }

            var firstName =  args[0];
            var lastName = args[1];

            var nikola = new Person(firstName, lastName, new DateTime(1981,12,1));

            Console.WriteLine($"Hello {nikola}");
        }
    }
}
