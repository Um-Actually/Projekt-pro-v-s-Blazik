using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Velky_ctverec_zere_male
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Ctverecky hrac;
        private List<Ctverecky> maleCtverecky;
        private Random random;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            random = new Random();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            hrac = new Ctverecky(GraphicsDevice, new Rectangle(100, 100, 100, 100));
            maleCtverecky = new List<Ctverecky>();
            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(0, _graphics.PreferredBackBufferWidth - 20);
                int y = random.Next(0, _graphics.PreferredBackBufferHeight - 20);
                maleCtverecky.Add(new Ctverecky(GraphicsDevice, new Rectangle(x, y, 20, 20)));
            }
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState state = Keyboard.GetState();
            int speed = 5;
            hrac.Pohnout(state);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            foreach (var ctverecek in maleCtverecky)
            {
                ctverecek.Draw(_spriteBatch, Color.Green);
            }
            hrac.Draw(_spriteBatch, Color.Red);

                _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
