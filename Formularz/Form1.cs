namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label4.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string email = textBox1.Text;
            string haslo = textBox2.Text;
            string phaslo = textBox3.Text;
            string x = radioButton1.Checked ? "ma³a" : "0";
            string y = radioButton2.Checked ? "œrednia" : "0";
            string z = radioButton3.Checked ? "du¿a" : "0";

            if (email.Length < 1)
            {
                label4.ForeColor = Color.Red;
                label4.Text += "Wype³nij pole E-Mail!";
            }
            if (haslo.Length >= 1)
            {
                label8.Text = "E-mail: "+ email;
            }

            if (haslo != phaslo && haslo.Length > 8)
            {
                label5.ForeColor = Color.Red;
                label5.Text += "Has³a nie s¹ identyczne lub nie maj¹ min. 8 znaków!";
            }
            if (haslo != "0")
            {
                label9.Text = "Has³o: " + haslo;
            }
            if(radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                label11.Text = "Znajomoœæ C#: " + x + y + z;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            label10.Text = "Zgoda wyra¿ona.";
        }
    }
}