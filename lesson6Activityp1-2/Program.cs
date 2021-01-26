using System;
using MyNamespace.MyObjects;

namespace Transportation.Vehicles
{
    public class Auto
    {
        public Auto()
        {
            this.make = "";
            this.model = "";
        }

        public Auto(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        public string make { get; set; }
        public string model { get; set; }
    }
}

namespace Exercise
{

    public class Test
    {
        // TODO: 'TestWidget` method
        public void TestWidget(Widget widget)
        {
            widget.viewed++;
        }
    }
}

namespace MyNamespace
{
    namespace MyObjects
    {
        public class Widget
        {
            public int viewed;

            public Widget()
            {
                this.viewed = 0;
            }
        }
    }
}
