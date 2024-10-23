using System.Xml.Linq;

namespace ForEGDoWhatWant
{
    public class Dog : Animal   // класс Dog наследник класса Animal
    {
        public int age;   // public сделано для того, чтобы бы ОБРАТИТЬСЯ, то есть в классе puppy мы можем обратиться к breed
        
        //private string breed;   // privat сделано для того, чтобы НЕ ОБРАТИТЬСЯ, то есть в классе puppy мы не можем обратиться к breed
        public string breed;    // поменяли privat на public, чтобы сделать код менее нагруженным и убрать лишнее
        
        public string Name {  get; set; }




        public virtual void ReactToCar()
        {
            Console.WriteLine("Dog barks at the car");
        }

        public virtual void ReactToPet()
        {
            Console.WriteLine("Собака виляет хвостом");
        }


        public int Age  // свойства полей age и breed
        {
            get { return age; }     // get - получить
            set {
                    if(value<1)
                    {
                        Console.WriteLine("Возраст не может быть меньше чем 1");
                        age = 1;
                    }
                    else
                    {
                        age = value;
                    }
                }    // set- установить
        }

        public string Breed
        {
            get { return breed; }   // get 
            set { breed = value; }  // set 
        }

        //Delete
        
        public void DisplayInfo()
        {
            Name = "Петя";
            Age = 4;
            Breed = "Бульдог";
            // теперь в классе Program выведет 2 результат
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Порода: {Breed}");
        }

    }
}


