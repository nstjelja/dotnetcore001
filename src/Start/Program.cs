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

            Console.WriteLine("Hello World!");
        }
    }
}
