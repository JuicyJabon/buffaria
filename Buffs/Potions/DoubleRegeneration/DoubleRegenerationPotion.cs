using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.DoubleRegeneration
{
    public class DoubleRegenerationPotion : ModItem
    {
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
            item.buffType = mod.BuffType("DoubleRegenerationBuff");
        }

        public override bool CanUseItem(Player player)
        {
            int buff = mod.BuffType("DoubleRegenerationBuff");
            return !player.HasBuff(buff);
        }

        public override bool UseItem(Player player)
        {
            //Buffs go off of seconds
            //So 60fps = 1 second
            //60fps * # of seconds

            player.AddBuff(mod.BuffType("DoubleRegenerationBuff"), 3600);
            return base.UseItem(player);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RegenerationPotion);
            recipe.AddIngredient(ItemID.ManaRegenerationPotion);
            recipe.AddTile(mod.TileType("PotionMixerTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
