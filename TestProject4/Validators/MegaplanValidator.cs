using AutotestAPI.Entities.Megaplan.Responses;
using FluentAssertions;

namespace AutotestAPI.Validators
{
    public class MegaplanValidator
    {
        /// <summary>
        /// Проверить Задачу
        /// </summary>
        /// <param name="response">Изначальные данные задачи </param>
        /// <param name="task">С чем сравнивать</param>
        public static void CheckTask(BasicTaskResponse response, BasicTaskResponse task)
        {
            response.Should().BeEquivalentTo(task, options =>
            options.Excluding(o => o.Data.Owner.LastOnline.Value)
                   .Excluding(o => o.Data.LastView)
                   //.Excluding убрать что либо, если надо убрать большую часть то можно убрать весь параметр и добавить нужные через .Including
                   );
        }
        /// <summary>
        /// Проверить только название Задачи
        /// </summary>
        /// <param name="response">Изначальные данные задачи </param>
        /// <param name="task">С чем сравнивать</param>
        public static void CheckTaskName(BasicTaskResponse response, BasicTaskResponse task)
        {
            response.Should().BeEquivalentTo(task, options =>
            options.Excluding(o => o)
            .Including(o => o.Data.Name)
                   );
        }
    }
}
