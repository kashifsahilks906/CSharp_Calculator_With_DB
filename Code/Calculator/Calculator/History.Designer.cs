namespace Calculator
{
    partial class History
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
            dataGridView1 = new DataGridView();
            UpdateBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(24, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(665, 309);
            dataGridView1.TabIndex = 1;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ControlDarkDark;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.ImageAlign = ContentAlignment.MiddleRight;
            UpdateBtn.Location = new Point(370, 412);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(130, 47);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.ControlDarkDark;
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.ImageAlign = ContentAlignment.MiddleRight;
            deleteBtn.Location = new Point(207, 412);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(130, 47);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 57);
            label1.TabIndex = 3;
            label1.Text = "HISTORY";
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 493);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(dataGridView1);
            Name = "History";
            Text = "HISTORY";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button UpdateBtn;
        private Button deleteBtn;
        private Label label1;
    }
}