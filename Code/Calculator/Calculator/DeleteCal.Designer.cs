namespace Calculator
{
    partial class DeleteCal
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
            deletelbl = new Label();
            label1 = new Label();
            ID = new TextBox();
            SubmitBtn = new Button();
            messege = new Label();
            SuspendLayout();
            // 
            // deletelbl
            // 
            deletelbl.AutoSize = true;
            deletelbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            deletelbl.Location = new Point(70, 39);
            deletelbl.Name = "deletelbl";
            deletelbl.Size = new Size(168, 57);
            deletelbl.TabIndex = 0;
            deletelbl.Text = "DELETE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(61, 117);
            label1.Name = "label1";
            label1.Size = new Size(40, 35);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 13F);
            ID.Location = new Point(107, 118);
            ID.Name = "ID";
            ID.Size = new Size(125, 36);
            ID.TabIndex = 2;
            ID.TextAlign = HorizontalAlignment.Center;
            ID.KeyPress += ID_Press;
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SubmitBtn.Location = new Point(107, 174);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(94, 44);
            SubmitBtn.TabIndex = 3;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // messege
            // 
            messege.AutoSize = true;
            messege.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            messege.ForeColor = SystemColors.GrayText;
            messege.Location = new Point(20, 221);
            messege.Name = "messege";
            messege.Size = new Size(0, 23);
            messege.TabIndex = 4;
            // 
            // DeleteCal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 254);
            Controls.Add(messege);
            Controls.Add(SubmitBtn);
            Controls.Add(ID);
            Controls.Add(label1);
            Controls.Add(deletelbl);
            Name = "DeleteCal";
            Text = "DELETE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deletelbl;
        private Label label1;
        private TextBox ID;
        private Button SubmitBtn;
        private Label messege;
    }
}