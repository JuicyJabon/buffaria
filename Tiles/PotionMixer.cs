using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Tiles
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
            item.width = 16;
            item.height = 16;
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
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.AlchemyTable);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
