using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.IchorPhial
{
    public class IchorPhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ichor");
            Description.SetDefault("All Attacks inflict ichor");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().IchorEffect = true;
        }
    }
}
