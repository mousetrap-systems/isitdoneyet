/// <summary>
/// An objective is a measurable step that you take to achieve a goal.
/// Objectives are concrete, short- to mid-term, and actionable.
/// They are more specific than goals and include a clear plan or steps to reach them.
/// For example, if your goal is to "be healthier," an objective might be to "run a 5K race in six months."
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Objective : Need
{
    /// <summary>
    /// Gets or sets the goal that this objective is meant to achieve.
    /// This can link the objective to a broader goal.
    /// </summary>
    public string RelatedGoal { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the target date by which the objective should be achieved.
    /// </summary>
    public DateTime? TargetDate { get; set; }

    /// <summary>
    /// Gets or sets the measure or indicator of success for the objective.
    /// This could be a numeric target, a completion status, or any other measure 
    /// that indicates whether the objective has been achieved.
    /// </summary>
    public string SuccessIndicator { get; set; } = string.Empty;

    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}