using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// An Imperative represents a command, duty, or an action that an individual should take.
/// Imperatives are often derived from a Value but they are more specific – a direct application
/// of a value in a certain context. For example, from the value of "honesty", we can derive 
/// the imperative "Do not lie".
/// </summary>
[Author("GPT-4", 2023)]
[Health(CodeStability.Experimental)]
public partial class Imperative : Value
{
    /// <summary>
    /// Gets or sets the specific action, command or duty that the imperative represents.
    /// </summary>
    public string Action { get; set; }

    public override List<Sensitivity> Sensitivities { get; set; }
}