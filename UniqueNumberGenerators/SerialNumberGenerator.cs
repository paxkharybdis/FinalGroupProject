using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumberGenerators
{
    public class SerialNumberGenerator
    {

        private static volatile SerialNumberGenerator instance;
        public static object sychronizationRoot = new object();
        private long _count = 111412345;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sychronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGenerator() { }

        public virtual long NextSerial
        {
            get { return ++_count; }
        }

    }
}