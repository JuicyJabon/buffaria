using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.FirePhial
{
    public class FirePhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Fiery");
            Description.SetDefault("All Attacks inflict fire");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().FireEffect = true;
        }
    }
}
