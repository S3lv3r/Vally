using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jungle_Math.MathOperation;

namespace Jungle_Math
{
    public partial class FrmMultiplication : Form
    {
        private MathOperation.MultiplicationOperation multOperation;
        private Animations animationControl;
        private ScoreControl scoreControl;
        Random random = new Random();
        public FrmMultiplication()
        {
            InitializeComponent();
            scoreControl = new ScoreControl();
            LblBestScore.Text = "Mejor Puntuacion: " + Convert.ToString(scoreControl.ReadScore(2));
            animationControl = new Animations();
            animationControl.AnimationBtn(BtnBackMain);
            animationControl.AnimationBtn(BtnCheck);
            animationControl.AnimationBtn(BtnRetry);
            animationControl.AnimationBtn(BtnMenu);
            multOperation = new MathOperation.MultiplicationOperation();
            multOperation.SetControls(this.Controls);
            multOperation.GiveThePropertiesToTxtBox();
            multOperation.AssingNumberMult();
            multOperation.SubIndiceIncrent();

            PnlWhenFinish.Visible = false;

            TimerTime = new Timer();
            TimerTime.Interval = 1000;
            TimerTime.Tick += Timer_Tick;
            TimerTime.Start();
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

        private int counter = 0;
        private Timer TimerTime;

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter < 10)
            {
                LblTimer.Text = "00" + counter.ToString();
            }
            else if (counter < 100)
            {
                LblTimer.Text = "0" + counter.ToString();
            }
            else
            {
                LblTimer.Text = counter.ToString();
            }

        }

        string[] MotivationalPhraseToGoodWork = {
            "¡Bien hecho!",
            "¡Excelente!",
            "¡Muy bien!",
            "¡Sigue así!",
            "¡Bravo!",
            "¡Genial!",
            "¡Buen trabajo!",
            "¡Fantástico!",
            "¡Impresionante!",
            "¡Eres genial!"};
        string[] MotivationPhraseToRegularWork = {
            "¡No te rindas!",
            "¡Tú puedes!",
            "¡Sigue adelante!",
            "¡No te preocupes!",
            "¡Inténtalo de nuevo!",
            "¡Lo harás mejor!",
            "¡No te desanimes!",
            "¡Sigue practicando!",
            "¡Cada paso cuenta!",
            "¡Ánimo!"
        };

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            Boolean IsComplete = true;
            for (int i = 0; i < 10; i++)
            {
                string TxtBoxName = "TxtBxResult_" + (i + 1);
                Control[] controlTxtBx = this.Controls.Find(TxtBoxName, true);
                if (controlTxtBx.Length > 0 && controlTxtBx[0] is TextBox txtbx)
                {
                    if (txtbx.Text == string.Empty)
                    {
                        IsComplete = false;
                    }
                }
            }
            if (IsComplete)
            {
                TimerTime.Stop();
                multOperation.VerifiyOperationMult();
                PnlWhenFinish.Visible = true;
                BtnCheck.Visible = false;
                double time = Convert.ToDouble(LblTimer.Text);
                double PointsTimes = 0;
                if (time <= 60)
                {
                    PointsTimes = 500 - (multOperation.NumbersOfIncorrects * 50);
                }
                else
                {
                    PointsTimes = Math.Round(500 - ((time - 60) * 0.6));
                }

                double Puntation = (50 * multOperation.NumbersOfCorrects) + PointsTimes;
                LblPNLPuntuacion.Text = "Tu puntuacion fue de " + Convert.ToString(Puntation);
                //----
                if (Puntation > scoreControl.ReadScore(2))
                {
                    string filePathSC = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ScoreDB.txt");
                    string[] lines = File.ReadAllLines(filePathSC);

                    if (lines.Length > 2)
                    {
                        lines[2] = Convert.ToString(Puntation);
                    }
                    File.WriteAllLines(filePathSC, lines);
                }
                //----
                string nameofuser;
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsernameDB.txt");
                using (StreamReader SR = new StreamReader(filePath))
                {
                    nameofuser = SR.ReadToEnd();
                }
                if (multOperation.NumbersOfCorrects >= 7)
                {
                    LblPNLMotvName.Text = MotivationalPhraseToGoodWork[random.Next(0, MotivationalPhraseToGoodWork.Length)] + ", " + nameofuser;
                }
                else
                {
                    LblPNLMotvName.Text = MotivationPhraseToRegularWork[random.Next(0, MotivationPhraseToRegularWork.Length)] + ", " + nameofuser;
                }

            }
            else
            {
                MessageBox.Show("Completa Todas Las Operaciones");
            }
        }



        private void BtnBackMain_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
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

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            FrmMultiplication form1 = new FrmMultiplication();
            form1.Show();

            this.Hide();
            this.Dispose();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        
    }
}
