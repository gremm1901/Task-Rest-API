namespace AutotestAPI.OOP
{
    //Sealed блокирует возможность наследоваться от этого класса
    sealed class Transport
    {
    }
    //Будет ошибка ибо родитель с типом Sealed
    public class Car : Transport
    { }
    //Основной класс internal, значит и наследники должны быть internal или private
    internal class Human { }
    //Ошибка так как родитель internal, а этот класс public
    public class Man: Human { }
}
