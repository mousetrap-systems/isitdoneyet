/// <summary>
/// The common properties which construe being a 'prediction'.
/// This doesn't necessarily represent a vision of the future so much as being a focus on inputs/outputs.
/// </summary>
public interface IModel
{
    /// <summary>
    /// Adjusts the priority or weight of the object based on the given adjustment factor.
    /// </summary>
    /// <param name="adjustmentFactor">Factor to adjust the priority or weight by.</param>
    public string Title { get; set; }
}