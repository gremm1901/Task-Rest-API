namespace TestProject4
{
    public class CreateClient
    {
        public object CreateClients(string nameClient, string jobClient) {
            return new
            {
                name = nameClient,
                job = jobClient
            };
        }
    }
}
