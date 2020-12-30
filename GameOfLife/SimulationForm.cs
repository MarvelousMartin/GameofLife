using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GameOfLife
{
    public partial class SimulationForm : Form
    {

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
            numericUpDownValue.Value = 0;
            simulationButton.Text = "SIMULATE!";
            simulationButton.BackColor = Color.ForestGreen;
            GolSim = new Simulation(radioCorner.Checked);
            // 78 rows and 160 columns is ideal for window resolution
            radio100.Checked = true;
            radioAll.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pauseButton.Visible = false;
            simulationButton.Text = "SIMULATE!";
            GolSim = new Simulation(radioCorner.Checked);
            if (!simulation.Visible)
            {
                pauseButton.Visible = true;
                pauseButton.Text = "PAUSE";
                simulationButton.Text = "GAME OVER";
                simulationButton.BackColor = Color.Red;
                if (radio1000.Checked) //checking the radio button selected
                {
                    timer.Interval = 500; //2 ticks per second
                }
                else
                {
                    timer.Interval = 10; //100 ticks per second
                }
                timer.Enabled = true;
            }
            else
            {
                simulationButton.Text = "SIMULATE!";
                pauseButton.Visible = false;
                simulationButton.BackColor = Color.ForestGreen;
                timer.Enabled = false;
            }
            simulation.Visible = !simulation.Visible;
            genLabel.Text = "Generation: "+ GolSim.GetGeneration();
            timerLabel.Text = "Tick is set to " + timer.Interval + " ms/generation.";
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