namespace BankLibrery
{
    partial class BankUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankUIForm));
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            TxtSaldo = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            label2 = new Label();
            TxtCuenta = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(450, 22);
            label5.Name = "label5";
            label5.Size = new Size(218, 50);
            label5.TabIndex = 18;
            label5.Text = "Bienvenido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Moccasin;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TxtSaldo);
            panel2.Controls.Add(TxtApellido);
            panel2.Controls.Add(TxtNombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TxtCuenta);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(294, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 183);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 1;
            label1.Text = "Cuenta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 140);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 5;
            label4.Text = "Saldo";
            // 
            // TxtSaldo
            // 
            TxtSaldo.Location = new Point(179, 140);
            TxtSaldo.Name = "TxtSaldo";
            TxtSaldo.Size = new Size(309, 27);
            TxtSaldo.TabIndex = 6;
            TxtSaldo.TextChanged += TxtSaldo_TextChanged;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(179, 97);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(309, 27);
            TxtApellido.TabIndex = 7;
            TxtApellido.TextChanged += TxtApellido_TextChanged;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(179, 53);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(309, 27);
            TxtNombre.TabIndex = 8;
            TxtNombre.TextChanged += TxtNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 3;
            label2.Text = "Primer Apellido";
            // 
            // TxtCuenta
            // 
            TxtCuenta.Location = new Point(179, 14);
            TxtCuenta.Name = "TxtCuenta";
            TxtCuenta.Size = new Size(309, 27);
            TxtCuenta.TabIndex = 2;
            TxtCuenta.TextChanged += TxtCuenta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 52);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 4;
            label3.Text = "Primer Nombre";
            // 
            // BankUIForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1103, 716);
            Controls.Add(panel2);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BankUIForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankUIForm";
            Load += BankUIForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private TextBox TxtSaldo;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Label label2;
        private TextBox TxtCuenta;
        private Label label3;
    }
}