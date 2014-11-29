using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNControl
{
    internal class VPNCEventGroup
    {
        
        private string _name;

	    public string Name
	    {
		    get { return _name;}
		    set { _name = value;}
	    }
	
        private List<IVPNCAction> _actions;

        public List<IVPNCAction> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        private List<IVPNCTrigger> _triggers;

        public List<IVPNCTrigger> Triggers
        {
            get { return _triggers; }
            set { _triggers = value; }
        }

        public VPNCEventGroup(string eventGroupName)
        {
            this._name = eventGroupName;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
