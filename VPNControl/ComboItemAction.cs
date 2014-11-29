using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    public class ComboItemAction
    {
        private string _visibleName;

        public string VisibleName
        {
            get { return _visibleName; }
            set { _visibleName = value; }
        }

        private VPNCComponentActionAttribute _sourceType;

        public VPNCComponentActionAttribute SourceType
        {
            get { return _sourceType; }
            set { _sourceType = value; }
        }


        public ComboItemAction(string VisibleName, VPNCComponentActionAttribute AttrType)
        {
            this.VisibleName = VisibleName;
            this.SourceType = AttrType;
        }

        public override string ToString()
        {
            return this.VisibleName;
        }
    }
}
