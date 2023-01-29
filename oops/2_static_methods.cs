namespace oops {
    
    class StaticMethodExplainer {
        public static void Main(string[] args) {
            StaticMethodExplainer.printName("Rodrigos");
        }

        public static void printName(string name) {
            Console.WriteLine($"My name is {name}");
        }
    }

}
