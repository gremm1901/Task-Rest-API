namespace AutotestAPI.OOP
{
    /// <summary>
    /// Это интерфейс реализующие разные виды движений
    /// Move - это двигаться
    /// Jump -  прагать
    /// Squat - присидать
    /// </summary>
    public interface IMovementAnimal
    {
        void Move();
        void Jump();
        void Squat();
        void Crawl();
    }
}
