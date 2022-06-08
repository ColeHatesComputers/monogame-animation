using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D tribbleGreyTexture;
        Texture2D tribbleBrownTexture;
        Texture2D starwarsTexture;
        Texture2D tribbleCreamTexture;
        Texture2D tribbleOrangeTexture;
        Rectangle tribbleOrangeRect;
        Vector2 tribbleOrangeSpeed;
        Rectangle tribbleGreyRect;
        Vector2 tribbleGreySpeed;
        Rectangle tribbleBrownRect;
        Vector2 tribbleBrownSpeed;
        Vector2 tribbleCreamSpeed;
        Rectangle tribbleCreamRect;
       
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tribbleBrownRect = new Rectangle(100, 100, 75, 75);
            tribbleBrownSpeed = new Vector2(2, 0);
            tribbleGreyRect = new Rectangle(90, 90, 75, 75);
            tribbleGreySpeed = new Vector2(0, 2);
            tribbleCreamRect = new Rectangle(70, 70, 75, 75);
            tribbleCreamSpeed = new Vector2(3, 7);
            tribbleOrangeRect = new Rectangle(70, 70, 75, 75);
            tribbleOrangeSpeed = new Vector2(0, 2);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            starwarsTexture = Content.Load<Texture2D>("starwars");
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");


            // TODO: use this.Content to load your game content here
        }
        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.X < 0)
                tribbleBrownSpeed.X *= -1;
           
            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;
            if (tribbleGreyRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGreyRect.Top < 0)
                tribbleGreySpeed.Y *= -1;

            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Top < 0)
                tribbleCreamSpeed.Y *= -1;

            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.X < 0) 
                tribbleCreamSpeed.X *= -1;


            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Top < 0)
                tribbleOrangeSpeed.Y *= -1.1f;


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);            
            _spriteBatch.Begin();
            _spriteBatch.Draw(starwarsTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleGreyTexture, tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
