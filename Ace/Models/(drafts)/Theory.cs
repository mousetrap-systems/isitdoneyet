using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A Theory represents an abstract structure of ideas that explains a phenomenon.
/// Theories are often backed by evidence and widely accepted in the academic community.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Theory : Concept
{
    /// <summary>
    /// Gets or sets the main principles or laws that the theory proposes.
    /// </summary>
    public string Principles { get; set; }

    /// <summary>
    /// Gets or sets the list of evidence supporting the theory.
    /// </summary>
    public List<string> Evidence { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; }
}
