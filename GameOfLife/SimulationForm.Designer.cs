
namespace GameOfLife
{
    partial class SimulationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simulationButton = new System.Windows.Forms.Button();
            this.simGoBack = new System.Windows.Forms.Button();
            this.simExitButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.simulation = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeOKButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.genLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.radio100 = new System.Windows.Forms.RadioButton();
            this.radio1000 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioCorner = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // simulationButton
            // 
            this.simulationButton.BackColor = System.Drawing.Color.ForestGreen;
            this.simulationButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simulationButton.Location = new System.Drawing.Point(926, 24);
            this.simulationButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Size = new System.Drawing.Size(386, 114);
            this.simulationButton.TabIndex = 1;
            this.simulationButton.Text = "SIMULATE!";
            this.simulationButton.UseVisualStyleBackColor = false;
            this.simulationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // simGoBack
            // 
            this.simGoBack.BackColor = System.Drawing.Color.Black;
            this.simGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simGoBack.Location = new System.Drawing.Point(21, 30);
            this.simGoBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simGoBack.Name = "simGoBack";
            this.simGoBack.Size = new System.Drawing.Size(184, 78);
            this.simGoBack.TabIndex = 4;
            this.simGoBack.Text = "Go back";
            this.simGoBack.UseVisualStyleBackColor = false;
            this.simGoBack.Click += new System.EventHandler(this.simGoBack_Click);
            // 
            // simExitButton
            // 
            this.simExitButton.BackColor = System.Drawing.Color.DarkRed;
            this.simExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simExitButton.Location = new System.Drawing.Point(2043, 30);
            this.simExitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simExitButton.Name = "simExitButton";
            this.simExitButton.Size = new System.Drawing.Size(184, 78);
            this.simExitButton.TabIndex = 10;
            this.simExitButton.Text = "Exit";
            this.simExitButton.UseVisualStyleBackColor = false;
            this.simExitButton.Click += new System.EventHandler(this.simExitButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // simulation
            // 
            this.simulation.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulation.Location = new System.Drawing.Point(21, 228);
            this.simulation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(2204, 1754);
            this.simulation.TabIndex = 11;
            this.simulation.Text = "";
            this.simulation.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(309, 64);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(145, 30);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "Choose a size:";
            // 
            // sizeOKButton
            // 
            this.sizeOKButton.BackColor = System.Drawing.Color.ForestGreen;
            this.sizeOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeOKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sizeOKButton.Location = new System.Drawing.Point(588, 54);
            this.sizeOKButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sizeOKButton.Name = "sizeOKButton";
            this.sizeOKButton.Size = new System.Drawing.Size(64, 50);
            this.sizeOKButton.TabIndex = 14;
            this.sizeOKButton.Text = "OK";
            this.sizeOKButton.UseVisualStyleBackColor = false;
            this.sizeOKButton.Click += new System.EventHandler(this.sizeOKButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Teal;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetButton.Location = new System.Drawing.Point(662, 54);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetButton.Name = "resetButton";
            this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resetButton.Size = new System.Drawing.Size(100, 50);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Default";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genLabel.Location = new System.Drawing.Point(1317, 24);
            this.genLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(0, 32);
            this.genLabel.TabIndex = 16;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(1317, 100);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 32);
            this.timerLabel.TabIndex = 17;
            // 
            // radio100
            // 
            this.radio100.AutoSize = true;
            this.radio100.Location = new System.Drawing.Point(10, 68);
            this.radio100.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radio100.Name = "radio100";
            this.radio100.Size = new System.Drawing.Size(154, 34);
            this.radio100.TabIndex = 18;
            this.radio100.TabStop = true;
            this.radio100.Text = "10 ms / GEN";
            this.radio100.UseVisualStyleBackColor = true;
            // 
            // radio1000
            // 
            this.radio1000.AutoSize = true;
            this.radio1000.Location = new System.Drawing.Point(10, 28);
            this.radio1000.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radio1000.Name = "radio1000";
            this.radio1000.Size = new System.Drawing.Size(165, 34);
            this.radio1000.TabIndex = 19;
            this.radio1000.TabStop = true;
            this.radio1000.Text = "500 ms / GEN";
            this.radio1000.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Every setting modification requires a game restart.";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(10, 26);
            this.radioAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(250, 34);
            this.radioAll.TabIndex = 21;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Starts from everywhere";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioCorner
            // 
            this.radioCorner.AutoSize = true;
            this.radioCorner.Location = new System.Drawing.Point(10, 66);
            this.radioCorner.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioCorner.Name = "radioCorner";
            this.radioCorner.Size = new System.Drawing.Size(204, 34);
            this.radioCorner.TabIndex = 23;
            this.radioCorner.TabStop = true;
            this.radioCorner.Text = "Starts from corner";
            this.radioCorner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio100);
            this.groupBox1.Controls.Add(this.radio1000);
            this.groupBox1.Location = new System.Drawing.Point(298, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(190, 120);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select other ticks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Controls.Add(this.radioCorner);
            this.groupBox2.Location = new System.Drawing.Point(494, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(268, 120);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select start position";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pauseButton.Location = new System.Drawing.Point(926, 152);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(386, 64);
            this.pauseButton.TabIndex = 27;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(471, 57);
            this.numericUpDownValue.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(108, 35);
            this.numericUpDownValue.TabIndex = 28;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2248, 1404);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sizeOKButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.simExitButton);
            this.Controls.Add(this.simGoBack);
            this.Controls.Add(this.simulationButton);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.Button simGoBack;
        private System.Windows.Forms.Button simExitButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox simulation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button sizeOKButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.RadioButton radio100;
        private System.Windows.Forms.RadioButton radio1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioCorner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
    }
}