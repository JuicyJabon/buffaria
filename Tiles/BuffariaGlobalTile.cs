using Buffaria.Tiles.PotionFuser;
using Terraria;
using Terraria.ModLoader;

namespace Buffaria.Tiles
{
    public class BuffariaGlobalTile : GlobalTile
    {
        public override int[] AdjTiles(int type)
        {
            if (type == ModContent.TileType<PotionFuserTile>())
            {
                Main.LocalPlayer.alchemyTable = true;
            }
            return base.AdjTiles(type);
        }
    }
}
