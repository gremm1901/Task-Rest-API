using AutotestAPI.Client;
using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Framework;
using AutotestAPI.Validators;
using AssertionHelper = AutotestAPI.Helpers.AssertionHelper;
using EnumHelper = AutotestAPI.Helpers.EnumHelper;
using static AutotestAPI.Enums.DomenEnum;
using static AutotestAPI.Enums.ContentTypeEnum;
using static AutotestAPI.Enums.EmployeeEnum;
using static AutotestAPI.Enums.ContractHumanEnum;

namespace AutotestAPI.Tests
{
    /// <summary>
    /// Создание и проверка задачи
    /// </summary>
    public class TestsMegaplan
    {
        [Test]
        public void CreateTask()
        {
            //arrange
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = EnumHelper.GetDescription(Password)
            };
            var createTaskRequest = new TaskCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee),
                },
                IsTemplate = false,
                IsUrgent = false
            };
            //act
            var client = new MegaplanClient(EnumHelper.GetDescription(Megaplan));
            client.AuthEmployee(createUserRequest);
            var respCreateTask = client.CreateTask(createTaskRequest);
            var OpenTask = client.OpenTaskId(Convert.ToInt32(respCreateTask.Data.Data.Id));
            //Assert
            MegaplanValidator.CheckTask(respCreateTask.Data, OpenTask.Data);
            MegaplanValidator.CheckTaskName(respCreateTask.Data, OpenTask.Data);
            AssertionHelper.ChecksStatus(OpenTask);
        }
        /// <summary>
        /// Создание проекта и проверка его
        /// </summary>
        [Test]
        public void CreateProject()
        {
            //arrange
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = EnumHelper.GetDescription(Password)
            };

            var client = new MegaplanClient(EnumHelper.GetDescription(Megaplan));
            client.AuthEmployee(createUserRequest); 
            var file = client.AddFile();
            //Есть ли смысл создать отдельный файл в котором будут методы в которых будет весь этот код по созданию
            var createProjectRequest = new ProjectCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                Category165CustomFieldFayl = new List<Category165CustomFieldFaylRequest>
                {
                    new Category165CustomFieldFaylRequest
                    {
                        ContentType = EnumHelper.GetDescription(FileType),
                        Id = file.Data.Data[0].Id
                    }
                },
                Category165CustomFieldBolshoeChislo = GenerationData.GenerationInt(5).ToString(),
                Category165CustomFieldChislo = GenerationData.GenerationInt(3),
                Category165CustomFieldDaNet = true,
                Category165CustomFieldDataIVremya = new Category165CustomFieldDataIVremyaRequest
                {
                    ContentType = EnumHelper.GetDescription(DateTimeType),
                    Value = DateTime.Now
                },
                Category165CustomFieldPlanFakt = new Category165CustomFieldPlanFaktRequest
                {
                    ContentType = EnumHelper.GetDescription(ResourceValue),
                    Planned = GenerationData.GenerationInt(2)
                },
                Category165CustomFieldSotrudnikKlient = new Category165CustomFieldSotrudnikKlientRequest
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeTest)
                },
                Category165CustomFieldViborIzSpiska = "1",//Вынести в Enum
                Auditors = new List<AuditorRequest>
                {
                    new AuditorRequest
                    {
                        ContentType = EnumHelper.GetDescription(Employee),
                        Id = EnumHelper.GetDescription(EmployeeTest)
                    }
                },
                ContentType = EnumHelper.GetDescription(Project),
                Contractor = new ContractorRequest
                {
                    ContentType = EnumHelper.GetDescription(ContractorHuman),
                    Id = EnumHelper.GetDescription(Human)
                },
                Deadline = new DeadlineRequest
                {
                    ContentType = EnumHelper.GetDescription(DateOnlyType),
                    Day = DateTime.Now.Day.CompareTo(2),
                    Month = DateTime.Now.Month.CompareTo(1),
                    Year = DateTime.Now.Year,
                },
                Executors = new List<ExecutorRequest>
                {
                    new ExecutorRequest
                    {
                        ContentType = EnumHelper.GetDescription(Employee),
                        Id = EnumHelper.GetDescription(EmployeeTest)
                    }
                },
                KpiStart = GenerationData.GenerationInt(1),
                KpiUnit = GenerationData.GenerationString(3),
                Owner = new OwnerRequest 
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeDirector)
                },
                Statement = "<p>asdasd</p>",
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };
            //act
            var respCreateProjec = client.CreateProject(createProjectRequest);
            AssertionHelper.ChecksStatus(respCreateProjec);
            var OpenProjec = client.OpenProjectId(respCreateProjec.Data.Data.Id);
            //Assert
            AssertionHelper.ChecksStatus(OpenProjec);
            MegaplanValidator.CheckProject(respCreateProjec.Data, OpenProjec.Data);
        }
        /// <summary>
        /// Добавить коментарий в проекте
        /// </summary>
        [Test]
        public void AddComentToProject()
        {
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = EnumHelper.GetDescription(Password)
            };
            var createProjectRequest = new ProjectCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                ContentType = EnumHelper.GetDescription(Project),
                Owner = new OwnerRequest
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeDirector)
                },
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };

            var client = new MegaplanClient(EnumHelper.GetDescription(Megaplan));
            client.AuthEmployee(createUserRequest);
            var respCreateProjec = client.CreateProject(createProjectRequest);
            var createComent = new CreateCommentRequest
            {
                Comment = new CommentRequest
                {
                    Completed = 0,
                    Content = GenerationData.GenerationString(12),
                    ContentType = EnumHelper.GetDescription(Comment),
                    Owner = new OwnerRequest
                    {
                        ContentType = EnumHelper.GetDescription(Employee),
                        Id = EnumHelper.GetDescription(EmployeeDirector)
                    },
                    Subject = new SubjectRequest
                    {
                        ContentType = EnumHelper.GetDescription(Project),
                        Id = respCreateProjec.Data.Data.Id
                    },
                    TimeCreated = new TimeCreatedRequest
                    {
                        ContentType = EnumHelper.GetDescription(DateTimeType),
                        Value = DateTime.Now
                    },
                    WorkDate = new WorkDateRequest
                    {
                        ContentType = EnumHelper.GetDescription(DateTimeType),
                        Value = DateTime.Now
                    },
                    WorkTime = new WorkTimeRequest
                    {
                        ContentType = EnumHelper.GetDescription(DateInterval),
                        Value = GenerationData.GenerationInt(5)
                    }
                },
                ContentType = EnumHelper.GetDescription(CommentCreate),
                Transports = { }
            };
            var comment = client.AddComment(respCreateProjec.Data.Data.Id, "project", createComent);

            AssertionHelper.ChecksStatus(comment);

            var OpenProjec = client.OpenProjectId(respCreateProjec.Data.Data.Id);

            MegaplanValidator.CheckComment(comment.Data.Data, OpenProjec.Data.Data.LastComment);
        }
        /// <summary>
        /// Массовое удаление проектов
        /// </summary>
        [Test]
        public void MassDeleteProject()
        {
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = EnumHelper.GetDescription(Password)
            };
            var createProjectRequest = new ProjectCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                ContentType = EnumHelper.GetDescription(Project),
                Owner = new OwnerRequest
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeDirector)
                },
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };
            var createTwoProjectRequest = new ProjectCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                ContentType = EnumHelper.GetDescription(Project),
                Owner = new OwnerRequest
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeDirector)
                },
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };

            var client = new MegaplanClient(EnumHelper.GetDescription(Megaplan));
            client.AuthEmployee(createUserRequest);
            var respCreateProjec = client.CreateProject(createProjectRequest);
            var respCreateTwoProjec = client.CreateProject(createTwoProjectRequest);

            var massDelete = new MassDeleteRequest
            {
                ContentType = EnumHelper.GetDescription(MassActionDelete),
                Entities = new List<EntityDeleteRequest>
                {
                    new EntityDeleteRequest
                    {
                        ContentType = EnumHelper.GetDescription(Project),
                        Id = respCreateProjec.Data.Data.Id
                    },
                    new EntityDeleteRequest
                    {
                        ContentType = EnumHelper.GetDescription(Project),
                        Id = respCreateTwoProjec.Data.Data.Id
                    }
                },
                WithNotifications = false
            };

            var deleteProject = client.MassDelete(massDelete);
            AssertionHelper.ChecksStatus(deleteProject);
            var openDeleteProject = client.OpenProjectId(respCreateProjec.Data.Data.Id);
            AssertionHelper.ChecksStatus(openDeleteProject, 404);
            var openDeleteTwoProject = client.OpenProjectId(respCreateTwoProjec.Data.Data.Id);
            AssertionHelper.ChecksStatus(openDeleteTwoProject, 404);
        }
        /// <summary>
        /// Переименовать проект
        /// </summary>
        [Test]
        public void RenameProject()
        {
            var createUserRequest = new AuthEmployeeRequest
            {
                Username = "grisha.manuk1",
                Password = "grisha.manuk1",
                GrantType = EnumHelper.GetDescription(Password)
            };
            var createProjectRequest = new ProjectCreateRequest
            {
                Name = GenerationData.GenerationString(10),
                ContentType = EnumHelper.GetDescription(Project),
                Owner = new OwnerRequest
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(EmployeeDirector)
                },
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(EmployeeDirector),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };

            var client = new MegaplanClient(EnumHelper.GetDescription(Megaplan));
            client.AuthEmployee(createUserRequest);
            var respCreateProjec = client.CreateProject(createProjectRequest);

            var renameProject = new ProjectCreateRequest
            {
                ContentType = EnumHelper.GetDescription(Project),
                Id = respCreateProjec.Data.Data.Id,
                Name = GenerationData.GenerationString(10),
            };

            var renameProjectResp = client.UpdateProject(renameProject, respCreateProjec.Data.Data.Id);
            AssertionHelper.ChecksStatus(renameProjectResp);
            MegaplanValidator.CheckProjectNameСhanges(respCreateProjec.Data, renameProjectResp.Data);
        }
    }
}
