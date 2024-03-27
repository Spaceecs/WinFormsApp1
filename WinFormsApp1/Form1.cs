namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double count = 0, res = 0;
        int selectedIndex2 = 0;
        int selectedIndex1 = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("�");
                comboBox1.Items.Add("��");
                comboBox1.Items.Add("�");
                comboBox2.Items.Clear();
                comboBox2.Items.Add("�");
                comboBox2.Items.Add("��");
                comboBox2.Items.Add("�");
            }
            else if (radioButton2.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("��");
                comboBox1.Items.Add("��");
                comboBox1.Items.Add("�");
                comboBox2.Items.Clear();
                comboBox2.Items.Add("��");
                comboBox2.Items.Add("��");
                comboBox2.Items.Add("�");
            }
            else if (radioButton3.Checked)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("�");
                comboBox1.Items.Add("��");
                comboBox1.Items.Add("��");
                comboBox2.Items.Clear();
                comboBox2.Items.Add("�");
                comboBox2.Items.Add("��");
                comboBox2.Items.Add("��");
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex2 = comboBox2.SelectedIndex;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (double.TryParse(textBox2.Text, out count))
            {
                if (selectedIndex1 != -1)
                {
                    if (radioButton1.Checked)
                    {
                        switch (selectedIndex2)
                        {
                            case 0:
                                count = count / 1000;
                                break;
                            case 1:
                                break;
                            case 2:
                                count = count / 1000000;
                                break;
                            default:
                                break;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        switch (selectedIndex2)
                        {
                            case 0:
                                count = count / 1000;
                                break;
                            case 1:
                                count = count / 100;
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        switch (selectedIndex2)
                        {
                            case 0:
                                count = count / 1000000;
                                break;
                            case 1:
                                count = count / 10000;
                                break;
                            case 2:
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            if (selectedIndex1 != -1)
            {
                if (radioButton1.Checked)
                {
                    switch (selectedIndex1)
                    {
                        case 0:
                            res = count * 1000;
                            break;
                        case 1:
                            res = count;
                            break;
                        case 2:
                            res = count * 1000000;
                            break;
                        default:
                            break;
                    }
                }
                else if (radioButton2.Checked)
                {
                    switch (selectedIndex1)
                    {
                        case 0:
                            res = count * 1000;
                            break;
                        case 1:
                            res = count * 100;
                            break;
                        case 2:
                            res = count;
                            break;
                        default:
                            break;
                    }
                }
                else if (radioButton3.Checked)
                {
                    switch (selectedIndex1)
                    {
                        case 0:
                            res = count * 1000000;
                            break;
                        case 1:
                            res = count * 10000;
                            break;
                        case 2:
                            res = count;
                            break;
                        default:
                            break;
                    }
                }
            }
            textBox1.Text = res.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex1 = comboBox1.SelectedIndex;
        }
    }
}
