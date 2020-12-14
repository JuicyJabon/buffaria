using Terraria.ID;
using Terraria.ModLoader;

namespace Buffaria.Tiles.PotionFuser
{
    public class PotionFuser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion Fuser");
            Tooltip.SetDefault("Used to combine potions, while saving ingredients");
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

            item.createTile = mod.TileType("PotionFuserTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PotionMixer"));
            recipe.AddIngredient(ItemID.AlchemyTable);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
