namespace AppIII.Maui.Infrastructure.Model;

public record Equipment
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public DateTime? RetiredDate { get; set; }
}