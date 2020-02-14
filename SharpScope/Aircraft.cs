using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpScope
{
    class Aircraft
    {
        //Our List will be indexed by ICAO hex id because it is included in every message and is unique to each aircraft.

        //This class defines the Aircraft object that will hold all the data for each tracked aircraft

        //These are the data fields that are actually significant; we can ignore pretty much everything else in the message.
        public string icaoID //Transponder hex code
        {
            get;
            set;
        }
        public string callsign
        {
            get;
            set;
        }
        public int altitude
        {
            get;
            set;
        }
        public double groundSpeed
        {
            get;
            set;
        }
        public double latitude
        {
            get;
            set;
        }
        public double longitude
        {
            get;
            set;
        }
        public int verticalSpeed
        {
            get;
            set;
        }
        public string sqwawkCode
        {
            get;
            set;
        }
        public bool alertFlag
        {
            get;
            set;
        } //Sqwawk has changed if true
        public bool emergencyFlag
        {
            get;
            set;
        } //Emergency code has been selected
        public bool identFlag
        {
            get;
            set;
        } //IDENT has been pressed
        public bool onGroundFlag
        {
            get;
            set;
        } //The aircraft is on the ground. (For our purposes, these can be ignored- especially since they use
          //such a fucky method of determining position in this mode.)
        public bool displayOnScope
        {
            get;
            set;
        } //Wether the aircraft should be sent to the scope or not, requirements below:

        //Minimum requirements to be on the scope:
        /*
         * (NO MODE C)
         * -ICAO id
         * -Latitude
         * -Longitude
         * -Groundspeed
         * (MODE C)
         * -All listed above
         * -Sqwawk code
         * -Altitude
         * -Vertical Speed
         * (MODE C + IDENT)
         * -Ident flag
         */
    }
}
