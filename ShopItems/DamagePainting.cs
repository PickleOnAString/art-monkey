namespace ArtMonkey.ShopItems;

public class DamagePainting : ModTower
{
    public override string TowerSet => SUPPORT;
        
    public override string BaseTower => TowerType.DartMonkey;
    public override int Cost => 400;

    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 0;
    public override int BottomPathUpgrades => 0;
    public override string Description => "Throws playing cards at Bloons";
    public override void ModifyBaseTowerModel(TowerModel start)
    {
        
    }
}