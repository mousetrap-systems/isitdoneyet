using System;
using System.Collections.Generic;

/// <summary>
/// Preference represents a comparative assessment between two or more options.
/// It is an indication of an entity's comparative liking or favor for one option over others.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Preference : Concept
{
    public override List<Sensitivity> Sensitivities { get; set; }

    // Preference-specific properties
    public List<string> Options { get; set; } // The list of options to choose from
    public string PreferredOption { get; set; } // The preferred choice from the list of options
}