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
    public class OrderTaker
    {
        public static int _rsmallGadgetOrder = 5;
        private static int _rmediumGadgetOrder = 6;
        private static int _rlargeGadgetOrder = 4;
        public static char myChoice2;
        private static long _serialNumber = 0;
        private static long _upcNumber = 0;


        public OrderTaker()
        {

            // Determine whether to run the Retail or Custom order simulation
            do
            {
                // Print A Menu
                StringBuilder mainMenu = new StringBuilder();
                DateTime now = DateTime.Now;
                mainMenu.AppendLine();
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*********************************************************************************************************");
                mainMenu.AppendFormat("*********************************************************************************************************");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat(" WAG CORPORATION");
                mainMenu.AppendFormat("                                       ");
                mainMenu.AppendFormat("   Date/TIME:   {0}", now);
                mainMenu.AppendFormat("            ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                    ");
                mainMenu.AppendFormat(" GADGET ORDER SIMULATOR  ");
                mainMenu.AppendFormat("                                                                                   ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                       ");
                mainMenu.AppendFormat(" PLEASE SELECT FROM THE FOLLOWING MENU CHOICES:");
                mainMenu.AppendFormat("                                                                          ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                       ");
                mainMenu.AppendFormat("                                                                                                         ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                           ");
                mainMenu.AppendFormat("                                           ");
                mainMenu.AppendFormat("  1  - Retail Gadget Simulator");
                mainMenu.AppendFormat("                                              ");
                mainMenu.AppendFormat("                                              ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                      ");
                mainMenu.AppendFormat("  2  - Warehouse Gadget Simulator");
                mainMenu.AppendFormat("                                                                                         ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                       ");
                mainMenu.AppendFormat(" Q  - Quit");
                mainMenu.AppendFormat("                                                                                                               ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("                                                                                                        ");
                mainMenu.AppendFormat("*");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("*********************************************************************************************************");
                mainMenu.AppendFormat("*********************************************************************************************************");
                mainMenu.AppendLine();
                mainMenu.AppendFormat("Choice ( 1 - 2 or Q)  ");

                Console.WriteLine(mainMenu.ToString());

                // Retrieve the user's choice
                ConsoleKeyInfo myChoice = Console.ReadKey();
                myChoice2 = (char)myChoice.KeyChar;

                // Make a Decision based on the user's choice

                switch (myChoice2)
                {
                    case '1':
                        ProcessRetailOrder();
                        break;
                    case '2':
                        ProcessWholeSaleOrder();
                        break;
                    case 'Q':
                    case 'q':
                        break;
                    default:
                        Console.WriteLine("{0} is not a valid choice", myChoice);
                        break;
                }
            } while (myChoice2 != 'Q' && myChoice2 != 'q'); //Keep Going until the user wants to quit
        }

        private static void ProcessRetailOrder()
        {
            UPCNumber upcNumber = new UPCNumber();
            SerialNumberGenerator serialNumber = SerialNumberGenerator.Instance;
            List<AbstractGadget> myGadgets = new List<AbstractGadget>();

            for (int i = 0; i < _rsmallGadgetOrder; i++)
            {
                _serialNumber = serialNumber.NextSerial;
                myGadgets.Add(new GadgetSmall(WidgetColor.Painted, GadgetColor.Painted, GadgetPower.Battery, _serialNumber, upcNumber.UPCSmall));
            }

            for (int i = 0; i < _rmediumGadgetOrder; i++)
            {
                _serialNumber = serialNumber.NextSerial;
                myGadgets.Add(new GadgetMedium(WidgetColor.Painted, GadgetColor.Painted, GadgetPower.Battery, _serialNumber, upcNumber.UPCMedium));
            }

            for (int i = 0; i < _rlargeGadgetOrder; i++)
            {
                _serialNumber = serialNumber.NextSerial;
                myGadgets.Add(new GadgetLarge(WidgetColor.Painted, GadgetColor.Painted, GadgetPower.Generator, _serialNumber, upcNumber.UPCLarge));
            }

            RetailOutput retailReceipt = new RetailOutput(myGadgets);

        }
        private static void ProcessWholeSaleOrder()
        {

            UPCNumber upcNumber = new UPCNumber();
            SerialNumberGenerator serialNumber = SerialNumberGenerator.Instance;

            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myMediumGadgetCP = new GadgetMedium(WidgetColor.Painted, GadgetColor.Painted, GadgetPower.Solar, _serialNumber, upcNumber.UPCMedium);
            myMediumGadgetCP = new CustomButton(myMediumGadgetCP, 5, GadgetType.Custom);
            myMediumGadgetCP = new CustomSwitches(myMediumGadgetCP, 4, GadgetType.Custom);


            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myMediumGadgetCPL = new GadgetMedium(WidgetColor.Plated, GadgetColor.Plated, GadgetPower.Battery, _serialNumber, upcNumber.UPCMedium);
            myMediumGadgetCPL = new CustomButton(myMediumGadgetCPL, 7, GadgetType.Custom);
            myMediumGadgetCPL = new CustomSwitches(myMediumGadgetCPL, 5, GadgetType.Custom);

            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myMediumGadgetCUP = new GadgetMedium(_serialNumber, upcNumber.UPCMedium);
            myMediumGadgetCUP = new CustomButton(myMediumGadgetCUP, 4, GadgetType.Custom);
            myMediumGadgetCUP = new CustomSwitches(myMediumGadgetCUP, 7, GadgetType.Custom);


            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myLargeGadgetCP = new GadgetLarge(WidgetColor.Painted, GadgetColor.Painted, GadgetPower.Generator, _serialNumber, upcNumber.UPCLarge);
            myLargeGadgetCP = new CustomButton(myLargeGadgetCP, 5, GadgetType.Custom);
            myLargeGadgetCP = new CustomSwitches(myLargeGadgetCP, 4, GadgetType.Custom);
            myLargeGadgetCP = new CustomLights(myLargeGadgetCP, 8, GadgetType.Custom);


            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myLargeGadgetCPL = new GadgetLarge(WidgetColor.Plated, GadgetColor.Plated, GadgetPower.Solar, _serialNumber, upcNumber.UPCLarge);
            myLargeGadgetCPL = new CustomButton(myLargeGadgetCPL, 7, GadgetType.Custom);
            myLargeGadgetCPL = new CustomSwitches(myLargeGadgetCPL, 5, GadgetType.Custom);
            myLargeGadgetCPL = new CustomLights(myLargeGadgetCPL, 3, GadgetType.Custom);


            _serialNumber = serialNumber.NextSerial;
            AbstractGadget myLargeGadgetCUP = new GadgetLarge(_serialNumber, upcNumber.UPCLarge);
            myLargeGadgetCUP = new CustomButton(myLargeGadgetCUP, 6, GadgetType.Custom);
            myLargeGadgetCUP = new CustomSwitches(myLargeGadgetCUP, 3, GadgetType.Custom);
            myLargeGadgetCUP = new CustomLights(myLargeGadgetCUP, 5, GadgetType.Custom);


            ArrayList Order1 = new ArrayList();

            Order1.Add(myMediumGadgetCP);
            Order1.Add(myMediumGadgetCPL);
            Order1.Add(myMediumGadgetCUP);
            Order1.Add(myLargeGadgetCP);
            Order1.Add(myLargeGadgetCPL);
            Order1.Add(myLargeGadgetCUP);


            CustomOutput customReceipt = new CustomOutput(Order1);
        }
    }

}