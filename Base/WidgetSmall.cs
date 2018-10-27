using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public class WidgetSmall : AbstractWidget   
    {
        private int _gears = 2, _springs = 3, _levers = 1, _quantity;
        private WidgetColor _widgetColor;

        public override int Quantity
        {
            set
            {
                this._quantity = Quantity;
            }
            get
            {
                return _quantity;
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

        public override int Springs
        {
            get
            {
                return _springs;
            }
        }

        public override int Levers
        {
            get
            {
                return _levers;
            }
        }

        public override int Gears
        {
            get
            {
                return _gears;
            }
        }

        public WidgetSmall()
            : this(WidgetColor.Unpainted)
        {
        //    Console.WriteLine("Assembling Small Widget");
        //    Console.WriteLine("Widget Color is: " + WidgetColor.Unpainted);
        }

        public WidgetSmall(WidgetColor widgetColor)
            : base(widgetColor)
        {
        //    Console.WriteLine("Assembling Small Widget");
        //    Console.WriteLine("Widget Color is: " + widgetColor);
        }
    }
}
