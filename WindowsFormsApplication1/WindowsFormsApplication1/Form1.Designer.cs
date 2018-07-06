namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Sin = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.PowInvers = new System.Windows.Forms.Button();
            this.DegreeRoot = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.GeomMean = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Inverse = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(12, 95);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(36, 23);
            this.Plus.TabIndex = 5;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(54, 95);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(33, 23);
            this.Minus.TabIndex = 6;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(12, 124);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(36, 23);
            this.Multiplication.TabIndex = 7;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(54, 124);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(33, 23);
            this.Division.TabIndex = 8;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(172, 29);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 20);
            this.Output.TabIndex = 10;
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(102, 95);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(80, 23);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Click1);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(188, 95);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(84, 23);
            this.Tg.TabIndex = 12;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.Click1);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(12, 154);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(36, 23);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Click1);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(188, 124);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(84, 23);
            this.Ln.TabIndex = 14;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.Click1);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(54, 154);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(33, 23);
            this.Ctg.TabIndex = 15;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.Click1);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(103, 124);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(79, 23);
            this.Log.TabIndex = 16;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Click);
            // 
            // PowInvers
            // 
            this.PowInvers.Location = new System.Drawing.Point(103, 183);
            this.PowInvers.Name = "PowInvers";
            this.PowInvers.Size = new System.Drawing.Size(80, 23);
            this.PowInvers.TabIndex = 17;
            this.PowInvers.Text = "PowInvers";
            this.PowInvers.UseVisualStyleBackColor = true;
            this.PowInvers.Click += new System.EventHandler(this.Click);
            // 
            // DegreeRoot
            // 
            this.DegreeRoot.Location = new System.Drawing.Point(103, 153);
            this.DegreeRoot.Name = "DegreeRoot";
            this.DegreeRoot.Size = new System.Drawing.Size(79, 23);
            this.DegreeRoot.TabIndex = 18;
            this.DegreeRoot.Text = "DegreeRoot";
            this.DegreeRoot.UseVisualStyleBackColor = true;
            this.DegreeRoot.Click += new System.EventHandler(this.Click);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(188, 154);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(83, 23);
            this.Pow.TabIndex = 19;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.Click);
            // 
            // GeomMean
            // 
            this.GeomMean.Location = new System.Drawing.Point(188, 183);
            this.GeomMean.Name = "GeomMean";
            this.GeomMean.Size = new System.Drawing.Size(83, 23);
            this.GeomMean.TabIndex = 20;
            this.GeomMean.Text = "GeomMean";
            this.GeomMean.UseVisualStyleBackColor = true;
            this.GeomMean.Click += new System.EventHandler(this.Click);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(13, 183);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(75, 23);
            this.Mod.TabIndex = 21;
            this.Mod.Text = "Mod";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(103, 212);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(80, 23);
            this.Min.TabIndex = 22;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(189, 212);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(82, 23);
            this.Max.TabIndex = 23;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(13, 212);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 24;
            this.Div.Text = "Div";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Click);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(103, 241);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(80, 23);
            this.Cube.TabIndex = 25;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.Click1);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(189, 241);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(82, 23);
            this.Reverse.TabIndex = 26;
            this.Reverse.Text = "Reverse";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Click1);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(12, 241);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(75, 23);
            this.Average.TabIndex = 27;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.Click);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(13, 271);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 28;
            this.Log10.Text = "Log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.Click1);
            // 
            // Inverse
            // 
            this.Inverse.Location = new System.Drawing.Point(103, 271);
            this.Inverse.Name = "Inverse";
            this.Inverse.Size = new System.Drawing.Size(80, 23);
            this.Inverse.TabIndex = 29;
            this.Inverse.Text = "Inverse";
            this.Inverse.UseVisualStyleBackColor = true;
            this.Inverse.Click += new System.EventHandler(this.Click1);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(189, 271);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(82, 23);
            this.Module.TabIndex = 30;
            this.Module.Text = "Module";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.Click1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 310);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Inverse);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.GeomMean);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.DegreeRoot);
            this.Controls.Add(this.PowInvers);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button PowInvers;
        private System.Windows.Forms.Button DegreeRoot;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button GeomMean;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Inverse;
        private System.Windows.Forms.Button Module;
    }
}

