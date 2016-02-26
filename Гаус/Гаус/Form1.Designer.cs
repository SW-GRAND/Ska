namespace Гаус
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.BСreateGrid = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            this.SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.A_matrix_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.A_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_matrix_dgv.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.A_matrix_dgv.Location = new System.Drawing.Point(32, 80);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersWidth = 40;
            this.A_matrix_dgv.Size = new System.Drawing.Size(335, 316);
            this.A_matrix_dgv.TabIndex = 0;
            this.A_matrix_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellContentClick);
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.X_vector_dgv.BackgroundColor = System.Drawing.Color.Red;
            this.X_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X_vector_dgv.Location = new System.Drawing.Point(434, 80);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.RowHeadersWidth = 40;
            this.X_vector_dgv.Size = new System.Drawing.Size(141, 316);
            this.X_vector_dgv.TabIndex = 1;
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.B_vector_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_vector_dgv.Location = new System.Drawing.Point(670, 80);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.RowHeadersWidth = 40;
            this.B_vector_dgv.Size = new System.Drawing.Size(141, 316);
            this.B_vector_dgv.TabIndex = 2;
            this.B_vector_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B_vector_dgv_CellContentClick);
            // 
            // BСreateGrid
            // 
            this.BСreateGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BСreateGrid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BСreateGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BСreateGrid.ForeColor = System.Drawing.Color.LawnGreen;
            this.BСreateGrid.Location = new System.Drawing.Point(226, 431);
            this.BСreateGrid.Name = "BСreateGrid";
            this.BСreateGrid.Size = new System.Drawing.Size(141, 47);
            this.BСreateGrid.TabIndex = 3;
            this.BСreateGrid.Text = "Розв\'язати";
            this.BСreateGrid.UseVisualStyleBackColor = true;
            this.BСreateGrid.Click += new System.EventHandler(this.BСreateGrid_Click);
            // 
            // BClear
            // 
            this.BClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClear.ForeColor = System.Drawing.Color.Lime;
            this.BClear.Location = new System.Drawing.Point(434, 431);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(141, 47);
            this.BClear.TabIndex = 4;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClose
            // 
            this.BClose.Cursor = System.Windows.Forms.Cursors.No;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.ForeColor = System.Drawing.Color.Lime;
            this.BClose.Location = new System.Drawing.Point(670, 431);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(141, 47);
            this.BClose.TabIndex = 5;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.BackColor = System.Drawing.Color.Yellow;
            this.NUD_rozmir.Location = new System.Drawing.Point(140, 12);
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.Size = new System.Drawing.Size(113, 20);
            this.NUD_rozmir.TabIndex = 6;
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(135, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Матриця А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(468, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вектор Х";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(702, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вектор В";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Гаус.Properties.Resources._12;
            this.ClientSize = new System.Drawing.Size(982, 501);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BСreateGrid);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gauss";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.Button BСreateGrid;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

