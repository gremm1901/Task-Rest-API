using AutotestAPI.Entities.Megaplan.Responses;
using FluentAssertions;
using System.Threading.Tasks;

namespace AutotestAPI.Validators
{
    public class MegaplanValidator
    {
        /// <summary>
        /// Проверить Задачу
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="task">С чем сравнивать</param>
        public static void CheckTask(BasicTaskResponse response, BasicTaskResponse task)
        {
            response.Should().BeEquivalentTo(task, options =>
            options.Excluding(o => o.Data.Owner.LastOnline.Value)
                   .Excluding(o => o.Data.LastView)
                   .Excluding(o => o.Data.Category130CustomFieldTipTekst)
                   .Excluding(o => o.Data.Category130CustomFieldTipUnikalniyTekst)
                   //.Excluding убрать что либо, если надо убрать большую часть то можно убрать весь параметр и добавить нужные через .Including
                   );
        }
        /// <summary>
        /// Проверить Проект
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="project">С чем сравнивать</param>
        public static void CheckProject(BasicProjectResponse response, BasicProjectResponse project)
        {
            response.Should().BeEquivalentTo(project, options =>
            options.Excluding(o => o.Data.Owner.LastOnline.Value)
                   .Excluding(o => o.Data.LastView)
                   .Excluding(o => o.Data.AttachesInfo)
                   .Excluding(o => o.Data.Category165CustomFieldFayl)
                   //.Excluding убрать что либо, если надо убрать большую часть то можно убрать весь параметр и добавить нужные через .Including
                   );
        }
        /// <summary>
        /// Проверить коментарий
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="coment">С чем сравнивать</param>
        public static void CheckComment(ComentResponse response, ComentResponse coment)
        {
            response.Should().BeEquivalentTo(coment, options =>
            options.Excluding(o => o)
            .Including(o => o.ContentType)
            .Including(o => o.Content)
            .Including(o => o.Id)
            .Including(o => o.WorkTime)
                   );
        }
        /// <summary>
        /// Проверить только название Задачи
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="task">С чем сравнивать</param>
        public static void CheckTaskName(BasicTaskResponse response, BasicTaskResponse task)
        {
            response.Should().BeEquivalentTo(task, options =>
            options.Excluding(o => o)
            .Including(o => o.Data.Name)
                   );
        }
        /// <summary>
        /// Проверить только название Проекта
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="project">С чем сравнивать</param>
        public static void CheckProjectNameСhanges(BasicProjectResponse response, BasicProjectResponse project)
        {
            response.Should().NotBeEquivalentTo(project, options =>
            options.Excluding(o => o)
            .Including(o => o.Data.Name)
                   );
        }
        /// <summary>
        /// Проверить только описание Задачи
        /// </summary>
        /// <param name="response">Изначальные данные  </param>
        /// <param name="task">С чем сравнивать</param>
        public static void CheckTaskStatement(BasicTaskResponse response, BasicTaskResponse task)
        {
            response.Should().BeEquivalentTo(task, options =>
            options.Excluding(o => o)
            .Including(o => o.Data.Statement)
                   );
        }
    }
}
