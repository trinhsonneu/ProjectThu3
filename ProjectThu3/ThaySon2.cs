using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectThu3
{
    public partial class ThaySon2 : Form
    {
        double a, b, c, d, x1, x2;
        public ThaySon2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txta.Text);
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                d = b * b - 4 * a * c;
                if (d < 0)
                {
                    //  MessageBox.Show("Phương trình vô nghiệm");
                    lblkq.Text = "Phương trình vô nghiệm";
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    //  MessageBox.Show("Phương trình có nghiệm kép: x1=x2=" + x1);
                    lblkq.Text = "Phương trình có nghiệm kép: x1=x2=" + Math.Round(x1, 1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    //  MessageBox.Show("Phương trình có 2 nghiệm phân biệt: x1=" + x1 + " và x2=" + x2);
                    lblkq.Text = "Phương trình có 2 nghiệm phân biệt: x1=" + Math.Round(x1, 1) + " và x2=" + Math.Round(x2, 1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ");
            }
        }
    }
}
    

