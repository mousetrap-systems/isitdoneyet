using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

/// <summary>
/// Concepts are abstract ideas or mental constructs representing a class of objects,
/// events, or relationships. They are stable and long-lived, serving as the
/// building blocks of cognition. Concepts allow for generalization, categorization,
/// and understanding of the world.
/// 
/// AKA notion, thought
/// This representation is typically inert and usually stable,
/// each has different levels of utility to the observer.
/// Base-level aspect of a traditional concept. This exists in abstract space mostly,
/// and can be identifiable because it resists having ownership assigned.
/// Almost always has a pithy title, details in the description, e.g. conversation summary.
/// The various LLM's can usually do a good job of syntesis, and it can be refined later as the conversation progresses.
/// GPT-4 said: "When generating a summary, I analyze the key points, main ideas, or important information in the given text, and then create a concise representation of those elements. To obtain a summary from me, you can provide the content you'd like to summarize, and I will do my best to generate a concise version of that information."
/// </summary>
[Author("GPT-4", 2023)]
[Author("Warren James", 2023)]
[Health(CodeStability.Experimental)]
public abstract class Concept : PredictionModel
{
    /// <summary>
    /// This is the root-level identifier for the concept.
    /// </summary>
    [JsonPropertyName("id")]
    public string UniqueKey { get; set; } // = $"c-{Randomness.GenerateKey(12)}";

    [Required]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("parent")]
    public string Parent { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = "UNCLASSIFIED";

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public abstract List<Sensitivity> Sensitivities { get; set; }

    public List<string> RelatedConcepts { get; set; }

    /// <summary>
    /// Gets or sets a list of named sets that the concept belongs to.
    /// this has to be the id.
    /// </summary>
    public List<string>? NamedSets { get; set; }

    public string ParentObjective { get; set; }

    public string? ChainedSummary { get; set; }

    public List<string> Children => throw new NotImplementedException();

    public List<string> Related => throw new NotImplementedException();

    public string Serial => throw new NotImplementedException();

    public List<string> Tangents => throw new NotImplementedException();

    /// <summary>
    /// This property can store additional information or attributes related
    /// to the concept in a key-value format. This can be useful for adding
    /// custom or context-specific data without modifying the interface itself.
    /// </summary>
    Dictionary<string, string> Metadata { get; }

}