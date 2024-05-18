using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportCEOModLoader.Core;

namespace AirportCEOSchengenUpdate;

[HarmonyPatch]
public static class SUPatches
{
    [HarmonyPatch(typeof(TravelController), "InitializeTravelSystem")]
    [HarmonyPostfix]
    public static void UpdateCountries(HashSet<string> ___schengenCountries)
    {
        if (!SUConfig.UpdateCountries.Value)
        {
            return;
        }

        try
        {
            ___schengenCountries.Add("HR");
            ___schengenCountries.Add("BG");
            ___schengenCountries.Add("RO");
            AirportCEOSchegenUpdate.SULogger.LogInfo("Completed countries update");
        }
        catch (Exception ex)
        {
            AirportCEOSchegenUpdate.SULogger.LogError($"Error in adding countries {ExceptionUtils.ProccessException(ex)}");
        }
    }
}
