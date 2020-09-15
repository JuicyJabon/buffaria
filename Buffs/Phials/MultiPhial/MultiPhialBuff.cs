using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace Buffaria.Buffs.Phials.MultiPhial
{
    public class MultiPhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Death");
            Description.SetDefault("All Attacks inflict multiple debuffs");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().FireEffect = true;
            player.GetModPlayer<BuffPlayer>().FrostburnEffect = true;
            player.GetModPlayer<BuffPlayer>().IchorEffect = true;
            player.GetModPlayer<BuffPlayer>().PoisonEffect = true;
            player.GetModPlayer<BuffPlayer>().VenomEffect = true;
        }
    }
}
