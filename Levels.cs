
namespace ArtMonkey
{
    public class Levels
    {
        public class Level2 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Collected Bananas are worth 10% more.";

            public override int Level => 2;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Level3 : ModHeroLevel<ArtMonkey>
        {
            public override string AbilityName => "Bloon Pesticide";

            public override string AbilityDescription =>
                "Spray Bloons in a large area with pesticide, damaging them over time.";

            public override string Description => $"{AbilityName}: {AbilityDescription}";

            public override int Level => 3;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level4 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "All Banana Farms in radius get tier 1 upgrades for free.";

            public override int Level => 4;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }


        public class Level5 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Banana Farms can be placed on nearby water.";

            public override int Level => 5;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level6 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "All Banana Farms in radius get tier 2 upgrades for free.";

            public override int Level => 6;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level7 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Range is increased.";

            public override int Level => 7;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level8 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Banana Farms in radius and their upgrades cost 10% less.";

            public override int Level => 8;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level9 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Collected Bananas are now worth 15% more.";

            public override int Level => 9;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Level10 : ModHeroLevel<ArtMonkey>
        {
            public override string AbilityName => "Green Revolution";

            public override string AbilityDescription =>
                "Transforms some of the Largest Bloons on screen into Green Bloons. Targets up to BFBs.";

            public override string Description => $"{AbilityName}: {AbilityDescription}";

            public override int Level => 10;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Level11 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Bloon Pesticide's damage over time is significantly increased";

            public override int Level => 11;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level12 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Further increased range";

            public override int Level => 12;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }

        public class Level13 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Collected Bananas Crates are now worth 20% more.";

            public override int Level => 13;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Level14 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Bloon Pesticide makes Bloons take additional damage from attacks.";

            public override int Level => 14;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }


        public class Level15 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Banana Farms in radius and their upgrades now cost 20% less.";

            public override int Level => 15;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }


        public class Level16 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Green Revolution can hit more Bloons, including ZOMGs and DDTs.";

            public override int Level => 16;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }

        public class Level17 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Bloon Pesticide's damage over time is massively increased.";

            public override int Level => 17;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }


        public class Level18 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Further increased range";

            public override int Level => 18;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
            }
        }


        public class Level19 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Collected Bananas Crates are now worth 25% more.";

            public override int Level => 19;

            public override void ApplyUpgrade(TowerModel towerModel)
            {

            }
        }

        public class Level20 : ModHeroLevel<ArtMonkey>
        {
            public override string Description => "Green Revolution affects even more Bloons and has reduced cooldown.";

            public override int Level => 20;

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                
            }
        }
    }
}