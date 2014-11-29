using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    /// <summary>
    /// The VPNCComponentAttribute is used to identify the main class of a component.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public abstract class VPNCComponentAttribute : Attribute
    {
        public string HRName;
        public string Description;
        public string Author;
        public string Version;
        public string Website;
        public VPNCComponentType Type;
        public Guid GUID;

        public VPNCComponentAttribute(string HRName, string Description, string Author, string Version, string Website, VPNCComponentType Type)
        {
            this.HRName = HRName;
            this.Description = Description;
            this.Author = Author;
            this.Version = Version;
            this.Website = Website;
            this.Type = Type;
            this.GUID = Guid.NewGuid();
        }

    }

}
