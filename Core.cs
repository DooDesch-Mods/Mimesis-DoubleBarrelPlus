using MelonLoader;
using DooDesch.Weapons;

[assembly: MelonInfo(typeof(DoubleBarrelPlus.Core), "DoubleBarrelPlus", DooDesch.ModVersion.Current, "DooDesch", null)]
[assembly: MelonGame("ReLUGames", "MIMESIS")]

namespace DoubleBarrelPlus
{
    public sealed class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            WeaponPreferences.Initialize();
            MelonLogger.Msg("DoubleBarrelPlus initialized for item 1500. Gameplay follows the host.");
        }
        public override void OnUpdate()
        {
            DooDesch.HostSettings.Update();
            WeaponDisplay.Update();
            WeaponReloadAnimation.Update();
        }
    }
}
