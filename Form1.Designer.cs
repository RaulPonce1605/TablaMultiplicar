namespace TablaMultiplicar
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
            panelprincipal = new Panel();
            label2 = new Label();
            label1 = new Label();
            buttonclean = new Button();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(255, 224, 192);
            panelprincipal.Controls.Add(label2);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(buttonclean);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(-14, -7);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(1734, 767);
            panelprincipal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(852, 50);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 8;
            label2.Text = "Ponce Rico Jose Raul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // buttonclean
            // 
            buttonclean.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonclean.Location = new Point(104, 473);
            buttonclean.Name = "buttonclean";
            buttonclean.Size = new Size(94, 89);
            buttonclean.TabIndex = 6;
            buttonclean.Text = "limpiar";
            buttonclean.UseVisualStyleBackColor = true;
            buttonclean.Click += buttonclean_Click;
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.Location = new Point(476, 75);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(220, 356);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            richTextBoxresultados.TextChanged += richTextBox1_TextChanged;
            // 
            // buttonver
            // 
            buttonver.Font = new Font("Georgia", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonver.Location = new Point(104, 337);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(94, 59);
            buttonver.TabIndex = 3;
            buttonver.Text = "ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(104, 249);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelnumero.Location = new Point(91, 160);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(165, 19);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿cual tabla quieres?";
            labelnumero.UseMnemonic = false;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.BackColor = Color.LightSlateGray;
            labeltitulo.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltitulo.ForeColor = SystemColors.ButtonFace;
            labeltitulo.Location = new Point(91, 75);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(178, 23);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1721, 763);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private RichTextBox richTextBoxresultados;
        private Button buttonver;
        private TextBox textBoxnum;
        private Button buttonclean;
        private Label label2;
        private Label label1;
    }
}
