using DescriptionAttribute = System.ComponentModel.DescriptionAttribute;

namespace AutotestAPI.Enums
{
    /// <summary>
    /// Типы сущностей
    /// </summary>MassActionDelete
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
        TaskType = 4,
        [Description("DateTime")]
        DateTimeType = 5,
        [Description("ResourceValue")]
        ResourceValue = 6,
        [Description("password")]
        Password = 7,
        [Description("DateOnly")]
        DateOnlyType = 8,
        [Description("CommentCreateActionRequest")]
        CommentCreate = 9,
        [Description("Comment")]
        Comment = 10,
        [Description("DateInterval")]
        DateInterval = 11,
        [Description("MassActionDelete")]
        MassActionDelete = 112
    };

}

