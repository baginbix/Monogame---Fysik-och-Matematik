using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Physics_and_math
{
    class LaunchBall:Ball
    {
        bool launched;

        Vector2 power = Vector2.Zero;
        public LaunchBall(Texture2D texture, Vector2 position):base(texture,position)
        {
            launched = false;
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            if (launched)
            {
                velocity += Game1.GRAVITY * (float)gameTime.ElapsedGameTime.TotalSeconds;
                position += velocity;
            }
            else
            {
                Point mousePos = Mouse.GetState().Position;
                power = (mousePos.ToVector2() - position) * .05f;
                
                if (kState.IsKeyDown(Keys.L))
                {
                    launched = true;
                    velocity = power;
                }
            }

            

        }

        /*public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            DrawLaunchLine(spriteBatch, 10, 2);
            
        }

        private void DrawLaunchLine(SpriteBatch spriteBatch, int steps, float seconds)
        {
            //Vector2 fakePosition = position;
            //Vector2 fakeVelocity = power;
            //float timeStep = seconds / steps;
            //for (int i = 0; i < steps; i++)
            //{
            //    fakeVelocity += (Game1.GRAVITY * 1 / 60f);
            //    fakePosition += fakeVelocity / timeStep;

            //    Rectangle fakeRectangle = new Rectangle();
            //    fakeRectangle.Location = fakePosition.ToPoint();
            //    fakeRectangle.Width = 3;
            //    fakeRectangle.Height = 3;

            //    spriteBatch.Draw(texture, fakeRectangle, Color.AntiqueWhite);
            //}

            float timeStep = seconds / steps;
            for (int i = 1; i <= steps; i++)
            {

                Rectangle fakeRectangle = new Rectangle();
                fakeRectangle.Location = (position + (power* 60 + Game1.GRAVITY ) * (i*timeStep)).ToPoint();
                fakeRectangle.Width = 3;
                fakeRectangle.Height = 3;

                spriteBatch.Draw(texture, fakeRectangle, Color.AntiqueWhite);
            }
        }*/
    }
}
