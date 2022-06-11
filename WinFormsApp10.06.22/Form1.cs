using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10._06._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLoad.Click += btnLoad_Click;
            //btnEdit.Click += btnEdit_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            btnEdit.Enabled = false;
        }
        public Form1(FormEdit edit)
        {
            InitializeComponent();
            textBox1.Text=edit.textForEdition.Text;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                btnEdit.Enabled =false;
            else
                btnEdit.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormEdit edit = new FormEdit();
            edit.textForEdition.Text = textBox1.Text;
            edit.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
