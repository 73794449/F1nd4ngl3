using System;
using System.Windows.Forms;
namespace FindCinABC
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (this.TopMost.Equals(false))
            {
                this.TopMost = true;
                button4.BackColor = System.Drawing.Color.Aqua;
            }
            else
            {
                this.TopMost = false;
                button4.BackColor = System.Drawing.Color.White;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            double[] BCvect = new double[3] { Convert.ToInt32(CX.Text)
                - Convert.ToInt32(BX.Text), Convert.ToInt32(CY.Text)
                - Convert.ToInt32(BY.Text), Convert.ToInt32(CZ.Text)
                - Convert.ToInt32(BZ.Text) };
            double[] ACvect = new double[3] { Convert.ToInt32(CX.Text)
                - Convert.ToInt32(AX.Text), Convert.ToInt32(CY.Text)
                - Convert.ToInt32(AY.Text), Convert.ToInt32(CZ.Text)
                - Convert.ToInt32(AZ.Text) };
            double BCmodule = Math.Sqrt(Math.Pow(BCvect[0], 2) + Math.Pow(BCvect[1], 2) + Math.Pow(BCvect[2], 2));
            double ACmodule = Math.Sqrt(Math.Pow(ACvect[0], 2) + Math.Pow(ACvect[1], 2) + Math.Pow(ACvect[2], 2));
            double result = Math.Acos((BCvect[0] * ACvect[0] + BCvect[1] * ACvect[1] + BCvect[2] * ACvect[2]) / (BCmodule * ACmodule));
            label7.Text = "vector BC = {"
                + BCvect[0].ToString()
                + ", "
                + BCvect[1].ToString()
                + ", "
                + BCvect[2].ToString()
                + "}";
            label8.Text = "vector AC = {"
                + ACvect[0].ToString()
                + ", "
                + ACvect[1].ToString()
                + ", "
                + ACvect[2].ToString()
                + "}";
            label9.Text = "module vector BC = sqrt("
                + Math.Pow(BCvect[0], 2).ToString()
                + " + "
                + Math.Pow(BCvect[1], 2).ToString()
                + " + "
                + Math.Pow(BCvect[2], 2).ToString()
                + ") = "
                + BCmodule.ToString();
            label10.Text = "module vector AC = sqrt("
                + Math.Pow(ACvect[0], 2).ToString()
                + " + "
                + Math.Pow(ACvect[1], 2).ToString()
                + " + "
                + Math.Pow(ACvect[2], 2).ToString()
                + ") = "
                + ACmodule.ToString();
            label11.Text = "vector BC * vector AC = "
                + BCvect[0].ToString()
                + " * "
                + ACvect[0].ToString()
                + " + "
                + BCvect[1].ToString()
                + " * "
                + ACvect[1].ToString()
                + " + "
                + BCvect[2].ToString()
                + " * "
                + ACvect[2].ToString()
                + " = "
                + (BCvect[0] * ACvect[0] + BCvect[1] * ACvect[1] + (BCvect[2] * ACvect[2])).ToString();
            RESCOS.Text = "cos C = (vector BC * vector AC)/\n             (module vector BC * module vector AC)" + "\n          = " + ((BCvect[0] * ACvect[0] + BCvect[1] * ACvect[1] + BCvect[2] * ACvect[2]) / (BCmodule * ACmodule)).ToString();
            CResult.Text = result.ToString();
            label12.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] BAvect = new double[3] { Convert.ToInt32(AX.Text)
                - Convert.ToInt32(BX.Text), Convert.ToInt32(AY.Text)
                - Convert.ToInt32(BY.Text), Convert.ToInt32(AZ.Text)
                - Convert.ToInt32(BZ.Text) };
            double[] CAvect = new double[3] { Convert.ToInt32(AX.Text)
                - Convert.ToInt32(CX.Text), Convert.ToInt32(AY.Text)
                - Convert.ToInt32(CY.Text), Convert.ToInt32(AZ.Text)
                - Convert.ToInt32(CZ.Text) };
            double BAmodule = Math.Sqrt(Math.Pow(BAvect[0], 2) + Math.Pow(BAvect[1], 2) + Math.Pow(BAvect[2], 2));
            double CAmodule = Math.Sqrt(Math.Pow(CAvect[0], 2) + Math.Pow(CAvect[1], 2) + Math.Pow(CAvect[2], 2));
            double result = Math.Acos((BAvect[0] * CAvect[0] + BAvect[1] * CAvect[1] + BAvect[2] * CAvect[2]) / (BAmodule * CAmodule));
            label7.Text = "vector BA = {"
                + BAvect[0].ToString()
                + ", "
                + BAvect[1].ToString()
                + ", "
                + BAvect[2].ToString()
                + "}";
            label8.Text = "vector CA = {"
                + CAvect[0].ToString()
                + ", "
                + CAvect[1].ToString()
                + ", "
                + CAvect[2].ToString()
                + "}";
            label9.Text = "module vector BA = sqrt("
                + Math.Pow(BAvect[0], 2).ToString()
                + " + "
                + Math.Pow(BAvect[1], 2).ToString()
                + " + "
                + Math.Pow(BAvect[2], 2).ToString()
                + ") = "
                + BAmodule.ToString();
            label10.Text = "module vector CA = sqrt("
                + Math.Pow(CAvect[0], 2).ToString()
                + " + "
                + Math.Pow(CAvect[1], 2).ToString()
                + " + "
                + Math.Pow(CAvect[2], 2).ToString()
                + ") = "
                + CAmodule.ToString();
            label11.Text = "vector BA * vector CA = "
                + BAvect[0].ToString()
                + " * "
                + CAvect[0].ToString()
                + " + "
                + BAvect[1].ToString()
                + " * "
                + CAvect[1].ToString()
                + " + "
                + BAvect[2].ToString()
                + " * "
                + CAvect[2].ToString()
                + " = "
                + (BAvect[0] * CAvect[0] + BAvect[1] * CAvect[1] + (BAvect[2] * CAvect[2])).ToString();
            RESCOS.Text = "cos A = (vector BA * vector CA)/\n             (module vector BA * module vector CA)" + "\n          = " + ((BAvect[0] * CAvect[0] + BAvect[1] * CAvect[1] + BAvect[2] * CAvect[2]) / (BAmodule * CAmodule)).ToString();
            AResult.Text = result.ToString();
            label12.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] ABvect = new double[3] { Convert.ToInt32(AX.Text)
                - Convert.ToInt32(BX.Text), Convert.ToInt32(AY.Text)
                - Convert.ToInt32(BY.Text), Convert.ToInt32(AZ.Text)
                - Convert.ToInt32(BZ.Text) };
            double[] CBvect = new double[3] { Convert.ToInt32(AX.Text)
                - Convert.ToInt32(CX.Text), Convert.ToInt32(AY.Text)
                - Convert.ToInt32(CY.Text), Convert.ToInt32(AZ.Text)
                - Convert.ToInt32(CZ.Text) };
            double ABmodule = Math.Sqrt(Math.Pow(ABvect[0], 2) + Math.Pow(ABvect[1], 2) + Math.Pow(ABvect[2], 2));
            double CBmodule = Math.Sqrt(Math.Pow(CBvect[0], 2) + Math.Pow(CBvect[1], 2) + Math.Pow(CBvect[2], 2));
            double result = Math.Acos((ABvect[0] * CBvect[0] + ABvect[1] * CBvect[1] + ABvect[2] * CBvect[2]) / (ABmodule * CBmodule));
            label7.Text = "vector AB = {"
                + ABvect[0].ToString()
                + ", "
                + ABvect[1].ToString()
                + ", "
                + ABvect[2].ToString()
                + "}";
            label8.Text = "vector CB = {"
                + CBvect[0].ToString()
                + ", "
                + CBvect[1].ToString()
                + ", "
                + CBvect[2].ToString()
                + "}";
            label9.Text = "module vector AB = sqrt("
                + Math.Pow(ABvect[0], 2).ToString()
                + " + "
                + Math.Pow(ABvect[1], 2).ToString()
                + " + "
                + Math.Pow(ABvect[2], 2).ToString()
                + ") = "
                + ABmodule.ToString();
            label10.Text = "module vector CB = sqrt("
                + Math.Pow(CBvect[0], 2).ToString()
                + " + "
                + Math.Pow(CBvect[1], 2).ToString()
                + " + "
                + Math.Pow(CBvect[2], 2).ToString()
                + ") = "
                + CBmodule.ToString();
            label11.Text = "vector AB * vector CB = "
                + ABvect[0].ToString()
                + " * "
                + CBvect[0].ToString()
                + " + "
                + ABvect[1].ToString()
                + " * "
                + CBvect[1].ToString()
                + " + "
                + ABvect[2].ToString()
                + " * "
                + CBvect[2].ToString()
                + " = "
                + (ABvect[0] * CBvect[0] + ABvect[1] * CBvect[1] + (ABvect[2] * CBvect[2])).ToString();
            RESCOS.Text = "cos A = (vector AB * vector CB)/\n             (module vector AB * module vector CB)" + "\n          = " + ((ABvect[0] * CBvect[0] + ABvect[1] * CBvect[1] + ABvect[2] * CBvect[2]) / (ABmodule * CBmodule)).ToString();
            BResult.Text = result.ToString();
            label12.Text = "";
        }
    }
}
