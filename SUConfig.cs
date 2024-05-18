using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportCEOSchengenUpdate;

internal class SUConfig
{
    internal static ConfigEntry<bool> UpdateCountries { get; private set; }

    internal static void SetUpConfig()
    {
        UpdateCountries = AirportCEOSchegenUpdate.ConfigReference.Bind("General", "Update Schengen Countries", true, "Add new countries to the schegen zone?");
    }
}
