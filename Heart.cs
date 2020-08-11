using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiArcanoid
{
    class Heart : ICreature
    { 
        public Size size { get ; private set ; } = new Size(52, 42);
        public Point speed { get ; set ; }
        public Point position { get ; private set ; }
        public HeartState HeartState { get ; set ; }

        private readonly Size _playZone;
        private readonly Heart _anotherHeart;

        private Random _random = new Random();

        public Heart(Size playZone, Heart anotherHeart)
        {
            this._playZone = playZone;
            this._anotherHeart = anotherHeart;
        }
        public void Move()
        {
            position = new Point(position.X + speed.X, position.Y + speed.Y);
            speed = new Point(BounceWall(), speed.Y);
        }

        private int BounceWall()
        {
            if (position.X < 0)
                return Math.Abs(speed.X);

            if (position.X > _playZone.Width - size.Width)
                return -1 * speed.X;
            
            return speed.X;
        }

        public void Stop()
        {
            position = new Point(_random.Next(0, _playZone.Width - size.Width), _random.Next(0, _playZone.Height / 8));
            speed = new Point(0, 0);
            HeartState = HeartState.Got;
        }
    }
}
