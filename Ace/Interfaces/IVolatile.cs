using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface for objects with properties that can be dynamically adjusted.
/// This is typically used to signify that an object's priority or weight
/// may change over time or in response to changing circumstances or requirements.
/// </summary>
public interface IVolatile
{
    /// <summary>
    /// Adjusts the priority or weight of the object based on the given adjustment factor.
    /// </summary>
    /// <param name="adjustmentFactor">Factor to adjust the priority or weight by.</param>
    void AdjustPriority(decimal adjustmentFactor);
}
