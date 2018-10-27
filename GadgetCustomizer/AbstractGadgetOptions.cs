using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINALPROJECT;


namespace GadgetCustomizer
{
    public abstract class AbstractGadgetOptions : AbstractGadget
    {
        protected internal IGadget customGadget;
        public override int Buttons { get; set; }
        public override int Switches { get; set; }
        public AbstractGadgetOptions(IGadget gadget)

        {
            this.customGadget = gadget;
        }
    }
}
