using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Physics_and_math
{
    class FallingBall: Ball
    {

        public FallingBall(Texture2D texture, Vector2 position):base(texture,position)
        {
        }

        public override void Update( GameTime gameTime)
        {
            velocity += Game1.GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;
            position += velocity;
        }



    }
}