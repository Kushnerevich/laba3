﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Serialization.ClassOfAnimals;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public partial class Form1 : Form
    {
        public List<dynamic> Animals = new List<dynamic>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Animals.Add(new Mammals(textBox1.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox2.Text.ToString(), textBox6.Text.ToString(), "Mammals"));
            ShowTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animals.Add(new Birds(textBox7.Text.ToString(), textBox8.Text.ToString(), textBox10.Text.ToString(), textBox11.Text.ToString(), textBox12.Text.ToString(), "Birds"));
            ShowTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animals.Add(new Fishs(textBox13.Text.ToString(), textBox14.Text.ToString(), textBox16.Text.ToString(), textBox17.Text.ToString(), textBox15.Text.ToString(), "Fishs"));
            ShowTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animals.Add(new Insects(textBox19.Text.ToString(), textBox20.Text.ToString(), textBox22.Text.ToString(), textBox23.Text.ToString(), textBox21.Text.ToString(), "Insects"));
            ShowTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animals.Add(new Reptiles(textBox25.Text.ToString(), textBox26.Text.ToString(), textBox28.Text.ToString(), textBox29.Text.ToString(), textBox27.Text.ToString(), "Reptiles"));
            ShowTable();
        }

        public void ShowTable()
        {

            if (Animals.Count != 0)
            {
                dataGridView1.ColumnCount = 5;
                dataGridView1.RowCount = Animals.Count;

                dataGridView1.Columns[0].HeaderCell.Value = "Вес";
                dataGridView1.Columns[1].HeaderCell.Value = "Рост";
                dataGridView1.Columns[2].HeaderCell.Value = "Тип питания";
                dataGridView1.Columns[3].HeaderCell.Value = "Цвет глаз";
                dataGridView1.Columns[4].HeaderCell.Value = "Доп. свойство";
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = Animals[i].Weight;
                    dataGridView1.Rows[i].Cells[1].Value = Animals[i].Growth;
                    dataGridView1.Rows[i].Cells[2].Value = Animals[i].TypeOfFood;
                    dataGridView1.Rows[i].Cells[3].Value = Animals[i].ColorOfEyes;
                    string type = Animals[i].TypeOfAnimal;
                    switch (type)
                    {
                        case "Mammals":
                            dataGridView1.Rows[i].Cells[4].Value = Animals[i].Hairline;
                            break;
                        case "Birds":
                            dataGridView1.Rows[i].Cells[4].Value = Animals[i].ColorOfPlumage;
                            break;
                        case "Fishs":
                            dataGridView1.Rows[i].Cells[4].Value = Animals[i].ColorOfScales;
                            break;
                        case "Insects":
                            dataGridView1.Rows[i].Cells[4].Value = Animals[i].GroupOfInsects;
                            break;
                        case "Reptiles":
                            dataGridView1.Rows[i].Cells[4].Value = Animals[i].Sex;
                            break;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();

            mySaveFileDialog.InitialDirectory = ".";
            mySaveFileDialog.Filter = "Animals files (*.txt)|*.txt|All files(*.*)|*.*";
            mySaveFileDialog.FilterIndex = 1;
            mySaveFileDialog.RestoreDirectory = true;
            mySaveFileDialog.FileName = "Animals";
            if (mySaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream mystream = mySaveFileDialog.OpenFile();
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    serializer.Serialize(mystream, Animals);
                }
                catch (Exception name)
                {
                    MessageBox.Show("Файл не сохранен" + name.Message);
                }
                finally
                {
                    mystream.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();

            myOpenFileDialog.InitialDirectory = ".";
            myOpenFileDialog.Filter = "Animals files (*.txt)|*.txt|All files(*.*)|*.*";
            myOpenFileDialog.FilterIndex = 1;
            myOpenFileDialog.RestoreDirectory = true;

            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Animals.Clear();
                Stream mystream = myOpenFileDialog.OpenFile();
                try
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Animals = deserializer.Deserialize(mystream) as List<dynamic>;
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось загрузить файл");
                }
                finally
                {
                    mystream.Close();
                    ShowTable();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Animals.Clear();
            dataGridView1.Rows.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите строку которую хотите изменить в таблице.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
                    int numToChange = e.RowIndex;
                    string LastPropety="";
                    string type = Animals[numToChange].type;

                    switch (type)
                    {
                        case "Mammals":
                            LastPropety = "Волосяной покров";
                            break;
                        case "Birds":
                            LastPropety = "Цвет оперения";
                            break;
                        case "Fishs":
                            LastPropety = "Цвет чешуи";
                            break;
                        case "Insect":
                            LastPropety = "Группы насекомых";
                            break;
                        case "Reptiles": 
                            LastPropety = "Пол";
                            break;
                    }
                    Edit ChangeForm = new Edit(Animals, numToChange, this, LastPropety);

               }
           }
       }
}

            
        

