/// <summary>
/// Properties that indicate the 'relative life span' of another model or entity.
/// This is mostly used for tracking very short-term things, because we're interested in estimation of duration.
/// Obviously everything has a life span, so there's no real need to label everything, but
/// Only apply this to objects which
/// </summary>
public interface IDuration
{
    /// <summary>
    /// Adjusts the priority or weight of the object based on the given adjustment factor.
    /// </summary>
    /// <param name="adjustmentFactor">Factor to adjust the priority or weight by.</param>
    public int AverageDurationMinutes { get; set; }

    /// <summary>
    /// Sort of like a timer, roughly how much of this timespan has elapsed?
    /// </summary>
    public int CurrentSnapshotMinutes { get; set; }
}