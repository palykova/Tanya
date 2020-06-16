using System;

namespace TRPO_15
{
    class AgeOverSizeException : ArgumentException
    {
        public int Value
        {
            get;
        }
        public AgeOverSizeException (string sms, int val) : base(sms)
        {
            Value = val;
        }
        public void ToString()
        {
            Console.WriteLine(Message + $"ему {Value} лет");
        }
    }
    class Person
    {
        string name { get; set; }
        int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16)
                {
                    new AgeOverSizeException("Лицам до 16 лет - регистрация запрещена, ", value).ToString();
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string Name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество регистраций");
            int k = int.Parse(Console.ReadLine());
            Person[] p = new Person[k];
            for (int i = 0; i < k; i++) 
            {
                Console.WriteLine("Введите Имя");
                string n = Console.ReadLine();
                Console.WriteLine("Введите Возраст");
                int a = int.Parse(Console.ReadLine());
                p[i] = new Person(n);
                p[i].Age = a;
            }
            Console.Read();
        }
    }
}
