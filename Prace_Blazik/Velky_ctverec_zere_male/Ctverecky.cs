using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Velky_ctverec_zere_male
{
    internal class Ctverecky
    {
        private Texture2D texture;
        public Rectangle Rect { get; private set; }

        int v = 5;
        public Ctverecky(GraphicsDevice graphicsDevice, Rectangle startRect)
        {
            Rect = startRect;
            texture = new Texture2D(graphicsDevice, 1, 1);
            texture.SetData(new[] { Color.White });
        }
        public void Pohnout(KeyboardState state)
        {
            int x = Rect.X;
            int y = Rect.Y;

            if (state.IsKeyDown(Keys.A))
                x -= v;
            if (state.IsKeyDown(Keys.D))
                x += v;
            if (state.IsKeyDown(Keys.W))
                y -= v;
            if (state.IsKeyDown(Keys.S))
                y += v;

            Rect = new Rectangle(x, y, Rect.Width, Rect.Height);
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            spriteBatch.Draw(texture, Rect, color);
        }
    }
}