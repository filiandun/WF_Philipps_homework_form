using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            whatRadioButton.Checked = true;
            completeButton.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле с фамилией!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле с именем!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (patronymicTextBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле с отчеством!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (surnameTextBox.Text == "" || nameTextBox.Text == "" || patronymicTextBox.Text == "")
            //{
            //    MessageBox.Show("Вы не заполнили поле с фамилией!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

    }
}
