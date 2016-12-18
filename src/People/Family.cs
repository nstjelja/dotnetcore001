using System.Collections.Generic;
using System;

namespace People {
    public class Family{
        public List<Person> Children {get; private set;}

        public Person Mother {get; private set;}
        public Person Father {get; private set;}

        public Family(){
            Children = new List<Person>();
        }

        public void AddFather(Person father){
            Father = father;
        }

        public void AddMother(Person mother){
            Mother = mother;
        }

      


    }

}