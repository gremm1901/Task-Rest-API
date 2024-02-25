//start test
namespace TestProject4
{
    public class Test
    {
        //3 задание
        [Test]
        public void Test3()
        {
            var request = new Request(); 
            var resp = request.postRequest("https://reqres.in", "api/users", new
            {
                name = "sdf",
                job = "dsfsd"

            });

            var People = JsonSerializer.Deserialize<Reqres1>(resp.Content);
            
            if (request.checkStatus(resp, 201))
            {
                Console.WriteLine(People.id);
                Assert.Pass();
            }
            else
            {
                Console.WriteLine("код ответа не 201");
                Assert.Fail();
            };
        }
        //2 задание
        [Test]
        public void Test2()
        {

            var request = new Request();
            var resp = request.getRequest("https://reqres.in", "api/users?page=2");

            var People = JsonSerializer.Deserialize<Reqres>(resp.Content);
            if (request.checkStatus(resp, 200))
            {
                for (int i = 0; i < People.data.Capacity; i++)
                {
                    if (People.data[i].first_name == "George" && People.data[i].last_name == "Edwards")
                    {
                        Console.WriteLine(People.data[i].email);
                        Assert.Pass();
                        break;
                    }
                }
            }
            else { Console.WriteLine("Запрос не корректен"); Assert.Fail(); }
        }
        //Задание 1
        [Test]
        public void Test1()
        {
            var request = new Request();
            var resp = request.getRequest("https://swapi.dev", "api/people/2/");

            var People = JsonSerializer.Deserialize<StarWars>(resp.Content);

            if (People.films.Length != 0 && request.checkStatus(resp,200))
            {
                for (int i = 0; i < People.films.Length; i++)
                {
                    Console.WriteLine(People.films[i]);
                }
                Assert.Pass();
            }
            else { Console.WriteLine("чет не так"); Assert.Fail(); }
        }
    }
}
