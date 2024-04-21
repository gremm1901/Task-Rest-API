using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{

    /// <summary>
    /// Роли клиентов в PlatziFakeStore
    /// </summary>
    public enum RoleEnum
    {
        [Description("admin")]
        Admin = 0,
        [Description("customer")]
        Customer = 1 
    };
}
