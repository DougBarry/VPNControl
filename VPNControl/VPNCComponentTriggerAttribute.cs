using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    /// <summary>
    /// The VPNCComponentTriggerAttribute is used to identify the main class of an trigger component.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class VPNCComponentTriggerAttribute : VPNCComponentAttribute
    {

        public VPNCComponentTriggerAttribute(string Name, string Description, string Author, string Version, string Website)
            : base(Name, Description, Author, Version, Website, VPNCComponentType.Trigger)
        {
        }

    }
}
