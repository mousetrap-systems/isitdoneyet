using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Intent represents an entity's planned course of action based on its current understanding or state.
/// In AI, it's a high-level representation of the decision-making process. It informs what the AI plans to do next.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Intent : Concept
{
    public override List<Sensitivity> Sensitivities { get; set; }

    // Intent-specific properties
    public string ActionPlan { get; set; } // A description of the planned action or response
    public float ConfidenceLevel { get; set; } // AI's confidence in the correctness or effectiveness of the intent
}