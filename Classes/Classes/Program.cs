using Classes.Math;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
