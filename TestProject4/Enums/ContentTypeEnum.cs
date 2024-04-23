using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// Типы сущностей
    /// </summary>
    public enum ContentTypeEnum
    {
        [Description("Employee")]
        Employee = 0,
        [Description("ContractorHuman")]
        ContractorHuman = 1,
        [Description("Project")]
        Project = 2,
        [Description("File")]
        FileType = 3,
        [Description("Task")]
        Task = 4,
        [Description("DateTime")]
        DateTimeType = 5,
        [Description("ResourceValue")]
        ResourceValue = 6,
        [Description("password")]
        Password = 7,
        [Description("DateOnly")]
        DateOnlyType = 8
    };

}

