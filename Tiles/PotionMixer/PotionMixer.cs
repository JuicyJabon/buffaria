using Terraria.ID;
using Terraria.ModLoader;

namespace Buffaria.Tiles.PotionMixer
{
    public class PotionMixer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion Mixer");
            Tooltip.SetDefault("Used to combine potions");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.useTime = 14;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.useTurn = true;
            item.autoReuse = true;

            item.createTile = mod.TileType("PotionMixerTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 50);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
