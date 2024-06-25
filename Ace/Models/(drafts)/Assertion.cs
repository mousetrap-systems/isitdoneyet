using System;
using System.Collections.Generic;

/// <summary>
/// An Assertion is a confident and forceful statement of fact or belief, typically articulated
/// by an intelligent entity. It often aligns with an underlying motive or goal. An assertion is
/// a confident claim that a speaker believes to be factual or true. Such claims may be rooted
/// in empirical evidence, logical reasoning, or widely accepted truths. For instance,
/// "The Earth revolves around the Sun" is an example of an assertion.
///
/// Assertions can generally be verified or refuted given sufficient information or evidence.
/// For example, if someone asserts that "it's raining outside," this claim can be checked and verified.
///
/// Assertions frequently serve as the foundation of arguments and debates, as they are verifiable
/// statements that can be supported or disputed with evidence and reasoning. Therefore, assertions
/// hold significant importance in discussions, debates, and decision-making processes.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Assertion : Concept
{
    /// <summary>
    /// Gets or sets the level of confidence in the assertion.
    /// This could be a measure of how strongly the assertion is held.
    /// </summary>
    public int ConfidenceLevel { get; set; } = 0;

    /// <summary>
    /// Gets or sets any information or reasoning that supports the assertion.
    /// </summary>
    public List<string> SupportingReasons { get; set; } = new List<string>();

    /// <summary>
    /// What are the starting points for the verification of this assertion?
    /// </summary>
    public object? VerificationChain { get; set; }

    /// <summary>
    /// Gets or sets the motive or goal that is associated with this assertion.
    /// This property can link the assertion to an underlying motive or goal.
    /// </summary>
    public string UnderlyingMotive { get; set; } = string.Empty;

    public override List<Sensitivity> Sensitivities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}