using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace GameOfLife
{
    public partial class SimulationForm : Form
    {
        public SimulationForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            radio100.Checked = true;
            radioAll.Checked = true;
            //TODO WIKI
            //TODO Google Easter egg link
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
            Print(grid);
            grid = NextGeneration(grid);
        }

        public enum Status
        {
            Dead,
            Alive,
        }

        Status[,] grid;
        int rows = 78;
        int columns = 160;
        public void Setup()
        {
            grid = new Status[rows, columns];

            // randomly initialize our grid
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    var random = new Random();
                    //grid[row, column] = (Status) RandomNumberGenerator.GetInt32(0, 2);
                    if(radioCorner.Checked)
                    {
                        if (column < 50 && row < 50) //option to start from corner
                        {
                            grid[row, column] = (Status)random.Next(0, 2);
                        }
                    }
                    else
                    {
                        if (column < columns && row < rows) //option to start from everywhere
                        {
                            grid[row, column] = (Status)random.Next(0, 2);
                        }
                    }
                }
            }
        }

        int genCounter = 0;

        private Status[,] NextGeneration(Status[,] currentGrid)
        {
            var nextGeneration = new Status[rows, columns];

            // Loop through every cell 
            for (var row = 1; row < rows - 1; row++)
                for (var column = 1; column < columns - 1; column++)
                {
                    // find your alive neighbors
                    var aliveNeighbors = 0;
                    for (var i = -1; i <= 1; i++)
                    {
                        for (var j = -1; j <= 1; j++)
                        {
                            aliveNeighbors += currentGrid[row + i, column + j] == Status.Alive ? 1 : 0;
                        }
                    }

                    var currentCell = currentGrid[row, column];

                    // The cell needs to be subtracted 
                    // from its neighbors as it was  
                    // counted before 
                    aliveNeighbors -= currentCell == Status.Alive ? 1 : 0;

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if (currentCell == Status.Alive && aliveNeighbors < 2)
                    {
                        nextGeneration[row, column] = Status.Dead;
                    }

                    // Cell dies due to over population 
                    else if (currentCell == Status.Alive && aliveNeighbors > 3)
                    {
                        nextGeneration[row, column] = Status.Dead;
                    }

                    // A new cell is born 
                    else if (currentCell == Status.Dead && aliveNeighbors == 3)
                    {
                        nextGeneration[row, column] = Status.Alive;
                    }
                    // stays the same
                    else
                    {
                        nextGeneration[row, column] = currentCell;
                    }
                }
            genCounter++;
            genLabel.Text = "Generation: " + genCounter;
            return nextGeneration;
        }

        private void Print(Status[,] future)
        {
            var stringBuilder = new StringBuilder();
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    var cell = future[row, column];
                    stringBuilder.Append(cell == Status.Alive ? "•" : " ");
                }
                stringBuilder.Append("\n");
            }

            simulation.Text = stringBuilder.ToString();
        }

        private void sizeOKButton_Click(object sender, EventArgs e)
        {
            rows = Int32.Parse(valueInput.Text);
            columns = Int32.Parse(valueInput.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            simulation.Visible = false;
            valueInput.Text = "";
            pauseButton.Visible = false;
            button1.Text = "SIMULATE!";
            button1.BackColor = Color.ForestGreen;
            genCounter = 0;
            rows = 78;
            columns = 160;
            // 78 rows and 160 columns is ideal for window resolution
            radio100.Checked = true;
            radioAll.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pauseButton.Visible = false;
            button1.Text = "SIMULATE!";
            genCounter = 0;
            if (!simulation.Visible)
            {
                pauseButton.Visible = true;
                pauseButton.Text = "PAUSE";
                button1.Text = "GAME OVER";
                button1.BackColor = Color.Red;
                Setup();
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
                button1.Text = "SIMULATE!";
                pauseButton.Visible = false;
                button1.BackColor = Color.ForestGreen;
                timer.Enabled = false;
            }
            simulation.Visible = !simulation.Visible;
            genLabel.Text = "Generation: "+ genCounter;
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