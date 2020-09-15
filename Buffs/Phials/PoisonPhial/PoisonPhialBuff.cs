using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Phials.PoisonPhial
{
    public class PoisonPhialBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Poisonous");
            Description.SetDefault("All Attacks inflict poison");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<BuffPlayer>().PoisonEffect = true;
        }
    }
}
