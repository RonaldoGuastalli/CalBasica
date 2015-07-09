namespace AtividadeS1_2_Calculadora_Client
{
    partial class Calculadora
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.rbtSomar = new System.Windows.Forms.RadioButton();
            this.rbtDividir = new System.Windows.Forms.RadioButton();
            this.rbtMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbtSubtrair = new System.Windows.Forms.RadioButton();
            this.lblLabelResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(106, 97);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(226, 31);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(106, 168);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(226, 31);
            this.txtValor2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(365, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 34);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(106, 66);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(80, 25);
            this.lblValor1.TabIndex = 3;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(106, 140);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(80, 25);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "Valor 2";
            // 
            // rbtSomar
            // 
            this.rbtSomar.AutoSize = true;
            this.rbtSomar.Checked = true;
            this.rbtSomar.Location = new System.Drawing.Point(368, 66);
            this.rbtSomar.Name = "rbtSomar";
            this.rbtSomar.Size = new System.Drawing.Size(105, 29);
            this.rbtSomar.TabIndex = 5;
            this.rbtSomar.TabStop = true;
            this.rbtSomar.Text = "Somar";
            this.rbtSomar.UseVisualStyleBackColor = true;
            // 
            // rbtDividir
            // 
            this.rbtDividir.AutoSize = true;
            this.rbtDividir.Location = new System.Drawing.Point(368, 170);
            this.rbtDividir.Name = "rbtDividir";
            this.rbtDividir.Size = new System.Drawing.Size(103, 29);
            this.rbtDividir.TabIndex = 6;
            this.rbtDividir.Text = "Dividir";
            this.rbtDividir.UseVisualStyleBackColor = true;
            // 
            // rbtMultiplicar
            // 
            this.rbtMultiplicar.AutoSize = true;
            this.rbtMultiplicar.Location = new System.Drawing.Point(368, 136);
            this.rbtMultiplicar.Name = "rbtMultiplicar";
            this.rbtMultiplicar.Size = new System.Drawing.Size(141, 29);
            this.rbtMultiplicar.TabIndex = 7;
            this.rbtMultiplicar.Text = "Multiplicar";
            this.rbtMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbtSubtrair
            // 
            this.rbtSubtrair.AutoSize = true;
            this.rbtSubtrair.Location = new System.Drawing.Point(368, 101);
            this.rbtSubtrair.Name = "rbtSubtrair";
            this.rbtSubtrair.Size = new System.Drawing.Size(118, 29);
            this.rbtSubtrair.TabIndex = 8;
            this.rbtSubtrair.Text = "Subtrair";
            this.rbtSubtrair.UseVisualStyleBackColor = true;
            // 
            // lblLabelResultado
            // 
            this.lblLabelResultado.AutoSize = true;
            this.lblLabelResultado.Location = new System.Drawing.Point(101, 276);
            this.lblLabelResultado.Name = "lblLabelResultado";
            this.lblLabelResultado.Size = new System.Drawing.Size(121, 25);
            this.lblLabelResultado.TabIndex = 9;
            this.lblLabelResultado.Text = "Resultado: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(211, 276);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 10;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 358);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblLabelResultado);
            this.Controls.Add(this.rbtSubtrair);
            this.Controls.Add(this.rbtMultiplicar);
            this.Controls.Add(this.rbtDividir);
            this.Controls.Add(this.rbtSomar);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.RadioButton rbtSomar;
        private System.Windows.Forms.RadioButton rbtDividir;
        private System.Windows.Forms.RadioButton rbtMultiplicar;
        private System.Windows.Forms.RadioButton rbtSubtrair;
        private System.Windows.Forms.Label lblLabelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}

