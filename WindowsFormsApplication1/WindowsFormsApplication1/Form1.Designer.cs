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
            this.button2 = new System.Windows.Forms.Button();
            this.Sqrtpow = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
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
            this.Sin.Location = new System.Drawing.Point(162, 95);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(34, 23);
            this.Sin.TabIndex = 11;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Click1);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(201, 95);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(36, 23);
            this.Tg.TabIndex = 12;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(120, 95);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(36, 23);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Click1);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(201, 124);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(36, 23);
            this.Ln.TabIndex = 14;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(120, 124);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(36, 23);
            this.Ctg.TabIndex = 15;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.Click1);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(162, 125);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(34, 23);
            this.Log.TabIndex = 16;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Sqrtpow
            // 
            this.Sqrtpow.Location = new System.Drawing.Point(162, 154);
            this.Sqrtpow.Name = "Sqrtpow";
            this.Sqrtpow.Size = new System.Drawing.Size(34, 23);
            this.Sqrtpow.TabIndex = 18;
            this.Sqrtpow.Text = "Sp";
            this.Sqrtpow.UseVisualStyleBackColor = true;
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(202, 154);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(35, 23);
            this.Pow.TabIndex = 19;
            this.Pow.Text = "Pow";
            this.Pow.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(162, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Sqrtpow);
            this.Controls.Add(this.button2);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Sqrtpow;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button button5;
    }
}

