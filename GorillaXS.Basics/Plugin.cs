using BepInEx;

namespace GorillaXS.Basics
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class XSBasicsPlugin : BaseUnityPlugin
    {
        void Start() => GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        void OnGameInitialized()
        {
            gameObject.AddComponent<PUNNotifications>();
        }
    }
}
