using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Physics_and_math
{
    class MovableBall:Ball
    {
        float speed = 10f;
        public MovableBall(Texture2D texture, Vector2 position): base(texture, position)
        { }

        public override void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            Vector2 direction = Vector2.Zero;
            if (kState.IsKeyDown(Keys.S))
                direction.Y = 1;
            if (kState.IsKeyDown(Keys.W))
                direction.Y = -1;
            if (kState.IsKeyDown(Keys.D))
                direction.X = 1;
            if (kState.IsKeyDown(Keys.A))
                direction.X = -1;


            if(direction != Vector2.Zero) // Undvik att dividera 0 med 0
                direction.Normalize(); // gör om från vector till riktning
            velocity += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            position += velocity;

            if (position.X > 800) position.X -= 850;
            if (position.Y > 480) position.Y -= 530;
            if (position.X < -50) position.X += 850;
            if (position.Y < -50) position.Y += 530;
        }
    }
}