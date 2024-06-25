using System;
using System.Collections.Generic;

/// <summary>
/// A Core Principle or a Guiding Concept represents a foundational belief or idea that significantly influences an individual's or entity's behavior, decision-making, and actions.
/// It is a 'go to' concept that serves as a reference point in various situations and contexts.
/// It's a foundational idea or concept that guides your thinking, decision-making, and actions. It's something that you consistently come back to when you need guidance or direction.
/// It might not perfectly fit into the constructs we've talked about so far. It's kind of an amalgamation of several: it's a Belief in that it is something you hold to be true; it's an Objective in that it drives your actions and decisions; it could be an Assertion if you state it as a fact; and it's a Value in that it influences your priorities and judgments.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Keystone : Concept
{
    /// <summary>
    /// Defines why this principle or concept is important and how it influences behavior and decisions.
    /// </summary>
    public string Importance { get; set; }

    /// <summary>
    /// Explains the typical outcomes or results when this principle or concept is applied.
    /// </summary>
    public string Outcomes { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; } = new List<Sensitivity>();

}