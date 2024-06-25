using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Decision represents the choice made between different alternatives.
/// In AI, this might also involve a probabilistic element, where decisions are made based on computed likelihoods.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Decision : Concept
{
    public override List<Sensitivity> Sensitivities { get; set; }

    // Decision-specific properties
    public string ChosenAlternative { get; set; } // The chosen alternative after the decision process
    public Dictionary<string, float> AlternativesProbability { get; set; } // Alternatives with their respective probabilities
}