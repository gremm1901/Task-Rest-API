namespace TestProject4
{
    public class Register
    {
        public object RegisterClients(string usernameClient, string emailClient, string passwordClient)
        {
            return new
            {
                username = usernameClient,
                email = emailClient,
                password = passwordClient
            };
        }
    }
}
