using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.Delirious
{
    public class DeliriousBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Delirious");
            Description.SetDefault("Increases all placing, attacking, and mining speeds");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer <BuffPlayer>().AttackSpeedAdd = true;
        }
    }
}
