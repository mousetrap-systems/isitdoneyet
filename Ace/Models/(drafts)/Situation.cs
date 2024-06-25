/// <summary>
/// A situation is a zoned 'activity' which is taking place.
/// This structure is designed to be nested in heirarchy and can go as high or deep as required.
/// The situation has a specific markov blanket, and depending on the schemas involved,
/// and is usually specific to an entity boundary ... e.g. current entity
/// Example: a meeting.
/// </summary>
[Author("Warren James", 2024)]
[Health(CodeStability.Experimental)]
public partial class Situation : PredictionModel, IDuration, IHistory
{
    /// <summary>
    /// Indicates which other entities are currently in the same situation.
    /// This is a volatile list and can change at any given time.
    /// </summary>
    public List<string> EntitiesPresent { get; set; } = new List<string>();

    public int AverageDurationMinutes { get; set; }

    public int CurrentSnapshotMinutes { get; set; }

    public string Notes { get; set; } = string.Empty;
}