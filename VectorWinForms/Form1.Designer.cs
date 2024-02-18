namespace VectorWinForms
{
    partial class Form1
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
            calculo = new Button();
            SumaRes = new Label();
            RestaRes = new Label();
            MultRes = new Label();
            txtV1x = new TextBox();
            txtV1y = new TextBox();
            txtV2y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtV2x = new TextBox();
            limpiar = new Button();
            SuspendLayout();
            // 
            // calculo
            // 
            calculo.BackColor = SystemColors.ScrollBar;
            calculo.Cursor = Cursors.Hand;
            calculo.Location = new Point(261, 317);
            calculo.Name = "calculo";
            calculo.Size = new Size(94, 29);
            calculo.TabIndex = 0;
            calculo.Text = "Calcular";
            calculo.UseVisualStyleBackColor = false;
            calculo.Click += calculo_Click;
            // 
            // SumaRes
            // 
            SumaRes.AutoSize = true;
            SumaRes.Location = new Point(188, 278);
            SumaRes.Name = "SumaRes";
            SumaRes.Size = new Size(0, 20);
            SumaRes.TabIndex = 1;
            // 
            // RestaRes
            // 
            RestaRes.AutoSize = true;
            RestaRes.Location = new Point(369, 278);
            RestaRes.Name = "RestaRes";
            RestaRes.Size = new Size(0, 20);
            RestaRes.TabIndex = 2;
            // 
            // MultRes
            // 
            MultRes.AutoSize = true;
            MultRes.Location = new Point(572, 278);
            MultRes.Name = "MultRes";
            MultRes.Size = new Size(0, 20);
            MultRes.TabIndex = 3;
            // 
            // txtV1x
            // 
            txtV1x.Location = new Point(178, 119);
            txtV1x.Name = "txtV1x";
            txtV1x.Size = new Size(125, 27);
            txtV1x.TabIndex = 4;
            // 
            // txtV1y
            // 
            txtV1y.Location = new Point(473, 119);
            txtV1y.Name = "txtV1y";
            txtV1y.Size = new Size(125, 27);
            txtV1y.TabIndex = 6;
            // 
            // txtV2y
            // 
            txtV2y.Location = new Point(473, 185);
            txtV2y.Name = "txtV2y";
            txtV2y.Size = new Size(125, 27);
            txtV2y.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 96);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 8;
            label1.Text = "Vector 1 X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 162);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 9;
            label2.Text = "Vector 2 X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 10;
            label3.Text = "Vector 1 Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 162);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 11;
            label4.Text = "Vector 2 Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 258);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 14;
            label5.Text = "Resultado Multiplicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 258);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 13;
            label6.Text = "Resultado Resta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 258);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 12;
            label7.Text = "Resultado Suma";
            // 
            // txtV2x
            // 
            txtV2x.Location = new Point(178, 185);
            txtV2x.Name = "txtV2x";
            txtV2x.Size = new Size(125, 27);
            txtV2x.TabIndex = 5;
            // 
            // limpiar
            // 
            limpiar.BackColor = SystemColors.MenuHighlight;
            limpiar.Cursor = Cursors.Hand;
            limpiar.Location = new Point(423, 317);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(94, 29);
            limpiar.TabIndex = 15;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(limpiar);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtV2y);
            Controls.Add(txtV1y);
            Controls.Add(txtV2x);
            Controls.Add(txtV1x);
            Controls.Add(MultRes);
            Controls.Add(RestaRes);
            Controls.Add(SumaRes);
            Controls.Add(calculo);
            Name = "Form1";
            Text = "Vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculo;
        private Label SumaRes;
        private Label RestaRes;
        private Label MultRes;
        private TextBox txtV1x;
        private TextBox txtV1y;
        private TextBox txtV2y;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtV2x;
        private Button limpiar;
    }
}