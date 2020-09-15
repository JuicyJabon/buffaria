using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.VenomPhial
{
    public class VenomPhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Venom");
            Description.SetDefault("All Attacks inflict venom");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().VenomEffect = true;
        }
    }
}
