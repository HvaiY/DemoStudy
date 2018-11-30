public class People
{
    [StringLength(8)]
    public string Name { get; set; }

    [StringLength(15)]
    public string Description { get; set; }
}