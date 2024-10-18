using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForEGDoWhatWant
{
    public class Puppy: Dog 
    {
        public override void ReactToCar()   // override переопределяет метод
        {
            Console.WriteLine("Щенок тявкает на машину");
        }

        public override void ReactToPet()
        {
            Console.WriteLine("Puppy wags its tail quickly");
        }

        public string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}, Порода: {Breed}";
        }

        public Puppy(int age, string breed)
        {
            Age = age;
            Breed = breed;
        }

        public Puppy()
        {
        }
    }
}
