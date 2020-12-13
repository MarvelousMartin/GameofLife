
namespace GameOfLife
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.wiki = new System.Windows.Forms.Button();
            this.ConwayText = new System.Windows.Forms.Label();
            this.simulation = new System.Windows.Forms.Button();
            this.ConwayPicture = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.GameOfLife = new System.Windows.Forms.Label();
            this.inNutshell = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ConwayPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // wiki
            // 
            this.wiki.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wiki.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wiki.ForeColor = System.Drawing.SystemColors.Control;
            this.wiki.Location = new System.Drawing.Point(386, 140);
            this.wiki.Margin = new System.Windows.Forms.Padding(2);
            this.wiki.Name = "wiki";
            this.wiki.Size = new System.Drawing.Size(195, 48);
            this.wiki.TabIndex = 0;
            this.wiki.Text = "Wiki";
            this.wiki.UseVisualStyleBackColor = false;
            this.wiki.Click += new System.EventHandler(this.wiki_Click);
            // 
            // ConwayText
            // 
            this.ConwayText.AutoSize = true;
            this.ConwayText.Location = new System.Drawing.Point(228, 358);
            this.ConwayText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConwayText.Name = "ConwayText";
            this.ConwayText.Size = new System.Drawing.Size(93, 15);
            this.ConwayText.TabIndex = 1;
            this.ConwayText.Text = "John H. Conway";
            // 
            // simulation
            // 
            this.simulation.BackColor = System.Drawing.SystemColors.ControlText;
            this.simulation.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulation.ForeColor = System.Drawing.SystemColors.Control;
            this.simulation.Location = new System.Drawing.Point(386, 214);
            this.simulation.Margin = new System.Windows.Forms.Padding(2);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(195, 48);
            this.simulation.TabIndex = 2;
            this.simulation.Text = "Simulation";
            this.simulation.UseVisualStyleBackColor = false;
            this.simulation.Click += new System.EventHandler(this.simulation_Click);
            // 
            // ConwayPicture
            // 
            this.ConwayPicture.Image = ((System.Drawing.Image)(resources.GetObject("ConwayPicture.Image")));
            this.ConwayPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("ConwayPicture.InitialImage")));
            this.ConwayPicture.Location = new System.Drawing.Point(39, 29);
            this.ConwayPicture.Margin = new System.Windows.Forms.Padding(2);
            this.ConwayPicture.Name = "ConwayPicture";
            this.ConwayPicture.Size = new System.Drawing.Size(282, 327);
            this.ConwayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConwayPicture.TabIndex = 4;
            this.ConwayPicture.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkRed;
            this.exit.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(547, 378);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(83, 43);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameOfLife
            // 
            this.GameOfLife.AutoSize = true;
            this.GameOfLife.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOfLife.Location = new System.Drawing.Point(375, 29);
            this.GameOfLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameOfLife.Name = "GameOfLife";
            this.GameOfLife.Size = new System.Drawing.Size(215, 39);
            this.GameOfLife.TabIndex = 6;
            this.GameOfLife.Text = "Game of Life";
            // 
            // inNutshell
            // 
            this.inNutshell.AutoSize = true;
            this.inNutshell.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inNutshell.Location = new System.Drawing.Point(442, 69);
            this.inNutshell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inNutshell.Name = "inNutshell";
            this.inNutshell.Size = new System.Drawing.Size(81, 18);
            this.inNutshell.TabIndex = 7;
            this.inNutshell.Text = "in nutshell";
            // 
            // loading
            // 
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loading.ErrorImage = ((System.Drawing.Image)(resources.GetObject("loading.ErrorImage")));
            this.loading.InitialImage = ((System.Drawing.Image)(resources.GetObject("loading.InitialImage")));
            this.loading.Location = new System.Drawing.Point(501, 378);
            this.loading.Margin = new System.Windows.Forms.Padding(2);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(42, 43);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 8;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("AvenirNext LT Pro Regular", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(12, 409);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 14);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Google Game of Life Easter egg";
            this.linkLabel1.VisitedLinkColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(641, 432);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.inNutshell);
            this.Controls.Add(this.GameOfLife);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ConwayPicture);
            this.Controls.Add(this.simulation);
            this.Controls.Add(this.ConwayText);
            this.Controls.Add(this.wiki);
            this.Controls.Add(this.loading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOfLife";
            ((System.ComponentModel.ISupportInitialize)(this.ConwayPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wiki;
        private System.Windows.Forms.Label ConwayText;
        private System.Windows.Forms.Button simulation;
        private System.Windows.Forms.PictureBox ConwayPicture;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label GameOfLife;
        private System.Windows.Forms.Label inNutshell;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

