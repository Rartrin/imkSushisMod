using Terraria;
using Terraria.ID;

namespace imkSushisMod.Items
{
    public class GuideSummoningPotion : NPCSummoningPotion
    {
        public override int NpcId => NPCID.Guide;

        public override bool CanSpawn(Player player)
        {
            return true;
        }
    }
}