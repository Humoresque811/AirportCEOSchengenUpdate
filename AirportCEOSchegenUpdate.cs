using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace AirportCEOSchengenUpdate;

[BepInPlugin("org.airportceoschegenupdate.humoresque", "AirportCEO Schengen Update", PluginInfo.PLUGIN_VERSION)]
[BepInDependency("org.airportceomodloader.humoresque")]
public class AirportCEOSchegenUpdate : BaseUnityPlugin
{
    public static AirportCEOSchegenUpdate Instance { get; private set; }
    internal static Harmony Harmony { get; private set; }
    internal static ManualLogSource SULogger { get; private set; }
    internal static ConfigFile ConfigReference {  get; private set; }
    private void Awake()
    {
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        Harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        Harmony.PatchAll(); 

        Instance = this;
        SULogger = Logger;
        ConfigReference = Config;

        // Config
        Logger.LogInfo($"{PluginInfo.PLUGIN_GUID} is setting up config.");
        SUConfig.SetUpConfig();
        Logger.LogInfo($"{PluginInfo.PLUGIN_GUID} finished setting up config.");
    }
}
