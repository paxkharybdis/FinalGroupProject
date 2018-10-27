using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumberGenerators
{
    public class OrderNumberGenerator
    {
        private static volatile OrderNumberGenerator instance;
        public static object sychronizationRoot = new object();
        private long _count = 888880000;

        public static OrderNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sychronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new OrderNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private OrderNumberGenerator() { }

        public virtual long NextOrder
        {
            get { return ++_count; }
        }

    }
}