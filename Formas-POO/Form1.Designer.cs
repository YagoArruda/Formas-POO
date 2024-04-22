namespace Formas_POO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            formasControle = new TabControl();
            Quadrado = new TabPage();
            label2 = new Label();
            button1 = new Button();
            ladoQuadrado = new TextBox();
            Octagono = new TabPage();
            label8 = new Label();
            button3 = new Button();
            ladoOctogono = new TextBox();
            Pentagono = new TabPage();
            label7 = new Label();
            button4 = new Button();
            ladoPentagono = new TextBox();
            Retangulo = new TabPage();
            label6 = new Label();
            button5 = new Button();
            baseRetangulo = new TextBox();
            label5 = new Label();
            alturaRetangulo = new TextBox();
            Triangulo = new TabPage();
            label1 = new Label();
            button6 = new Button();
            baseTriangulo = new TextBox();
            label3 = new Label();
            alturaTriangulo = new TextBox();
            Circulo = new TabPage();
            label4 = new Label();
            button7 = new Button();
            raioCirculo = new TextBox();
            Hexagono = new TabPage();
            label9 = new Label();
            button8 = new Button();
            ladoHexagono = new TextBox();
            Area = new Label();
            Perimetro = new Label();
            imagemForma = new PictureBox();
            groupBox1 = new GroupBox();
            formasControle.SuspendLayout();
            Quadrado.SuspendLayout();
            Octagono.SuspendLayout();
            Pentagono.SuspendLayout();
            Retangulo.SuspendLayout();
            Triangulo.SuspendLayout();
            Circulo.SuspendLayout();
            Hexagono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagemForma).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // formasControle
            // 
            formasControle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            formasControle.Controls.Add(Quadrado);
            formasControle.Controls.Add(Octagono);
            formasControle.Controls.Add(Pentagono);
            formasControle.Controls.Add(Retangulo);
            formasControle.Controls.Add(Triangulo);
            formasControle.Controls.Add(Circulo);
            formasControle.Controls.Add(Hexagono);
            formasControle.Location = new Point(246, 139);
            formasControle.Name = "formasControle";
            formasControle.SelectedIndex = 0;
            formasControle.Size = new Size(352, 148);
            formasControle.TabIndex = 1;
            // 
            // Quadrado
            // 
            Quadrado.Controls.Add(label2);
            Quadrado.Controls.Add(button1);
            Quadrado.Controls.Add(ladoQuadrado);
            Quadrado.Location = new Point(4, 24);
            Quadrado.Name = "Quadrado";
            Quadrado.Padding = new Padding(3);
            Quadrado.Size = new Size(344, 120);
            Quadrado.TabIndex = 0;
            Quadrado.Text = "Quadrado";
            Quadrado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Lado:";
            // 
            // button1
            // 
            button1.Location = new Point(112, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ladoQuadrado
            // 
            ladoQuadrado.Location = new Point(6, 53);
            ladoQuadrado.Name = "ladoQuadrado";
            ladoQuadrado.Size = new Size(100, 23);
            ladoQuadrado.TabIndex = 1;
            // 
            // Octagono
            // 
            Octagono.Controls.Add(label8);
            Octagono.Controls.Add(button3);
            Octagono.Controls.Add(ladoOctogono);
            Octagono.Location = new Point(4, 24);
            Octagono.Name = "Octagono";
            Octagono.Padding = new Padding(3);
            Octagono.Size = new Size(344, 120);
            Octagono.TabIndex = 1;
            Octagono.Text = "Octagono";
            Octagono.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 34);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 2;
            label8.Text = "Lado:";
            // 
            // button3
            // 
            button3.Location = new Point(112, 51);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ladoOctogono
            // 
            ladoOctogono.Location = new Point(6, 52);
            ladoOctogono.Name = "ladoOctogono";
            ladoOctogono.Size = new Size(100, 23);
            ladoOctogono.TabIndex = 1;
            // 
            // Pentagono
            // 
            Pentagono.Controls.Add(label7);
            Pentagono.Controls.Add(button4);
            Pentagono.Controls.Add(ladoPentagono);
            Pentagono.Location = new Point(4, 24);
            Pentagono.Name = "Pentagono";
            Pentagono.Padding = new Padding(3);
            Pentagono.Size = new Size(344, 120);
            Pentagono.TabIndex = 2;
            Pentagono.Text = "Pentagono";
            Pentagono.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 34);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 2;
            label7.Text = "Lado:";
            // 
            // button4
            // 
            button4.Location = new Point(112, 52);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ladoPentagono
            // 
            ladoPentagono.Location = new Point(6, 52);
            ladoPentagono.Name = "ladoPentagono";
            ladoPentagono.Size = new Size(100, 23);
            ladoPentagono.TabIndex = 1;
            // 
            // Retangulo
            // 
            Retangulo.Controls.Add(label6);
            Retangulo.Controls.Add(button5);
            Retangulo.Controls.Add(baseRetangulo);
            Retangulo.Controls.Add(label5);
            Retangulo.Controls.Add(alturaRetangulo);
            Retangulo.Location = new Point(4, 24);
            Retangulo.Name = "Retangulo";
            Retangulo.Padding = new Padding(3);
            Retangulo.Size = new Size(344, 120);
            Retangulo.TabIndex = 3;
            Retangulo.Text = "Retangulo";
            Retangulo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 36);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Altura:";
            // 
            // button5
            // 
            button5.Location = new Point(218, 54);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Calcular";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // baseRetangulo
            // 
            baseRetangulo.Location = new Point(6, 54);
            baseRetangulo.Name = "baseRetangulo";
            baseRetangulo.Size = new Size(100, 23);
            baseRetangulo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 36);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 2;
            label5.Text = "Base:";
            // 
            // alturaRetangulo
            // 
            alturaRetangulo.Location = new Point(112, 54);
            alturaRetangulo.Name = "alturaRetangulo";
            alturaRetangulo.Size = new Size(100, 23);
            alturaRetangulo.TabIndex = 5;
            // 
            // Triangulo
            // 
            Triangulo.Controls.Add(label1);
            Triangulo.Controls.Add(button6);
            Triangulo.Controls.Add(baseTriangulo);
            Triangulo.Controls.Add(label3);
            Triangulo.Controls.Add(alturaTriangulo);
            Triangulo.Location = new Point(4, 24);
            Triangulo.Name = "Triangulo";
            Triangulo.Padding = new Padding(3);
            Triangulo.Size = new Size(344, 120);
            Triangulo.TabIndex = 4;
            Triangulo.Text = "Triangulo";
            Triangulo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 10;
            label1.Text = "Altura:";
            // 
            // button6
            // 
            button6.Location = new Point(218, 54);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "Calcular";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // baseTriangulo
            // 
            baseTriangulo.Location = new Point(6, 54);
            baseTriangulo.Name = "baseTriangulo";
            baseTriangulo.Size = new Size(100, 23);
            baseTriangulo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Base:";
            // 
            // alturaTriangulo
            // 
            alturaTriangulo.Location = new Point(112, 54);
            alturaTriangulo.Name = "alturaTriangulo";
            alturaTriangulo.Size = new Size(100, 23);
            alturaTriangulo.TabIndex = 9;
            // 
            // Circulo
            // 
            Circulo.Controls.Add(label4);
            Circulo.Controls.Add(button7);
            Circulo.Controls.Add(raioCirculo);
            Circulo.Location = new Point(4, 24);
            Circulo.Name = "Circulo";
            Circulo.Padding = new Padding(3);
            Circulo.Size = new Size(344, 120);
            Circulo.TabIndex = 5;
            Circulo.Text = "Circulo";
            Circulo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 2;
            label4.Text = "Raio:";
            // 
            // button7
            // 
            button7.Location = new Point(112, 54);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "Calcular";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // raioCirculo
            // 
            raioCirculo.Location = new Point(6, 54);
            raioCirculo.Name = "raioCirculo";
            raioCirculo.Size = new Size(100, 23);
            raioCirculo.TabIndex = 1;
            // 
            // Hexagono
            // 
            Hexagono.Controls.Add(label9);
            Hexagono.Controls.Add(button8);
            Hexagono.Controls.Add(ladoHexagono);
            Hexagono.Location = new Point(4, 24);
            Hexagono.Name = "Hexagono";
            Hexagono.Padding = new Padding(3);
            Hexagono.Size = new Size(344, 120);
            Hexagono.TabIndex = 6;
            Hexagono.Text = "Hexagono";
            Hexagono.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 36);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 2;
            label9.Text = "Lado:";
            // 
            // button8
            // 
            button8.Location = new Point(112, 54);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 7;
            button8.Text = "Calcular";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // ladoHexagono
            // 
            ladoHexagono.Location = new Point(6, 54);
            ladoHexagono.Name = "ladoHexagono";
            ladoHexagono.Size = new Size(100, 23);
            ladoHexagono.TabIndex = 1;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.Location = new Point(152, 51);
            Area.Name = "Area";
            Area.Size = new Size(34, 15);
            Area.TabIndex = 3;
            Area.Text = "Area:";
            // 
            // Perimetro
            // 
            Perimetro.AutoSize = true;
            Perimetro.Location = new Point(152, 81);
            Perimetro.Name = "Perimetro";
            Perimetro.Size = new Size(62, 15);
            Perimetro.TabIndex = 4;
            Perimetro.Text = "Perimetro:";
            // 
            // imagemForma
            // 
            imagemForma.Image = (Image)resources.GetObject("imagemForma.Image");
            imagemForma.Location = new Point(10, 26);
            imagemForma.Name = "imagemForma";
            imagemForma.Size = new Size(136, 100);
            imagemForma.SizeMode = PictureBoxSizeMode.Zoom;
            imagemForma.TabIndex = 5;
            imagemForma.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(imagemForma);
            groupBox1.Controls.Add(Perimetro);
            groupBox1.Controls.Add(Area);
            groupBox1.Location = new Point(246, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 132);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(formasControle);
            Name = "Form1";
            Text = "Formas - POO - Daniel V e Yago A";
            formasControle.ResumeLayout(false);
            Quadrado.ResumeLayout(false);
            Quadrado.PerformLayout();
            Octagono.ResumeLayout(false);
            Octagono.PerformLayout();
            Pentagono.ResumeLayout(false);
            Pentagono.PerformLayout();
            Retangulo.ResumeLayout(false);
            Retangulo.PerformLayout();
            Triangulo.ResumeLayout(false);
            Triangulo.PerformLayout();
            Circulo.ResumeLayout(false);
            Circulo.PerformLayout();
            Hexagono.ResumeLayout(false);
            Hexagono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagemForma).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl formasControle;
        private TabPage Quadrado;
        private TabPage Octagono;
        private Label label2;
        private TextBox ladoQuadrado;
        private Label Area;
        private Label Perimetro;
        private TabPage Pentagono;
        private TabPage Retangulo;
        private TabPage Triangulo;
        private TabPage Circulo;
        private TabPage Hexagono;
        private Label label4;
        private TextBox raioCirculo;
        private Label label5;
        private TextBox baseRetangulo;
        private Label label8;
        private TextBox ladoOctogono;
        private Label label7;
        private TextBox ladoPentagono;
        private Label label6;
        private TextBox alturaRetangulo;
        private Label label9;
        private TextBox ladoHexagono;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label1;
        private Label label3;
        private TextBox baseTriangulo;
        private TextBox alturaTriangulo;
        private PictureBox imagemForma;
        private GroupBox groupBox1;
    }

}
