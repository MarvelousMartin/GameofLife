
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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(617, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "SIMULATE!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simGoBack
            // 
            this.simGoBack.BackColor = System.Drawing.Color.Black;
            this.simGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simGoBack.Location = new System.Drawing.Point(14, 20);
            this.simGoBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simGoBack.Name = "simGoBack";
            this.simGoBack.Size = new System.Drawing.Size(123, 52);
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
            this.simExitButton.Location = new System.Drawing.Point(1362, 20);
            this.simExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simExitButton.Name = "simExitButton";
            this.simExitButton.Size = new System.Drawing.Size(123, 52);
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
            this.simulation.Location = new System.Drawing.Point(14, 152);
            this.simulation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(1471, 1171);
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
            this.sizeLabel.Location = new System.Drawing.Point(206, 43);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(102, 20);
            this.sizeLabel.TabIndex = 12;
            this.sizeLabel.Text = "Choose a size:";
            // 
            // sizeOKButton
            // 
            this.sizeOKButton.BackColor = System.Drawing.Color.ForestGreen;
            this.sizeOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeOKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sizeOKButton.Location = new System.Drawing.Point(392, 36);
            this.sizeOKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeOKButton.Name = "sizeOKButton";
            this.sizeOKButton.Size = new System.Drawing.Size(43, 33);
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
            this.resetButton.Location = new System.Drawing.Point(441, 36);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resetButton.Size = new System.Drawing.Size(67, 33);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Default";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genLabel.Location = new System.Drawing.Point(878, 16);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(0, 25);
            this.genLabel.TabIndex = 16;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(878, 67);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 25);
            this.timerLabel.TabIndex = 17;
            // 
            // radio100
            // 
            this.radio100.AutoSize = true;
            this.radio100.Location = new System.Drawing.Point(7, 45);
            this.radio100.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio100.Name = "radio100";
            this.radio100.Size = new System.Drawing.Size(112, 24);
            this.radio100.TabIndex = 18;
            this.radio100.TabStop = true;
            this.radio100.Text = "10 ms / GEN";
            this.radio100.UseVisualStyleBackColor = true;
            // 
            // radio1000
            // 
            this.radio1000.AutoSize = true;
            this.radio1000.Location = new System.Drawing.Point(7, 19);
            this.radio1000.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio1000.Name = "radio1000";
            this.radio1000.Size = new System.Drawing.Size(120, 24);
            this.radio1000.TabIndex = 19;
            this.radio1000.TabStop = true;
            this.radio1000.Text = "500 ms / GEN";
            this.radio1000.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Every setting modification requires a game restart.";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(7, 17);
            this.radioAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(182, 24);
            this.radioAll.TabIndex = 21;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Starts from everywhere";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioCorner
            // 
            this.radioCorner.AutoSize = true;
            this.radioCorner.Location = new System.Drawing.Point(7, 44);
            this.radioCorner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCorner.Name = "radioCorner";
            this.radioCorner.Size = new System.Drawing.Size(149, 24);
            this.radioCorner.TabIndex = 23;
            this.radioCorner.TabStop = true;
            this.radioCorner.Text = "Starts from corner";
            this.radioCorner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio100);
            this.groupBox1.Controls.Add(this.radio1000);
            this.groupBox1.Location = new System.Drawing.Point(199, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(127, 80);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select other ticks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAll);
            this.groupBox2.Controls.Add(this.radioCorner);
            this.groupBox2.Location = new System.Drawing.Point(329, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(179, 80);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select start position";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pauseButton.Location = new System.Drawing.Point(617, 101);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(257, 43);
            this.pauseButton.TabIndex = 27;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Visible = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(314, 38);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            175,
            0,
            0,
            0});
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownValue.TabIndex = 28;
            this.numericUpDownValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1499, 1055);
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
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button simGoBack;
        private System.Windows.Forms.Button exitButton;
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