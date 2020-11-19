using System.Collections.Generic;

namespace ClassLibraryTemperature_v2
{
    public static class PhysicDictionaries
    {
        public static Dictionary<float, string> EvaporationDictionary()
        {
            Dictionary<float, string> d = new Dictionary<float, string>();
            d.Add(-196f, "Nitrogen evaporates at -196°C");
            d.Add(78f, "Alcohol evaporates at 78°C");
            d.Add(100f, "Water evaporates at 100°C");
            d.Add(357f, "Mercury evaporates at 357°C");
            d.Add(1620f, "Lead evaporates at 1620°C");
            d.Add(2660f, "Gold evaporates at 2660°C");
            return d;
        }

        public static Dictionary<float, string> FusionDictionary()
        {
            Dictionary<float, string> d = new Dictionary<float, string>();
            d.Add(-210f, "Nitrogen melt at -210°C");
            d.Add(-114f, "Alcohol melt at -114°C");
            d.Add(-39f, "Mercury melt at -39°C");
            d.Add(0f, "Water melt at 0°C");
            d.Add(327f, "Lead melt at 327°C");
            d.Add(1063f, "Gold melt at 1063°C");
            return d;
        }
    }
}