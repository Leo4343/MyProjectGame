using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiArcanoid
{
    class Kupi : ICreature
    {
        private readonly Size _playZone;
        public Size size { get; private set; } = new Size(114, 84);
        public Point speed { get; private set; }
        public Point position { get; private set; } = new Point(150, 450);
        
        private static Point ChangeX(Point point, int x)
        {
            if (point.X >= -2 && point.X <= 2) 
                return new Point {X = x, Y = point.Y};
           
            return new Point(point.X , point.Y);
        }
        
        private static Point ChangeY(Point point, int y)
        {
            if (point.Y >= -2 && point.Y <= 2)
                return new Point {X = point.X, Y = y};
            
            return new Point(point.X , point.Y);
        }


        public Kupi(Size playZone) 
        {
            this._playZone = playZone;
        }

        public void Move(Keys pressedKey)
        {
            switch (pressedKey)
            {
                case Keys.Up:
                    speed = ChangeY(speed,-2);
                    break;
                case Keys.Down:
                    speed = ChangeY(speed,2);
                    break;
                case Keys.Right:
                    speed = ChangeX(speed,2);
                    break;
                case Keys.Left:
                    speed = ChangeX(speed,-2);
                    break;
            }

            position = new Point(position.X + speed.X * 2, position.Y + speed.Y);

            KeepKupiInsidePlayZone();
        }

        private void KeepKupiInsidePlayZone()
        {
            if (position.X < 0)
            {
                speed = new Point(0, speed.Y);
                position = new Point(0, position.Y);
            }

            if (position.X > _playZone.Width - size.Width)
            {
                speed = new Point(0, speed.Y);
                position = new Point(_playZone.Width - size.Width, position.Y);
            }

            if (position.Y < _playZone.Height / 6)
            {
                speed = new Point(speed.X, 0);
                position = new Point(position.Y, _playZone.Height / 6);
            }

            if (position.Y > _playZone.Height - size.Height)
            {
                speed = new Point(speed.X, 0);
                position = new Point(position.Y, _playZone.Height - size.Height);
            }
        }
    }
}
