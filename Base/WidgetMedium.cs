using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public class WidgetMedium : AbstractWidget
    {
        private int _gears = 4, _springs = 5, _levers = 3, _quantity;
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

        public WidgetMedium()
            : this(WidgetColor.Unpainted)
        {
        //    Console.WriteLine("Assembling Medium Widget");
        //    Console.WriteLine("Widget Color is: " + WidgetColor.Unpainted);
        }

        public WidgetMedium(WidgetColor widgetColor)
            : base(widgetColor)
        {
         //   Console.WriteLine("Assembling Medium Widget");
         //   Console.WriteLine("Widget Color is: " + widgetColor);
        }
    }
}
