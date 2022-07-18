using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Main : Form
    {
        public Main()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            //loading.ImageLocation = "D:\\Semestr 3\\Komponent\\GameOfLife\\GameOfLifeWForms\\assets\\images\\loading.gif";
            loading.ImageLocation = "D:\\Semestr 3\\Komponent\\GameOfLife\\GameOfLifeWForms\\assets\\images\\loading.gif";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            loading.Visible = !loading.Visible;
            exit.UseWaitCursor = true;
            await Task.Delay(TimeSpan.FromSeconds(2)); // Wait for two seconds
            Application.Exit();
        }
        private void wiki_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            //this.Opacity = 0;
            //this.ShowInTaskbar = false;
            WikiForm wikiForm = new WikiForm();
            wikiForm.ShowDialog(this);
        }

        private void simulation_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            //this.Opacity = 0;
            //this.ShowInTaskbar = false;
            SimulationForm simulationForm = new SimulationForm();
            simulationForm.ShowDialog(this);
        }
    }
}

