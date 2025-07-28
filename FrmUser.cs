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

namespace Jungle_Math
{
    public partial class FrmUser : Form
    {
        Animations animationsControl;
        public FrmUser()
        {
            InitializeComponent();
            animationsControl = new Animations();
            animationsControl.AnimationBtn(BtnEntry);
            TxtUserName.KeyPress += new KeyPressEventHandler(textBoxLetras_KeyPress);

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


        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnEntry_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text != String.Empty)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsernameDB.txt");
                using (StreamWriter SW = new StreamWriter(filePath))
                {
                    SW.WriteLine(TxtUserName.Text);
                }
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese su nombre para continuar");
            }
        }
    }
}
