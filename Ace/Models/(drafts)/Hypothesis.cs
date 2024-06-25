using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A Hypothesis is a proposed explanation for a phenomenon, formulated for 
/// the purpose of testing through experimentation and observation.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Hypothesis : Concept
{
    /// <summary>
    /// Gets or sets the testable statement or prediction made by the hypothesis.
    /// </summary>
    public string Statement { get; set; }

    /// <summary>
    /// Gets or sets the methodology proposed to test the hypothesis.
    /// </summary>
    public string Methodology { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; }
}
