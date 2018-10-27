using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GadgetCustomizer;
using UniqueNumberGenerators;

namespace FINALPROJECT
{
    public class CustomOutput
    {
        private static int _cmediumGadgetsOrdered = 0;
        private static int _clargeGadgetsOrdered = 0;
        private static int _ctotalGadgetsOrdered = 0;
        private static int _cmtotalButtons = 0;
        private static int _cmtotalSwitches = 0;
        private static int _cmtotalLights = 0;
        private static int _cmtotalBattery = 0;
        private static int _cmtotalSolar = 0;
        private static int _cmtotalGenerator = 0;
        private static int _cmtotalPainted = 0;
        private static int _cmtotalWPainted = 0;
        private static int _cmtotalPlated = 0;
        private static int _cmtotalWPlated = 0;
        private static int _cmtotalUnpainted = 0;
        private static int _cmtotalWUnpainted = 0;
        private static int _cltotalButtons = 0;
        private static int _cltotalSwitches = 0;
        private static int _cltotalLights = 0;
        private static int _cltotalBattery = 0;
        private static int _cltotalGenerator = 0;
        private static int _cltotalSolar = 0;
        private static int _cltotalPainted = 0;
        private static int _cltotalPlated = 0;
        private static int _cltotalUnpainted = 0;
        private static int _cltotalWPainted = 0;
        private static int _cltotalWPlated = 0;
        private static int _cltotalWUnpainted = 0;
        private static decimal _cmediumGadgetSubtotal = 0m;
        private static decimal _clargeGadgetSubtotal = 0m;
        private static decimal _ctotalGadgetsCost = 0m;
        private static int _ctotalGadgetsPainted = 0;
        private static int _ctotalGadgetsPlated = 0;
        private static int _ctotalGadgetsUnpainted = 0;
        private static int _ctotalWidgetsSetsPainted = 0;
        private static int _ctotalWidgetsSetsPlated = 0;
        private static int _ctotalWidgetsSetsUnpainted = 0;
        private static int _ctotalGadgetsBattery = 0;
        private static int _ctotalGadgetsGenerator = 0;
        private static int _ctotalGadgetsSolar = 0;
        private static int _ctotalGadgetsButtons = 0;
        private static int _ctotalGadgetsLights = 0;
        private static int _ctotalGadgetsSwitches = 0;
        public static char myChoice2;
        public static string _sizePrint;
        public static string _typePrint;
        public static string _powerPrint;
        public static string _gadgetColor;
        public static string _widgetColor;

