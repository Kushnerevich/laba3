using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serialization
{
    public partial class Edit : Form
    {
        List<dynamic> Animals;
        int Number;
        Form1 MainForm;
        string LastProperty;

        public Edit(List<dynamic> animals, int number, Form1 mainForm, string lastPropetry)
        {
            InitializeComponent();
            Animals = animals;
            Number = number;
            MainForm = mainForm;
            LastProperty = lastPropetry;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            label5.Text = LastProperty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animals[Number].Weight=textBox1.Text;
            Animals[Number].Growth=textBox2.Text;
            Animals[Number].ColorOfEyes=textBox3.Text;
            Animals[Number].TypeOfFood = textBox4.Text;

            string type = Animals[Number].TypeOfFood;
            switch (type)
            {
                case "Mammals":
                    Animals[Number].Hairline = textBox5.Text;
                    break;
                case "Birds":
                    Animals[Number].ColorOfPlumage = textBox5.Text;
                    break;
                case "Fishs":
                    Animals[Number].ColorOfScales = textBox5.Text;
                    break;
                case "Insect":
                    Animals[Number].GroupOfInsects = textBox5.Text;
                    break;
                case "Reptiles":
                    Animals[Number].Sex = textBox5.Text;
                    break;
            }
            MainForm.ShowTable();
            this.Dispose();
        }
    }
}
