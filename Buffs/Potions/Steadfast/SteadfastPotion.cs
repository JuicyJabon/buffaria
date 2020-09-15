using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.Steadfast
{
    public class SteadfastPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases defense and adds knockback resistance");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 16;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useTurn = true;
            item.maxStack = 30;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.rare = ItemRarityID.Blue;
            item.buffType = mod.BuffType("SteadfastBuff");
        }

        public override bool CanUseItem(Player player)
        {
            int buff = mod.BuffType("SteadfastBuff");
            return !player.HasBuff(buff);
        }

        public override bool UseItem(Player player)
        {
            //Buffs go off of seconds
            //So 60fps = 1 second
            //60fps * # of seconds

            player.AddBuff(mod.BuffType("SteadfastBuff"), 14400);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.IronskinPotion);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.AddIngredient(ItemID.ArmoredCavefish);
            recipe.AddIngredient(ItemID.IronOre);
            recipe.AddIngredient(ItemID.Daybloom);
            recipe.AddTile(mod.TileType("PotionMixerTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
