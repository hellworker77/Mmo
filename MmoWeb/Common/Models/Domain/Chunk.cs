namespace Common.Models.Domain;

public class Chunk
{
    public int Size { get; set; }
    public int Index { get; set; }
    public int Offset => Index * Size;

}