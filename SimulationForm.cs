using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GameOfLife
{
    public partial class SimulationForm : Form
    {
        bool DefaultFlag { get; set; } = false;
        Simulation GolSim { get; set; }
        public SimulationForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            radio100.Checked = true;
            radioAll.Checked = true;
            GolSim = new Simulation(radioCorner.Checked);
        }

        private void simGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Visible = !main.Visible;
        }

        private async void simExitButton_Click(object sender, EventArgs e)
        {
            simExitButton.UseWaitCursor = true;
            await Task.Delay(TimeSpan.FromSeconds(2)); // Wait for two seconds
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            simulation.Text = AsciArt.Artify(GolSim);
            genLabel.Text = "Generation: " + GolSim.GetGeneration();
            GolSim.Tick();
        }

        private void sizeOKButton_Click(object sender, EventArgs e)
        {
            
            int rows = (int)numericUpDownValue.Value;
            int columns = (int)numericUpDownValue.Value;
            GolSim = new Simulation(radioCorner.Checked, rows, columns);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            simulation.Visible = false;
            pauseButton.Visible = false;
            DefaultFlag = true;
            button1.Text = "SIMULATE!";
            button1.BackColor = Color.ForestGreen;
            radio100.Checked = true;
            radioAll.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!simulation.Visible)
            {
                pauseButton.Visible = true;
                //pauseButton.Text = "PAUSE";
                button1.Text = "GAME OVER";
                button1.BackColor = Color.Red;

                if (DefaultFlag)
                {
                    GolSim = new Simulation(radioCorner.Checked);
                }
                else
                {
                    int size = (int)numericUpDownValue.Value;
                    GolSim = new Simulation(radioCorner.Checked, size, size);
                }


                if (radio1000.Checked) //checking the radio button selected
                {
                    timer.Interval = 500; //2 ticks per second
                }
                else
                {
                    timer.Interval = 10; //100 ticks per second
                }
                timer.Enabled = true;
                DefaultFlag = false;
                genLabel.Text = "Generation: " + GolSim.GetGeneration();
                timerLabel.Text = "Tick is set to " + timer.Interval + " ms/generation.";
            }
            else
            {
                button1.Text = "SIMULATE!";
                pauseButton.Visible = false;
                button1.BackColor = Color.ForestGreen;
                timer.Enabled = false;
            }
            simulation.Visible = !simulation.Visible;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled; //switching pause and resume
            if (timer.Enabled)
            {
                pauseButton.Text = "PAUSE";
            }
            else
            {
                pauseButton.Text = "RESUME";
            }
        }
    }
}