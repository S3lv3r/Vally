using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jungle_Math
{
    public partial class MainMenu : Form
    {
        private Timer timer;
        private bool isMouseOverButton;
        private const int targetSizeIncrement = 20;
        private int originalWidth = 450;  
        private int originalHeight = 125;  
        private int targetWidth;
        private int targetHeight;
        private int step = 2;
        private PictureBox currentButton; 
        private PictureBox previousButton;

        MathOperation mathOperation;

        DailyPhrase dailyPhraseControl;
        
        public MainMenu()
        {
            InitializeComponent();
            mathOperation = new MathOperation();
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(Timer_Tick);
            dailyPhraseControl = new DailyPhrase();
            dailyPhraseControl.SistemDailyPhrase(LblDailyPhrase);

            AnimationOfButtons();
            MessageToUser();
            LoadCustomFont();
            ApplyCustomFont(this);

        }

        private FontFamily customFontFamily;

        private void LoadCustomFont()
        {
            string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts", "Fredoka-VariableFont_wdth,wght.ttf");
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            customFontFamily = privateFonts.Families[0];
        }

        private void ApplyCustomFont(Control control)
        {
            if (control is Label label)
            {
                label.Font = new Font(customFontFamily, label.Font.Size);
            }
            else if (control is TextBox textBox)
            {
                textBox.Font = new Font(customFontFamily, textBox.Font.Size);
            }
            foreach (Control childControl in control.Controls)
            {
                ApplyCustomFont(childControl);
            }

        }

        public void MessageToUser()
        {
            int horaActual = DateTime.Now.Hour;

            if (horaActual >= 1 && horaActual <= 12)
            {
                LblUserName.Text = "Buenos días";
            }
            else if (horaActual >= 13 && horaActual <= 18)
            {
                LblUserName.Text = "Buenas tardes";
            }
            else if (horaActual >= 19 && horaActual <= 24)
            {
                LblUserName.Text = "Buenas noches";
            }
            else
            {
                LblUserName.Text = "Buenas noches";
            }
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsernameDB.txt");
            using (StreamReader SR = new StreamReader(filePath))
            {
                string Name; Name = SR.ReadToEnd();
                LblUserName.Text += ", " + Name + "¿Con ganas de aprender?";
            }
        }
        public void AnimationOfButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                string[] Names = { "Sum", "Subs", "Mult", "Div" };
                string[] Img = { "Sums", "Rest", "Mult", "Div" };
                string BtnName = "Btn" + Names[i] + "Form";
                Control[] Btns = this.Controls.Find(BtnName, true);
                if (Btns.Length > 0 && Btns[0] is PictureBox picbx)
                {
                    string imageNameAfter = "BtnAfter" + Img[i] + ".png";
                    string imageNameBefore = "BtnBefore" + Img[i] + ".png";
                    picbx.MouseEnter += (sender, e) => Button_MouseEnter(sender, e, imageNameAfter);
                    picbx.MouseLeave += (sender, e) => Button_MouseLeave(sender, e, imageNameBefore);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e, string NameOfImage)
        {
            if (sender is PictureBox picbx)
            {
                isMouseOverButton = true;


                timer.Stop();

                if (previousButton != null && previousButton != picbx)
                {

                    previousButton.Width = originalWidth;
                    previousButton.Height = originalHeight;

                    previousButton.Left = originalLeft;
                    previousButton.Top = originalTop;
                }

                picbx.Image = Image.FromFile(NameOfImage);


                targetWidth = originalWidth + targetSizeIncrement;
                targetHeight = originalHeight + targetSizeIncrement;

  
                originalLeft = picbx.Left;
                originalTop = picbx.Top;

                currentButton = picbx;
                previousButton = picbx;
                timer.Start();
            }
        }
        private int originalLeft;
        private int originalTop;

        private void Button_MouseLeave(object sender, EventArgs e, string NameOfImage)
        {
            if (sender is PictureBox picbx)
            {
                isMouseOverButton = false;
                picbx.Image = Image.FromFile(NameOfImage);


                currentButton = picbx;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentButton == null)
            {
                timer.Stop();
                return;
            }

            if (isMouseOverButton)
            {
                if (currentButton.Width < targetWidth)
                {
                    currentButton.Width += step;
                    currentButton.Height += step;
                    currentButton.Left -= step / 2;
                    currentButton.Top -= step / 2;
                }
                else
                {
                    timer.Stop();
                }
            }
            else
            {
                if (currentButton.Width > originalWidth)
                {
                    currentButton.Width -= step;
                    currentButton.Height -= step;
                    currentButton.Left += step / 2;
                    currentButton.Top += step / 2;
                }
                else
                {
                    currentButton.Width = originalWidth;
                    currentButton.Height = originalHeight;

                    currentButton.Left = originalLeft;
                    currentButton.Top = originalTop;
                    timer.Stop();
                }
            }
        }


        private void BtnSumForm_Click(object sender, EventArgs e)
        {
            FrmSumas frmSumas = new FrmSumas();
            frmSumas.Show();
            this.Hide();
        }
        private void BtnSubsForm_Click(object sender, EventArgs e)
        {
            FrmSubtraction frmrestas = new FrmSubtraction();
            frmrestas.Show();
            this.Hide();
        }

        private void BtnMultForm_Click(object sender, EventArgs e)
        {
            FrmMultiplication frmmultiplicaciones = new FrmMultiplication();
            frmmultiplicaciones.Show();
            this.Hide();
        }
        
        

        public void HoverMouse()
        {

        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (var form in openForms)
            {
                if (form != this) 
                {
                    form.Close();
                }
            }
            this.Close();
        }

        private void BtnMinApp_Click(object sender, EventArgs e)
        {
            ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void BtnSumForm_Click_1(object sender, EventArgs e)
        {
            FrmSumas frmSum = new FrmSumas();
            frmSum.Show();
            this.Hide();
        }

        private void BtnDivForm_Click(object sender, EventArgs e)
        {
            FrmDivision frmdiv = new FrmDivision();
            frmdiv.Show();
            this.Hide();
        }

        private void LblUserName_DoubleClick(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            user.Show();
            this.Hide();
        }
    }
}
