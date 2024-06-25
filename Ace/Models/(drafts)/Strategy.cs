using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Strategy represents a higher-level plan designed to achieve a particular goal.
/// It's often composed of a sequence of actions or decisions.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Strategy : Concept
{
    public override List<Sensitivity> Sensitivities { get; set; }

    // Strategy-specific properties
    public string Goal { get; set; } // The goal that the strategy is designed to achieve
    public List<string> ActionSequence { get; set; } // A sequence of actions or steps designed to achieve the goal
}