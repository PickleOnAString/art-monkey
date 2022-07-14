using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Unity;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using IndustrialFarmer.Patches;

namespace IndustrialFarmer
{
    public class IndustrialFarmer : ModHero
    {
        public override string BaseTower => TowerType.Geraldo;

        public override int Cost => 200;

        public override string DisplayName => "Art Monkey";
        public override string Title => "Painter";
        public override string Level1Description => "Can paint a damage painting";

        public override string Description =>
            "Paints Paintings To Buff Towers.";


        public override string NameStyle => TowerType.Gwendolin; // Yellow colored
        public override string BackgroundStyle => TowerType.Etienne; // Yellow colored
        public override string GlowStyle => TowerType.Geraldo; // Yellow colored


        public override int MaxLevel => 20;
        public override float XpRatio => 1.0f;

        public override int Abilities => 2;

        /// <summary>
        ///     <seealso cref="TowerCreation.InputManager_CreateTowerAt.Postfix" />
        /// </summary>
        /// <param name="towerModel"></param>
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var baseTower = Game.instance.model.GetTowerWithName(TowerType.Geraldo);
        }
    }
}