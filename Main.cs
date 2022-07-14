using Assets.Scripts.Simulation.Input;
using Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;
using BTD_Mod_Helper;
using HarmonyLib;
using IndustrialFarmer;
using MelonLoader;

[assembly: MelonInfo(typeof(IndustrialFarmerMod), "Industrial Farmer", "1.0.0", "doombubbles")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace IndustrialFarmer
{
    public class IndustrialFarmerMod : BloonsTD6Mod
    {
        public static GeraldoShopInventory shop;
        [HarmonyPatch(typeof(GeraldoShopMenuUi), "Populate")]
        public class TitleScreenStart_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(ref GeraldoShopMenuUi __instance)
            {
                foreach (var thing in __instance.uiItems)
                {
                    var thing1 = thing.geraldoItemModel;
                    thing1.maxQuantity = 999999;
                    thing1.amountToReplenish = 999999;
                    thing1.startingQuantity = 999999;
                    thing1.roundsToReplenish = 1;
                    thing1.levelUnlockedAt = 0;
                    thing1.bannedForModes = "";
                    thing1.bannedForModesList = new UnhollowerBaseLib.Il2CppStringArray(0);
                    thing1.maxPurchases = 0;
                    thing1.blockPurchaseIfTowerPlaced = "";
                    thing1.cost = 100;
                    thing1.canBeActivatedBetweenRounds = true;
                    thing1.onlyReplenishIfNonePlaced = false;
                }
                foreach (var thing in shop.stockItems)
                {
                    thing.remaining = 999999;
                }
                __instance.UpdateShopUiItems();

            }
        }
        [HarmonyPatch(typeof(GeraldoShopInventory), "Init")]
        public class GeraldoShopInventoryInit_Patch
        {
            [HarmonyPostfix]
            public static void Postfix(ref GeraldoShopInventory __instance)
            {
                foreach (var thing in __instance.geraldoItemModelsByName.Values)
                {
                    thing.maxQuantity = 999999;
                    thing.amountToReplenish = 999999;
                    thing.startingQuantity = 999999;
                    thing.roundsToReplenish = 1;
                    thing.levelUnlockedAt = 0;
                    thing.bannedForModes = "";
                    thing.bannedForModesList = new UnhollowerBaseLib.Il2CppStringArray(0);
                    thing.maxPurchases = 0;
                    thing.blockPurchaseIfTowerPlaced = "";
                    thing.cost = 100;
                    thing.canBeActivatedBetweenRounds = true;
                    thing.onlyReplenishIfNonePlaced = false;
                }
                shop = __instance;
            }
        }
    }
}