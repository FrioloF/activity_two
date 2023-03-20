namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Wishlist = new System.Windows.Forms.ListBox();
            this.Fillbox = new System.Windows.Forms.Button();
            this.SortOut = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Countbutton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wish List";
            // 
            // Wishlist
            // 
            this.Wishlist.FormattingEnabled = true;
            this.Wishlist.Location = new System.Drawing.Point(115, 74);
            this.Wishlist.Name = "Wishlist";
            this.Wishlist.Size = new System.Drawing.Size(218, 238);
            this.Wishlist.TabIndex = 1;
            this.Wishlist.SelectedIndexChanged += new System.EventHandler(this.Wishlist_SelectedIndexChanged);
            // 
            // Fillbox
            // 
            this.Fillbox.Location = new System.Drawing.Point(367, 86);
            this.Fillbox.Name = "Fillbox";
            this.Fillbox.Size = new System.Drawing.Size(75, 23);
            this.Fillbox.TabIndex = 2;
            this.Fillbox.Text = "Fill";
            this.Fillbox.UseVisualStyleBackColor = true;
            this.Fillbox.Click += new System.EventHandler(this.button1_Click);
            // 
            // SortOut
            // 
            this.SortOut.Location = new System.Drawing.Point(367, 131);
            this.SortOut.Name = "SortOut";
            this.SortOut.Size = new System.Drawing.Size(75, 23);
            this.SortOut.TabIndex = 3;
            this.SortOut.Text = "Sort";
            this.SortOut.UseVisualStyleBackColor = true;
            this.SortOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(367, 177);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 4;
            this.ClearAll.Text = "Clear";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // Countbutton
            // 
            this.Countbutton.Location = new System.Drawing.Point(367, 223);
            this.Countbutton.Name = "Countbutton";
            this.Countbutton.Size = new System.Drawing.Size(75, 23);
            this.Countbutton.TabIndex = 5;
            this.Countbutton.Text = "Count";
            this.Countbutton.UseVisualStyleBackColor = true;
            this.Countbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(367, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 379);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 489);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Countbutton);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.SortOut);
            this.Controls.Add(this.Fillbox);
            this.Controls.Add(this.Wishlist);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Wishlist;
        private System.Windows.Forms.Button Fillbox;
        private System.Windows.Forms.Button SortOut;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Countbutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

