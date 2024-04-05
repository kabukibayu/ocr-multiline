using System.ComponentModel.DataAnnotations;

public class FlowiseAIRequestModel
{
    [Required]
    public required string[] Question { get; set; }
}
