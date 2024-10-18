using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEGDoWhatWant
{
    public class AdultDog: Dog 
    {
        public override void ReactToCar()
        {
            Console.WriteLine("Взрослая собака громко лает на машину");
        }

        public override void ReactToPet()
        {
            Console.WriteLine("Взрослая собака медленно виляет хвостом");
        }

        public AdultDog(int age, string breed)
        {
            Age = age;
            Breed = breed;
        }
    }
}
