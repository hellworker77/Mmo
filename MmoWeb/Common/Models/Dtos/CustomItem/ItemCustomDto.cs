namespace Common.Models.Dtos.CustomItem;

public class ItemCustomDto
{
    public Guid OwnerId { get; set; }
    public string Name { get; set; }

    public bool SoulBound { get; set; }
}