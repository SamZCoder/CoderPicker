namespace CoderPicker.App
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
            this.saturationCanvas = new System.Windows.Forms.Panel();
            this.hueCanvas = new System.Windows.Forms.Panel();
            this.hueRedText = new System.Windows.Forms.TextBox();
            this.hueGreenText = new System.Windows.Forms.TextBox();
            this.hueBlueText = new System.Windows.Forms.TextBox();
            this.currentColorCanvas = new System.Windows.Forms.Panel();
            this.hoverCanvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentRedText = new System.Windows.Forms.TextBox();
            this.currentGreenText = new System.Windows.Forms.TextBox();
            this.currentBlueText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentHexText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentAlphaText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saturationCanvas
            // 
            this.saturationCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saturationCanvas.Location = new System.Drawing.Point(28, 62);
            this.saturationCanvas.Name = "saturationCanvas";
            this.saturationCanvas.Size = new System.Drawing.Size(400, 250);
            this.saturationCanvas.TabIndex = 0;
            this.saturationCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.saturationCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saturationCanvas_MouseDown);
            this.saturationCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.saturationCanvas_MouseMove);
            this.saturationCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saturationCanvas_MouseUp);
            // 
            // hueCanvas
            // 
            this.hueCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hueCanvas.Location = new System.Drawing.Point(0, 0);
            this.hueCanvas.Name = "hueCanvas";
            this.hueCanvas.Size = new System.Drawing.Size(498, 41);
            this.hueCanvas.TabIndex = 0;
            this.hueCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.hueCanvas_Paint);
            this.hueCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hueCanvas_MouseDown);
            this.hueCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hueCanvas_MouseMove);
            this.hueCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hueCanvas_MouseUp);
            // 
            // hueRedText
            // 
            this.hueRedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hueRedText.Location = new System.Drawing.Point(95, 376);
            this.hueRedText.Name = "hueRedText";
            this.hueRedText.Size = new System.Drawing.Size(42, 23);
            this.hueRedText.TabIndex = 2;
            this.hueRedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hueGreenText
            // 
            this.hueGreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hueGreenText.Location = new System.Drawing.Point(170, 377);
            this.hueGreenText.Name = "hueGreenText";
            this.hueGreenText.Size = new System.Drawing.Size(42, 23);
            this.hueGreenText.TabIndex = 2;
            this.hueGreenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hueBlueText
            // 
            this.hueBlueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hueBlueText.Location = new System.Drawing.Point(245, 376);
            this.hueBlueText.Name = "hueBlueText";
            this.hueBlueText.Size = new System.Drawing.Size(42, 23);
            this.hueBlueText.TabIndex = 2;
            this.hueBlueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentColorCanvas
            // 
            this.currentColorCanvas.BackColor = System.Drawing.Color.White;
            this.currentColorCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorCanvas.Location = new System.Drawing.Point(450, 62);
            this.currentColorCanvas.Name = "currentColorCanvas";
            this.currentColorCanvas.Size = new System.Drawing.Size(78, 44);
            this.currentColorCanvas.TabIndex = 3;
            // 
            // hoverCanvas
            // 
            this.hoverCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoverCanvas.Location = new System.Drawing.Point(450, 107);
            this.hoverCanvas.Name = "hoverCanvas";
            this.hoverCanvas.Size = new System.Drawing.Size(78, 44);
            this.hoverCanvas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Advanced Color Picker";
            // 
            // currentRedText
            // 
            this.currentRedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentRedText.Location = new System.Drawing.Point(473, 157);
            this.currentRedText.Name = "currentRedText";
            this.currentRedText.Size = new System.Drawing.Size(55, 23);
            this.currentRedText.TabIndex = 2;
            this.currentRedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentGreenText
            // 
            this.currentGreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentGreenText.Location = new System.Drawing.Point(473, 183);
            this.currentGreenText.Name = "currentGreenText";
            this.currentGreenText.Size = new System.Drawing.Size(55, 23);
            this.currentGreenText.TabIndex = 2;
            this.currentGreenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentBlueText
            // 
            this.currentBlueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentBlueText.Location = new System.Drawing.Point(473, 209);
            this.currentBlueText.Name = "currentBlueText";
            this.currentBlueText.Size = new System.Drawing.Size(55, 23);
            this.currentBlueText.TabIndex = 2;
            this.currentBlueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(450, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(450, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(450, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(450, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hex Code";
            // 
            // currentHexText
            // 
            this.currentHexText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentHexText.Location = new System.Drawing.Point(453, 289);
            this.currentHexText.Name = "currentHexText";
            this.currentHexText.Size = new System.Drawing.Size(75, 23);
            this.currentHexText.TabIndex = 2;
            this.currentHexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(450, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "B";
            // 
            // currentAlphaText
            // 
            this.currentAlphaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.currentAlphaText.Location = new System.Drawing.Point(473, 235);
            this.currentAlphaText.Name = "currentAlphaText";
            this.currentAlphaText.Size = new System.Drawing.Size(55, 23);
            this.currentAlphaText.TabIndex = 2;
            this.currentAlphaText.Text = "255";
            this.currentAlphaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(71, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "R";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(145, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(222, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "B";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(25, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Hue : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(28, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 36);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hueCanvas);
            this.panel2.Location = new System.Drawing.Point(28, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 43);
            this.panel2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hoverCanvas);
            this.Controls.Add(this.currentColorCanvas);
            this.Controls.Add(this.currentHexText);
            this.Controls.Add(this.currentAlphaText);
            this.Controls.Add(this.currentBlueText);
            this.Controls.Add(this.hueBlueText);
            this.Controls.Add(this.currentGreenText);
            this.Controls.Add(this.hueGreenText);
            this.Controls.Add(this.currentRedText);
            this.Controls.Add(this.hueRedText);
            this.Controls.Add(this.saturationCanvas);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Coder Picker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel saturationCanvas;
        private System.Windows.Forms.Panel hueCanvas;
        private System.Windows.Forms.TextBox hueRedText;
        private System.Windows.Forms.TextBox hueGreenText;
        private System.Windows.Forms.TextBox hueBlueText;
        private System.Windows.Forms.Panel currentColorCanvas;
        private System.Windows.Forms.Panel hoverCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentRedText;
        private System.Windows.Forms.TextBox currentGreenText;
        private System.Windows.Forms.TextBox currentBlueText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentHexText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentAlphaText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

