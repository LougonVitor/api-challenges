using task.Communication.Requests;
using task.Communication.Responses;

namespace task.Application.UseCase.Task.Update;

//CLASSE APENAS PARA SIMULAR, N�O APLICANDO L�GICAS REAIS E COMPLEXAS
public class UpdateTaskUseCase
{
    public ResponseTaskJson Execute(int id, RequestTaskJson request)
    {
        return new ResponseTaskJson
        {
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            LimitDate = request.LimitDate,
            Status = request.Status
        };
    }
}