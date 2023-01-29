using System;
using System.Collections.Generic;
namespace advanced {
    
    public class DelegatesExplained {
        // Delegates are objects that can hold a reference to methods/functions
        // or storing functions as value in a variable
        // more readability; more functionality; smaller codebase
        //delegates are creating an interface behind
         
         //this is a reference to any method that has the same function signature of no arguments and a void return type
        public delegate void DrinkingAction();
        public delegate bool Agefilter(int n);
        

        public static void Relax(DrinkingAction drink) {
            Console.WriteLine("Relaxing on the beach..");
            if (drink!=null) drink();
        }

        public static List<int> SelectPeople(List<int> agelist, Agefilter fun) {
            return agelist.Where(x => fun(x)).ToList();
        }
         
        public static void Main(String[] args) {
           void DrinkWater() => Console.WriteLine("Drinking water");
           void DrinkBeer() => Console.WriteLine("Drinking Beer");
           void DrinkCocktail() => Console.WriteLine("Drinking Rum with Hot Water");

            DelegatesExplained.Relax(DrinkWater);
            DelegatesExplained.Relax(DrinkBeer);
            DelegatesExplained.Relax(DrinkCocktail);

            //example 2 - delegate methods
            Agefilter filter_youth = delegate (int n) {
                return n >=21 && n<35;
            };
            Agefilter filter_middleAge = delegate (int n) {
                return n >=35 && n<=50 ? true: false;
            };

            // example 3: lambda expression
            Agefilter filter_oldAge = (int n) => {
                return n>65;
            };

            var agelist = new List<int>(){18,35,44,21,22,28,31,25,33};
            var young = SelectPeople(agelist, filter_youth); //passing delegates
            var middle = SelectPeople(agelist, filter_middleAge); //passing delegate
            var old = SelectPeople(agelist, filter_oldAge); //passing lambda

            //with a new custom simple lambda function (no return statement required)
            var everyone = SelectPeople(agelist, (int n)=>true);
            
            // EVEN SIMPLER LAMBDA
            var kids = SelectPeople(agelist, n => n<=14);
            
            //with a new custom complex lambda function (return statement required as code is encapsulated by curly braces)
            var evenkids = SelectPeople(agelist, (int i)=> {
                if (i%2 == 0) return true;
                else return false;
            });
        
            foreach(int i in young) Console.Write($"{i} ");
            foreach(int i in middle) Console.Write($"{i} ");
            foreach(int i in old) Console.Write($"{i} ");
        }

    }
}