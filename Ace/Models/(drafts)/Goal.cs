/// <summary>
/// A goal is generally considered to be the end point. It's where you want to be.
/// A goal is typically broad, long-term, and aspirational.
/// Goals are often less specific and can lack a detailed plan or timeline.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Goal : Need
{
    /// <summary>
    /// Gets or sets the status of the goal.
    /// This could indicate whether the goal is not started, in progress, or completed.
    /// </summary>
    public new string Status { get; set; } = "not started";

    /// <summary>
    /// Gets or sets the target time frame for the goal.
    /// This represents a more flexible or approximate indication of when the goal should be achieved.
    /// It can be set to values like 'far in the future', 'near future', 'month target', 'year target', etc.
    /// </summary>
    public string TargetTimeFrame { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the steps or actions that need to be taken to achieve the goal.
    /// </summary>
    public List<string> Steps { get; set; } = new List<string>();


    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}