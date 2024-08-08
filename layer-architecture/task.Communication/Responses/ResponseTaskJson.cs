using task.Communication.Enums;

namespace task.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public Status Status { get; set; }
}