using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

/// <summary>
/// Represents a 'motive-force', acting as a part of a dependency chain usually 
/// leading to a higher objective or goal. A Need is typically derived from or 
/// drives other needs, potentially signifying a state of cognitive entropy.
/// It serves as a fundamental building block that can be extended to other 
/// conceptual entities such as 'Objective', 'Desire', 'Goal', and 'Requirement'. 
/// Each of these entities can be considered a specific manifestation of a need 
/// with unique characteristics and purposes. In essence, a Need contributes to 
/// cognitive entropy, a measure of uncertainty or disorder in an entity's knowledge or beliefs.
/// </summary>
[Author("Warren James", 2023)]
[Health(CodeStability.RequiresReview)]
public abstract class Need : Concept, IChainable, IVolatile
{
    /// <summary>
    /// Gets or sets the urgency of the need.
    /// This could be represented as a numeric scale (e.g., from 1 to 5),
    /// or as descriptive terms (e.g., "low", "medium", "high").
    /// </summary>
    [Author("GPT-4", 2023)]
    public string Urgency { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the status of the need.
    /// This could indicate whether the need is unmet, partially met, or fully met.
    /// </summary>
    [Author("GPT-4", 2023)]
    public string Status { get; set; } = "unmet";

    /// <summary>
    /// Gets or sets any actions that are being taken or should be taken
    /// to meet the need. This could be a list of steps, tasks, or strategies.
    /// </summary>
    [Author("GPT-4", 2023)]
    public List<string> Actions { get; set; } = new List<string>();

    /// <summary>
    /// Indicates who 'has' the objective. Normally a single association attributed to a specific entity boundary.
    /// e.g. 'Warren James' or 'AI Entity'.
    /// Zero-length means unknown and indicates an unstable state.
    /// VIRTUAL entities are okay as well, so long as they are registered.
    /// e.g. 'objective belonging to the business as a virtual entity'.
    /// </summary>
    [Required]
    public string OwnershipFlag { get; set; } = string.Empty;

    /// <summary>
    /// Almost always 'en-uk' but can be changed to other locales as required.
    /// If you don't use 'override' on the derived class, this will be the default.
    /// If you WANT to override the Language property in MY_DERIVED_CLASS, you can do this:
    /// public override string Language { get; set; } = "en-au";
    /// </summary>
    public virtual string Language { get; set; } = "en-uk";

    /// <summary>
    /// Provides guidance to the AI on how the presence of this objective, goal, or intent affects the context of the discussion.
    /// The description can be as long or short as needed but should be as accurate and concise as possible.
    /// Consider using GPT-4 to help write the content for this property, as it can better understand the nuances of large language models.
    /// NOTE: The codebase will specify a default definition, but the AI may later adjust it in accordance with its goals and understanding.
    /// </summary>
    [Required]
    public string AIContextNotes { get; set; } = string.Empty;

    /// <summary>
    /// Represents the priority of the goal, objective, or intent. Higher values indicate higher priority.
    /// Supports negative values, which can be used to represent lower priority or special cases.
    /// Default value is 0, indicating a neutral or unspecified priority.
    /// Adjusted by the application and is dynamic as priorities change.
    /// NOTE: Do not store this as a property in Cosmos DB.
    /// </summary>
    [IgnoreDataMember]
    [Range(-100, 100)]
    public float Priority { get; set; } = 0;

    public void AdjustPriority(decimal adjustmentFactor)
    {
        throw new NotImplementedException();
    }
}