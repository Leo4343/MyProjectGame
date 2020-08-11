using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiArcanoid
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainForm = new Form1();
            var pressedKey = Keys.None;
            var gameModel = new GameModel(mainForm.Size, mainForm.Message);
            mainForm.KeyDown += (_, args) => pressedKey = args.KeyCode;
            mainForm.SetTimerCallback(() =>
            {
                gameModel.Tick(pressedKey);
                
                Point kupiPosition = gameModel.KupiPosition();
                Point firstHeartPosition = gameModel.FirstHeartPosition();
                Point secondHeartPosition = gameModel.SecondHeartPosition();
                
                mainForm.Move(kupiPosition, firstHeartPosition, secondHeartPosition);
                
                mainForm.Message.Text = gameModel.Message;
                mainForm.NumGoals.Text = gameModel.NumGoals;
            });
            mainForm.Start();
            Application.Run(mainForm);
        }
    }
}