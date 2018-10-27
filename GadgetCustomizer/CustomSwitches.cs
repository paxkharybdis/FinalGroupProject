using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;

namespace GadgetCustomizer
{
    class CustomSwitches : AbstractGadgetOptions
    {
        private int _qty, _lights, _buttons, _switches;
        private GadgetColor _gadgetColor;
        private WidgetColor _widgetColor;
        private GadgetPower _gadgetPower;
        private GadgetType _gadgetType;
        private GadgetSize _gadgetSize;
        private long _serialNumber;
        private long _upcNumber;

        public CustomSwitches(IGadget gadget, int Qty, GadgetType gadgettype)
            : base(gadget)
        {
            _qty = Qty;
            this._gadgetColor = gadget.GadgetColorType;
            this._widgetColor = gadget.WidgetColorType;
            this._gadgetPower = gadget.PowerType;
            this._gadgetType = gadgettype;
            this._gadgetSize = gadget.GadgetSize;
            this._serialNumber = gadget.SerialNumber;
            this._upcNumber = gadget.UpcNumber;

        }

        public override decimal Price
        {
            get { return customGadget.Price + (_qty * 15.00m); }
        }

        public override int Switches
        {
            set
            {
                this._switches = customGadget.Switches + _qty;
            }
            get
            {
                return customGadget.Switches + _qty;
            }
        }

        public override GadgetColor GadgetColorType
        {
            set
            {
                this._gadgetColor = value;
            }
            get
            {
                return _gadgetColor;
            }
        }

        public override WidgetColor WidgetColorType
        {
            set
            {
                this._widgetColor = value;
            }
            get
            {
                return _widgetColor;
            }
        }
        public override GadgetPower PowerType
        {
            set
            {
                this._gadgetPower = value;
            }
            get
            {
                return _gadgetPower;
            }
        }

        public override int Buttons
        {
            set
            {
                this._buttons = customGadget.Buttons;
            }
            get
            {
                return customGadget.Buttons;
            }
        }

        public override int Lights
        {
            set
            {
                this._lights = customGadget.Lights;
            }
            get
            {
                return customGadget.Lights;
            }
        }

        public override GadgetType GadgetType
        {
            set
            {
                this._gadgetType = value;
            }
            get
            {
                return _gadgetType;
            }
        }

        public override GadgetSize GadgetSize
        {
            get
            {
                return _gadgetSize;
            }
        }

        public override int Quantity
        {
            get { return customGadget.Quantity; }
            set { }
        }

        public override int SmallWidgets
        {
            get { return customGadget.SmallWidgets; }
        }

        public override int MediumWidgets
        {
            get { return customGadget.MediumWidgets; }
        }

        public override int LargeWidgets
        {
            get { return customGadget.LargeWidgets; }
        }

        public override long SerialNumber
        {
            set
            {
                this._serialNumber = value;
            }
            get
            {
                return _serialNumber;
            }
        }

        public override long UpcNumber
        {
            set
            {
                this._upcNumber = value;
            }
            get
            {
                return _upcNumber;
            }
        }
    }
}
