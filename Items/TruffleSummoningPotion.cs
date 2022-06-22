using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class TruffleSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Truffle;
        public override bool CanSpawn(Player player)
        {
            return Main.hardMode;
        }
    }
}