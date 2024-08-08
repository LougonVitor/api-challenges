using task.Communication.Responses;

namespace task.Application.UseCase.Task.GetAll;


//CLASSE APENAS PARA SIMULAR, NÃO APLICANDO LÓGICAS REAIS E COMPLEXAS
public class GetAllTaskUseCase
{
    public List<ResponseTaskJson> Execute()
    {
        return new List<ResponseTaskJson>()
        {
            new ResponseTaskJson()
            {
                Id = 1,
                Name = "test",
                Description = "test",
                Priority = Communication.Enums.Priority.High,
                LimitDate = DateTime.Now,
                Status = Communication.Enums.Status.InProgress
            },
            new ResponseTaskJson()
            {
                Id = 2,
                Name = "test",
                Description = "test",
                Priority = Communication.Enums.Priority.High,
                LimitDate = DateTime.Now,
                Status = Communication.Enums.Status.InProgress
            }
        };
    }
}