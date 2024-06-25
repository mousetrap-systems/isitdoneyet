using System;
using System.Collections.Generic;

/// <summary>
/// Claims are statements or propositions presented for evaluation or acceptance.
/// They can never be fully proven but can accumulate evidence to support their validity.
/// Claims can still be used in reasoning, argumentation, and decision-making, even if they
/// are not fully proven.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Claim : Concept
{
    /// <summary>
    /// Gets or sets the list of supporting evidence for the claim.
    /// This can include facts, statistics, references, or any other type of evidence
    /// that could potentially support the validity of the claim.
    /// </summary>
    public List<string> Evidence { get; set; } = new List<string>();

    /// <summary>
    /// Gets or sets the list of counter evidence for the claim.
    /// This can include facts, statistics, references, or any other type of evidence
    /// that could potentially oppose the validity of the claim.
    /// </summary>
    public List<string> CounterEvidence { get; set; } = new List<string>();

    /// <summary>
    /// Gets or sets the status of the claim.
    /// This could indicate whether the claim is unverified, disputed, or accepted.
    /// </summary>
    public string Status { get; set; } = "unverified";

    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}