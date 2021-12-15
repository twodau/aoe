using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace Aoe3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D whiteRectangle;

        //bg
        Texture2D background;
        Texture2D grass;
        bool backgroundIsActive;
        Rectangle mainFrame;


        Map map;
        Vector2 vector;
        private SpriteFont textMenu;
        Font font = new Font(10, "Segoe UI", "Bold");
        //Menu start = new Menu(200, 50, 300, 20, Microsoft.Xna.Framework.Color.Black, "Start");

        public List<Menu> mainmenu = new List<Menu>();
        public List<Menu> settingsmenu = new List<Menu>();

        Menu start = new Menu(900, 100, 500, 420, Microsoft.Xna.Framework.Color.Black, "Start",true);
        Menu setting = new Menu(900, 100, 500, 540, Microsoft.Xna.Framework.Color.Black, "Settings",true);
        Menu exit = new Menu(900, 100, 500, 680, Microsoft.Xna.Framework.Color.Black, "Exit",true);
        
       

        


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            //_graphics.ToggleFullScreen();
            _graphics.PreferredBackBufferWidth = 1980;
            _graphics.PreferredBackBufferHeight = 1080;
            IsMouseVisible = true;
            

            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            mainmenu.Add(new Menu(900, 100, 500, 420, Microsoft.Xna.Framework.Color.Black, "Start", true));
            mainmenu.Add(new Menu(900, 100, 500, 540, Microsoft.Xna.Framework.Color.Black, "Settings", true));
            mainmenu.Add(new Menu(900, 100, 500, 680, Microsoft.Xna.Framework.Color.Black, "Exit", true));

            settingsmenu.Add(new Menu(140, 100, 1, 1, Microsoft.Xna.Framework.Color.Black, "SoundUp", false));
            settingsmenu.Add(new Menu(900, 100, 500, 880, Microsoft.Xna.Framework.Color.Black, "back", false));
            settingsmenu.Add(new Menu(140, 100, 1, 101, Microsoft.Xna.Framework.Color.Black, "SoundDown", false));
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            mainFrame = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
            background = Content.Load<Texture2D>(@"bg");
            backgroundIsActive = true;

            grass = Content.Load<Texture2D>(@"trava");

            textMenu = Content.Load<SpriteFont>(@"txtMenu");
            whiteRectangle = new Texture2D(GraphicsDevice, 1, 1);
            whiteRectangle.SetData(new[] { Color.White });

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            var mouseState = Mouse.GetState();
            var mousePosition = new Point(mouseState.X, mouseState.Y);

            if (mainmenu[0].rect.Contains(mousePosition) && mainmenu[0].isActive == true)
            {

                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    //загрузка карты
                }

            }

            if (settingsmenu[1].rect.Contains(mousePosition) && settingsmenu[1].isActive == true)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    mainmenu[0].isActive = true;
                    mainmenu[1].isActive = true;
                    mainmenu[2].isActive = true;
                    settingsmenu[1].isActive = false;
                    settingsmenu[0].isActive = false;
                    settingsmenu[2].isActive = false;
                }
            }

            if (settingsmenu[0].rect.Contains(mousePosition) && settingsmenu[0].isActive == true)
            {

                if (mouseState.LeftButton == ButtonState.Pressed)
                {

                    MediaPlayer.Volume += 0.1f;



                }
            }

            if (settingsmenu[2].rect.Contains(mousePosition) && settingsmenu[2].isActive == true)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    MediaPlayer.Volume -= 0.1f;
                }



            }

            if (mainmenu[1].rect.Contains(mousePosition) && mainmenu[1].isActive == true)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    settingsmenu[0].isActive = true;
                    settingsmenu[1].isActive = true;
                    settingsmenu[2].isActive = true;
                    mainmenu[0].isActive = false;
                    mainmenu[1].isActive = false;
                    mainmenu[2].isActive = false;

                }
            }

            if (mainmenu[2].rect.Contains(mousePosition) && mainmenu[2].isActive == true)
            {


                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    Exit();
                }

            }

            // TODO: Add your update logic here

            base.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            if (backgroundIsActive == true)
            {
                _spriteBatch.Draw(background, mainFrame, Color.White);
            }



            // _spriteBatch.Draw(whiteRectangle, new Rectangle(menu.X,menu.Y,menu.Width,menu.Height));
            Color c = Color.Black;
            Color c1 = Color.Gold;
            if (mainmenu[0].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[0].X - 1, mainmenu[0].Y - 1, mainmenu[0].Width + 2, mainmenu[0].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[0].X, mainmenu[0].Y, mainmenu[0].Width, mainmenu[0].Height), c);
                _spriteBatch.DrawString(textMenu, $"{mainmenu[0].text}", new Vector2(mainmenu[0].X + 20, mainmenu[0].Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }
            if (mainmenu[1].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[1].X - 1, mainmenu[1].Y - 1, mainmenu[1].Width + 2, mainmenu[1].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[1].X, mainmenu[1].Y, mainmenu[1].Width, mainmenu[1].Height), c);
                _spriteBatch.DrawString(textMenu, $"{mainmenu[1].text}", new Vector2(mainmenu[1].X + 20, mainmenu[1].Y + 10), Microsoft.Xna.Framework.Color.Coral);

            }
            if (mainmenu[2].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[2].X - 1, mainmenu[2].Y - 1, mainmenu[2].Width + 2, mainmenu[2].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(mainmenu[2].X, mainmenu[2].Y, mainmenu[2].Width, mainmenu[2].Height), c);
                _spriteBatch.DrawString(textMenu, $"{mainmenu[2].text}", new Vector2(mainmenu[2].X + 20, mainmenu[2].Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }

            if (settingsmenu[0].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[0].X - 1, settingsmenu[0].Y - 1, settingsmenu[0].Width + 2, settingsmenu[0].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[0].X, settingsmenu[0].Y, settingsmenu[0].Width, settingsmenu[0].Height), c);
                _spriteBatch.DrawString(textMenu, $"{settingsmenu[0].text}", new Vector2(settingsmenu[0].X + 10, settingsmenu[0].Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }

            if (settingsmenu[2].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[2].X - 1, settingsmenu[2].Y - 1, settingsmenu[2].Width + 2, settingsmenu[2].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[2].X, settingsmenu[2].Y, settingsmenu[2].Width, settingsmenu[2].Height), c);
                _spriteBatch.DrawString(textMenu, $"{settingsmenu[2].text}", new Vector2(settingsmenu[2].X + 10, settingsmenu[2].Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }

            if (settingsmenu[1].isActive == true)
            {
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[1].X - 1, settingsmenu[1].Y - 1, settingsmenu[1].Width + 2, settingsmenu[1].Height + 2), c1);
                _spriteBatch.Draw(whiteRectangle, new Rectangle(settingsmenu[1].X, settingsmenu[1].Y, settingsmenu[1].Width, settingsmenu[1].Height), c);
                _spriteBatch.DrawString(textMenu, $"{settingsmenu[1].text}", new Vector2(settingsmenu[1].X + 20, settingsmenu[1].Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }




            // TODO: Add your drawing code here
            _spriteBatch.End();

        }
    }
}
