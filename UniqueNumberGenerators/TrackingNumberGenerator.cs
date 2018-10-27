using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UniqueNumberGenerators
{
    public class TrackingNumberGenerator
    {
        private static volatile TrackingNumberGenerator instance;
        public static object sychronizationRoot = new object();
        private long _count = 7777001234;

        public static TrackingNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sychronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new TrackingNumberGenerator();
                        }
                    }
                }
                return instance;
            }
        }

        private TrackingNumberGenerator() { }

        public virtual long NextTracking
        {
            get

            {
                return ++_count;
            }


        }


    }
}