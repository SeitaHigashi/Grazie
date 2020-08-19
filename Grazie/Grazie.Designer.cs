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
            this.NumberOfSatisfaction = new System.Windows.Forms.Label();
            this.NumberOfGood = new System.Windows.Forms.Label();
            this.NumberOfGoodluck = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.satisfactionButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.goodluckButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumberOfSatisfaction, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumberOfGood, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumberOfGoodluck, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // satisfactionButton
            // 
            this.satisfactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
            this.satisfactionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisfactionButton.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Bold);
            this.satisfactionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.satisfactionButton.Location = new System.Drawing.Point(4, 32);
            this.satisfactionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satisfactionButton.Name = "satisfactionButton";
            this.satisfactionButton.Size = new System.Drawing.Size(347, 441);
            this.satisfactionButton.TabIndex = 0;
            this.satisfactionButton.Text = "満足😄";
            this.satisfactionButton.UseVisualStyleBackColor = false;
            this.satisfactionButton.Click += new System.EventHandler(this.satisfactionButton_Click);
            // 
            // goodButton
            // 
            this.goodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(156)))));
            this.goodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodButton.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Bold);
            this.goodButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.goodButton.Location = new System.Drawing.Point(359, 32);
            this.goodButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goodButton.Name = "goodButton";
            this.goodButton.Size = new System.Drawing.Size(347, 441);
            this.goodButton.TabIndex = 1;
            this.goodButton.Text = "普通😐";
            this.goodButton.UseVisualStyleBackColor = false;
            this.goodButton.Click += new System.EventHandler(this.goodButton_Click);
            // 
            // goodluckButton
            // 
            this.goodluckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.goodluckButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodluckButton.Font = new System.Drawing.Font("メイリオ", 48F, System.Drawing.FontStyle.Bold);
            this.goodluckButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.goodluckButton.Location = new System.Drawing.Point(714, 32);
            this.goodluckButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goodluckButton.Name = "goodluckButton";
            this.goodluckButton.Size = new System.Drawing.Size(349, 441);
            this.goodluckButton.TabIndex = 2;
            this.goodluckButton.Text = "頑張って🙁";
            this.goodluckButton.UseVisualStyleBackColor = false;
            this.goodluckButton.Click += new System.EventHandler(this.goodluckButton_Click);
            // 
            // NumberOfSatisfaction
            // 
            this.NumberOfSatisfaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfSatisfaction.AutoSize = true;
            this.NumberOfSatisfaction.Font = new System.Drawing.Font("画線法", 30F, System.Drawing.FontStyle.Bold);
            this.NumberOfSatisfaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.NumberOfSatisfaction.Location = new System.Drawing.Point(3, 477);
            this.NumberOfSatisfaction.Name = "NumberOfSatisfaction";
            this.NumberOfSatisfaction.Size = new System.Drawing.Size(349, 85);
            this.NumberOfSatisfaction.TabIndex = 3;
            this.NumberOfSatisfaction.Text = "0人";
            // 
            // NumberOfGood
            // 
            this.NumberOfGood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfGood.AutoSize = true;
            this.NumberOfGood.Font = new System.Drawing.Font("画線法", 30F, System.Drawing.FontStyle.Bold);
            this.NumberOfGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.NumberOfGood.Location = new System.Drawing.Point(358, 477);
            this.NumberOfGood.Name = "NumberOfGood";
            this.NumberOfGood.Size = new System.Drawing.Size(349, 85);
            this.NumberOfGood.TabIndex = 3;
            this.NumberOfGood.Text = "0人";
            // 
            // NumberOfGoodluck
            // 
            this.NumberOfGoodluck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfGoodluck.AutoSize = true;
            this.NumberOfGoodluck.Font = new System.Drawing.Font("画線法", 30F, System.Drawing.FontStyle.Bold);
            this.NumberOfGoodluck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumberOfGoodluck.Location = new System.Drawing.Point(713, 477);
            this.NumberOfGoodluck.Name = "NumberOfGoodluck";
            this.NumberOfGoodluck.Size = new System.Drawing.Size(351, 85);
            this.NumberOfGoodluck.TabIndex = 3;
            this.NumberOfGoodluck.Text = "0人";
            // 
            // Grazie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grazie";
            this.Text = "Grazie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grazie_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button satisfactionButton;
        private System.Windows.Forms.Button goodButton;
        private System.Windows.Forms.Button goodluckButton;
        private System.Windows.Forms.Label NumberOfSatisfaction;
        private System.Windows.Forms.Label NumberOfGood;
        private System.Windows.Forms.Label NumberOfGoodluck;
    }
}

