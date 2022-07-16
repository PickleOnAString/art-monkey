using ArtMonkey;

[assembly: MelonInfo(typeof(ArtMonkeyMod), "ArtMonkey", "1.0.0", "Pickle")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ArtMonkey
{
    public class ArtMonkeyMod : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("ArtMonkey Mod Has Loaded");
        }

    }
}