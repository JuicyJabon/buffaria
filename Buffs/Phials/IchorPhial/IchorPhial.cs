using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.IchorPhial
{
    public class IchorPhial : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("All Attacks inflict ichor");
        }

        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 16;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useTurn = true;
            item.maxStack = 30;
            item.consumable = true;
            item.UseSound = SoundID.Item3;
            item.rare = ItemRarityID.LightRed;
            item.buffType = mod.BuffType("IchorPhialBuff");
        }

        public override bool CanUseItem(Player player)
        {
            int buff = mod.BuffType("IchorPhialBuff");
            return !player.HasBuff(buff);
        }

        public override bool UseItem(Player player)
        {
            //Buffs go off of seconds
            //So 60fps = 1 second
            //60fps * # of seconds

            player.AddBuff(mod.BuffType("IchorPhialBuff"), 36000);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.Ichor);
            recipe.AddIngredient(ItemID.Amber);
            recipe.AddTile(TileID.ImbuingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
