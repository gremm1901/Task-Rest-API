namespace AutotestAPI.OOP
{
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
