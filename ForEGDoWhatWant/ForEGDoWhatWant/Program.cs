using ForEGDoWhatWant;
using System.Drawing;
using System.Xml.Linq;

namespace ForEGDoWhatWant
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();  // объявление объекта класса дог = инициализация создания собаки     // до создания public Puppy() { } в Dog слово Dog здесь подчеркивалось красным
            myDog.age = 5;
            myDog.Name = "Шарик";
            Console.WriteLine($"Первый вариант написания (переменная myDog) \nВозраст myDog= {myDog.Age}, а кличка {myDog.Name} \n");

            Console.WriteLine("Второй вариант написания(переменная myDog2)");
            Dog myDog2 = new Dog(); // как вывести?
            myDog2.DisplayInfo();
            Console.WriteLine();

            var myDog3 = new { Name = "Рекс", Age = 2, Breed = "Такса" };
            Console.WriteLine($"Третий вариант написания (переменная myDog3) \nИмя: {myDog3.Name}, Возраст: {myDog3.Age}, Порода: {myDog3.Breed} \n");



            Puppy myPuppy = new Puppy();    // до создания public Puppy() { } в Puppy слово Puppy здесь подчеркивалось красным
            Puppy myPuppy2 = new();
            Console.WriteLine($"Возраст щенка myPuppy {myPuppy.age=1}");
            //myPuppy.age = 1;
            Console.WriteLine($"\nВозраст щенка myPuppy2 {myPuppy.age=2}");
            //myPuppy2.age = 2;
            Console.WriteLine();

            myPuppy.ReactToCar();
            Console.WriteLine("Это используется метод из класса Puppy, public override void ReactToCar() \nЖивотное издает звуки (в данном случае myPuppy");
            Console.WriteLine();
            myDog.Sound();
            Console.WriteLine("Это используется метод из класса Animal,public void Sound(), тк в классе Dog нет этого метода \nЖивотное издает звуки (в данном случае myDog)");
        }
    }
}
