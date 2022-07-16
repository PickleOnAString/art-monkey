
namespace ArtMonkey
{

    public class ArtMonkey : ModHero
    {
        public override string BaseTower => TowerType.Quincy;

        public override int Cost => 800;

        public override string DisplayName => "Art Monkey";
        public override string Title => "Painter";
        public override string Level1Description => "Can paint a damage painting";

        public override string Description =>
            "Paints Paintings To Buff Towers.";
        
        public override int MaxLevel => 20;
        public override float XpRatio => 1.0f;

        public override int Abilities => 2;
        
        public override void ModifyBaseTowerModel(TowerModel tower)
        {
            var abilityModel = new AbilityModel("AbilityModel_PainterShop", "Painter's Shop",
                "Opens ArtMonkey's Shop.", 1, 0,
                null, .1f, null, false, false, null,
                0, 0, 9999999, false, false, 
                true, true);
            abilityModel.Cooldown = .1f;
            abilityModel.CooldownSpeedScale = 0;
            tower.AddBehavior(abilityModel);
            
        }
    }
}