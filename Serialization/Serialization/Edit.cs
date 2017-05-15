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
    }
}
