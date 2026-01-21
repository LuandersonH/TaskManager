using System.ComponentModel.DataAnnotations;
using TaskManager.Application.Enums;

namespace TaskManager.Communication.Requests;

public class RequestRegisterTaskJson
{
    [Required]
    [StringLength(maximumLength: 100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(maximumLength: 500)]
    public string Description { get; set; } = string.Empty;
    
    [Required]
    [EnumDataType(typeof(Priority))]
    public Priority Priority { get; set; }

    [Required]
    public required DateTime dueDate { get; set; }
    
    [Required]
    [EnumDataType(typeof(Status))]
    public Status Status { get; set; }
}
