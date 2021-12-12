using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Aoe3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D whiteRectangle;

        //bg
        Texture2D background;
        bool backgroundIsActive;
        Rectangle mainFrame;



        Vector2 vector;
        private SpriteFont textMenu;
        Font font = new Font(10, "Segoe UI", "Bold");
        //Menu start = new Menu(200, 50, 300, 20, Microsoft.Xna.Framework.Color.Black, "Start");

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            mainFrame = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
            background = Content.Load<Texture2D>(@"bg");
            backgroundIsActive = true;

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

            if(start.rect.Contains(mousePosition)&&start.isActive==true)
            {
               
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    start.isActive = false;
                    setting.isActive = false;
                    exit.isActive = false;
                    backgroundIsActive = false;
                }

            }
            if(exit.rect.Contains(mousePosition)&&exit.isActive==true)
            {
                
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    Exit();
                }
            }
            
            
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(background, mainFrame, Color.White);


            //_spriteBatch.Draw(whiteRectangle, new Rectangle(menu.X,menu.Y,menu.Width,menu.Height));
            Color c =Color.Black;
            Color c1 = Color.Gold;
            if(start.isActive==true)
            {
            _spriteBatch.Draw(whiteRectangle, new Rectangle(start.X-1, start.Y-1, start.Width+2, start.Height+2), c1);
            _spriteBatch.Draw(whiteRectangle, new Rectangle(start.X, start.Y, start.Width, start.Height), c);
            _spriteBatch.DrawString(textMenu, $"{start.text}", new Vector2(start.X + 20, start.Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }
            if(setting.isActive==true)
            {
            _spriteBatch.Draw(whiteRectangle, new Rectangle(setting.X - 1, setting.Y - 1, setting.Width + 2, setting.Height + 2), c1);
            _spriteBatch.Draw(whiteRectangle, new Rectangle(setting.X, setting.Y, setting.Width, setting.Height), c);
            _spriteBatch.DrawString(textMenu, $"{setting.text}", new Vector2(setting.X + 20, setting.Y + 10), Microsoft.Xna.Framework.Color.Coral);

            }
            if(exit.isActive==true)
            {
            _spriteBatch.Draw(whiteRectangle, new Rectangle(exit.X - 1, exit.Y - 1, exit.Width + 2, exit.Height + 2), c1);
            _spriteBatch.Draw(whiteRectangle, new Rectangle(exit.X, exit.Y, exit.Width, exit.Height), c);
            _spriteBatch.DrawString(textMenu, $"{exit.text}", new Vector2(exit.X + 20, exit.Y + 10), Microsoft.Xna.Framework.Color.Coral);
            }
            



            // TODO: Add your drawing code here
            _spriteBatch.End();

        }
    }
}
