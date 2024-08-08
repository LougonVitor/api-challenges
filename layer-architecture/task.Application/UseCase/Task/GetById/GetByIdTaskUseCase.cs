using task.Communication.Responses;

namespace task.Application.UseCase.Task.GetById;

//CLASSE APENAS PARA SIMULAR, N�O APLICANDO L�GICAS REAIS E COMPLEXAS
public class GetByIdTaskUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson()
        {
            Id = id,
            Name = "test",
            Description = "test",
            Priority = Communication.Enums.Priority.High,
            LimitDate = DateTime.Now,
            Status = Communication.Enums.Status.InProgress
        };
    }
}