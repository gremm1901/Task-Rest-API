using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// Список всех доменов
    /// </summary>
    public enum DomenEnum
    {
        [Description("https://ra.megaplan.ru")]
        Megaplan = 0,
        [Description("https://swapi.dev")]
        StarWars = 1,
        [Description("https://petstore.swagger.io")]
        PetStore = 2,
        [Description("https://api.escuelajs.co")]
        PlatziFakeStore = 3,
        [Description("https://reqres.in")]
        Reqres = 4
    };
}
