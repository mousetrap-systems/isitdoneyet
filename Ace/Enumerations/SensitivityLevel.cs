using System;

/// <summary>
/// Use this to flag (in combination with 'Entity') a concept/nugget
/// as a particular sensitivity level.
/// Other entities must have similar or matching clearance in conjunction with groups.
/// </summary>
public enum SensitivityLevel : int
{
    Secret,          // Extremely sensitive, should never be disclosed
    TopSecret,       // Highly sensitive, only disclosed to very few with the highest clearance
    Confidential,    // Sensitive, only disclosed to those with proper clearance
    Restricted,      // Limited access, shared only with specific groups or individuals
    HBI,             // High Business Impact
    MBI,             // Medium Business Impact
    LBI,             // Low Business Impact
    Internal,        // Information meant for internal use within an organization
    Personal,        // Personal information, not meant to be shared outside a specific context
    Unrestricted,    // No specific restrictions, can be shared more freely
    Public           // Completely public, can be shared with anyone
}