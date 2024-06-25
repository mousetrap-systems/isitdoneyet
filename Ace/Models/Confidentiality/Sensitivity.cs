/// <summary>
/// 
/// </summary>
public class Sensitivity : PredictionModel
{
    public string Prefix => "sensi";

    public SensitivityLevel Level { get; set; }
    public IModel AssociatedEntity { get; set; }

    // public Group AssociatedGroup { get; set; }
}