namespace TestProject4
{
    public class Test
    {
        //3 задание
        public void Test3()
        {
            var request = new Request(); 
            var resp = request.postRequest("https://reqres.in", "api/users", new
            {
                name = "sdf",
                job = "dsfsd"

            });
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var People = JsonSerializer.Deserialize<Reqres1>(resp.Content, options);
            
            if (request.checkStatus(resp, 201))
            {
                Console.WriteLine(People.id);
            }
            else
            {
                Console.WriteLine("код ответа не 201");
            };
        }
        //2 задание
        public void Test2()
        {

            var request = new Request();
            var resp = request.getRequest("https://reqres.in", "api/users?page=2");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var People = JsonSerializer.Deserialize<Reqres>(resp.Content, options);
            if (request.checkStatus(resp, 200))
            {
                for (int i = 0; i < People.data.Capacity; i++)
                {
                    if (People.data[i].first_name == "George" && People.data[i].last_name == "Edwards")
                    {
                        Console.WriteLine(People.data[i].email);
                        break;
                    }
                }
            }
            else { Console.WriteLine("Запрос не корректен"); }
        }
        //Задание 1
        public void Test1()
        {
            var request = new Request();
            var resp = request.getRequest("https://swapi.dev", "api/people/2/");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var People = JsonSerializer.Deserialize<StarWars>(resp.Content, options);

            if (People.films.Length != 0 && request.checkStatus(resp,200))
            {
                for (int i = 0; i < People.films.Length; i++)
                {
                    Console.WriteLine(People.films[i]);
                }
            }else { Console.WriteLine("чет не так"); }
        }
    }
}
