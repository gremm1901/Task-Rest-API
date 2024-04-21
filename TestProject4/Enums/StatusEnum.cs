using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// Статусы животных
    /// </summary>
    public enum StatusEnum
    {
        [Description("available")]
        Available = 0,
        [Description("pending")]
        Pending = 1,
        [Description("sold")]
        Sold = 2
    };
}
