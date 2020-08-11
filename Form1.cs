using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AntiArcanoid
{
    public partial class Form1 : Form
    { 
        public void Move(Point kupiPosition, Point firstHeartPosition, Point secondHeartPosition)
        {
            kupi.Location = new Point(kupiPosition.X, kupiPosition.Y);
            firstHeart.Location = new Point(firstHeartPosition.X, firstHeartPosition.Y);
            secondHeart.Location = new Point(secondHeartPosition.X, secondHeartPosition.Y);
        }

        public void SetTimerCallback(Action callback)
        {
            timer1.Tick += (_, __) => callback.Invoke();
        }
        
        public void Start()
        {
            timer1.Start();
        }

        public Form1()
        {
            timer1 = new Timer();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            InitializeComponent();

            firstHeart.Parent = backGround;
            secondHeart.Parent = backGround;
            kupi.Parent = backGround;
            NumGoals.Parent = backGround;
            Message.Parent = backGround;

            kupi.Image = Properties.Resources.kupi;
            backGround.Image = Properties.Resources.back;
            firstHeart.BackgroundImage = Properties.Resources.first;
            secondHeart.BackgroundImage = Properties.Resources.second;

            NumGoals.BackColor = Color.Transparent;
            Message.BackColor = Color.Transparent;
            NumGoals.Font = new Font("Tobota", 15, FontStyle.Regular);
            Message.Font = new Font("Tobota", 25, FontStyle.Italic);
        }
    }
}
