namespace AutotestAPI.OOP
{
    public class Turtle : Animal, IMovementAnimal
    {
        public Turtle(string name) : base(name) { }
        public void Move()
        {
            Console.WriteLine($"Черепаха бегает быстро, но очень редко");
        }
        public void Jump()
        {
            Console.WriteLine($"Черепаха не умеет прыгать");
        }
        public void Squat()
        {
            Console.WriteLine("Черепахи не прыгают(");
        }
        public void Crawl()
        {
            Console.WriteLine("Черепахи ходят всегда");
        }
        // Переопределили метод, но будет ошибка так как мы обрали параметры
        public override void MyNewName()
        {
            Console.WriteLine($"Просто текст");
        }
    }
}
