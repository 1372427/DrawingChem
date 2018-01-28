using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingChem
{
    public partial class MainForm : Form
    {
        private ChemData data;

        public MainForm()
        {
            InitializeComponent();

            data = new ChemData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        

        private void SearchCompound(object sender, EventArgs e)
        {

        }

        private Drawer d = new Drawer();

        private void DrawCompound_Click(object sender, EventArgs e)
        {
            output.Text = d.Draw(input.Text);
        }

        private void SearchEl_Click(object sender, EventArgs e)
        {
            if(data.ElementExist(input.Text))output.Text = data.FindElement(input.Text).ToString();   
        }
    }
}
