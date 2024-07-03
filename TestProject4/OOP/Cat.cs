namespace AutotestAPI.OOP
{
    // кот наследует все от родителя Animal, Animal ничего не знает о Cat
    //У него будет ошибка так как нериализоавн метод из интерфейса
    // Если класс родитель private, то наследуемые не может быть Public
    public class Cat : Animal, IMovementAnimal
    {
        public Cat(string name) : base(name) { }
        //Порода кошки
        public string Breed { get; set; }
        public void Move()
        {
            Console.WriteLine($"Кошка бегает по дому в час ночи");
        }
        public void Jump()
        {
            Console.WriteLine($"Кошка прыгает высоко и далеко");
        }
        public void Squat() { }
    }
}
