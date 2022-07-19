
namespace laba1_oop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clear = new System.Windows.Forms.Button();
            this.btCircle = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            this.btTriangle = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btRectangle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btLine = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.btCircle);
            this.panel1.Controls.Add(this.btEllipse);
            this.panel1.Controls.Add(this.btTriangle);
            this.panel1.Controls.Add(this.btSquare);
            this.panel1.Controls.Add(this.btRectangle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btColor);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 132);
            this.panel1.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Plum;
            this.Clear.Location = new System.Drawing.Point(577, 37);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 38);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btCircle
            // 
            this.btCircle.BackColor = System.Drawing.Color.Plum;
            this.btCircle.Location = new System.Drawing.Point(222, 66);
            this.btCircle.Name = "btCircle";
            this.btCircle.Size = new System.Drawing.Size(103, 37);
            this.btCircle.TabIndex = 11;
            this.btCircle.Text = "Circle";
            this.btCircle.UseVisualStyleBackColor = false;
            this.btCircle.Click += new System.EventHandler(this.btCircle_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.BackColor = System.Drawing.Color.Plum;
            this.btEllipse.Location = new System.Drawing.Point(222, 17);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(104, 38);
            this.btEllipse.TabIndex = 10;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = false;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btTriangle
            // 
            this.btTriangle.BackColor = System.Drawing.Color.Plum;
            this.btTriangle.Location = new System.Drawing.Point(122, 17);
            this.btTriangle.Name = "btTriangle";
            this.btTriangle.Size = new System.Drawing.Size(93, 38);
            this.btTriangle.TabIndex = 9;
            this.btTriangle.Text = "Triangle";
            this.btTriangle.UseVisualStyleBackColor = false;
            this.btTriangle.Click += new System.EventHandler(this.btInheretedTriangle_Click);
            // 
            // btSquare
            // 
            this.btSquare.BackColor = System.Drawing.Color.Plum;
            this.btSquare.Location = new System.Drawing.Point(122, 65);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(93, 38);
            this.btSquare.TabIndex = 8;
            this.btSquare.Text = "Square";
            this.btSquare.UseVisualStyleBackColor = false;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // btRectangle
            // 
            this.btRectangle.BackColor = System.Drawing.Color.Plum;
            this.btRectangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRectangle.Location = new System.Drawing.Point(15, 65);
            this.btRectangle.Name = "btRectangle";
            this.btRectangle.Size = new System.Drawing.Size(101, 38);
            this.btRectangle.TabIndex = 7;
            this.btRectangle.Text = "Rectangle";
            this.btRectangle.UseVisualStyleBackColor = false;
            this.btRectangle.Click += new System.EventHandler(this.btRectangle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(370, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color";
            // 
            // btColor
            // 
            this.btColor.BackColor = System.Drawing.Color.Plum;
            this.btColor.Location = new System.Drawing.Point(363, 37);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(63, 57);
            this.btColor.TabIndex = 4;
            this.btColor.UseVisualStyleBackColor = false;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Thistle;
            this.trackBar1.Location = new System.Drawing.Point(455, 38);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(86, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(467, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pen size";
            // 
            // btLine
            // 
            this.btLine.BackColor = System.Drawing.Color.Plum;
            this.btLine.Location = new System.Drawing.Point(12, 17);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(101, 38);
            this.btLine.TabIndex = 0;
            this.btLine.Text = "Line";
            this.btLine.UseVisualStyleBackColor = false;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Location = new System.Drawing.Point(0, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1230, 564);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Plum;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.archivationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // archivationToolStripMenuItem
            // 
            this.archivationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packToolStripMenuItem,
            this.unpackToolStripMenuItem});
            this.archivationToolStripMenuItem.Name = "archivationToolStripMenuItem";
            this.archivationToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.archivationToolStripMenuItem.Text = "Archivation";
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.packToolStripMenuItem.Text = "Pack";
            this.packToolStripMenuItem.Click += new System.EventHandler(this.packToolStripMenuItem_Click);
            // 
            // unpackToolStripMenuItem
            // 
            this.unpackToolStripMenuItem.Name = "unpackToolStripMenuItem";
            this.unpackToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.unpackToolStripMenuItem.Text = "Unpack";
            this.unpackToolStripMenuItem.Click += new System.EventHandler(this.unpackToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 726);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.Button btRectangle;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btTriangle;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btCircle;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpackToolStripMenuItem;
        private static System.Windows.Forms.PictureBox pictureBox1;
    }
}

