using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiArcanoid
{
    class GameModel
    {
        public int Goals;
        private Size _formSize;
        private Label _labelMessage;
        public String Message { get; set; }
        public String NumGoals { get; set; }

        public GameModel(Size formSize, Label labelMessage)
        {
            this._formSize = formSize;
            this._labelMessage = labelMessage;
            
            _kupi = new Kupi(formSize);
            _firstHeart = new Heart(formSize, _secondHeart);
            _secondHeart = new Heart(formSize, _firstHeart);
            
            _firstHeart.Stop();
            _secondHeart.Stop();
            SetSpeed();
        }

        private Random _random = new Random();

        private Kupi _kupi;
        Heart _firstHeart;
        Heart _secondHeart;
        
        public Point KupiPosition()
        {
            return _kupi.position;
        }
        
        public Point FirstHeartPosition()
        {
            return _firstHeart.position;
        }
        
        public Point SecondHeartPosition()
        {
            return _secondHeart.position;
        }

        public void Tick(Keys pressedKey) 
        {
            Move(pressedKey);
            CheckGoals();
            
            Goals += SetGoal(_firstHeart, _secondHeart);
            Goals += SetGoal(_secondHeart, _firstHeart);
        }

        private void Move(Keys pressedKey)
        {
            _kupi.Move(pressedKey);
            _firstHeart.Move();
            _secondHeart.Move();
            
            CheckBroken(_firstHeart, _secondHeart);
            CheckBroken(_secondHeart, _firstHeart);
        }

        private int SetGoal(Heart heart, Heart anotherHeart)
        {
            if ((heart.position.X >= _kupi.position.X) && (heart.position.X <= _kupi.position.X + _kupi.size.Width) &&
               (heart.position.Y >= _kupi.position.Y) && (heart.position.Y <= _kupi.position.Y + _kupi.size.Height))
            {
                heart.Stop();

                if (anotherHeart.HeartState == HeartState.Got)
                {
                    SetSpeed();

                    heart.HeartState = HeartState.Free;
                    anotherHeart.HeartState = HeartState.Free;

                    return 1;
                }

                if (anotherHeart.HeartState == HeartState.Broken)
                {
                    anotherHeart.Stop();
                    SetSpeed();
                }
            }
            return 0;
        }

        private void SetSpeed()
        {
            _firstHeart.speed = new Point(_random.Next(2, 4), _random.Next(2, 4));
            _secondHeart.speed = new Point(_random.Next(-4, -2), _random.Next(2, 4));

            _firstHeart.HeartState = HeartState.Free;
            _secondHeart.HeartState = HeartState.Free;
        }
        
        private bool CheckBroken(Heart heart, Heart anotherHeart)
        {
            if (heart.position.Y >= _formSize.Height)
            {
                if (anotherHeart.HeartState == HeartState.Got)
                {
                    heart.Stop();
                    SetSpeed();
                }

                if (anotherHeart.HeartState == HeartState.Broken)
                    _labelMessage.Text = "Ты разбила \n моё сердце";
                return true;
            }
            return false;
        }

        private void CheckGoals()
        {
            NumGoals = Goals.ToString();

            switch (Goals)
            {
                case 1:
                    Message = "В этой";
                    break;
                case 2:
                    Message = "игре";
                    break;
                case 3:
                    Message = "показана";
                    break;
                case 4:
                    Message = "лишь";
                    break;
                case 5:
                    Message = "часть";
                    break;
                case 6:
                    Message = "моих";
                    break;
                case 7:
                    Message = "знаний";
                    break;
            }
        }

    }
}
