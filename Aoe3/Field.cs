using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System.Timers;

namespace Aoe3
{
    class Field
    {
        public TerrainEnum terrain { get; set; }
        public Timer timer;
        public bool cheked { get; set; } = true;
        public int spriteId { get; set; }

        public bool CheckTerrain()
        {
            bool res = false;
            if (!cheked)
            {
                cheked = true;
                res = true;
            }
            return res;
        }

       

    }
}
