using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте класс MyDictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
//использования  его  экземпляра  аналогично  экземпляру  класса  Dictionary
//(Урок  5(индексаторы) пример  5). 
//Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления 
//пар элементов, индексатор для получения значения элемента по указанному индексу и свойство только 
//для чтения для получения общего количества пар элементов.  

namespace Task_3
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] elements;
        int length = 0;

        public int Count { get { return length; } }

        public void Add(TKey ind, TValue el)
        {
            Array.Resize(ref keys, Count + 1);
            Array.Resize(ref elements, Count + 1);
            keys[elements.Length - 1] = ind;
            elements[elements.Length - 1] = el;
            length++;
        }

        public TValue this[TKey index]
        {
            get
            {
                int i = Array.IndexOf(keys, index);
                if (i == -1)
                    return default(TValue);
                else
                    return elements[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var words = new MyDictionary<string, string>();
            words.Add("книга", "book");
            words.Add("ручка", "pen");
            words.Add("солнце", "sun");
            words.Add("яблоко", "apple");
            words.Add("стол", "table");

            Console.Write("Введите слово на русском языке: ");
            string key = Console.ReadLine();
            Console.WriteLine($"{key} - {words[key]}");

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
