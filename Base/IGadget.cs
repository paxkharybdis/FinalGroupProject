using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALPROJECT
{
    public interface IGadget
    {
        GadgetColor GadgetColorType { get; set; }
        GadgetPower PowerType { get; set; }
        WidgetColor WidgetColorType { get; set; }
        GadgetType GadgetType { get; set; }
        GadgetSize GadgetSize { get; }
        decimal Price { get; }
        int Buttons { get; set; }
        int Switches { get; set; }
        int Lights { get; set; }
        int Quantity { get; set; }
        int SmallWidgets { get; }
        int MediumWidgets { get; }
        int LargeWidgets { get; }
        long SerialNumber { get; set; }
        long UpcNumber { get; set; }

        void CleanGadget();
        void PackageGadget();
        void AddUpc();
    }
}
