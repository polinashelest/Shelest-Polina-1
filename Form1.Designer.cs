namespace Lab1
{
    partial class VectorForm
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
            this.VectorDimension = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown0 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.CordNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddEqualBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scalarSB = new System.Windows.Forms.NumericUpDown();
            this.LengthButton = new System.Windows.Forms.Button();
            this.MulticonstButton = new System.Windows.Forms.Button();
            this.xConst = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VectorDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xConst)).BeginInit();
            this.SuspendLayout();
            // 
            // VectorDimension
            // 
            this.VectorDimension.Location = new System.Drawing.Point(248, 41);
            this.VectorDimension.Margin = new System.Windows.Forms.Padding(2);
            this.VectorDimension.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.VectorDimension.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VectorDimension.Name = "VectorDimension";
            this.VectorDimension.Size = new System.Drawing.Size(40, 20);
            this.VectorDimension.TabIndex = 0;
            this.VectorDimension.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VectorDimension.ValueChanged += new System.EventHandler(this.VectorDimension_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість вимірів (від 2 до 5):";
            // 
            // numericUpDown0
            // 
            this.numericUpDown0.DecimalPlaces = 2;
            this.numericUpDown0.Location = new System.Drawing.Point(63, 75);
            this.numericUpDown0.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown0.Name = "numericUpDown0";
            this.numericUpDown0.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown0.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(63, 98);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(63, 121);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Location = new System.Drawing.Point(63, 144);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Location = new System.Drawing.Point(63, 166);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown4.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown4.TabIndex = 6;
            // 
            // CordNumber
            // 
            this.CordNumber.AutoSize = true;
            this.CordNumber.Location = new System.Drawing.Point(32, 77);
            this.CordNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CordNumber.Name = "CordNumber";
            this.CordNumber.Size = new System.Drawing.Size(24, 13);
            this.CordNumber.TabIndex = 12;
            this.CordNumber.Text = "x1=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "x2=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "x3=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "x4=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "x5=";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(142, 94);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(146, 64);
            this.AddBtn.TabIndex = 23;
            this.AddBtn.Text = "Почати вводити\r\n координати другого вектора";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddEqualBtn
            // 
            this.AddEqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEqualBtn.Location = new System.Drawing.Point(318, 73);
            this.AddEqualBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddEqualBtn.Name = "AddEqualBtn";
            this.AddEqualBtn.Size = new System.Drawing.Size(32, 31);
            this.AddEqualBtn.TabIndex = 24;
            this.AddEqualBtn.Text = " +";
            this.AddEqualBtn.UseVisualStyleBackColor = true;
            this.AddEqualBtn.Click += new System.EventHandler(this.AddEqualBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(318, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 31);
            this.button1.TabIndex = 25;
            this.button1.Text = " -";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(318, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scalarSB
            // 
            this.scalarSB.DecimalPlaces = 4;
            this.scalarSB.Enabled = false;
            this.scalarSB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.scalarSB.Location = new System.Drawing.Point(232, 244);
            this.scalarSB.Margin = new System.Windows.Forms.Padding(2);
            this.scalarSB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.scalarSB.Name = "scalarSB";
            this.scalarSB.ReadOnly = true;
            this.scalarSB.Size = new System.Drawing.Size(56, 20);
            this.scalarSB.TabIndex = 27;
            // 
            // LengthButton
            // 
            this.LengthButton.Location = new System.Drawing.Point(35, 239);
            this.LengthButton.Margin = new System.Windows.Forms.Padding(2);
            this.LengthButton.Name = "LengthButton";
            this.LengthButton.Size = new System.Drawing.Size(165, 37);
            this.LengthButton.TabIndex = 29;
            this.LengthButton.Text = "Вивести довжину вектора/результат";
            this.LengthButton.UseVisualStyleBackColor = true;
            this.LengthButton.Click += new System.EventHandler(this.LengthButton_Click);
            // 
            // MulticonstButton
            // 
            this.MulticonstButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulticonstButton.Location = new System.Drawing.Point(35, 207);
            this.MulticonstButton.Margin = new System.Windows.Forms.Padding(2);
            this.MulticonstButton.Name = "MulticonstButton";
            this.MulticonstButton.Size = new System.Drawing.Size(165, 28);
            this.MulticonstButton.TabIndex = 30;
            this.MulticonstButton.Text = "Помножити на скаляр";
            this.MulticonstButton.UseVisualStyleBackColor = true;
            this.MulticonstButton.Click += new System.EventHandler(this.MulticonstButton_Click);
            // 
            // xConst
            // 
            this.xConst.DecimalPlaces = 2;
            this.xConst.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.xConst.Location = new System.Drawing.Point(232, 212);
            this.xConst.Margin = new System.Windows.Forms.Padding(2);
            this.xConst.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xConst.Name = "xConst";
            this.xConst.Size = new System.Drawing.Size(53, 20);
            this.xConst.TabIndex = 31;
            this.xConst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(120, 294);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(165, 28);
            this.SaveBtn.TabIndex = 32;
            this.SaveBtn.Text = "Зберегти вектор в JSON";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(120, 326);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(165, 27);
            this.LoadBtn.TabIndex = 33;
            this.LoadBtn.Text = "Завантажити вектор з JSON";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // VectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 399);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.xConst);
            this.Controls.Add(this.MulticonstButton);
            this.Controls.Add(this.LengthButton);
            this.Controls.Add(this.scalarSB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddEqualBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CordNumber);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VectorDimension);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VectorForm";
            this.Text = "VectorCalculus";
            this.Load += new System.EventHandler(this.VectorForm_Load);
            this.Shown += new System.EventHandler(this.VectorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.VectorDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalarSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xConst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown0;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label CordNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown VectorDimension;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button AddEqualBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown scalarSB;
        private System.Windows.Forms.Button LengthButton;
        private System.Windows.Forms.Button MulticonstButton;
        private System.Windows.Forms.NumericUpDown xConst;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
    }
}

