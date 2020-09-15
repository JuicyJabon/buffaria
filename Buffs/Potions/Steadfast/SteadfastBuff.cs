using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.Steadfast
{
    public class SteadfastBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Steadfast");
            Description.SetDefault("Increases defense and adds knockback resistance");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 8;
            player.noKnockback = true;
        }
    }
}
