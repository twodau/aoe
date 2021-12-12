using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Aoe3
{
    class Map
    {
        public Texture2D maptiles;
        public Texture2D buildingtiles;
        public const int mapSize = 100;
        public const int fieldPixelSize = 32;
        public Map()
        {
            //map = new Field[mapSize, mapSize];
        }
    }
}
