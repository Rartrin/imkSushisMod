using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace imkSushisMod.Items
{
	public class ToyTank : ModItem
	{
		public override void SetDefaults()
		{

			Item.width = 60;
			Item.height = 36;

			Item.consumable = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.useTurn = true;
			Item.rare = ItemRarityID.Blue;
			Item.autoReuse = true;
			Item.maxStack = 30;
		}

	    public override void SetStaticDefaults()
	    {
	      DisplayName.SetDefault("Toy Tank");
	      Tooltip.SetDefault("Wait, but it's only Wave 1...");
	    }

		public override bool CanUseItem(Player player)
		{
			return Main.snowMoon;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.SantaNK1);
			return true;
		}
	}
}