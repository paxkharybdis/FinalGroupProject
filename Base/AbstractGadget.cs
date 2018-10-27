using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public abstract class AbstractGadget : IGadget
    {
        private GadgetColor _gadgetColor;
        private WidgetColor _widgetColor;
        private GadgetPower _gadgetPower;
        private long _upcNumber;
        private long _serialNumber;
        private int _gadgetQuantity;
        //private string _paintColor;

        public abstract int Buttons { get; set; }

        public abstract int Switches { get; set; }
        public abstract int Lights { get; set; }
        public abstract int Quantity { get; set; }
        public abstract int SmallWidgets { get; }
        public abstract int MediumWidgets { get; }
        public abstract int LargeWidgets { get; }
        public abstract GadgetColor GadgetColorType { get; set; }
        public abstract WidgetColor WidgetColorType { get; set; }
        public abstract GadgetPower PowerType { get; set; }
        public abstract GadgetType GadgetType { get; set; }
        public abstract GadgetSize GadgetSize { get; }
        public abstract long SerialNumber { get; set; }
        public abstract long UpcNumber { get; set; }

        public abstract decimal Price { get; }

        public AbstractGadget()
        {

        }

        public AbstractGadget(WidgetColor widgetcolor, GadgetColor gadgetcolor, GadgetPower power, long SerialNumber, long UPCNumber)
        {
            this._gadgetPower = power;
            this._gadgetColor = gadgetcolor;
            this._widgetColor = widgetcolor;
            this._upcNumber = UPCNumber;
            this._serialNumber = SerialNumber;
            this._upcNumber = UPCNumber;
        }

        public AbstractGadget(int quantity)
        {
            this._gadgetQuantity = quantity;

        }


        public virtual void CleanGadget()
        {
            Console.WriteLine("Cleaning Gadget...");
        }

        public virtual void PackageGadget()
        {
            Console.WriteLine("Packaging Gadget...");
        }

        public virtual void AddUpc()
        {
            Console.WriteLine("Adding UPC to Package");
        }


        /* 
         public override string ToString()
         {
             return this.GetType().Name + "Gadgets color is " +_gadgetColor + "and it costs $" + Price;
         }
         */
    }
}
