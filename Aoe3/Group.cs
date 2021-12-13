using Microsoft.Xna.Framework;

namespace Aoe3
{
    public class Group
    {
        public Point FocusedObj { get; private set; }
        public bool WoodObtain { get; private set; } = false;
        public bool GoldOntain { get; private set; } = false;
        public BuildingType buildingType =BuildingType.None;
        public Group()
        {
            FocusedObj = new Point(-1, -1);
        }
        public void ChangePoint(int x, int y)
        {
            FocusedObj = new Point(x, y);
            buildingType = BuildingType.None;
            OntainChange(false);
        }
        public void ChangePoint(Point pt)
        {
            FocusedObj = new Point(pt.X, pt.Y);
            buildingType = BuildingType.None;
            OntainChange(false);
        }
        public void OntainChange(bool can, TypeOfTerrain typeOfTerrain)
        {
            switch (typeOfTerrain)
            {
                case TypeOfTerrain.Tree:
                    WoodObtain = can;
                    break;
                case TypeOfTerrain.Mine:
                    GoldOntain = can;
                    break;
            }
        }
        public void OntainChange(bool can)
        {
            WoodObtain = can;
            GoldOntain = can;
        }
    }
}
