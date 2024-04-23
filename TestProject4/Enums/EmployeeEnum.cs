using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// ID Сотрудников
    /// </summary>
    public enum EmployeeEnum
    {
        [Description("1000237")]
        Employee1 = 0,
        [Description("1000189")]
        Employee2 = 1,
        [Description("1000157")]
        Employee3 = 2
    };

}
