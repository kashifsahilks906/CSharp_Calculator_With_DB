namespace Calculator
{
    partial class UpdateCal
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
            ID = new TextBox();
            VALUE1 = new TextBox();
            VALUE2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SubmitBtn = new Button();
            label1 = new Label();
            Updatelbl = new Label();
            Operator = new ComboBox();
            SuspendLayout();
            // 
            // ID
            // 
            ID.Font = new Font("Segoe UI", 13F);
            ID.Location = new Point(200, 106);
            ID.Name = "ID";
            ID.Size = new Size(125, 36);
            ID.TabIndex = 26;
            ID.TextAlign = HorizontalAlignment.Center;
            ID.KeyPress += ID_Press;
            // 
            // VALUE1
            // 
            VALUE1.Font = new Font("Segoe UI", 13F);
            VALUE1.Location = new Point(200, 150);
            VALUE1.Name = "VALUE1";
            VALUE1.Size = new Size(125, 36);
            VALUE1.TabIndex = 27;
            VALUE1.TextAlign = HorizontalAlignment.Center;
            VALUE1.KeyPress += Value1_Press;
            // 
            // VALUE2
            // 
            VALUE2.Font = new Font("Segoe UI", 13F);
            VALUE2.Location = new Point(200, 192);
            VALUE2.Name = "VALUE2";
            VALUE2.Size = new Size(125, 36);
            VALUE2.TabIndex = 28;
            VALUE2.TextAlign = HorizontalAlignment.Center;
            VALUE2.KeyPress += Value2_Press;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(46, 239);
            label4.Name = "label4";
            label4.Size = new Size(136, 35);
            label4.TabIndex = 24;
            label4.Text = "OPERATOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(46, 195);
            label3.Name = "label3";
            label3.Size = new Size(108, 35);
            label3.TabIndex = 23;
            label3.Text = "VALUE 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(46, 149);
            label2.Name = "label2";
            label2.Size = new Size(108, 35);
            label2.TabIndex = 22;
            label2.Text = "VALUE 1";
            // 
            // SubmitBtn
            // 
            SubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SubmitBtn.Location = new Point(129, 303);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(97, 43);
            SubmitBtn.TabIndex = 20;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(46, 108);
            label1.Name = "label1";
            label1.Size = new Size(40, 35);
            label1.TabIndex = 19;
            label1.Text = "ID";
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            Updatelbl.Location = new Point(96, 29);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(185, 57);
            Updatelbl.TabIndex = 18;
            Updatelbl.Text = "UPDATE";
            // 
            // Operator
            // 
            Operator.Font = new Font("Segoe UI", 13F);
            Operator.FormattingEnabled = true;
            Operator.Items.AddRange(new object[] { "+", "-", "*", "/", "x²", "√" });
            Operator.Location = new Point(200, 236);
            Operator.Name = "Operator";
            Operator.Size = new Size(125, 38);
            Operator.TabIndex = 31;
            // 
            // UpdateCal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 371);
            Controls.Add(Operator);
            Controls.Add(ID);
            Controls.Add(VALUE1);
            Controls.Add(VALUE2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SubmitBtn);
            Controls.Add(label1);
            Controls.Add(Updatelbl);
            Name = "UpdateCal";
            Text = "UPDATE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID;
        private TextBox VALUE1;
        private TextBox VALUE2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button SubmitBtn;
        private Label label1;
        private Label Updatelbl;
        private ComboBox Operator;
    }
}