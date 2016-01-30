﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using IBE.Enums_and_Utility_Classes;
using System.Windows.Forms.DataVisualization.Charting;

namespace IBE.EDDB_Data
{

    public class EDSystem
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }

        [JsonProperty("population")]
        public long? Population { get; set; }

        [JsonProperty("government")]
        public string Government { get; set; }

        [JsonProperty("allegiance")]
        public string Allegiance { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("security")]
        public string Security { get; set; }

        [JsonProperty("primary_economy")]
        public string PrimaryEconomy { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("power_state")]
        public string PowerState { get; set; }

        [JsonProperty("needs_permit")]
        public int? NeedsPermit { get; set; }

        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }

        [JsonProperty("simbad_ref")]
        public string Simbad_Ref { get; set; }
        
        /// <summary>
         /// creates a new system
        /// </summary>
        public EDSystem()
        {
            clear();
        }

        /// <summary>
         /// creates a new system as a copy of another system
         /// only the id must declared extra
        /// </summary>
        /// <param name="newSystemIndex"></param>
        /// <param name="ownSystem"></param>
        public EDSystem(int newId, EDSystem sourceSystem)
        {
            clear();
            Id              = newId;
            getValues(sourceSystem);   
        }

        /// <summary>
        /// true, if all data *except the ID* is equal (case insensitive)
        /// </summary>
        /// <param name="eqSystem"></param>
        /// <returns></returns>
        public bool EqualsED(EDSystem eqSystem)
        {
            bool retValue = false;

            if (eqSystem != null)
            {
                if (ObjectCompare.EqualsNullable(this.Name, eqSystem.Name) &&
                    ObjectCompare.EqualsNullable(this.X, eqSystem.X) &&
                    ObjectCompare.EqualsNullable(this.Y, eqSystem.Y) &&
                    ObjectCompare.EqualsNullable(this.Z, eqSystem.Z) &&
                    ObjectCompare.EqualsNullable(this.Faction, eqSystem.Faction) &&
                    ObjectCompare.EqualsNullable(this.Population, eqSystem.Population) &&
                    ObjectCompare.EqualsNullable(this.Government, eqSystem.Government) &&
                    ObjectCompare.EqualsNullable(this.Allegiance, eqSystem.Allegiance) &&
                    ObjectCompare.EqualsNullable(this.State, eqSystem.State) &&
                    ObjectCompare.EqualsNullable(this.Security, eqSystem.Security) &&
                    ObjectCompare.EqualsNullable(this.PrimaryEconomy, eqSystem.PrimaryEconomy) &&
                    ObjectCompare.EqualsNullable(this.Power, eqSystem.Power) &&
                    ObjectCompare.EqualsNullable(this.PowerState, eqSystem.PowerState) &&
                    ObjectCompare.EqualsNullable(this.NeedsPermit, eqSystem.NeedsPermit) &&
                    ObjectCompare.EqualsNullable(this.UpdatedAt, eqSystem.UpdatedAt) &&
                    ObjectCompare.EqualsNullable(this.Simbad_Ref, eqSystem.Simbad_Ref))
                    retValue = true;
            }

            return retValue;             
        }

        /// <summary>
        /// copy the values from another system exept for the ID
        /// </summary>
        /// <param name="ValueStation"></param>
        public void getValues(EDSystem ownSystem, bool getAll=false)
        {
            if(getAll)
                Id = ownSystem.Id;

            Name            = ownSystem.Name;
            X               = ownSystem.X;
            Y               = ownSystem.Y;
            Z               = ownSystem.Z;
            Faction         = ownSystem.Faction;
            Population      = ownSystem.Population;
            Government      = ownSystem.Government;
            Allegiance      = ownSystem.Allegiance;
            State           = ownSystem.State;
            Security        = ownSystem.Security;
            PrimaryEconomy  = ownSystem.PrimaryEconomy;
            Power           = ownSystem.Power;
            PowerState      = ownSystem.PowerState;
            NeedsPermit     = ownSystem.NeedsPermit;
            UpdatedAt       = ownSystem.UpdatedAt;
            Simbad_Ref      = ownSystem.Simbad_Ref;
        }

        /// <summary>
        /// reset all data 
        /// </summary>
        public void clear()
        { 
            Id              = 0;
            Name            = String.Empty;
            X               = 0.0;
            Y               = 0.0;
            Z               = 0.0;
            Faction         = null;
            Population      = null;
            Government      = null;
            Allegiance      = null;
            State           = null;
            Security        = null;
            PrimaryEconomy  = null;
            Power           = null;
            PowerState      = null;
            NeedsPermit     = null;
            UpdatedAt       = 0;
            Simbad_Ref      = null;

        }

        /// <summary>
        /// return the coordinates of the system
        /// </summary>
        /// <returns></returns>
        internal System.Windows.Forms.DataVisualization.Charting.Point3D SystemCoordinates()
        {
            return new Point3D((float)X, (float)Y, (float)Z);
        }

    }
}
