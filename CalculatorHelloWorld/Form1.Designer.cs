namespace CalculatorHelloWorld {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Display = new System.Windows.Forms.TextBox();
            this.BtnCE = new System.Windows.Forms.Button();
            this.Display2 = new System.Windows.Forms.TextBox();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnNegate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Gray;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.White;
            this.Display.Location = new System.Drawing.Point(3, 58);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(295, 39);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCE
            // 
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCE.ForeColor = System.Drawing.Color.White;
            this.BtnCE.Location = new System.Drawing.Point(1, 9);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(71, 58);
            this.BtnCE.TabIndex = 1;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // Display2
            // 
            this.Display2.BackColor = System.Drawing.Color.Gray;
            this.Display2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display2.ForeColor = System.Drawing.Color.White;
            this.Display2.Location = new System.Drawing.Point(3, 12);
            this.Display2.Multiline = true;
            this.Display2.Name = "Display2";
            this.Display2.Size = new System.Drawing.Size(295, 39);
            this.Display2.TabIndex = 2;
            this.Display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnC
            // 
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(78, 9);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(71, 58);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.FlatAppearance.BorderSize = 0;
            this.BtnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiv.ForeColor = System.Drawing.Color.White;
            this.BtnDiv.Location = new System.Drawing.Point(232, 9);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(71, 58);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "÷";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(155, 9);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(71, 58);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "DEL";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.FlatAppearance.BorderSize = 0;
            this.BtnMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMul.ForeColor = System.Drawing.Color.White;
            this.BtnMul.Location = new System.Drawing.Point(232, 73);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(71, 58);
            this.BtnMul.TabIndex = 9;
            this.BtnMul.Text = "x";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.FlatAppearance.BorderSize = 0;
            this.BtnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.ForeColor = System.Drawing.Color.White;
            this.BtnNine.Location = new System.Drawing.Point(155, 73);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(71, 58);
            this.BtnNine.TabIndex = 8;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.FlatAppearance.BorderSize = 0;
            this.BtnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.ForeColor = System.Drawing.Color.White;
            this.BtnEight.Location = new System.Drawing.Point(78, 73);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(71, 58);
            this.BtnEight.TabIndex = 7;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.FlatAppearance.BorderSize = 0;
            this.BtnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.ForeColor = System.Drawing.Color.White;
            this.BtnSeven.Location = new System.Drawing.Point(1, 73);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(71, 58);
            this.BtnSeven.TabIndex = 6;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.Location = new System.Drawing.Point(232, 137);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(71, 58);
            this.BtnMin.TabIndex = 13;
            this.BtnMin.Text = "-";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.FlatAppearance.BorderSize = 0;
            this.BtnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.ForeColor = System.Drawing.Color.White;
            this.BtnSix.Location = new System.Drawing.Point(155, 137);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(71, 58);
            this.BtnSix.TabIndex = 12;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.FlatAppearance.BorderSize = 0;
            this.BtnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.ForeColor = System.Drawing.Color.White;
            this.BtnFive.Location = new System.Drawing.Point(78, 137);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(71, 58);
            this.BtnFive.TabIndex = 11;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.FlatAppearance.BorderSize = 0;
            this.BtnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.ForeColor = System.Drawing.Color.White;
            this.BtnFour.Location = new System.Drawing.Point(1, 137);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(71, 58);
            this.BtnFour.TabIndex = 10;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.ForeColor = System.Drawing.Color.White;
            this.BtnPlus.Location = new System.Drawing.Point(232, 201);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(71, 58);
            this.BtnPlus.TabIndex = 17;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.FlatAppearance.BorderSize = 0;
            this.BtnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.ForeColor = System.Drawing.Color.White;
            this.BtnThree.Location = new System.Drawing.Point(155, 201);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(71, 58);
            this.BtnThree.TabIndex = 16;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.FlatAppearance.BorderSize = 0;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.ForeColor = System.Drawing.Color.White;
            this.BtnTwo.Location = new System.Drawing.Point(78, 201);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(71, 58);
            this.BtnTwo.TabIndex = 15;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.FlatAppearance.BorderSize = 0;
            this.BtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.ForeColor = System.Drawing.Color.White;
            this.BtnOne.Location = new System.Drawing.Point(1, 201);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(71, 58);
            this.BtnOne.TabIndex = 14;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.FlatAppearance.BorderSize = 0;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.ForeColor = System.Drawing.Color.White;
            this.BtnEqual.Location = new System.Drawing.Point(232, 265);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(71, 58);
            this.BtnEqual.TabIndex = 21;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.FlatAppearance.BorderSize = 0;
            this.BtnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoint.ForeColor = System.Drawing.Color.White;
            this.BtnPoint.Location = new System.Drawing.Point(155, 265);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(71, 58);
            this.BtnPoint.TabIndex = 20;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.FlatAppearance.BorderSize = 0;
            this.BtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.ForeColor = System.Drawing.Color.White;
            this.BtnZero.Location = new System.Drawing.Point(78, 265);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(71, 58);
            this.BtnZero.TabIndex = 19;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // BtnNegate
            // 
            this.BtnNegate.FlatAppearance.BorderSize = 0;
            this.BtnNegate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNegate.ForeColor = System.Drawing.Color.White;
            this.BtnNegate.Location = new System.Drawing.Point(1, 265);
            this.BtnNegate.Name = "BtnNegate";
            this.BtnNegate.Size = new System.Drawing.Size(71, 58);
            this.BtnNegate.TabIndex = 18;
            this.BtnNegate.Text = "±";
            this.BtnNegate.UseVisualStyleBackColor = true;
            this.BtnNegate.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Display);
            this.panel1.Controls.Add(this.Display2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 105);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.BtnCE);
            this.panel2.Controls.Add(this.BtnEqual);
            this.panel2.Controls.Add(this.BtnC);
            this.panel2.Controls.Add(this.BtnPoint);
            this.panel2.Controls.Add(this.BtnDel);
            this.panel2.Controls.Add(this.BtnZero);
            this.panel2.Controls.Add(this.BtnDiv);
            this.panel2.Controls.Add(this.BtnNegate);
            this.panel2.Controls.Add(this.BtnSeven);
            this.panel2.Controls.Add(this.BtnPlus);
            this.panel2.Controls.Add(this.BtnEight);
            this.panel2.Controls.Add(this.BtnThree);
            this.panel2.Controls.Add(this.BtnNine);
            this.panel2.Controls.Add(this.BtnTwo);
            this.panel2.Controls.Add(this.BtnMul);
            this.panel2.Controls.Add(this.BtnOne);
            this.panel2.Controls.Add(this.BtnFour);
            this.panel2.Controls.Add(this.BtnMin);
            this.panel2.Controls.Add(this.BtnFive);
            this.panel2.Controls.Add(this.BtnSix);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 326);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.Operation_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.TextBox Display2;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnNegate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

