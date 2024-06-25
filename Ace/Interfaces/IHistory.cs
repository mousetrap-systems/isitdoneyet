/// <summary>
/// Indicates this event may form part of a historical record - someone did something
/// </summary>
public interface IHistory
{
    public string Notes { get; set; }
}