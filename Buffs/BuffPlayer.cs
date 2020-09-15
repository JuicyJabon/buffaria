using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Buffaria.Buffs
{
    public class BuffPlayer : ModPlayer
    {
        //Attack speed modifier
        public bool AttackSpeedAdd;

        //Debuffs for Enemies
        public bool PoisonEffect;
        public bool FireEffect;
        public bool FrostburnEffect;
        public bool VenomEffect;
        public bool IchorEffect;

        public override void ResetEffects()
        {
            AttackSpeedAdd = false;
            PoisonEffect = false;
            FireEffect = false;
            FrostburnEffect = false;
            IchorEffect = false;
    }
        public override float UseTimeMultiplier(Item item)
        {
            float mult = 1f;
            if (AttackSpeedAdd) mult += 0.15f;
            return mult;
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (PoisonEffect)
            {
                target.AddBuff(BuffID.Poisoned, 60 * Main.rand.Next(5, 15), false);
            }

            if (FireEffect)
            {
                target.AddBuff(BuffID.OnFire, 60 * Main.rand.Next(5, 15), false);
            }

            if (FrostburnEffect)
            {
                target.AddBuff(BuffID.Frostburn, 60 * Main.rand.Next(5, 15), false);
            }

            if (VenomEffect)
            {
                target.AddBuff(BuffID.Venom, 60 * Main.rand.Next(5, 15), false);
            }

            if (IchorEffect)
            {
                target.AddBuff(BuffID.Ichor, 60 * Main.rand.Next(5, 15), false);
            }

        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (PoisonEffect)
            {
                target.AddBuff(BuffID.Poisoned, 60 * Main.rand.Next(5, 15), false);
            }

            if (FireEffect)
            {
                target.AddBuff(BuffID.OnFire, 60 * Main.rand.Next(5, 15), false);
            }

            if (FrostburnEffect)
            {
                target.AddBuff(BuffID.Frostburn, 60 * Main.rand.Next(5, 15), false);
            }

            if (VenomEffect)
            {
                target.AddBuff(BuffID.Venom, 60 * Main.rand.Next(5, 15), false);
            }

            if (IchorEffect)
            {
                target.AddBuff(BuffID.Ichor, 60 * Main.rand.Next(5, 15), false);
            }
        }
    }
}
