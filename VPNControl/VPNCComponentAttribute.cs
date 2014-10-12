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
    public sealed class VPNCComponentAttribute : Attribute
    {
        public string Name;
        public string Author;
        public string Version;
        public string Website;
        public VPNCComponentType Type;

        public VPNCComponentAttribute(string Name, string Author, string Version, string Website, VPNCComponentType Type)
        {
            this.Name = Name;
            this.Author = Author;
            this.Version = Version;
            this.Website = Website;
            this.Type = Type;
        }

    }

}
