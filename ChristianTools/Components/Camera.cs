﻿using ChristianTools.Helpers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChristianTools.Components
{
    public class Camera
    {
        public Rectangle rectangle { get; private set; }
        public Matrix transform { get; private set; }
        Viewport viewport;
        int zoom = 1;

        public Camera()
        {
            this.viewport = ChristianGame.viewport;
            transform = Matrix.CreateScale(new Vector3(zoom, zoom, 0)) * Matrix.CreateTranslation(Vector3.Zero);//-center.X, -center.Y, 0);
            rectangle = new Rectangle(0, 0, viewport.Width, viewport.Height);
        }

        public void Update(Vector2 targetPosition)
        {
            rectangle = new Rectangle(
                x: (int)(targetPosition.X - viewport.Width / 2),
                y: (int)targetPosition.Y - viewport.Height / 2,
                width: viewport.Width,
                height: viewport.Height
            );

            transform = Matrix.CreateTranslation(new Vector3(-rectangle.X, -rectangle.Y, 0));
        }
    }
}