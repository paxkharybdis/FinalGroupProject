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
    public class RetailOutput
    {
        private static decimal _rsmallGadgetSubtotal = 0m;
        private static int _rtotalGadgetsPainted = 0;
        private static int _rtotalGadgetsPlated = 0;
        private static int _rtotalGadgetsUnpainted = 0;
        private static int _rtotalWidgetsSetsPainted = 0;
        private static int _rtotalWidgetsSetsPlated = 0;
        private static int _rtotalWidgetsSetsUnpainted = 0;
        private static int _rtotalGadgetsBattery = 0;
        private static int _rtotalGadgetsGenerator = 0;
        private static int _rtotalGadgetsSolar = 0;
        private static int _rtotalGadgetsButtons = 0;
        private static int _rtotalGadgetsLights = 0;
        private static int _rtotalGadgetsSwitches = 0;
        private static int _rsmallGadgetsOrdered = 0;
        private static int _rmediumGadgetsOrdered = 0;
        private static int _rlargeGadgetsOrdered = 0;
        private static int _rtotalGadgetsOrdered = 0;
        private static int _rmtotalButtons = 0;
        private static int _rmtotalSwitches = 0;
        private static int _rmtotalLights = 0;
        private static int _rmtotalBattery = 0;
        private static int _rmtotalGenerator = 0;
        private static int _rmtotalSolar = 0;
        private static int _rmtotalPainted = 0;
        private static int _rmtotalWPainted = 0;
        private static int _rmtotalPlated = 0;
        private static int _rmtotalWPlated = 0;
        private static int _rmtotalUnpainted = 0;
        private static int _rmtotalWUnpainted = 0;
        private static int _rltotalButtons = 0;
        private static int _rltotalSwitches = 0;
        private static int _rltotalLights = 0;
        private static int _rltotalBattery = 0;
        private static int _rltotalGenerator = 0;
        private static int _rltotalSolar = 0;
        private static int _rltotalPainted = 0;
        private static int _rltotalPlated = 0;
        private static int _rltotalUnpainted = 0;
        private static int _rltotalWPainted = 0;
        private static int _rltotalWPlated = 0;
        private static int _rltotalWUnpainted = 0;
        private static int _rstotalButtons = 0;
        private static int _rstotalSwitches = 0;
        private static int _rstotalLights = 0;
        private static int _rstotalPainted = 0;
        private static int _rstotalWPainted = 0;
        private static int _rstotalPlated = 0;
        private static int _rstotalWPlated = 0;
        private static int _rstotalUnpainted = 0;
        private static int _rstotalWUnpainted = 0;
        private static int _rstotalBattery = 0;
        private static int _rstotalGenerator = 0;
        private static int _rstotalSolar = 0;
        private static decimal _rmediumGadgetSubtotal = 0m;
        private static decimal _rlargeGadgetSubtotal = 0m;
        private static decimal _rtotalGadgetsCost = 0m;
        public static string _sizePrint;
        public static string _typePrint;
        public static string _powerPrint;
        public static string _gadgetColor;
        public static string _widgetColor;
        public static char myChoice2;

        public RetailOutput(List<AbstractGadget> myGadgets)
        {

            TrackingNumberGenerator retailShipOrderTracker = TrackingNumberGenerator.Instance;
            OrderNumberGenerator retailOrderTracker = OrderNumberGenerator.Instance;
            StringBuilder rbody = new StringBuilder();
            StringBuilder rfooter = new StringBuilder();
            StringBuilder heading = new StringBuilder();
            DateTime now = DateTime.Now;
            foreach (AbstractGadget rgadget in myGadgets)
            {
                if (rgadget.GadgetSize == GadgetSize.Small)
                {
                    _rsmallGadgetSubtotal += rgadget.Price;
                    _rsmallGadgetsOrdered++;
                    _rstotalButtons += rgadget.Buttons;
                    _rstotalLights += rgadget.Lights;
                    _rstotalSwitches += rgadget.Switches;
                    if (rgadget.GadgetType == GadgetType.Retail)
                    {
                        _typePrint = "R";
                    }
                    else
                    {
                        _typePrint = "W";
                    }

                    if (rgadget.GadgetSize == GadgetSize.Small)
                    {
                        _sizePrint = "S";
                    }
                    else if (rgadget.GadgetSize == GadgetSize.Medium)
                    {
                        _sizePrint = "M";
                    }
                    else
                    {
                        _sizePrint = "L";
                    }

                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _powerPrint = "B";
                    }
                    else if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _powerPrint = "G";
                    }
                    else
                    {
                        _sizePrint = "S";
                    }

                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _gadgetColor = "PT";
                    }
                    else if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _gadgetColor = "PL";
                    }
                    else
                    {
                        _gadgetColor = "UP";
                    }

                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _widgetColor = "PT";
                    }
                    else if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _widgetColor = "PL";
                    }
                    else
                    {
                        _widgetColor = "UP";
                    }

                    rbody.AppendFormat("*");
                    rbody.Append(String.Format("{0,12} {1,30} {2,25} {3,16} {4,19}",_sizePrint, _typePrint, rgadget.Buttons, "N/A", rgadget.Switches));
                    rbody.Append(String.Format("{0,16} {1,15} {2,24} {3,26}", _gadgetColor, _widgetColor, _powerPrint, rgadget.Price));
                    rbody.Append(String.Format("{0,18} {1,16}", rgadget.SerialNumber, rgadget.UpcNumber));
                    rbody.AppendFormat("   ");
                    rbody.AppendFormat("*");
                    rbody.AppendLine();

                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _rstotalPainted++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _rstotalPlated++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Unpainted)
                    {
                        _rstotalUnpainted++;
                    }
                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _rstotalWPainted++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _rstotalWPlated++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Unpainted)
                    {
                        _rstotalWUnpainted++;
                    }
                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _rstotalBattery++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _rstotalGenerator++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Solar)
                    {
                        _rstotalSolar++;
                    }
                }
                if (rgadget.GadgetSize == GadgetSize.Medium)
                {
                    _rmediumGadgetSubtotal += rgadget.Price;
                    _rmediumGadgetsOrdered++;
                    _rmtotalButtons += rgadget.Buttons;
                    _rmtotalSwitches += rgadget.Switches;
                    _rmtotalLights += rgadget.Lights;
                    if (rgadget.GadgetType == GadgetType.Retail)
                    {
                        _typePrint = "R";
                    }
                    else
                    {
                        _typePrint = "W";
                    }

                    if (rgadget.GadgetSize == GadgetSize.Small)
                    {
                        _sizePrint = "S";
                    }
                    else if (rgadget.GadgetSize == GadgetSize.Medium)
                    {
                        _sizePrint = "M";
                    }
                    else
                    {
                        _sizePrint = "L";
                    }

                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _powerPrint = "B";
                    }
                    else if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _powerPrint = "G";
                    }
                    else
                    {
                        _powerPrint = "S";
                    }

                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _gadgetColor = "PT";
                    }
                    else if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _gadgetColor = "PL";
                    }
                    else
                    {
                        _gadgetColor = "UP";
                    }

                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _widgetColor = "PT";
                    }
                    else if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _widgetColor = "PL";
                    }
                    else
                    {
                        _widgetColor = "UP";
                    }
                    rbody.AppendFormat("*");
                    rbody.Append(String.Format("{0,12} {1,30} {2,25} {3,16} {4,19}", _sizePrint, _typePrint, rgadget.Buttons,rgadget.Lights, rgadget.Switches));
                    rbody.Append(String.Format("{0,16} {1,15} {2,24} {3,26}", _gadgetColor, _widgetColor, _powerPrint, rgadget.Price));
                    rbody.Append(String.Format("{0,18} {1,16}", rgadget.SerialNumber, rgadget.UpcNumber));
                    rbody.AppendFormat("   ");
                    rbody.AppendFormat("*");
                    rbody.AppendLine();
                 
                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _rmtotalPainted++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _rmtotalPlated++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Unpainted)
                    {
                        _rmtotalUnpainted++;
                    }
                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _rmtotalWPainted++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _rmtotalWPlated++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Unpainted)
                    {
                        _rmtotalWUnpainted++;
                    }
                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _rmtotalBattery++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _rmtotalGenerator++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Solar)
                    {
                        _rmtotalSolar++;
                    }
                }
                if (rgadget.GadgetSize == GadgetSize.Large)
                {
                    _rlargeGadgetSubtotal += rgadget.Price;
                    _rlargeGadgetsOrdered++;
                    _rltotalButtons += rgadget.Buttons;
                    _rltotalSwitches += rgadget.Switches;
                    _rltotalLights += rgadget.Lights;

                    if (rgadget.GadgetType == GadgetType.Retail)
                    {
                        _typePrint = "R";
                    }
                    else
                    {
                        _typePrint = "W";
                    }

                    if (rgadget.GadgetSize == GadgetSize.Small)
                    {
                        _sizePrint = "S";
                    }
                    else if (rgadget.GadgetSize == GadgetSize.Medium)
                    {
                        _sizePrint = "M";
                    }
                    else
                    {
                        _sizePrint = "L";
                    }

                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _powerPrint = "B";
                    }
                    else if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _powerPrint = "G";
                    }
                    else
                    {
                        _powerPrint = "S";
                    }

                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _gadgetColor = "PT";
                    }
                    else if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _gadgetColor = "PL";
                    }
                    else
                    {
                        _gadgetColor = "UP";
                    }

                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _widgetColor = "PT";
                    }
                    else if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _widgetColor = "PL";
                    }
                    else
                    {
                        _widgetColor = "UP";
                    }

                    rbody.AppendFormat("*");
                    rbody.Append(String.Format("{0,12} {1,30} {2,25} {3,16} {4,19}", _sizePrint, _typePrint, rgadget.Buttons, rgadget.Lights, rgadget.Switches));
                    rbody.Append(String.Format("{0,16} {1,15} {2,24} {3,26}", _gadgetColor, _widgetColor, _powerPrint, rgadget.Price));
                    rbody.Append(String.Format("{0,18} {1,16}", rgadget.SerialNumber, rgadget.UpcNumber));
                    rbody.AppendFormat("   ");
                    rbody.AppendFormat("*");
                    rbody.AppendLine();

                    if (rgadget.GadgetColorType == GadgetColor.Painted)
                    {
                        _rltotalPainted++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Plated)
                    {
                        _rltotalPlated++;
                    }
                    else
                    if (rgadget.GadgetColorType == GadgetColor.Unpainted)
                    {
                        _rltotalUnpainted++;
                    }
                    if (rgadget.WidgetColorType == WidgetColor.Painted)
                    {
                        _rltotalWPainted++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Plated)
                    {
                        _rltotalWPlated++;
                    }
                    else
                    if (rgadget.WidgetColorType == WidgetColor.Unpainted)
                    {
                        _rltotalWUnpainted++;
                    }
                    if (rgadget.PowerType == GadgetPower.Battery)
                    {
                        _rltotalBattery++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Generator)
                    {
                        _rltotalGenerator++;
                    }
                    else
                    if (rgadget.PowerType == GadgetPower.Solar)
                    {
                        _rltotalSolar++;
                    }
                }
            }

            _rtotalGadgetsCost = _rsmallGadgetSubtotal + _rmediumGadgetSubtotal + _rlargeGadgetSubtotal;
            _rtotalGadgetsOrdered = _rsmallGadgetsOrdered + _rmediumGadgetsOrdered + _rlargeGadgetsOrdered;
            _rtotalGadgetsPainted = _rstotalPainted + _rmtotalPainted + _rltotalPainted;
            _rtotalGadgetsUnpainted = _rstotalUnpainted + _rmtotalUnpainted + _rltotalUnpainted;
            _rtotalGadgetsPlated = _rstotalPlated + _rmtotalPlated + _rltotalPlated;
            _rtotalWidgetsSetsPainted = _rstotalWPainted + _rmtotalWPainted + _rltotalWPainted;
            _rtotalWidgetsSetsPlated = _rstotalWPlated + _rmtotalWPlated + _rltotalWPlated;
            _rtotalWidgetsSetsUnpainted = _rstotalWUnpainted + _rmtotalWUnpainted + _rltotalWUnpainted;
            _rtotalGadgetsGenerator = _rltotalGenerator;
            _rtotalGadgetsSolar =_rstotalSolar + _rmtotalSolar + _rltotalSolar;
            _rtotalGadgetsBattery = _rstotalBattery + _rmtotalBattery + _rltotalBattery;
            _rtotalGadgetsButtons = _rstotalButtons + _rmtotalButtons + _rltotalButtons;
            _rtotalGadgetsLights = _rstotalLights + _rmtotalLights + _rltotalLights;
            _rtotalGadgetsSwitches = _rstotalSwitches + _rmtotalSwitches + _rltotalSwitches;

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
            heading.Append(String.Format("{0,15} {1,30}","   (S)mall(M)ed(L)arge", "(R)etail(W)arehouse"));
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
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                                                  ");
            rfooter.AppendFormat("                                                                                                                  ");
            rfooter.AppendFormat("*");
            rfooter.AppendLine();
            rfooter.AppendFormat("*******************************************************************************************************************");
            rfooter.AppendFormat("*******************************************************************************************************************");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Order Summary:");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Retail Gadget info ");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Small Gadgets Ordered:                {0}", _rsmallGadgetsOrdered);
            rfooter.AppendLine();
            rfooter.AppendFormat("*           Buttons:    {0}            Lights:    {1}            Switches:   {2}", _rstotalButtons, _rstotalLights, _rstotalSwitches);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("     GadgetsPlated:    {0}    GadgetsPainted:    {1}    GadgetsUnpainted:    {2}", _rstotalPlated, _rstotalPainted, _rstotalUnpainted);
            rfooter.AppendFormat("     WPlated:    {0}     WPainted:    {1}    WUnpainted:   {2}", _rstotalWPlated, _rstotalWPainted, _rstotalWUnpainted);
            rfooter.AppendFormat(" ");
            rfooter.AppendFormat("    Battery:   {0}   Generator: {1}     Solar:     {2}", _rstotalBattery, _rstotalGenerator, _rstotalSolar);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                            ");
            rfooter.AppendFormat("                                                                                      ");
            rfooter.AppendFormat("     SubTotal Cost:     ${0}", _rsmallGadgetSubtotal);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Custom Medium Gadget info ");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Medium Gadgets Ordered:               {0}", _rmediumGadgetsOrdered);
            rfooter.AppendLine();
            rfooter.AppendFormat("*           Buttons:   {0}            Lights:   {1}            Switches:   {2}", _rmtotalButtons, _rmtotalLights, _rmtotalSwitches);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("     GadgetsPlated:    {0}    GadgetsPainted:    {1}    GadgetsUnpainted:    {2}", _rmtotalPlated, _rmtotalPainted, _rmtotalUnpainted);
            rfooter.AppendFormat("     WPlated:    {0}     WPainted:    {1}    WUnpainted:   {2}", _rmtotalWPlated, _rmtotalWPainted, _rmtotalWUnpainted);
            rfooter.AppendFormat(" ");
            rfooter.AppendFormat("    Battery:   {0}   Generator: {1}     Solar:     {2}", _rmtotalBattery, _rmtotalGenerator, _rmtotalSolar);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                            ");
            rfooter.AppendFormat("                                                                                      ");
            rfooter.AppendFormat("     SubTotal Cost:    ${0}", _rmediumGadgetSubtotal);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Custom Large Gadget info ");
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Large Gadgets Ordered:                {0}", _rlargeGadgetsOrdered);
            rfooter.AppendLine();
            rfooter.AppendFormat("*           Buttons:   {0}            Lights:   {1}            Switches:   {2}", _rltotalButtons, _rltotalLights, _rltotalSwitches);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("     GadgetsPlated:    {0}    GadgetsPainted:    {1}    GadgetsUnpainted:    {2}", _rltotalPlated, _rltotalPainted, _rltotalUnpainted);
            rfooter.AppendFormat("     WPlated:    {0}     WPainted:    {1}    WUnpainted:   {2}", _rltotalWPlated, _rltotalWPainted, _rltotalWUnpainted);
            rfooter.AppendFormat("    Battery:   {0}    Generator: {1}     Solar:     {2}", _rltotalBattery, _rltotalGenerator, _rltotalSolar);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                            ");
            rfooter.AppendFormat("                                                                                      ");
            rfooter.AppendFormat("     SubTotal Cost:     ${0}", _rlargeGadgetSubtotal);
            rfooter.AppendLine();
            rfooter.AppendFormat("*   Total Gadgets Ordered:                     {0}", _rtotalGadgetsOrdered);
            rfooter.AppendLine();
            rfooter.AppendFormat("*          Buttons:    {0}            Lights:   {1}            Switches:   {2}", _rtotalGadgetsButtons, _rtotalGadgetsLights, _rtotalGadgetsSwitches);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("    GadgetsPlated:     {0}    GadgetsPainted:   {1}    GadgetsUnpainted:    {2}", _rtotalGadgetsPlated, _rtotalGadgetsPainted, _rtotalGadgetsUnpainted);
            rfooter.AppendFormat("     WPlated:    {0}     WPainted:   {1}    WUnpainted:   {2}", _rtotalWidgetsSetsPlated, _rtotalWidgetsSetsPainted, _rtotalWidgetsSetsUnpainted);
            rfooter.AppendFormat("    Battery:  {0}    Generator: {1}     Solar:     {2}", _rtotalGadgetsBattery, _rtotalGadgetsGenerator, _rtotalGadgetsSolar);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                           ");
            rfooter.AppendFormat("                                                                                           ");
            rfooter.AppendFormat("--------------------------");
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendFormat("                                                                                            ");
            rfooter.AppendFormat("                                                                                      ");
            rfooter.AppendFormat("        Total Cost:     ${0}", _rtotalGadgetsCost);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendLine();
            rfooter.AppendFormat("*    Please allow 5-7 business days for your shipment");
            rfooter.AppendLine();
            rfooter.AppendFormat("*    Shipment Method: UPS");
            rfooter.AppendLine();
            rfooter.AppendFormat("*    Tracking_number: " + retailShipOrderTracker.NextTracking);
            rfooter.AppendLine();
            rfooter.AppendFormat("*    Order_number: " + retailOrderTracker.NextOrder);
            rfooter.AppendLine();
            rfooter.AppendFormat("*");
            rfooter.AppendLine();
            rfooter.AppendFormat("*********************************************************************************************************");
            rfooter.AppendFormat("*********************************************************************************************************");
            rfooter.AppendLine();
            Console.WriteLine(heading.ToString() + rbody.ToString() + rfooter.ToString());

            //Reset Accumulators since Order has been Processed.
           _rtotalGadgetsPainted = 0;
           _rtotalGadgetsPlated = 0;
           _rtotalGadgetsUnpainted = 0;
           _rtotalWidgetsSetsPainted = 0;
           _rtotalWidgetsSetsPlated = 0;
           _rtotalWidgetsSetsUnpainted = 0;
           _rtotalGadgetsBattery = 0;
           _rtotalGadgetsGenerator = 0;
           _rtotalGadgetsSolar = 0;
           _rtotalGadgetsButtons = 0;
           _rtotalGadgetsLights = 0;
           _rtotalGadgetsSwitches = 0;
           _rsmallGadgetsOrdered = 0;
           _rmediumGadgetsOrdered = 0;
           _rlargeGadgetsOrdered = 0;
           _rtotalGadgetsOrdered = 0;
           _rmtotalButtons = 0;
           _rmtotalSwitches = 0;
           _rmtotalLights = 0;
           _rmtotalBattery = 0;
           _rmtotalGenerator = 0;
           _rmtotalSolar = 0;
           _rmtotalPainted = 0;
           _rmtotalWPainted = 0;
           _rmtotalPlated = 0;
           _rmtotalWPlated = 0;
           _rmtotalUnpainted = 0;
           _rmtotalWUnpainted = 0;
           _rltotalButtons = 0;
           _rltotalSwitches = 0;
           _rltotalLights = 0;
           _rltotalBattery = 0;
           _rltotalGenerator = 0;
           _rltotalSolar = 0;
           _rltotalPainted = 0;
           _rltotalPlated = 0;
           _rltotalUnpainted = 0;
           _rltotalWPainted = 0;
           _rltotalWPlated = 0;
           _rltotalWUnpainted = 0;
           _rstotalButtons = 0;
           _rstotalSwitches = 0;
           _rstotalLights = 0;
           _rstotalPainted = 0;
           _rstotalWPainted = 0;
           _rstotalPlated = 0;
           _rstotalWPlated = 0;
           _rstotalUnpainted = 0;
           _rstotalWUnpainted = 0;
           _rstotalBattery = 0;
           _rstotalGenerator = 0;
           _rstotalSolar = 0;
           _rtotalGadgetsCost = 0m;
           _rsmallGadgetSubtotal = 0;
           _rsmallGadgetsOrdered = 0;
           _rstotalButtons = 0;
           _rstotalLights = 0;
           _rstotalSwitches = 0;
           _rmediumGadgetSubtotal = 0;
           _rmediumGadgetsOrdered = 0;
           _rmtotalButtons = 0;
           _rmtotalSwitches = 0;
           _rmtotalLights = 0;
           _rlargeGadgetSubtotal = 0;
           _rlargeGadgetsOrdered = 0;
           

            //   Console.WriteLine(heading.ToString() + rbody.ToString() + rfooter.ToString());
        }

    }
}
