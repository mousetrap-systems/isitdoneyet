using System;
using System.Collections.Generic;

/// <summary>
/// ITaxonomy defines an interface for managing taxonomies, which are collections of items that can be classified and organized in a hierarchical or flat structure.
/// </summary>
public interface ITaxonomy<T> where T : Concept
{
    /// <summary>
    /// Add an item to the taxonomy.
    /// </summary>
    void AddItem(T item);

    /// <summary>
    /// Remove an item from the taxonomy.
    /// </summary>
    void RemoveItem(T item);

    /// <summary>
    /// Get an item from the taxonomy by its ID or unique identifier.
    /// </summary>
    T GetItemById(string id);

    /// <summary>
    /// Determine if an item is in the taxonomy.
    /// </summary>
    bool ContainsItem(T item);

    /// <summary>
    /// Retrieve all items in the taxonomy.
    /// </summary>
    List<T> GetAllItems();
}