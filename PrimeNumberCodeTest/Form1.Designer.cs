namespace PrimeNumberCodeTest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlgorithmSieveOfEratosthenes = new System.Windows.Forms.ToolStripMenuItem();
            this.EratosthenesLimit_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EratosthenesLimit_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.EratosthenesLimit_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.AlgorithmSieveOfAtkin = new System.Windows.Forms.ToolStripMenuItem();
            this.AtkinLimit_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AtkinLimit_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AtkinLimit_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberOfPrimes = new System.Windows.Forms.TextBox();
            this.GenerateTable = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.PrimeNumberTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlgorithmSieveOfEratosthenes,
            this.AlgorithmSieveOfAtkin});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.fileToolStripMenuItem.Text = "&Algorithm";
            // 
            // AlgorithmSieveOfEratosthenes
            // 
            this.AlgorithmSieveOfEratosthenes.Checked = true;
            this.AlgorithmSieveOfEratosthenes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlgorithmSieveOfEratosthenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EratosthenesLimit_1,
            this.EratosthenesLimit_2,
            this.EratosthenesLimit_3});
            this.AlgorithmSieveOfEratosthenes.Name = "AlgorithmSieveOfEratosthenes";
            this.AlgorithmSieveOfEratosthenes.Size = new System.Drawing.Size(185, 22);
            this.AlgorithmSieveOfEratosthenes.Text = "Sieve of Eratosthenes";
            // 
            // EratosthenesLimit_1
            // 
            this.EratosthenesLimit_1.Name = "EratosthenesLimit_1";
            this.EratosthenesLimit_1.Size = new System.Drawing.Size(152, 22);
            this.EratosthenesLimit_1.Text = "100";
            this.EratosthenesLimit_1.Click += new System.EventHandler(this.EratosthenesLimit_1_Click);
            // 
            // EratosthenesLimit_2
            // 
            this.EratosthenesLimit_2.Name = "EratosthenesLimit_2";
            this.EratosthenesLimit_2.Size = new System.Drawing.Size(152, 22);
            this.EratosthenesLimit_2.Text = "1000";
            this.EratosthenesLimit_2.Click += new System.EventHandler(this.EratosthenesLimit_2_Click);
            // 
            // EratosthenesLimit_3
            // 
            this.EratosthenesLimit_3.Checked = true;
            this.EratosthenesLimit_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EratosthenesLimit_3.Name = "EratosthenesLimit_3";
            this.EratosthenesLimit_3.Size = new System.Drawing.Size(152, 22);
            this.EratosthenesLimit_3.Text = "10000";
            this.EratosthenesLimit_3.Click += new System.EventHandler(this.EratosthenesLimit_3_Click);
            // 
            // AlgorithmSieveOfAtkin
            // 
            this.AlgorithmSieveOfAtkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AtkinLimit_1,
            this.AtkinLimit_2,
            this.AtkinLimit_3});
            this.AlgorithmSieveOfAtkin.Name = "AlgorithmSieveOfAtkin";
            this.AlgorithmSieveOfAtkin.Size = new System.Drawing.Size(185, 22);
            this.AlgorithmSieveOfAtkin.Text = "Sieve of Atkin";
            // 
            // AtkinLimit_1
            // 
            this.AtkinLimit_1.Name = "AtkinLimit_1";
            this.AtkinLimit_1.Size = new System.Drawing.Size(152, 22);
            this.AtkinLimit_1.Text = "100";
            this.AtkinLimit_1.Click += new System.EventHandler(this.AtkinLimit_1_Click);
            // 
            // AtkinLimit_2
            // 
            this.AtkinLimit_2.Name = "AtkinLimit_2";
            this.AtkinLimit_2.Size = new System.Drawing.Size(152, 22);
            this.AtkinLimit_2.Text = "1000";
            this.AtkinLimit_2.Click += new System.EventHandler(this.AtkinLimit_2_Click);
            // 
            // AtkinLimit_3
            // 
            this.AtkinLimit_3.Name = "AtkinLimit_3";
            this.AtkinLimit_3.Size = new System.Drawing.Size(152, 22);
            this.AtkinLimit_3.Text = "10000";
            this.AtkinLimit_3.Click += new System.EventHandler(this.AtkinLimit_3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Primes: ";
            // 
            // NumberOfPrimes
            // 
            this.NumberOfPrimes.Location = new System.Drawing.Point(116, 35);
            this.NumberOfPrimes.Name = "NumberOfPrimes";
            this.NumberOfPrimes.Size = new System.Drawing.Size(100, 20);
            this.NumberOfPrimes.TabIndex = 3;
            this.NumberOfPrimes.Text = "1";
            // 
            // GenerateTable
            // 
            this.GenerateTable.Location = new System.Drawing.Point(15, 63);
            this.GenerateTable.Name = "GenerateTable";
            this.GenerateTable.Size = new System.Drawing.Size(201, 23);
            this.GenerateTable.TabIndex = 4;
            this.GenerateTable.Text = "Generate!";
            this.GenerateTable.UseVisualStyleBackColor = true;
            this.GenerateTable.Click += new System.EventHandler(this.GenerateTable_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablePanel.Controls.Add(this.PrimeNumberTable);
            this.TablePanel.Location = new System.Drawing.Point(15, 92);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(1237, 577);
            this.TablePanel.TabIndex = 5;
            // 
            // PrimeNumberTable
            // 
            this.PrimeNumberTable.AutoSize = true;
            this.PrimeNumberTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.PrimeNumberTable.ColumnCount = 1;
            this.PrimeNumberTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PrimeNumberTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.PrimeNumberTable.Location = new System.Drawing.Point(3, 3);
            this.PrimeNumberTable.Name = "PrimeNumberTable";
            this.PrimeNumberTable.RowCount = 1;
            this.PrimeNumberTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.PrimeNumberTable.Size = new System.Drawing.Size(54, 29);
            this.PrimeNumberTable.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.GenerateTable);
            this.Controls.Add(this.NumberOfPrimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Numbers Code Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlgorithmSieveOfEratosthenes;
        private System.Windows.Forms.ToolStripMenuItem EratosthenesLimit_1;
        private System.Windows.Forms.ToolStripMenuItem EratosthenesLimit_2;
        private System.Windows.Forms.ToolStripMenuItem EratosthenesLimit_3;
        private System.Windows.Forms.ToolStripMenuItem AlgorithmSieveOfAtkin;
        private System.Windows.Forms.ToolStripMenuItem AtkinLimit_1;
        private System.Windows.Forms.ToolStripMenuItem AtkinLimit_2;
        private System.Windows.Forms.ToolStripMenuItem AtkinLimit_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberOfPrimes;
        private System.Windows.Forms.Button GenerateTable;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.TableLayoutPanel PrimeNumberTable;
    }
}

