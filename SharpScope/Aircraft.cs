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
            get { return icaoID; }
            set { icaoID = value; }
        }
        public string callsign
        {
            get { return callsign; }
            set { callsign = value; }
        }
        public int altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }
        public double groundSpeed
        {
            get { return groundSpeed; }
            set { groundSpeed = value; }
        }
        public double latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public double longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public int verticalSpeed
        {
            get { return verticalSpeed; }
            set { verticalSpeed = value; }
        }
        public string sqwawkCode
        {
            get { return sqwawkCode; }
            set { sqwawkCode = value; }
        }
        public bool alertFlag
        {
            get { return alertFlag; }
            set { alertFlag = value; }
        } //Sqwawk has changed if true
        public bool emergencyFlag
        {
            get { return emergencyFlag; }
            set { emergencyFlag = value; }
        } //Emergency code has been selected
        public bool identFlag
        {
            get { return identFlag; }
            set { identFlag = value; }
        } //IDENT has been pressed
        public bool onGroundFlag
        {
            get { return onGroundFlag; }
            set { onGroundFlag = value; }
        } //The aircraft is on the ground. (For our purposes, these can be ignored- especially since they use
          //such a fucky method of determining position in this mode.)
        public bool displayOnScope
        {
            get { return displayOnScope; }
            set { displayOnScope = value; }
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
