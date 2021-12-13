using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System.Timers;


namespace Aoe3
{


    public class Field
    {
        public TypeOfTerrain terrain { get; set; }
        public bool cheked { get; set; } = true;

        public Timer timer;
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




        public Color GetFieldColor()
        {
            Color returnableColor = new Color();
            switch (terrain)
            {
                case TypeOfTerrain.Earth:
                    returnableColor = new Color(164, 198, 57, 255);
                    break;
                case TypeOfTerrain.Water:
                    returnableColor = new Color(0, 108, 165, 255);
                    break;
                case TypeOfTerrain.Road:
                    returnableColor = new Color(220, 135, 52, 255);
                    break;
                case TypeOfTerrain.Tree:
                    returnableColor = new Color(17, 134, 47, 255);
                    break;
                case TypeOfTerrain.Bridge:
                    returnableColor = Color.DarkOrange;
                    break;

            }
            return returnableColor;
        }

        public Rectangle GetFieldTerrain()
        {
            switch (terrain)
            {
                case TypeOfTerrain.Earth:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Water, spriteId);
                case TypeOfTerrain.Water:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Water, spriteId);
                case TypeOfTerrain.Road:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Road, spriteId);
                case TypeOfTerrain.Tree:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Tree, spriteId);
                case TypeOfTerrain.Mine:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Mine, spriteId);
                case TypeOfTerrain.Bridge:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Bridge, spriteId);
                case TypeOfTerrain.Building:
                    return GroundSprite.GetRecquiredSprite(TypeOfTerrain.Water, spriteId);
            }
            return new Rectangle(264, 66, 32, 32);
        }


    }
}
