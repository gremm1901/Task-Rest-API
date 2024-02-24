namespace TestProject4
{
    public class Reqres
    {
        public int page { get; set; }
        public int er_page { get; set; }
        public int total { get; set; }
        public int otal_pages { get; set; }
        public List<Users> data { get; set; }

    }
    public class Users
    {
        public int id { get; set; }
        public string? email { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? avatar { get; set; }

    }
    public class Reqres1
    {
        public string? name { get; set; }
        public string? job { get; set; }
        public string? id { get; set; }
        public string? createdAt { get; set; }

    }
    public class StarWars
    {
        public string? name { get; set; }
        public string? height { get; set; }
        public string? mass { get; set; }
        public string? hair_color { get; set; }
        public string[]? films { get; set; }

    }
}
