using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Physics_and_math
{
    class Ball
    {
        protected Texture2D texture;
        protected Vector2 position;
        protected Vector2 velocity;
        protected Vector2 startPosition;

        public Ball(Texture2D texture, Vector2 position)
        {
            startPosition = position;
            this.position = position;
            this.texture = texture;
            velocity = Vector2.Zero;
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(position.ToPoint(), new Point(50, 50)), Color.White);
        }

        public virtual void Reset()
        {
            position = startPosition;
            //velocity = Vector2.Zero;
        }
    }
}
