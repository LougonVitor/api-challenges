using task.Communication.Requests;
using task.Communication.Responses;

namespace task.Application.UseCase.Task.Register;


//CLASSE APENAS PARA SIMULAR, NÃO APLICANDO LÓGICAS REAIS E COMPLEXAS
public class RegisterTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseTaskJson
        {
            Id = 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            LimitDate = request.LimitDate,
            Status = request.Status
        };
    }
}