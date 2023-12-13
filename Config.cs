using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyFirstPlugin
{
    public class Config : IRocketPluginConfiguration
    {
        public ushort EffectID;
        public short LayerID;
        public List<LocationData> Locations;
        public void LoadDefaults()
        {
            EffectID = 26010;
            LayerID = 110;
            Locations = new List<LocationData>();
        }
    }

    public class LocationData
    {
        public string Name;
        public Vector3 Position;
        public float Radius;
    }
}
