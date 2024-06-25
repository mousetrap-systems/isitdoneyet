using System;
using System.Collections.Generic;

/// <summary>
/// A correction is an adjustment on a previous claim or statement, usually by the originator.
/// It's a form of self-reflection and indicates the originator knows they made a mistake.
/// They seek to modify the concept as it sits in the recipient's head ....
/// So we need to model that as well...
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Correction : Concept
{
    public override List<Sensitivity> Sensitivities { get; set; }

    public string OriginalConcept { get; set; }

    public float ConfidenceLevel { get; set; }
}