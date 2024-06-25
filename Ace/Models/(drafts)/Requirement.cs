/// <summary>
/// a Requirement usually has a more formal, specific connotation,
/// especially in a business or technical context.
/// For instance, in project management or software development,
/// requirements are detailed, actionable specifications that a system
/// or process must fulfill. They are typically mandatory and can often be
/// measured or tested to confirm compliance.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Requirement : Need
{
    /// <summary>
    /// Gets or sets a value indicating whether the requirement is mandatory.
    /// In many contexts, requirements are expected to be met without exception.
    /// </summary>
    public bool IsMandatory { get; set; }

    /// <summary>
    /// Gets or sets the criteria or method for verifying the requirement.
    /// This could be a test, a measure, a review, or any other method 
    /// that can confirm whether the requirement has been fulfilled.
    /// </summary>
    public string VerificationMethod { get; set; } = string.Empty;
    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}