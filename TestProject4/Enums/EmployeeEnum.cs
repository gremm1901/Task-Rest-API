using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// ID Сотрудников
    /// </summary>
    public enum EmployeeEnum
    {
        [Description("1000237")]
        EmployeeTest = 0,
        [Description("1000189")]
        EmployeeProstoy = 1,
        [Description("1000157")]
        EmployeeDirector = 2
    };

}
