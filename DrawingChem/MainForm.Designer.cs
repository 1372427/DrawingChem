namespace DrawingChem
{
    partial class MainForm
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
            this.search = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.drawComp = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(418, 54);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(136, 23);
            this.search.TabIndex = 0;
            this.search.Text = "Search Element";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.SearchEl_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(65, 55);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(321, 22);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Element/Compound Name and Press Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search Compound";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchCompound);
            // 
            // drawComp
            // 
            this.drawComp.Location = new System.Drawing.Point(418, 142);
            this.drawComp.Name = "drawComp";
            this.drawComp.Size = new System.Drawing.Size(136, 23);
            this.drawComp.TabIndex = 4;
            this.drawComp.Text = "Draw Compound";
            this.drawComp.UseVisualStyleBackColor = true;
            this.drawComp.Click += new System.EventHandler(this.DrawCompound_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(62, 193);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 17);
            this.output.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 416);
            this.Controls.Add(this.output);
            this.Controls.Add(this.drawComp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.search);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button drawComp;
        private System.Windows.Forms.Label output;
    }
}