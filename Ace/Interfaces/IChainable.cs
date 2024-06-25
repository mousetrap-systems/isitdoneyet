using System.ComponentModel.DataAnnotations;

/// <summary>
/// Pattern for universal cognitive structures, this class provides linking to other things (in all directions).
/// Effectively the underlying structure for 'Prediction Model', but only containing everything relating to
/// (1) Heirarchy, (2) Tagging, (3) Set based inclusions
/// </summary>
public interface IChainable
{
    /// <summary>
    /// Indicates the depth or level of the current concept within the overall cognitive chain.
    /// A higher level might represent a more abstract or encompassing idea, while a lower level might be more specific or detailed.
    /// </summary>
    // public int Depth { get; }

    /// <summary>
    /// Points to immediate children or subordinate concepts that stem from the current node.
    /// This enables navigation to finer-grained details or branching ideas, expanding the chain's breadth.
    /// the models listed here should have this model as 'parent' (singular).
    /// </summary>
    public List<string> Children { get; }

    /// <summary>
    /// This property can store a list of related concepts, allowing you to create a
    /// web of interconnected ideas and make it easier to navigate through related concepts.
    /// The unique key of the concept should be used.
    /// </summary>
    List<string> Related { get; }

    /// <summary>
    /// The unique identifier of this object
    /// </summary>
    [MaxLength(16)]
    public abstract string Serial { get; }

    /// <summary>
    /// Indicates a link to (identifier of) a parent reference.
    /// There are only very-few top-level objectives, and in this case,
    /// the parent objective will be the same as the Class name.
    /// </summary>
    [MaxLength(16)]
    public abstract string Parent { get; }

    /// <summary>
    /// Provides a succinct overview of the hierarchically superior objectives linked to the current concept.
    /// Acting as a lens, the Synopsis encapsulates the essence of preceding links, ensuring a coherent 
    /// understanding without delving into each individual detail. Ideal for quick orientation within the cognitive structure.
    /// </summary>
    public abstract string Synopsis { get; }

    /// <summary>
    /// Suggests related but non-hierarchical concepts that might be of interest.
    /// These tangents can enrich understanding by providing alternative perspectives or related avenues of exploration.
    /// </summary>
    public List<string> Tangents { get; }
}