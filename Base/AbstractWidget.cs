using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;


namespace FINALPROJECT
{
    public abstract class AbstractWidget : IWidget
    {
        
        private WidgetColor _color1;

        public WidgetColor Colortype => _color1;

        public abstract int Springs { get; }
        public abstract int Levers { get; }
        public abstract int Gears { get; }
        public abstract int Quantity { get; set; }
        public abstract WidgetColor WidgetColorType { get; set; }

        public AbstractWidget()
            : this(WidgetColor.Unpainted)
        {}

        public AbstractWidget(WidgetColor color){ }
      
    }
}
