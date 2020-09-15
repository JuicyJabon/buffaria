using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace Buffaria.Buffs.Phials.MultiPhial
{
    public class MultiPhial : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("All Attacks inflict a variety of debuffs");
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
            item.rare = ItemRarityID.LightRed;
            item.buffType = mod.BuffType("MultiPhialBuff");
        }

        public override bool CanUseItem(Player player)
        {
            int buff = mod.BuffType("MultiPhialBuff");
            return !player.HasBuff(buff);
        }

        public override bool UseItem(Player player)
        {
            //Buffs go off of seconds
            //So 60fps = 1 second
            //60fps * # of seconds

            player.AddBuff(mod.BuffType("MultiPhialBuff"), 36000);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PoisonPhial"));
            recipe.AddIngredient(mod.ItemType("FirePhial"));
            recipe.AddIngredient(mod.ItemType("FrostburnPhial"));
            recipe.AddIngredient(mod.ItemType("VenomPhial"));
            recipe.AddIngredient(mod.ItemType("IchorPhial"));
            recipe.AddTile(mod.TileType("PotionMixerTile"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
