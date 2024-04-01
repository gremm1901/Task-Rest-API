namespace AutotestAPI.Framework
{
    public class EnumAssertion
    {
        /// <summary>
        /// Статусы животных
        /// </summary>
        public enum Status { available = 0, pending = 1, sold = 2 };
        /// <summary>
        /// Роли клиентов в PlatziFakeStore
        /// </summary>
        public enum Role { admin = 0, customer = 1 };
    }
}
