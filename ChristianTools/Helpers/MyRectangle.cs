using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChristianTools.Helpers
{
    public static class MyRectangle
    {
        public static Rectangle CreateRectangle(Point centerPosition, int Width, int Height)
        {
            Rectangle rectangle = new Rectangle(
                x: (int)(centerPosition.X - (Width / 2)),
                y: (int)(centerPosition.Y - (Height / 2)),
                width: Width,
                height: Height
            );

            return rectangle;
        }

        public static Rectangle CreateRectangle(Point centerPosition, Texture2D texture2D)
        {
            return CreateRectangle(centerPosition, texture2D.Width, texture2D.Height);
        }

        public static Rectangle ScaleRectangleSides(Rectangle originalRectangle, int scaleFactor)
        {
            Rectangle rectangle = new Rectangle(
                x: (int)(originalRectangle.X - scaleFactor),
                y: (int)(originalRectangle.Y - scaleFactor),
                width: originalRectangle.Width + (scaleFactor * 2),
                height: originalRectangle.Height + (scaleFactor * 2)
            );

            return rectangle;
        }

        public static Rectangle GetRectangleUp(Rectangle mainRectangle, int scaleFactor)
        {
            Rectangle rectangleUp = new Rectangle(
                x: mainRectangle.X,
                y: mainRectangle.Y - scaleFactor,
                width: mainRectangle.Width,
                height: scaleFactor
            );

            return rectangleUp;
        }

        public static Rectangle GetRectangleDown(Rectangle mainRectangle, int scaleFactor)
        {
            Rectangle rectangleDown = new Rectangle(
                x: mainRectangle.X,
                y: mainRectangle.Bottom,
                width: mainRectangle.Width,
                height: scaleFactor
            );

            return rectangleDown;
        }

        public static Rectangle GetRectangleLeft(Rectangle mainRectangle, int scaleFactor)
        {
            Rectangle rectangleLeft = new Rectangle(
                x: mainRectangle.X - scaleFactor,
                y: mainRectangle.Y,
                width: scaleFactor,
                height: mainRectangle.Height
            );

            return rectangleLeft;
        }

        public static Rectangle GetRectangleRight(Rectangle mainRectangle, int scaleFactor)
        {
            Rectangle rectangleRight = new Rectangle(
                x: mainRectangle.Right,
                y: mainRectangle.Y,
                width: scaleFactor,
                height: mainRectangle.Height
            );

            return rectangleRight;
        }
    }
}