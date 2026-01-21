
using TaskManager.Application.Enums;

namespace TaskManager.Application.Entities;

public class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime dueDate { get; set; }
    public Status Status { get; set; }

}
