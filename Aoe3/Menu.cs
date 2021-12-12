using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Aoe3
{
    public class Menu
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Rectangle rect;

        public string text { get; set; }

        public bool isActive { get; set; }

     
        

        
        public Microsoft.Xna.Framework.Color color { get; set; }

        
        
        public Menu(int w,int h,int x,int y, Microsoft.Xna.Framework.Color c,string f,bool act)
        {
            this.Width = w;
            this.Height = h;
            this.X = x;
            this.Y = y;
            this.color = c;
            this.rect = new Rectangle(this.X,this.Y, this.Width, this.Height);
            this.text = f;
            this.isActive = act;


        }
        

        
    }
}
