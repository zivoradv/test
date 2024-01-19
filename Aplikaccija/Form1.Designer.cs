namespace Aplikaccija
{
    partial class Form1
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
            label1 = new Label();
            btnUnesi = new Button();
            txtTitle = new TextBox();
            listBox1 = new ListBox();
            txtArtist = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // btnUnesi
            // 
            btnUnesi.Location = new Point(84, 231);
            btnUnesi.Name = "btnUnesi";
            btnUnesi.Size = new Size(94, 29);
            btnUnesi.TabIndex = 2;
            btnUnesi.Text = "Unesi";
            btnUnesi.UseVisualStyleBackColor = true;
            btnUnesi.Click += btnUnesi_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(111, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(289, 27);
            txtTitle.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(406, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(521, 284);
            listBox1.TabIndex = 4;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(111, 99);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(289, 27);
            txtArtist.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Artist";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(111, 153);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(289, 27);
            txtPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 160);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 527);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtArtist);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(txtTitle);
            Controls.Add(btnUnesi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUnesi;
        private TextBox txtTitle;
        private ListBox listBox1;
        private TextBox txtArtist;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
    }
}