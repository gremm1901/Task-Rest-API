namespace TestProject4
{
    public class login
    {
        public object LoginClients(string usernameClient, string emailClient, string passwordClient)
        {
            return new
            {
                username= usernameClient,
                email= emailClient,
                password= passwordClient
            };
        }
    }
}
