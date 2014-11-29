using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace VPNControl.Triggers
{
    [VPNCComponentTrigger("Date time condition","Tigger based on date and time constraints", "DougBarry", "1", "https://github.com/dougbarry")]
    internal class DateTimeCondition : IVPNCTrigger
    {
        enum DateTimeTriggerType
        {
            Moment,
            Daily,
            Weekly,
            Monthly,
            Yearly
        }

        enum DatetimeTriggerAccuracy
        {
            Exact,
            MinuteRange,
            HourRange,
            RandomRange
        }


        public bool TriggerTest()
        {
            throw new NotImplementedException();
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public void LoadSettings(Dictionary<string, string> settings)
        {
            throw new NotImplementedException();
        }

        public IVPNCComponentSettings GetAvailableSettings()
        {
            Logger.Entry();

            return new Settings();
        }

        [TypeConverter(typeof(PropertySorter))]
        [DefaultProperty("DateTimeTrigger")]
        class Settings : IVPNCComponentSettings
        {
            DateTimeTriggerType _dateTimeTriggerType;

            [DisplayName("Trigger Type")]
            [Description("")]
            [Category("Action (required)"), PropertyOrder(12)]
            public DateTimeTriggerType DateTimeTrigger
            {
                get { return _dateTimeTriggerType; }
                set { _dateTimeTriggerType = value; }
            }

            DatetimeTriggerAccuracy _accuracy;

            [DisplayName("Accuracy")]
            [Description("")]
            [Category("Optional"), PropertyOrder(10)]
            public DatetimeTriggerAccuracy Accuracy
            {
                get { return _accuracy; }
                set { _accuracy = value; }
            }

            int _rangeValue;

            [DisplayName("Accuracy range value (seconds)")]
            [Description("")]
            [Category("Optional"), PropertyOrder(11)]
            public int RangeValue
            {
                get { return _rangeValue; }
                set { _rangeValue = value; }
            }
        }
        
        public void LoadSettings(IVPNCComponentSettings properties)
        {
            Logger.Entry();

            throw new NotImplementedException();
        }
    }
}
