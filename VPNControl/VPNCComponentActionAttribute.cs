using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    /// <summary>
    /// The VPNCComponentActionAttribute is used to identify the main class of an action component.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class VPNCComponentActionAttribute : VPNCComponentAttribute
    {

        public VPNCComponentActionAttribute(string Name, string Description, string Author, string Version, string Website)
            : base(Name, Description, Author, Version, Website, VPNCComponentType.Action)
        {
        }

    }
}
