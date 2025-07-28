using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jungle_Math
{
    internal class Animations
    {
        public void AnimationBtn(PictureBox pictureBoxButton)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            bool isMouseOverButton = false;
            const int targetSizeIncrement = 10;
            int originalWidth = pictureBoxButton.Width;
            int originalHeight = pictureBoxButton.Height;
            int targetWidth = originalWidth + targetSizeIncrement;
            int targetHeight = originalHeight + targetSizeIncrement;
            int step = 5;

            pictureBoxButton.MouseEnter += new EventHandler(Button_MouseEnter);
            pictureBoxButton.MouseLeave += new EventHandler(Button_MouseLeave);

            timer.Interval = 2; 
            timer.Tick += new EventHandler(Timer_Tick);

            void Button_MouseEnter(object sender, EventArgs e)
            {
                isMouseOverButton = true;
                timer.Start();
            }

            void Button_MouseLeave(object sender, EventArgs e)
            {
                isMouseOverButton = false;
                timer.Start();
            }

            void Timer_Tick(object sender, EventArgs e)
            {
                if (isMouseOverButton)
                {
                    if (pictureBoxButton.Width < targetWidth)
                    {
                        pictureBoxButton.Width += step;
                        pictureBoxButton.Height += step;
                        pictureBoxButton.Left -= step / 2;
                        pictureBoxButton.Top -= step / 2;
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
                else
                {
                    if (pictureBoxButton.Width > originalWidth)
                    {
                        pictureBoxButton.Width -= step;
                        pictureBoxButton.Height -= step;
                        pictureBoxButton.Left += step / 2;
                        pictureBoxButton.Top += step / 2;
                    }
                    else
                    {
                        timer.Stop();
                    }
                }
            }
        }

    }

}
