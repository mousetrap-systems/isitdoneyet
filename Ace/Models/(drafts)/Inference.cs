using System;
using System.Collections.Generic;

/// <summary>
/// An Inference is a conclusion reached based on evidence, reasoning, and prior knowledge.
/// It represents a cognitive and essential process in problem-solving and decision-making, 
/// where available information is utilized to identify unseen situations, beliefs, or conditions.
/// In the context of an AI conversational model, inferences can be used to generate responses 
/// based on patterns and relationships between concepts, needs, and claims. Inferences in conversation 
/// have the potential to uncover hidden goals, desires, or motivations from the speaker.
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Inference : Concept
{
    /// <summary>
    /// Gets or sets the evidence or premises that the inference is based on.
    /// </summary>
    public string Evidence { get; set; }

    /// <summary>
    /// Gets or sets the conclusion reached based on the evidence.
    /// </summary>
    public string Conclusion { get; set; }

    /// <summary>
    /// Gets or sets the discovery potential of the inference. The discovery potential 
    /// can be a measure of how likely the inference might lead to the discovery of 
    /// hidden goals, desires, or motivations. This could be a score or a qualitative 
    /// assessment.
    /// </summary>
    public string DiscoveryPotential { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; }
}