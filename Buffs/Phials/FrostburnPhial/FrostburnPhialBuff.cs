using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.FrostburnPhial
{
    public class FrostburnPhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Icy Burn");
            Description.SetDefault("All Attacks inflict frostburn");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().FrostburnEffect = true;
        }
    }
}
