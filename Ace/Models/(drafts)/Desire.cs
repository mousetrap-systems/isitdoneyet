/// <summary>
/// A Desire could be viewed as a type of Need or Goal, but it typically has a more emotional or subjective connotation. While a Need might be something necessary for survival or function, and a Goal might be a specific achievement or outcome that someone is working towards, a Desire is often something that someone wants or wishes for, regardless of its necessity or attainability.
/// In this context, Desire might best inherit directly from Concept as it's a broad, abstract notion that could encompass aspects of needs, goals, beliefs, etc., but doesn't align perfectly with any of them.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Desire : Need, IVolatile
{
    /// <summary>
    /// Gets or sets the intensity or strength of the desire.
    /// This could be a measure of how much someone wants what they desire.
    /// </summary>
    public int Intensity { get; set; }

    /// <summary>
    /// Gets or sets any reasons or motivations for the desire.
    /// This could provide insight into why someone wants what they desire.
    /// </summary>
    public List<string> Reasons { get; set; } = new List<string>();

    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}