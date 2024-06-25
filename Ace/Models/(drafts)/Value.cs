using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A Value represents a principle or standard that an individual or society 
/// holds in high regard. These often guide behaviors, judgments, and attitudes.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Value : Concept
{
    /// <summary>
    /// Gets or sets the principle or standard that this value represents.
    /// </summary>
    public string Principle { get; set; }

    /// <summary>
    /// Gets or sets how this value guides behaviors or attitudes.
    /// </summary>
    public string Influence { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; }
}
