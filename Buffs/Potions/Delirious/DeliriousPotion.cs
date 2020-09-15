using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.Delirious
{
    public class DeliriousPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases all placing, attacking, and mining speeds");
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
            item.buffType = mod.BuffType("DeliriousBuff");
        }

        public override bool CanUseItem(Player player)
        {
            int buff = mod.BuffType("DeliriousBuff");
            return !player.HasBuff(buff);
        }

        public override bool UseItem(Player player)
        {
            //Buffs go off of seconds
            //So 60fps = 1 second
            //60fps * # of seconds

            player.AddBuff(mod.BuffType("DeliriousBuff"), 3600);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.SwiftnessPotion);
            recipe.AddIngredient(ItemID.Blinkroot);
            recipe.AddIngredient(ItemID.Shiverthorn);
            recipe.AddTile(mod.TileType("PotionMixerTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
