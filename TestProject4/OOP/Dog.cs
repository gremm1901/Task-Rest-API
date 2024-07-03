namespace AutotestAPI.OOP
{
    // кот наследует все от родителя Animal, Animal ничего не знает о Cat
    public class Dog : Animal, IMovementAnimal
    {
        public Dog(string name) : base(name) { }
        //Порода кошки
        public string Breed { get; set; }
        public void Move()
        {
            Console.WriteLine($"Собака убегает из дома как только ты не закрыл дверь");
        }
        public void Jump()
        {
            Console.WriteLine($"Собака прыгает высоко и далеко()");
        }
        public void Squat() { }
        public void Crawl()
        {
            Console.WriteLine("Конечно собака умеет ползать ибо все собаки хорошие мальчики");
        }
        // Переопределили метод 
        public override void MyNewName(string NewName)
        {
            Console.WriteLine($"{NewName} не мое настоящие имя");
        }
    }
}
