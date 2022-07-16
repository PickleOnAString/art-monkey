using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnhollowerBaseLib;
using UnityEngine;

namespace ArtMonkey.Displays
{
    public class ArtMonkeyDisplay : ModTowerDisplay<ArtMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.EngineerMonkey, 0, 1);
        public override bool UseForTower(int[] tiers)
        {
            return true;
        }   
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }
}