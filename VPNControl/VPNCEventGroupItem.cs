using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    struct VPNCEventGroupItem
    {
        private VPNCEventGroup _eventGroup;

        public VPNCEventGroup EventGroup
        {
            get { return _eventGroup; }
            set { _eventGroup = value; }
        }

        private IVPNCComponent _component;

        public IVPNCComponent Component
        {
            get { return _component; }
            set { _component = value; }
        }

        public VPNCEventGroupItem(VPNCEventGroup eventGroup, IVPNCComponent components)
        {
            this._eventGroup = eventGroup;
            this._component = components;
        }
    }
}
