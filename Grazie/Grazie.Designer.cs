namespace Grazie
{
    partial class Grazie
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.satisfactionButton = new System.Windows.Forms.Button();
            this.goodButton = new System.Windows.Forms.Button();
            this.goodluckButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.52381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.52381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.761906F));
            this.tableLayoutPanel1.Controls.Add(this.satisfactionButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodluckButton, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // satisfactionButton
            // 
            this.satisfactionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisfactionButton.Location = new System.Drawing.Point(41, 48);
            this.satisfactionButton.Name = "satisfactionButton";
            this.satisfactionButton.Size = new System.Drawing.Size(184, 174);
            this.satisfactionButton.TabIndex = 0;
            this.satisfactionButton.Text = "満足";
            this.satisfactionButton.UseVisualStyleBackColor = true;
            this.satisfactionButton.Click += new System.EventHandler(this.satisfactionButton_Click);
            // 
            // goodButton
            // 
            this.goodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodButton.Location = new System.Drawing.Point(307, 48);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(184, 174);
            this.goodButton.TabIndex = 1;
            this.goodButton.Text = "普通";
            this.goodButton.UseVisualStyleBackColor = true;
            this.goodButton.Click += new System.EventHandler(this.goodButton_Click);
            // 
            // goodluckButton
            // 
            this.goodluckButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodluckButton.Location = new System.Drawing.Point(573, 48);
            this.goodluckButton.Name = "goodluckButton";
            this.goodluckButton.Size = new System.Drawing.Size(184, 174);
            this.goodluckButton.TabIndex = 2;
            this.goodluckButton.Text = "頑張って";
            this.goodluckButton.UseVisualStyleBackColor = true;
            this.goodluckButton.Click += new System.EventHandler(this.goodluckButton_Click);
            // 
            // Grazie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Grazie";
            this.Text = "Grazie";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button satisfactionButton;
        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.Button goodluckButton;
    }
}

