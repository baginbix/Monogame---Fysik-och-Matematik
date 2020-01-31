using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Physics_and_math
{
    class RotateBall:Ball
    {
        float rad = 0;
        public RotateBall(Texture2D texture, Vector2 position):base(texture, position)
        {

        }

        public override void Update(GameTime gameTime)
        {
            rad += MathHelper.TwoPi / 360;
            rad = rad % MathHelper.TwoPi;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(),
                new Point(50, 50)), null, Color.White, rad,
                new Vector2(0f, 0f),SpriteEffects.None,0);
        }

    }
}