        public CustomOutput(ArrayList Order1)
        {
            TrackingNumberGenerator customShipOrderTracker = TrackingNumberGenerator.Instance;
            OrderNumberGenerator customOrderTracker = OrderNumberGenerator.Instance;
            StringBuilder cbody = new StringBuilder();
            StringBuilder cfooter = new StringBuilder();
            StringBuilder heading = new StringBuilder();
            DateTime now = DateTime.Now;
            foreach (AbstractGadget cgadget in Order1)
            {

                if (cgadget.GadgetSize == GadgetSize.Medium)
                {
                    _cmediumGadgetSubtotal += cgadget.Price;
                    _cmediumGadgetsOrdered++;
                    _cmtotalButtons += cgadget.Buttons;
                    _cmtotalSwitches += cgadget.Switches;
                    _cmtotalLights += cgadget.Lights;
                    if (cgadget.GadgetType == GadgetType.Retail)
                    {
                        _typePrint = "R";
                    }
                    else
                    {
                        _typePrint = "W";
                    }

                    if (cgadget.GadgetSize == GadgetSize.Medium)
                    {
                        _sizePrint = "M";
                    }
                    else
                    {
                        _sizePrint = "L";
                    }

                    if (cgadget.PowerType == GadgetPower.Battery)
                    {
                        _powerPrint = "B";
                    }
                    else if (cgadget.PowerType == GadgetPower.Generator)
                    {
                        _powerPrint = "G";
                    }
                    else
                    {
                        _powerPrint = "S";
                    }

                    if (cgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _gadgetColor = "PT";
                    }
                    else if (cgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _gadgetColor = "PL";
                    }
                    else
                    {
                        _gadgetColor = "UP";
                    }

                    if (cgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _widgetColor = "PT";
                    }
                    else if (cgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _widgetColor = "PL";
                    }
                    else
                    {
                        _widgetColor = "UP";
                    }
                    cbody.AppendFormat("*");
                    cbody.Append(String.Format("{0,12} {1,30} {2,25} {3,16} {4,19}", _sizePrint, _typePrint, cgadget.Buttons, cgadget.Lights, cgadget.Switches));
                    cbody.Append(String.Format("{0,16} {1,15} {2,24} {3,26}", _gadgetColor, _widgetColor, _powerPrint, cgadget.Price));
                    cbody.Append(String.Format("{0,18} {1,16}", cgadget.SerialNumber, cgadget.UpcNumber));
                    cbody.AppendFormat("   ");
                    cbody.AppendFormat("*");
                    cbody.AppendLine();

                    if (cgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _cmtotalPainted++;
                    }
                    else
                    if (cgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _cmtotalPlated++;
                    }
                    else
                    if (cgadget.GadgetColorType == GadgetColor.Unpainted)
                    {
                        _cmtotalUnpainted++;
                    }
                    if (cgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _cmtotalWPainted++;
                    }
                    else
                    if (cgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _cmtotalWPlated++;
                    }
                    else
                    if (cgadget.WidgetColorType == WidgetColor.Unpainted)
                    {
                        _cmtotalWUnpainted++;
                    }
                    if (cgadget.PowerType == GadgetPower.Battery)
                    {
                        _cmtotalBattery++;
                    }
                    else
                    if (cgadget.PowerType == GadgetPower.Generator)
                    {
                        _cmtotalGenerator++;
                    }
                    else
                    if (cgadget.PowerType == GadgetPower.Solar)
                    {
                        _cmtotalSolar++;
                    }
                }
                if (cgadget.GadgetSize == GadgetSize.Large)
                {
                    _clargeGadgetSubtotal += cgadget.Price;
                    _clargeGadgetsOrdered++;
                    _cltotalButtons += cgadget.Buttons;
                    _cltotalSwitches += cgadget.Switches;
                    _cltotalLights += cgadget.Lights;

                    if (cgadget.GadgetType == GadgetType.Retail)
                    {
                        _typePrint = "R";
                    }
                    else
                    {
                        _typePrint = "W";
                    }


                    if (cgadget.GadgetSize == GadgetSize.Medium)
                    {
                        _sizePrint = "M";
                    }
                    else
                    {
                        _sizePrint = "L";
                    }

                    if (cgadget.PowerType == GadgetPower.Battery)
                    {
                        _powerPrint = "B";
                    }
                    else if (cgadget.PowerType == GadgetPower.Generator)
                    {
                        _powerPrint = "G";
                    }
                    else
                    {
                        _powerPrint = "S";
                    }

                    if (cgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _gadgetColor = "PT";
                    }
                    else if (cgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _gadgetColor = "PL";
                    }
                    else
                    {
                        _gadgetColor = "UP";
                    }

                    if (cgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _widgetColor = "PT";
                    }
                    else if (cgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _widgetColor = "PL";
                    }
                    else
                    {
                        _widgetColor = "UP";
                    }

                    cbody.AppendFormat("*");
                    cbody.Append(String.Format("{0,12} {1,30} {2,25} {3,16} {4,19}", _sizePrint, _typePrint, cgadget.Buttons, cgadget.Lights, cgadget.Switches));
                    cbody.Append(String.Format("{0,16} {1,15} {2,24} {3,26}", _gadgetColor, _widgetColor, _powerPrint, cgadget.Price));
                    cbody.Append(String.Format("{0,18} {1,16}", cgadget.SerialNumber, cgadget.UpcNumber));
                    cbody.AppendFormat("   ");
                    cbody.AppendFormat("*");
                    cbody.AppendLine();

                    if (cgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _cltotalPainted++;
                    }
                    else
                    if (cgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _cltotalPlated++;
                    }
                    else
                    if (cgadget.GadgetColorType == GadgetColor.Unpainted)
                    {
                        _cltotalUnpainted++;
                    }
                    if (cgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _cltotalWPainted++;
                    }
                    else
                    if (cgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _cltotalWPlated++;
                    }
                    else
                    if (cgadget.WidgetColorType == WidgetColor.Unpainted)
                    {
                        _cltotalWUnpainted++;
                    }
                    if (cgadget.PowerType == GadgetPower.Battery)
                    {
                        _cltotalBattery++;
                    }
                    else
                    if (cgadget.PowerType == GadgetPower.Generator)
                    {
                        _cltotalGenerator++;
                    }
                    else
                    if (cgadget.PowerType == GadgetPower.Solar)
                    {
                        _cltotalSolar++;
                    }
                }
            }

            _ctotalGadgetsCost = _cmediumGadgetSubtotal + _clargeGadgetSubtotal;
            _ctotalGadgetsOrdered = _cmediumGadgetsOrdered + _clargeGadgetsOrdered;
            _ctotalGadgetsPainted = _cmtotalPainted + _cltotalPainted;
            _ctotalGadgetsUnpainted = _cmtotalUnpainted + _cltotalUnpainted;
            _ctotalGadgetsPlated = _cmtotalPlated + _cltotalPlated;
            _ctotalWidgetsSetsPainted = _cmtotalWPainted + _cltotalWPainted;
            _ctotalWidgetsSetsPlated = _cmtotalWPlated + _cltotalWPlated;
            _ctotalWidgetsSetsUnpainted = _cmtotalWUnpainted + _cltotalWUnpainted;
            _ctotalGadgetsGenerator = _cltotalGenerator;
            _ctotalGadgetsSolar = _cmtotalSolar + _cltotalSolar;
            _ctotalGadgetsBattery = _cmtotalBattery + _cltotalBattery;
            _ctotalGadgetsButtons = _cmtotalButtons + _cltotalButtons;
            _ctotalGadgetsLights = _cmtotalLights + _cltotalLights;
            _ctotalGadgetsSwitches = _cmtotalSwitches + _cltotalSwitches;

            heading.AppendLine();
            heading.AppendLine();
            heading.AppendFormat("*******************************************************************************************************************");
            heading.AppendFormat("*******************************************************************************************************************");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                     ");
            heading.AppendFormat(" WAG CORPORATION");
            heading.AppendFormat("                                                                                                               ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                ");
            heading.AppendFormat(" Thank you for Ordering from us, we are here to serve you!            ");
            heading.AppendFormat("                                                                              ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                         ");
            heading.AppendFormat("Please feel free to fill out the");
            heading.AppendFormat("  survey at Http://www.wagcorp.com/survey and let us know your");
            heading.AppendFormat("  overall experience with the order process!");
            heading.AppendFormat("                                                 ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                           ");
            heading.AppendFormat("   Date/TIME:   {0}", now);
            heading.AppendFormat("                                                                                                    ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*******************************************************************************************************************");
            heading.AppendFormat("*******************************************************************************************************************");
            heading.AppendLine();
            heading.AppendFormat("*   Order Details:");
            heading.AppendFormat("                                                                                                         ");
            heading.AppendFormat("                                                                                                          ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.Append(String.Format("{0,10} {1,30} {2,28} {3,16} {4,20}", "   Gadget Size", "Gadget Type", "Gadget Buttons", "Gadget Lights", "Gadget Switches"));
            heading.Append(String.Format("{0,15} {1,15} {2,26} {3,22}", "Gadget Color", "Widget Color", "Gadget PowerSource", "Gadget Price"));
            heading.Append(String.Format("{0,10} {1,10}", "    Gadget Serial", "    Gadget Upc"));
            heading.AppendFormat("   ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.Append(String.Format("{0,15} {1,30}", "   (S)mall(M)ed(L)arge", "(R)etail(W)arehouse"));
            heading.Append(String.Format("{0,96}", "(PT)Painted(PL)Plated(UP)Unpainted"));
            heading.Append(String.Format("{0,10}", "   (B)attery(S)olar(G)enerator"));
            heading.AppendFormat("                                                 ");
            heading.AppendFormat("*");
            heading.AppendLine();
            heading.AppendFormat("*");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("                                                                                                                  ");
            heading.AppendFormat("*");
            heading.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("                                                                                                                  ");
            cfooter.AppendFormat("                                                                                                                  ");
            cfooter.AppendFormat("*");
            cfooter.AppendLine();
            cfooter.AppendFormat("*******************************************************************************************************************");
            cfooter.AppendFormat("*******************************************************************************************************************");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Order Summary:");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Warehouse Gadget info ");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Medium Gadget info        ");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Medium Gadgets Ordered:               {0}", _cmediumGadgetsOrdered);
            cfooter.AppendLine();
            cfooter.AppendFormat("*           Buttons:   {0}            Lights:   {1}            Switches:   {2}", _cmtotalButtons, _cmtotalLights, _cmtotalSwitches);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("     GadgetsPlated:    {0}    GadgetsPainted:    {1}    GadgetsUnpainted:    {2}", _cmtotalPlated, _cmtotalPainted, _cmtotalUnpainted);
            cfooter.AppendFormat("     WPlated:    {0}     WPainted:    {1}    WUnpainted:   {2}", _cmtotalWPlated, _cmtotalWPainted, _cmtotalWUnpainted);
            cfooter.AppendFormat(" ");
            cfooter.AppendFormat("    Battery:   {0}   Generator: {1}     Solar:     {2}", _cmtotalBattery, _cmtotalGenerator, _cmtotalSolar);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("                                                                                            ");
            cfooter.AppendFormat("                                                                                      ");
            cfooter.AppendFormat("     SubTotal Cost:    ${0}", _cmediumGadgetSubtotal);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Large Gadget info        ");
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Large Gadgets Ordered:                {0}", _clargeGadgetsOrdered);
            cfooter.AppendLine();
            cfooter.AppendFormat("*           Buttons:   {0}            Lights:   {1}            Switches:   {2}", _cltotalButtons, _cltotalLights, _cltotalSwitches);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("     GadgetsPlated:    {0}    GadgetsPainted:    {1}    GadgetsUnpainted:    {2}", _cltotalPlated, _cltotalPainted, _cltotalUnpainted);
            cfooter.AppendFormat("     WPlated:    {0}     WPainted:    {1}    WUnpainted:   {2}", _cltotalWPlated, _cltotalWPainted, _cltotalWUnpainted);
            cfooter.AppendFormat("    Battery:   {0}    Generator: {1}     Solar:     {2}", _cltotalBattery, _cltotalGenerator, _cltotalSolar);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("                                                                                            ");
            cfooter.AppendFormat("                                                                                      ");
            cfooter.AppendFormat("     SubTotal Cost:     ${0}", _clargeGadgetSubtotal);
            cfooter.AppendLine();
            cfooter.AppendFormat("*   Total Gadgets Ordered:                     {0}", _ctotalGadgetsOrdered);
            cfooter.AppendLine();
            cfooter.AppendFormat("*          Buttons:    {0}            Lights:   {1}            Switches:   {2}", _ctotalGadgetsButtons, _ctotalGadgetsLights, _ctotalGadgetsSwitches);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("    GadgetsPlated:     {0}    GadgetsPainted:   {1}    GadgetsUnpainted:    {2}", _ctotalGadgetsPlated, _ctotalGadgetsPainted, _ctotalGadgetsUnpainted);
            cfooter.AppendFormat("     WPlated:    {0}     WPainted:   {1}    WUnpainted:   {2}", _ctotalWidgetsSetsPlated, _ctotalWidgetsSetsPainted, _ctotalWidgetsSetsUnpainted);
            cfooter.AppendFormat("    Battery:  {0}    Generator: {1}     Solar:     {2}", _ctotalGadgetsBattery, _ctotalGadgetsGenerator, _ctotalGadgetsSolar);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("                                                                                           ");
            cfooter.AppendFormat("                                                                                           ");
            cfooter.AppendFormat("--------------------------");
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendFormat("                                                                                            ");
            cfooter.AppendFormat("                                                                                      ");
            cfooter.AppendFormat("        Total Cost:     ${0}", _ctotalGadgetsCost);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendLine();
            cfooter.AppendFormat("*    Please allow 5-7 business days for your shipment");
            cfooter.AppendLine();
            cfooter.AppendFormat("*    Shipment Method: UPS");
            cfooter.AppendLine();
            cfooter.AppendFormat("*    Tracking_number: " + customShipOrderTracker.NextTracking);
            cfooter.AppendLine();
            cfooter.AppendFormat("*    Order_number: " + customOrderTracker.NextOrder);
            cfooter.AppendLine();
            cfooter.AppendFormat("*");
            cfooter.AppendLine();
            cfooter.AppendFormat("*********************************************************************************************************");
            cfooter.AppendFormat("*********************************************************************************************************");
            cfooter.AppendLine();
            Console.WriteLine(heading.ToString() + cbody.ToString() + cfooter.ToString());

            // Reset Accumulator Totals since Order has been processed.

            _ctotalGadgetsPainted = 0;
            _ctotalGadgetsPlated = 0;
            _ctotalGadgetsUnpainted = 0;
            _ctotalWidgetsSetsPainted = 0;
            _ctotalWidgetsSetsPlated = 0;
            _ctotalWidgetsSetsUnpainted = 0;
            _ctotalGadgetsBattery = 0;
            _ctotalGadgetsGenerator = 0;
            _ctotalGadgetsSolar = 0;
            _ctotalGadgetsButtons = 0;
            _ctotalGadgetsLights = 0;
            _ctotalGadgetsSwitches = 0;
            _cmediumGadgetsOrdered = 0;
            _clargeGadgetsOrdered = 0;
            _ctotalGadgetsOrdered = 0;
            _cmtotalButtons = 0;
            _cmtotalSwitches = 0;
            _cmtotalLights = 0;
            _cmtotalBattery = 0;
            _cmtotalGenerator = 0;
            _cmtotalSolar = 0;
            _cmtotalPainted = 0;
            _cmtotalWPainted = 0;
            _cmtotalPlated = 0;
            _cmtotalWPlated = 0;
            _cmtotalUnpainted = 0;
            _cmtotalWUnpainted = 0;
            _cltotalButtons = 0;
            _cltotalSwitches = 0;
            _cltotalLights = 0;
            _cltotalBattery = 0;
            _cltotalGenerator = 0;
            _cltotalSolar = 0;
            _cltotalPainted = 0;
            _cltotalPlated = 0;
            _cltotalUnpainted = 0;
            _cltotalWPainted = 0;
            _cltotalWPlated = 0;
            _cltotalWUnpainted = 0;
            _cmediumGadgetSubtotal = 0m;
            _ctotalGadgetsCost = 0m;
            _cmediumGadgetSubtotal = 0m;
            _clargeGadgetSubtotal = 0;
            _clargeGadgetsOrdered = 0;
        }
    }
}

