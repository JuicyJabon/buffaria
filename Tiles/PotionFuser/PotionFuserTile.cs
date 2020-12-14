using Buffaria.Tiles.PotionMixer;
using Microsoft.Xna.Framework;
using System;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Buffaria.Tiles.PotionFuser
{
    public class PotionFuserTile : ModTile
    {

        public override void SetDefaults()
        {


            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.LocalPlayer.alchemyTable = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.addTile(Type);

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Potion Fuser");
            AddMapEntry(new Color(200, 200, 200), name);
            adjTiles = new int[] { TileID.Bottles, ModContent.TileType<PotionMixerTile>() };
            disableSmartCursor = true;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("PotionFuser"));
        }
    }
}
