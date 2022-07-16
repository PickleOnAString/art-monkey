namespace ArtMonkey;

public class Patches
{
    [HarmonyPatch(typeof(Ability), "Activate")]
    public static class Activate_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(ref Ability __instance)
        {
            if (__instance.tower.namedMonkeyKey.Contains("Art"))
            {
                __instance.ClearCooldown();
                
                TowerSelectionMenu.instance.LoadGeraldoShop();
                TowerSelectionMenu.instance.ShowGeraldoShop();
                
            }
        }
    }
}