using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace imkSushisMod
{
	public class imkSushisMod : Mod
	{
		public override void AddRecipes()
		{
			base.AddRecipes();
			for (var i = 2772; i < 2787; i++)
			{
				ItemID.Sets.Deprecated[i] = false;
			}
			for (var i = 2462; i < 3467; i++)
			{
				ItemID.Sets.Deprecated[i] = false;
			}
			RecipeManager.AddRecipes();
		}

		public override void AddRecipeGroups()
		{
			imkSushiRecipeGroups.AddRecipeGroups();
		}
	}
}