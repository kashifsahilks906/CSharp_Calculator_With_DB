namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            TxtBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            ZeroBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            DivideBtn = new Button();
            PlusBtn = new Button();
            ClearBtn = new Button();
            Minus = new Button();
            SquareBtn = new Button();
            MultiplyBtn = new Button();
            HistoryBtn = new Button();
            ExpressionBtn = new TextBox();
            SquareRootBtn = new Button();
            DotBtn = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Font = new Font("Segoe UI", 24F);
            TxtBox.Location = new Point(22, 89);
            TxtBox.Margin = new Padding(3, 4, 3, 4);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(529, 61);
            TxtBox.TabIndex = 0;
            TxtBox.Text = "0";
            TxtBox.TextAlign = HorizontalAlignment.Right;
            TxtBox.KeyPress += TxtBox_Press;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(22, 179);
            SevenBtn.Margin = new Padding(3, 4, 3, 4);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(89, 84);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(22, 271);
            FourBtn.Margin = new Padding(3, 4, 3, 4);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(89, 84);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(22, 363);
            OneBtn.Margin = new Padding(3, 4, 3, 4);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(89, 84);
            OneBtn.TabIndex = 3;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(22, 456);
            ZeroBtn.Margin = new Padding(3, 4, 3, 4);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.RightToLeft = RightToLeft.Yes;
            ZeroBtn.Size = new Size(89, 84);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += zerobtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(118, 363);
            TwoBtn.Margin = new Padding(3, 4, 3, 4);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(89, 84);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(118, 271);
            FiveBtn.Margin = new Padding(3, 4, 3, 4);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(89, 84);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(118, 179);
            EightBtn.Margin = new Padding(3, 4, 3, 4);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(89, 84);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 12F);
            EqualBtn.Location = new Point(214, 455);
            EqualBtn.Margin = new Padding(3, 4, 3, 4);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(89, 84);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            EqualBtn.Click += EqualBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(214, 363);
            ThreeBtn.Margin = new Padding(3, 4, 3, 4);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(89, 84);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(214, 271);
            SixBtn.Margin = new Padding(3, 4, 3, 4);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(89, 84);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(214, 179);
            NineBtn.Margin = new Padding(3, 4, 3, 4);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(89, 84);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 12F);
            DivideBtn.Location = new Point(366, 363);
            DivideBtn.Margin = new Padding(3, 4, 3, 4);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(89, 84);
            DivideBtn.TabIndex = 15;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            DivideBtn.Click += DivideBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(366, 271);
            PlusBtn.Margin = new Padding(3, 4, 3, 4);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(89, 84);
            PlusBtn.TabIndex = 14;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(366, 179);
            ClearBtn.Margin = new Padding(3, 4, 3, 4);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(185, 84);
            ClearBtn.TabIndex = 13;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 12F);
            Minus.Location = new Point(462, 271);
            Minus.Margin = new Padding(3, 4, 3, 4);
            Minus.Name = "Minus";
            Minus.Size = new Size(89, 84);
            Minus.TabIndex = 18;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // SquareBtn
            // 
            SquareBtn.Font = new Font("Segoe UI", 12F);
            SquareBtn.Location = new Point(462, 455);
            SquareBtn.Margin = new Padding(3, 4, 3, 4);
            SquareBtn.Name = "SquareBtn";
            SquareBtn.Size = new Size(89, 84);
            SquareBtn.TabIndex = 20;
            SquareBtn.Text = " x²";
            SquareBtn.UseVisualStyleBackColor = true;
            SquareBtn.Click += SquareBtn_Click;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 12F);
            MultiplyBtn.Location = new Point(462, 363);
            MultiplyBtn.Margin = new Padding(3, 4, 3, 4);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(89, 84);
            MultiplyBtn.TabIndex = 19;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            MultiplyBtn.Click += MultiplyBtn_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.BackColor = SystemColors.ControlDarkDark;
            HistoryBtn.ForeColor = SystemColors.ButtonHighlight;
            HistoryBtn.Location = new Point(420, 12);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(131, 33);
            HistoryBtn.TabIndex = 21;
            HistoryBtn.Text = "Show History";
            HistoryBtn.UseVisualStyleBackColor = false;
            HistoryBtn.Click += HistoryBtn_Click;
            // 
            // ExpressionBtn
            // 
            ExpressionBtn.BackColor = SystemColors.ScrollBar;
            ExpressionBtn.ForeColor = SystemColors.WindowFrame;
            ExpressionBtn.Location = new Point(22, 55);
            ExpressionBtn.Name = "ExpressionBtn";
            ExpressionBtn.Size = new Size(529, 27);
            ExpressionBtn.TabIndex = 22;
            // 
            // SquareRootBtn
            // 
            SquareRootBtn.Font = new Font("Segoe UI", 12F);
            SquareRootBtn.Location = new Point(366, 456);
            SquareRootBtn.Name = "SquareRootBtn";
            SquareRootBtn.Size = new Size(89, 84);
            SquareRootBtn.TabIndex = 23;
            SquareRootBtn.Text = "√ ";
            SquareRootBtn.UseVisualStyleBackColor = true;
            SquareRootBtn.Click += SquareRootBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(118, 456);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(94, 83);
            DotBtn.TabIndex = 24;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 562);
            Controls.Add(DotBtn);
            Controls.Add(SquareRootBtn);
            Controls.Add(ExpressionBtn);
            Controls.Add(HistoryBtn);
            Controls.Add(SquareBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(Minus);
            Controls.Add(DivideBtn);
            Controls.Add(PlusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(TxtBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calculator";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button DivideBtn;
        private Button PlusBtn;
        private Button ClearBtn;
        private Button Minus;
        private Button SquareBtn;
        private Button MultiplyBtn;
        private Button HistoryBtn;
        private TextBox ExpressionBtn;
        private Button SquareRootBtn;
        private Button DotBtn;
    }
}
