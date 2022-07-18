using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class WikiForm : Form
    {
        public WikiForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            abstractLabel.Text = "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970.\n" +
                "It is a zero-player game, meaning that its evolution is determined by its initial state, requiring no further input. One interacts with the Game\n" +
                "of Life by creating an initial configuration and observing how it evolves. It is Turing complete and can simulate a universal constructor\n" +
                "or any other Turing machine.";

            rulesLabel.Text = "The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells, each of which is in one\n" +
                "of two possible states, live or dead, (or populated and unpopulated, respectively). Every cell interacts with its eight neighbours, \n" +
                "which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, the following transitions occur:\n\n" +
                "Any live cell with fewer than two live neighbours dies, as if by underpopulation.\n" +
                "Any live cell with two or three live neighbours lives on to the next generation.\n" +
                "Any live cell with more than three live neighbours dies, as if by overpopulation.\n" +
                "Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.\n" +
                "These rules, which compare the behavior of the automaton to real life, can be condensed into the following:\n\n" +
                "Any live cell with two or three live neighbours survives.\n" +
                "Any dead cell with three live neighbours becomes a live cell.\n" +
                "All other live cells die in the next generation.Similarly, all other dead cells stay dead.\n" +
                "The initial pattern constitutes the seed of the system.The first generation is created by applying the above rules simultaneously to every cell\n" +
                "in the seed; births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick. Each generation\n" +
                "is a pure function of the preceding one.The rules continue to be applied repeatedly to create further generations.";

            originsLabel.Text = "In late 1940, John von Neumann defined life as a creation (as a being or organism) which can reproduce itself and simulate a\n" +
                "Turing machine. Von Neumann was thinking about an engineering solution which would use electromagnetic components floating randomly in\n" +
                "liquid or gas. This turned out not to be realistic with the technology available at the time. Stanislaw Ulam invented cellular automata,\n" +
                "which were intended to simulate von Neumann's theoretical electromagnetic constructions. Ulam discussed using computers to simulate his\n" +
                "cellular automata in a two-dimensional lattice in several papers. In parallel, von Neumann attempted to construct Ulam's cellular automaton.\n" +
                "Although successful, he was busy with other projects and left some details unfinished. His construction was complicated because it tried to\n" +
                "simulate his own engineering design. Over time, simpler life constructions were provided by other researchers, and published in papers and books.\n\n" +
                "Motivated by questions in mathematical logic and in part by work on simulation games by Ulam, among others, John Conway began doing experiments\n" +
                "in 1968 with a variety of different two-dimensional cellular automaton rules.Conway's initial goal was to define an interesting and unpredictable\n" +
                "cell automaton. For example, he wanted some configurations to last for a long time before dying and other configurations to go on forever without\n" +
                "allowing cycles. It was a significant challenge and an open problem for years before experts on cellular automata managed to prove that, indeed,\n" +
                "the Game of Life admitted of a configuration which was alive in the sense of satisfying Von Neumann's two general requirements.\n" +
                "While the definitions before the Game of Life were proof-oriented, Conway's construction aimed at simplicity without a priori providing proof the automaton was alive.";

            betLabel.Text = "Conway originally conjectured that no pattern can grow indefinitely—i.e. that for any initial configuration with a finite number of living cells,\n" +
                "the population cannot grow beyond some finite upper limit. In the game's original appearance in Mathematical Games, Conway offered a prize of fifty dollars\n" +
                "to the first person who could prove or disprove the conjecture before the end of 1970. The prize was won in November by a team from the Massachusetts\n" +
                "Institute of Technology, led by Bill Gosper; the Gosper glider gun produces its first glider on the 15th generation, and another glider every 30th\n" +
                "generation from then on. For many years, this glider gun was the smallest one known. In 2015, a gun called the Simkin glider gun, which releases\n" +
                "a glider every 120th generation, was discovered that has fewer live cells but which is spread out across a larger bounding box at its extremities.";
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Visible = !main.Visible;
        }

        private async void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.UseWaitCursor = true;
            await Task.Delay(TimeSpan.FromSeconds(2)); // Wait for two seconds
            Application.Exit();
        }
    }
}
