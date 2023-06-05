namespace MyNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            AnimalInPlace animalInPlace = new AnimalInPlace(new Animal("Дуся", "Кошка"), 1);
        }
    }

    internal class Animal
    {
        private string name;
        private string category;
        
        public Animal()
        {
            name = "Чупакабра";
            category = "Собака";
        }

        public Animal(string _name, string _category)
        {
            name = _name;
            category = _category;
        }


        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Имя питомца не может быть пустым.");
                }
            }
        }

        public string Category
        {
            get { return category; }
            set 
            {
                if (string.IsNullOrWhiteSpace(category))
                {
                    category = value;
                }
                else
                {
                    throw new Exception("Категория питомца не может быть пустой.");
                }
            }
        }




    }

    internal class AnimalInPlace : Animal
    {
        private int numberOfPlace;
        private Animal animal;

        public AnimalInPlace()
        {
            numberOfPlace = 0;
            animal = new Animal("Чупокабра", "Собака");
        }

        public AnimalInPlace(Animal _animal, int _numberOfPlace)
        {
            animal = _animal;
            numberOfPlace = _numberOfPlace;
        }

        public int NumberOfPlace
        {
            get { return numberOfPlace; }
            set
            {
                numberOfPlace = value;
            }
        }

}