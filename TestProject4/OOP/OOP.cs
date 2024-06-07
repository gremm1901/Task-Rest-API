namespace AutotestAPI.OOP
{
    //Это обстрактный класс, его нельза инициализовать
    abstract class Animal
    {
        //Инкапсуляция это скрытие каких либо данных/методов
        private string yelling = "Очень громко орет";
        public string _name { get; }
        public Animal(string name)
        {
            _name = name;
        }
        public string GetYelling() { return yelling; }
        //Если все же нужен доступ к инкопсулированым данным, стоит делать отдельный метод для изменения
        public void SetYelling(string value) { if (value == "Матершино орет") yelling = value; }
        public void YELLING()
        {
            Console.WriteLine($"{_name} {yelling}");
        }
    }
    // кот наследует все от родителя Animal, Animal ничего не знает о Cat
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        //Порода кошки
        public string Breed { get; set; }
    }
    public class TestsOOP
    {

        [Test]
        public void TestOOP()
        {
            //Иницилизируем класс Cat
            Animal cat = new Cat("Сиамский");
            cat.YELLING();
        }
    }

}
