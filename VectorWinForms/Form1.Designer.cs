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
            label8 = new Label();
            SuspendLayout();
            // 
            // calculo
            // 
            calculo.BackColor = SystemColors.ScrollBar;
            calculo.Cursor = Cursors.Hand;
            calculo.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calculo.Location = new Point(261, 332);
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
            SumaRes.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SumaRes.Location = new Point(188, 293);
            SumaRes.Name = "SumaRes";
            SumaRes.Size = new Size(0, 19);
            SumaRes.TabIndex = 1;
            // 
            // RestaRes
            // 
            RestaRes.AutoSize = true;
            RestaRes.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RestaRes.Location = new Point(369, 293);
            RestaRes.Name = "RestaRes";
            RestaRes.Size = new Size(0, 19);
            RestaRes.TabIndex = 2;
            // 
            // MultRes
            // 
            MultRes.AutoSize = true;
            MultRes.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MultRes.Location = new Point(572, 293);
            MultRes.Name = "MultRes";
            MultRes.Size = new Size(0, 19);
            MultRes.TabIndex = 3;
            // 
            // txtV1x
            // 
            txtV1x.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtV1x.Location = new Point(178, 134);
            txtV1x.Name = "txtV1x";
            txtV1x.Size = new Size(125, 25);
            txtV1x.TabIndex = 4;
            txtV1x.TextChanged += txtV1x_TextChanged;
            txtV1x.KeyPress += txtV1x_KeyPress;
            // 
            // txtV1y
            // 
            txtV1y.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtV1y.Location = new Point(473, 134);
            txtV1y.Name = "txtV1y";
            txtV1y.Size = new Size(125, 25);
            txtV1y.TabIndex = 6;
            txtV1y.KeyPress += txtV1y_KeyPress;
            // 
            // txtV2y
            // 
            txtV2y.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtV2y.Location = new Point(473, 200);
            txtV2y.Name = "txtV2y";
            txtV2y.Size = new Size(125, 25);
            txtV2y.TabIndex = 7;
            txtV2y.TextChanged += txtV2y_TextChanged;
            txtV2y.KeyPress += txtV2y_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 111);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 8;
            label1.Text = "Vector 1 X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 177);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 9;
            label2.Text = "Vector 2 X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(495, 111);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 10;
            label3.Text = "Vector 1 Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(495, 177);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 11;
            label4.Text = "Vector 2 Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(506, 273);
            label5.Name = "label5";
            label5.Size = new Size(190, 19);
            label5.TabIndex = 14;
            label5.Text = "Resultado Multiplicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(335, 273);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 13;
            label6.Text = "Resultado Resta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(147, 273);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 12;
            label7.Text = "Resultado Suma";
            // 
            // txtV2x
            // 
            txtV2x.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtV2x.Location = new Point(178, 200);
            txtV2x.Name = "txtV2x";
            txtV2x.Size = new Size(125, 25);
            txtV2x.TabIndex = 5;
            txtV2x.KeyPress += txtV2x_KeyPress;
            // 
            // limpiar
            // 
            limpiar.BackColor = SystemColors.MenuHighlight;
            limpiar.Cursor = Cursors.Hand;
            limpiar.Font = new Font("Bitter", 9F, FontStyle.Regular, GraphicsUnit.Point);
            limpiar.Location = new Point(423, 332);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(94, 29);
            limpiar.TabIndex = 15;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Bitter", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(245, 38);
            label8.Name = "label8";
            label8.Size = new Size(313, 32);
            label8.TabIndex = 16;
            label8.Text = "Resolución de Vectores";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
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
        private Label label8;
    }
}