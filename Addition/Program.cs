using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте  класс  MyClass<T>, содержащий  статический  фабричный  метод  –  T  FacrotyMethod(), 
//который будет  порождать  экземпляры  типа, указанного  в  качестве  параметра  типа  (указателя  места 
//заполнения типом – Т). 

namespace Addition
{
    class First { }
    class Second { }
    class Third { }

    class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = MyClass<First>.FacrotyMethod();
            Console.WriteLine(a.GetType().Name);

            var b = MyClass<Second>.FacrotyMethod();
            Console.WriteLine(b.GetType().Name);

            var c = MyClass<Third>.FacrotyMethod();
            Console.WriteLine(c.GetType().Name);

            Console.ReadKey();
        }
    }
}
