using System;

namespace Start{
    public class Requires{
        public static void NotNull(object argument){
            if (argument != null) return;

            throw new ArgumentNullException($"{nameof(argument)} can't be null");
        }
    }
} 