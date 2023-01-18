using System;
using System.Collections.Generic;

namespace oops {
    public class Person {

        //fields are also member of the class and they can be changed. But usually these are things that you dont want to be changed.
        //you want fields to be a very internal component to the class
        private int _lifetime = 100; // a person can live for a max of 100 yrs.  

        // properties are attributes about the class that should be allowed to be customized to some degree
        public string Name {
            set {
                Name = value.Length > 2 ? value: "NoName";
            }
            get {
                return Name;
            }
        }
        public string Profession {get; set;}

        private int age {get;}
        private string gender {get;}

        public Person(string name, string gender, int age, string profession) {
            Name = name;
            this.gender = gender;
            this.age = age;
            Profession = profession;
        }

        public void describe() {
            Console.WriteLine($"I am a {Name}, a {age} year old {gender}. I am a {Profession}");
        }
        public void HowLongWillYouLive() {
            Console.WriteLine($"I will live for a max of {_lifetime - age} years or so.");
        }

    }

}