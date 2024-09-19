using BaiTap1___NET.BusinessLogicLayer;
using BaiTap1___NET.DataAccessLayer;
using BaiTap1___NET.DataAccessLayer.DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1___NET
{
    public partial class MainForm : Form
    {
        private AnimalLogic animalLogic;
        private string textCow;
        private string textSheep;
        private string textGoat;
        private int countCow;
        private int countSheep;
        private int countGoat;
        private bool canStatistical;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            animalLogic = new AnimalLogic();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            List<DataThongKe> data;
            ValidateData();
            if (canStatistical)
                data = animalLogic.Statistical(countCow, countSheep, countGoat);
            else
                return;

            dataGrid.DataSource = data; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textCow = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textSheep = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textGoat = textBox3.Text;
        }

        private void ValidateData()
        {
            if (!int.TryParse(textCow, out _))
            {
                MessageBox.Show("Please enter a valid number for Cow.");
                canStatistical = false;

            }
            else if (!int.TryParse(textSheep, out _))
            {
                MessageBox.Show("Please enter a valid number for Sheep.");
                canStatistical = false;

            }
            else if (!int.TryParse(textGoat, out _))
            {
                MessageBox.Show("Please enter a valid number for Goat.");
                canStatistical = false;

            }
            else
            {
                countCow = int.Parse(textBox1.Text);
                countSheep = int.Parse(textBox2.Text);
                countGoat = int.Parse(textBox3.Text);
                Debug.WriteLine(countCow.ToString() + countSheep.ToString() + countGoat.ToString());
                canStatistical = true;
            }
        }
    }
}
