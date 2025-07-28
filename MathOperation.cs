using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jungle_Math
{
    internal class MathOperation
    {
        protected Random random = new Random();
        public int NumbersOfCorrects { get; set; }
        public int NumbersOfIncorrects { get; set; }
        protected int[] IntNum = {0,1,2,3,4,5,6,7,8,9};
        public List<Control> AllNumbers { get; set; } = new List<Control>();

        protected Control.ControlCollection Controls { get; set; }
       

        public void SetControls(Control.ControlCollection controls)
        {
            Controls = controls;
        }


        public void AssingNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                string labelname1 = "LblN1_" + (i + 1);
                string labelname2 = "LblN2_" + (i + 1);

                Control[] controls = this.Controls.Find(labelname1, true);
                Control[] controls2 = this.Controls.Find(labelname2, true);
                if (controls.Length > 0 && controls[0] is Label label)
                {
                    label.Text = string.Empty;
                    AllNumbers.Add(label);
                }
                if (controls2.Length > 0 && controls2[0] is Label label2)
                {
                    label2.Text = string.Empty;
                    AllNumbers.Add(label2);
                }
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int IndiceNum = random.Next(IntNum.Length);
                        AllNumbers[i].Text += Convert.ToString(IntNum[IndiceNum]);
                    }
                }
                else
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j == 0)
                        {
                            AllNumbers[i].Text = "  ";
                        }
                        int IndiceNum = random.Next(IntNum.Length);
                        AllNumbers[i].Text += Convert.ToString(IntNum[IndiceNum]);
                    }

                }
            }
        }
        // -------------------- TEXT BOX -----------------------------
        public void GiveThePropertiesToTxtBox()
        {
            for (int i = 0; i < 10; i++)
            {
                string TxtBoxName = "TxtBxResult_" + (i + 1);
                Control[] controlTxtBx = this.Controls.Find(TxtBoxName, true);
                if (controlTxtBx.Length > 0 && controlTxtBx[0] is TextBox TextBox)
                {
                    TextBox.TextChanged += TxtBxResult_TextChanged;
                    TextBox.KeyDown += TxtBxResult_KeyDown;
                    TextBox.KeyPress += textBoxLNumber_KeyPress;
                }
            }
        }
        private void textBoxLNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtBxResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox txtbx)
            {
                if (e.KeyCode == Keys.Back)
                {
                    int currentPosition = txtbx.SelectionStart;

                    if (currentPosition > 0)
                    {
                        txtbx.Text = txtbx.Text.Remove(currentPosition - 1, 1);

                        txtbx.SelectionStart = currentPosition - 1;
                    }
                    else
                    {
                        txtbx.SelectionStart = 0;
                    }
                    e.SuppressKeyPress = true;
                }
            }
        }
        private bool isTextBoxAdjusted = false;
        private void TxtBxResult_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.SelectionStart = 0;
                textBox.SelectionLength = 0;
                if (textBox.Text.Length > 3 && !isTextBoxAdjusted)
                {
                    textBox.Width += 10;
                    textBox.Location = new Point(textBox.Location.X - 11, textBox.Location.Y);
                    isTextBoxAdjusted = true;
                }
                else if (textBox.Text.Length <= 3 && isTextBoxAdjusted)
                {
                    textBox.Width = 82;
                    textBox.Location = new Point(textBox.Location.X + 11, textBox.Location.Y);
                    isTextBoxAdjusted = false;
                }
            }
        }
        // ------------------ SUMAS --------------------------
        public class SumOperation:MathOperation
        {
            public void PutTheActionOfTheSubIndice()
            {
                for (int i = 0; i < 20; i++)
                {
                    string SubIndice1 = "SubIndice_" + (i + 1) + "_1";
                    string SubIndice2 = "SubIndice_" + (i + 1) + "_2";
                    Control[] controlSubIndice1 = this.Controls.Find(SubIndice1, true);
                    Control[] controlSubIndice2 = this.Controls.Find(SubIndice2, true);
                    if (controlSubIndice1.Length > 0 && controlSubIndice1[0] is Label label)
                    {
                        label.MouseClick += SubIndiceL_MouseClick;
                        label.MouseClick += SubIndiceR_MouseClick;
                    }
                    if (controlSubIndice2.Length > 0 && controlSubIndice2[0] is Label label2)
                    {
                        label2.MouseClick += SubIndiceL_MouseClick;
                        label2.MouseClick += SubIndiceR_MouseClick;
                    }
                }
            }

            private void SubIndiceL_MouseClick(object sender, MouseEventArgs e)
            {
                if (sender is Label label)
                {
                    if(e.Button == MouseButtons.Left)
                    {
                        label.Text = "1";
                    }
                    
                }
            }

            private void SubIndiceR_MouseClick(object sender, MouseEventArgs e)
            {
                if (sender is Label label)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        label.Text = "-";
                    }
                }
            }
        }

        public void VerifiyOperation()
        {
            NumbersOfCorrects = 0;
            NumbersOfIncorrects = 0;
            string Correct = "Check Green.png";
            string Incorrect = "Cross Red.png";
            for (int i = 0; i < 10; i++)
            {
                //Aqui Buscamos el Picture de la operacion
                string PicOfTheOperation = "PicResultOperation_" + (i + 1);
                Control[] controlspics = this.Controls.Find(PicOfTheOperation, true);
                PictureBox PicOfResult = controlspics[0] as PictureBox;
                // Numeros de la operacion
                int NumberOne = Convert.ToInt32(AllNumbers[i].Text);
                Label label1 = AllNumbers[0] as Label;
                int NumberTwo = Convert.ToInt32(AllNumbers[i + 1].Text);
                Label label2 = AllNumbers[0] as Label;
                // Buscamos el resultado del txtbox, como todos se llamada "TxtBxResult_ y el numero, entonces usamos el Find para encontrarlos
                // Auntomaticamente
                string TxtBoxOfTheResult = "TxtBxResult_" + (i + 1);
                Control[] controlsresults = this.Controls.Find(TxtBoxOfTheResult, true);
                TextBox txtResult = controlsresults[0] as TextBox;
                int ResultOfTheUser = Convert.ToInt32(controlsresults[0].Text); // Aqui agarramos lo que encontro y lo pasamos a Int, porque lo agarara como string

                if (ResultOfTheUser == NumberOne + NumberTwo)
                {
                    txtResult.ReadOnly = true;
                    PicOfResult.Image = Image.FromFile(Correct);
                    NumbersOfCorrects += 1;
                }
                else
                {
                    txtResult.ReadOnly = false;
                    PicOfResult.Image = Image.FromFile(Incorrect);
                    NumbersOfIncorrects += 1;
                }
                AllNumbers.Remove(label1);
                AllNumbers.Remove(label2);
            }
        }
        // ------------------------------------------------------------------------------

        public class SubstractionOperation : MathOperation
        {
            public void AssignNumberSubs()
            {
                Random random = new Random();
                List<int> IntNum = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                // Buscar y limpiar los labels
                for (int i = 0; i < 10; i++)
                {
                    string labelname1 = "LblN1_" + (i + 1);
                    string labelname2 = "LblN2_" + (i + 1);

                    Control[] controls = this.Controls.Find(labelname1, true);
                    Control[] controls2 = this.Controls.Find(labelname2, true);

                    if (controls.Length > 0 && controls[0] is Label label1)
                    {
                        label1.Text = string.Empty;
                        AllNumbers.Add(label1);
                    }
                    if (controls2.Length > 0 && controls2[0] is Label label2)
                    {
                        label2.Text = string.Empty;
                        AllNumbers.Add(label2);
                    }
                }

                // Generar números
                for (int i = 0; i < 10; i++)
                {
                    int upperNumber = 0;
                    int lowerNumber = 0;

                    // Generar el número mayor de 3 dígitos
                    for (int j = 0; j < 3; j++)
                    {
                        int IndiceNum = random.Next(IntNum.Count);
                        upperNumber = upperNumber * 10 + IntNum[IndiceNum];
                    }

                    // Generar el número menor de 2 dígitos
                    for (int j = 0; j < 2; j++)
                    {
                        int IndiceNum = random.Next(IntNum.Count);
                        lowerNumber = lowerNumber * 10 + IntNum[IndiceNum];
                    }

                    // Asegurarse que el número menor sea menor o igual que el número mayor
                    while (lowerNumber > upperNumber)
                    {
                        lowerNumber = 0;
                        for (int j = 0; j < 2; j++)
                        {
                            int IndiceNum = random.Next(IntNum.Count);
                            lowerNumber = lowerNumber * 10 + IntNum[IndiceNum];
                        }
                    }

                    // Formatear los números para que estén alineados
                    string upperNumberStr = upperNumber.ToString("D3");
                    string lowerNumberStr = lowerNumber.ToString("D2");

                    // Asignar los números a los labels
                    AllNumbers[i * 2].Text = upperNumberStr;
                    AllNumbers[i * 2 + 1].Text = lowerNumberStr;
                }
            }

            public void VerifiyOperationSub()
            {
                NumbersOfCorrects = 0;
                NumbersOfIncorrects = 0;
                string Correct = "Check Green.png";
                string Incorrect = "Cross Red.png";
                for (int i = 0; i < 10; i++)
                {
                    //Aqui Buscamos el Pic de la operacion
                    string PicOfTheOperation = "PicResultOperation_" + (i + 1);
                    Control[] controlspics = this.Controls.Find(PicOfTheOperation, true);
                    PictureBox PicOfResult = controlspics[0] as PictureBox;
                    // Numeros de la operacion
                    int NumberOne = Convert.ToInt32(AllNumbers[i].Text);
                    Label label1 = AllNumbers[0] as Label;
                    int NumberTwo = Convert.ToInt32(AllNumbers[i + 1].Text);
                    Label label2 = AllNumbers[0] as Label;
                    // Buscamos el resultado del txtbox, como todos se llamada "TxtBxResult_ y el numero, entonces usamos el Find para encontrarlos
                    // Auntomaticamente
                    string TxtBoxOfTheResult = "TxtBxResult_" + (i + 1);
                    Control[] controlsresults = this.Controls.Find(TxtBoxOfTheResult, true);
                    TextBox txtResult = controlsresults[0] as TextBox;
                    int ResultOfTheUser = Convert.ToInt32(controlsresults[0].Text); // Aqui agarramos lo que encontro y lo pasamos a Int, porque lo agarara como string

                    if (ResultOfTheUser == NumberOne - NumberTwo)
                    {
                        txtResult.ReadOnly = true;
                        PicOfResult.Image = Image.FromFile(Correct);
                        NumbersOfCorrects += 1;
                    }
                    else
                    {
                        txtResult.ReadOnly = false;
                        PicOfResult.Image = Image.FromFile(Incorrect);
                        NumbersOfIncorrects += 1;
                    }
                    AllNumbers.Remove(label1);
                    AllNumbers.Remove(label2);
                }
            }


        }

        public class MultiplicationOperation : MathOperation
        {

            public void VerifiyOperationMult()
            {
                NumbersOfCorrects = 0;
                NumbersOfIncorrects = 0;
                string Correct = "Check Green.png";
                string Incorrect = "Cross Red.png";
                for (int i = 0; i < 10; i++)
                {
                    //Aqui Buscamos el Pic de la operacion
                    string PicOfTheOperation = "PicResultOperation_" + (i + 1);
                    Control[] controlspics = this.Controls.Find(PicOfTheOperation, true);
                    PictureBox PicOfResult = controlspics[0] as PictureBox;
                    // Numeros de la operacion
                    int NumberOne = Convert.ToInt32(AllNumbers[i].Text);
                    Label label1 = AllNumbers[0] as Label;
                    int NumberTwo = Convert.ToInt32(AllNumbers[i + 1].Text);
                    Label label2 = AllNumbers[0] as Label;
                    // Buscamos el resultado del txtbox, como todos se llamada "TxtBxResult_ y el numero, entonces usamos el Find para encontrarlos
                    // Auntomaticamente
                    string TxtBoxOfTheResult = "TxtBxResult_" + (i + 1);
                    Control[] controlsresults = this.Controls.Find(TxtBoxOfTheResult, true);
                    TextBox txtResult = controlsresults[0] as TextBox;
                    int ResultOfTheUser = Convert.ToInt32(controlsresults[0].Text); // Aqui agarramos lo que encontro y lo pasamos a Int, porque lo agarara como string

                    if (ResultOfTheUser == NumberOne * NumberTwo)
                    {
                        txtResult.ReadOnly = true;
                        PicOfResult.Image = Image.FromFile(Correct);
                        NumbersOfCorrects += 1;
                    }
                    else
                    {
                        txtResult.ReadOnly = false;
                        PicOfResult.Image = Image.FromFile(Incorrect);
                        NumbersOfIncorrects += 1;
                    }
                    AllNumbers.Remove(label1);
                    AllNumbers.Remove(label2);
                }
            }
            // -------------- LABELS ------------------------
            public void SubIndiceIncrent()
            {
                for (int i = 0; i < 20; i++)
                {
                    string SubIndice1 = "SubIndice_" + (i + 1) + "_1";
                    Control[] controlSubIndice1 = this.Controls.Find(SubIndice1, true);
                    if (controlSubIndice1.Length > 0 && controlSubIndice1[0] is Label label)
                    {
                        label.MouseClick += SubIndiceMultL_MouseClick;
                        label.MouseClick += SubIndiceMultR_MouseClick;
                    }
                }
            }

            private void SubIndiceMultL_MouseClick(object sender, MouseEventArgs e)
            {
                if (sender is Label label)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (label.Text == "-")
                        {
                            label.Text = "1";
                        }
                        else
                        {
                            if (Convert.ToInt32(label.Text) >= 1 && (Convert.ToInt32(label.Text) <= 8))
                                label.Text = Convert.ToString(Convert.ToInt32(label.Text) + 1);
                        }
                    }
                }
            }

            private void SubIndiceMultR_MouseClick(object sender, MouseEventArgs e)
            {
                if (sender is Label label)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        label.Text = "-";
                    }
                }
            }

            // --------------------------------------------------------------------
            public void AssingNumberMult()
            {
                for (int i = 0; i < 10; i++)
                {
                    string labelname1 = "LblN1_" + (i + 1);
                    string labelname2 = "LblN2_" + (i + 1);

                    Control[] controls = this.Controls.Find(labelname1, true);
                    Control[] controls2 = this.Controls.Find(labelname2, true);

                    if (controls.Length > 0 && controls[0] is Label label1)
                    {
                        label1.Text = string.Empty;
                        AllNumbers.Add(label1);
                    }
                    if (controls2.Length > 0 && controls2[0] is Label label2)
                    {
                        label2.Text = string.Empty;
                        AllNumbers.Add(label2);
                    }
                }

                for (int i = 0; i < 20; i++) 
                {
                    if (i % 2 == 0) 
                    {
                        AllNumbers[i].Text = Convert.ToString(random.Next(10,50));
                    }
                    else
                    {
                        AllNumbers[i].Text = Convert.ToString(random.Next(1,9));
                    }
                }
            }
        }
        public class DivisionOperation : MathOperation
        {

            public void GiveThePropertiesToTxtBoxDIV()
            {
                for (int i = 0; i < 10; i++)
                {
                    string TxtApoyo1 = "TxtApoyo1_" + (i + 1);
                    string TxtApoyo2 = "TxtApoyo2_" + (i + 1);
                    Control[] controlTxtBxApoyo1 = this.Controls.Find(TxtApoyo1, true);
                    Control[] controlTxtApoyo2 = this.Controls.Find(TxtApoyo2, true);
                    string TxtBoxName = "TxtBxResult_" + (i + 1);
                    Control[] controlTxtBx = this.Controls.Find(TxtBoxName, true);
                    if (controlTxtBx.Length > 0 && controlTxtBx[0] is TextBox TextBox)
                    {
                        
                        TextBox.KeyPress += textBoxLNumberDIV_KeyPress;
                    }
                    if (controlTxtBxApoyo1.Length > 0 && controlTxtBxApoyo1[0] is TextBox TextBox1)
                    {

                        TextBox1.KeyPress += textBoxLNumberDIV_KeyPress;
                    }
                    if (controlTxtApoyo2.Length > 0 && controlTxtApoyo2[0] is TextBox TextBox2)
                    {

                        TextBox2.KeyPress += textBoxLNumberDIV_KeyPress;
                    }
                }
            }
            private void textBoxLNumberDIV_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            public void VerifiyOperationDiv()
            {
                NumbersOfCorrects = 0;
                NumbersOfIncorrects = 0;
                string Correct = "Check Green.png";
                string Incorrect = "Cross Red.png";
                string Question = "Question Yellow.png";
                for (int i = 0; i < 10; i++)
                {
                    //Aqui Buscamos el Pic de la operacion
                    string PicOfTheOperation = "PicResultOperation_" + (i + 1);
                    Control[] controlspics = this.Controls.Find(PicOfTheOperation, true);
                    PictureBox PicOfResult = controlspics[0] as PictureBox;
                    // Numeros de la operacion
                    double NumberOne = Convert.ToInt32(AllNumbers[i].Text);
                    Label label1 = AllNumbers[0] as Label;
                    double NumberTwo = Convert.ToInt32(AllNumbers[i + 1].Text);
                    Label label2 = AllNumbers[0] as Label;
                    // Buscamos el resultado del txtbox, como todos se llamada "TxtBxResult_ y el numero, entonces usamos el Find para encontrarlos
                    // Auntomaticamente
                    string TxtBoxOfTheResult = "TxtBxResult_" + (i + 1);
                    Control[] controlsresults = this.Controls.Find(TxtBoxOfTheResult, true);
                    TextBox txtResult = controlsresults[0] as TextBox;
                    double ResultOfTheUser = Convert.ToDouble(controlsresults[0].Text); // Aqui agarramos lo que encontro y lo pasamos a Int, porque lo agarara como string
                    // Aqui buscamos los textbox de apoyo
                    string TxtApoyo1 = "TxtApoyo1_" + (i + 1);
                    string TxtApoyo2 = "TxtApoyo2_" + (i + 1);
                    Control[] controlTxtBxApoyo1 = this.Controls.Find(TxtApoyo1, true);
                    Control[] controlTxtApoyo2 = this.Controls.Find(TxtApoyo2, true);

                    // -------------------------------
                    string PreResult = Math.Truncate(NumberOne / NumberTwo).ToString("00");

                    // TextBox de Ayuda (Osea los resuidos)
                    double FirstTxtbx1 = Convert.ToDouble(NumberOne.ToString()[0].ToString()) - (Convert.ToDouble(PreResult[0].ToString()) * NumberTwo);
                    double SecundoTxtbx2 = Convert.ToDouble(NumberOne.ToString()[1].ToString());
                    string FirstTextBoxNumber = FirstTxtbx1.ToString() + SecundoTxtbx2.ToString();
                    //double FirstTxtbx1 = Convert.ToDouble(Convert.ToString(NumberOne)[0]) - (Convert.ToInt32(PreResult[0]) * NumberTwo);
                    //double SecundoTxtbx2 = Convert.ToDouble(Convert.ToString(NumberOne)[1]);
                    //string FirstTextBoxNumber = Convert.ToString(FirstTxtbx1) + Convert.ToString(SecundoTxtbx2);

                    double SecundoTxtbx = Convert.ToDouble(FirstTextBoxNumber) - (Convert.ToDouble(PreResult[1].ToString()) * NumberTwo);
                    // ----------------------
                    //string StringTxtBoxApoyo1 = Convert.ToString(controlTxtBxApoyo1[i]);
                    //string StringTxtBoxApoyo2 = Convert.ToString(controlTxtApoyo2[i]);
                    string StringTxtBoxApoyo1 = controlTxtBxApoyo1[0].Text;
                    string StringTxtBoxApoyo2 = controlTxtApoyo2[0].Text;

                    if (ResultOfTheUser == Math.Truncate(NumberOne / NumberTwo) && StringTxtBoxApoyo1 == FirstTextBoxNumber && StringTxtBoxApoyo2 == Convert.ToString(SecundoTxtbx))
                    {
                        txtResult.ReadOnly = true;
                        PicOfResult.Image = Image.FromFile(Correct);
                        NumbersOfCorrects += 1;
                    }
                    else if (ResultOfTheUser == Math.Truncate(NumberOne / NumberTwo) && (StringTxtBoxApoyo1 != FirstTextBoxNumber || StringTxtBoxApoyo2 != Convert.ToString(SecundoTxtbx)))
                    {
                        
                        txtResult.ReadOnly = false;
                        PicOfResult.Image = Image.FromFile(Question);
                        NumbersOfIncorrects += 1;
                    }
                    else
                    {
                        txtResult.ReadOnly = false;
                        PicOfResult.Image = Image.FromFile(Incorrect);
                        NumbersOfIncorrects += 1;
                    }
                    AllNumbers.Remove(label1);
                    AllNumbers.Remove(label2);
                }
            }
            public void AssingNumberDivision()
            {
                for (int i = 0; i < 10; i++)
                {
                    string labelname1 = "LblN1_" + (i + 1);
                    string labelname2 = "LblN2_" + (i + 1);

                    Control[] controls = this.Controls.Find(labelname1, true);
                    Control[] controls2 = this.Controls.Find(labelname2, true);

                    if (controls.Length > 0 && controls[0] is Label label1)
                    {
                        label1.Text = string.Empty;
                        AllNumbers.Add(label1);
                    }
                    if (controls2.Length > 0 && controls2[0] is Label label2)
                    {
                        label2.Text = string.Empty;
                        AllNumbers.Add(label2);
                    }
                }

                for (int i = 0; i < 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        AllNumbers[i].Text = Convert.ToString(random.Next(10, 80));
                    }
                    else
                    {
                        AllNumbers[i].Text = Convert.ToString(random.Next(1, 3));
                    }
                }
            }
        }
    }
}
