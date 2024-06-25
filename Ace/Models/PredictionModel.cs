using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

/// <summary>
/// A prediction model is the generic fundamental layer of a concept - the FOUNDATION of all our cognitive thought constructs.
/// It can be as small or large as needed/presented but has fundamental properties - basically a foundation schema.
/// Thousands of these may get dynamically created per second in an ACE brain, but only the strong ones get prioritized by the entity boundary.
/// The most 'solid' prediction models can be used later as knowledge graphs, or used as pointers to more formalized structures.
/// This object will typically live as a single file in azure and be loaded into short-term memory as required.
/// The core components here represent a locked schema which is system-embedded.
/// Talk to the project about 'Prediction Models' for more info.
/// </summary>
[Author("GPT-4", 2024)]
[Author("Warren James", 2023 - 2024)]
public abstract class PredictionModel : IChainable
{
    /// <summary>
    /// This property represents the root-level identifier for the concept. Once set, this never changes.
    /// FORMAT: always composed of an lower-case prefix form-of [a-z], followed by a dash, then a random lowercase string.
    /// Example: "a-{Randomness.GenerateKey(14)}"
    /// Example: "ab-{Randomness.GenerateKey(13)}"
    /// The total length should not exceed 16 characters to ensure efficient indexing.
    /// For a-z lowercase ... with well-over 131,621,703,842,267,136 combinations per prefix, collisions should be very rare
    /// However, a collision handling mechanism still needs to be in place.
    /// If it turns out to be a major problem later (with volume) then modify the number generator to allow capitals !
    /// (then you can get combinations in the order of 13^62 which should be plenty)
    /// </summary>
    [Health(CodeStability.SuperStable)]
    [JsonPropertyName("serial")]
    [MaxLength(16)]
    [Required]
    public string Serial { get; set; } = string.Empty;

    /// <summary>
    /// Chaining of prediction models using hierarchy is VERY COMMON and generally preferred because it makes association lookup less expensive.
    /// If this prediction model is determined to a sub-component of a higher-level object, then this value is the identifier of the parent prediction model.
    /// Having a parent value is not essential and there may be competition for which is the 'true' parent and this may switch over time as better models become available.
    /// </summary>
    [Health(CodeStability.Stable)]
    [JsonInclude]
    [JsonPropertyName("parent")]
    public string Parent { get; set; } = string.Empty;

    /// <summary>
    /// Reference to the base schema of this model.
    /// Also known as 'Category', it denotes the primary class only, since OTHER schemas can also apply (and at different suitability levels)
    /// NOTE this value should typically be a serial belonging to another prediction model typeof:schema for this particular entity, which is another prediction model.
    /// This value may be a pointer to system-provided schemas, but many will be schemas that the ACE has created (e.g. with their own a copy of base schema)
    /// NOTE: It's assumed this is always a pointer to the current version.
    /// It's expected this can change over time (i.e. switching primary schemas), but should be rare.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("schema")]
    public string Schema { get; set; } = "schema-000000001";

    /// <summary>
    /// Uses ISO 639-1 language codes to indicate the expected (majority) content of the prediction model.
    /// This is fundamentally a marker to indicate the initial language encoding and will be used to route.
    /// If the content actually has several languages embedded, this should indicate that the model requires splitting (text-based markup can be used)
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;

    /// <summary>
    /// Full string of this particular prediction model, in title format. Minimum amount of information for a prediction model to exist.
    /// Note this could actually be quite large - but won't be longer than a large paragraph of text.
    /// Cognitive primitives will generally have much smaller titles.
    /// If the title is every changed, that actually causes versioning or split/budding.
    /// NOTE: The character set of the title should ideally match the language encoding indicated.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("title")]
    [Required]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// This is the explanatory body/text, basically an expanded description of the title.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// When was this prediction model first (ever) created?
    /// NOTE: Never changes once set.
    /// We're using this data format so that the data can be handled (potentially) by other systems.
    /// This value is fundamentally an audit record and it's only used in storing and processing data.
    /// 64-bit number allows beyound the unix year 2038 issue (and beyond).
    /// </summary>
    [JsonPropertyName("date_created")]
    public long DateCreated { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    /// <summary>
    /// When did this (version) of the prediction model last change?
    /// Very basic ... hopefully in tandem with 'version'.
    /// Indicates the change for any of 'title' and 'description'.
    /// If this value is the same as 'date created' then it means the model wasn't modified since it was created.
    /// </summary>
    [JsonPropertyName("date_modified")]
    public long DateModified { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    /// <summary>
    /// Gets or sets a list of named sets that the concept belongs to.
    /// This MUST be a prediction model serial.
    /// NOTE: This is not the same as 'Tags' because a 'set' is literally a named set, i.e. it represents a specific structure.
    /// </summary>
    public List<string> NamedSets { get; set; } = new List<string>();

    /// <summary>
    /// Summary statement which explains the current (or last) conclusion.
    /// This is basically the output.
    /// </summary>
    public string Synopsis { get; set; } = string.Empty;

    /// <summary>
    /// With respect to heirarchy, which items are positioned DIRECTLY beneath this one?
    /// </summary>
    public List<string> Children { get; set; } = new List<string>();

    /// <summary>
    /// Any prediction models which are referenced to this one, but non-heirarchy.
    /// It is also expected that a ratings matrix (stack ranking) would apply to each relationship/inclusion, but that's a separate structure.
    /// </summary>
    public List<string> Related { get; set; } = new List<string>();

    public List<string> Tangents { get; set; } = new List<string>();

    public List<string> Sensitivities { get; set; } = new List<string>();

    /// <summary>
    /// This property can store additional information or attributes related
    /// to the concept in a key-value format. This can be useful for adding
    /// custom or context-specific data without modifying the interface itself.
    /// TODO: Change this to some kind of property bag?
    /// This can also be persisted to Azure blob storage as properties
    /// </summary>
    Dictionary<string, string> Metadata { get; } = new Dictionary<string, string>();

    /// <summary>
    /// It is possible to tag directly ... can be general words but ideally prediction model serials.
    /// This is a loose implementation of inclusion of this item in a named set and mainly allows it to quickly show up in search.
    /// NOTE: Don't use sensitive values in here because it may be persisted to the search index.
    /// </summary>
    List<string> Tags { get; set; } = new List<string>();

    /// <summary>
    /// Indicates the current version of the prediction model.
    /// Ideally this is datetime-based, i.e. 20240512.1204
    /// </summary>
    public decimal Version { get; set; }
}