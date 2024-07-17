namespace AutotestAPI.OOP
{
    //Это обстрактный класс, его нельза инициализовать
    public abstract class Animal
    {
        //Инкапсуляция это скрытие каких либо данных/методов"Очень громко орет"
        private string yelling { get{ return "Очень громко орет"; } set{ if (value == "Матершино орет") yelling = value; } }
        public string _name { get; }
        public Animal(string name)
        {
            _name = name;
        }
        public void Yelling()
        {
            Console.WriteLine($"{_name} {yelling}");
        }
        //Это виртуальный метод,подкласс сможет его поменять для себя, но параметры должны осться 
        public virtual void MyNewName(string NewName)
        {
            Console.WriteLine($"{NewName}");
        }
    }
}
