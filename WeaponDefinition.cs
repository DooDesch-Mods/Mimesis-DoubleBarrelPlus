namespace DooDesch.Weapons
{
    internal static class WeaponDefinition
    {
        internal const string Name = "DoubleBarrelPlus";
        internal static readonly int ItemId = 1500;
        internal static bool IsGun => true;
        internal static bool IsBat => false;
        internal static bool IsReload(int skill) => skill == 10902;
        internal static bool HasSkill(int skill) => skill == 10900 || skill == 10902;
    }
}
