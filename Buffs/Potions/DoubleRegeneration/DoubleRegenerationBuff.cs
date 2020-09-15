using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs.Potions.DoubleRegeneration
{
    public class DoubleRegenerationBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Double Regeneration");
            Description.SetDefault("Increases life and mana regeneration");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 8;
            player.manaRegenBuff = true;
        }
    }
}
