using AutotestAPI.Client;
using AutotestAPI.Entities.Megaplan.Requests;
using AutotestAPI.Framework;
using AutotestAPI.Validators;
using AssertionHelper = AutotestAPI.Framework.AssertionHelper;
using EnumHelper = AutotestAPI.Framework.EnumHelper;
using static AutotestAPI.Enums.DomenEnum;
using static AutotestAPI.Enums.ContentTypeEnum;
using static AutotestAPI.Enums.EmployeeEnum;
using static AutotestAPI.Enums.ContractHumanEnum;

namespace AutotestAPI.Tests
{
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
                    Id = EnumHelper.GetDescription(Employee3),
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
                    Id = EnumHelper.GetDescription(Employee1)
                },
                Category165CustomFieldViborIzSpiska = "1",//Вынести в Enum
                Auditors = new List<AuditorRequest>
                {
                    new AuditorRequest
                    {
                        ContentType = EnumHelper.GetDescription(Employee),
                        Id = EnumHelper.GetDescription(Employee1)
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
                        Id = EnumHelper.GetDescription(Employee1)
                    }
                },
                KpiStart = GenerationData.GenerationInt(1),
                KpiUnit = GenerationData.GenerationString(3),
                Owner = new OwnerRequest 
                {
                    ContentType = EnumHelper.GetDescription(Employee),
                    Id = EnumHelper.GetDescription(Employee3)
                },
                Statement = "<p>asdasd</p>",
                Responsible = new ResponsibleRequest
                {
                    Id = EnumHelper.GetDescription(Employee3),
                    ContentType = EnumHelper.GetDescription(Employee)
                },
                IsTemplate = false,
            };
            //act
            var respCreateProjec = client.CreateProject(createProjectRequest);
            AssertionHelper.ChecksStatus(respCreateProjec);
            var OpenProjec = client.OpenProjectId(Convert.ToInt32(respCreateProjec.Data.Data.Id));
            //Assert
            AssertionHelper.ChecksStatus(OpenProjec);
            MegaplanValidator.CheckProject(respCreateProjec.Data, OpenProjec.Data);
        }
    }
}
