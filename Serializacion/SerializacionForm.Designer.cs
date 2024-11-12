namespace Serializacion
{
    partial class SerializacionForm
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
            Serializacionbutton = new Button();
            Serializacionjsonbutton = new Button();
            Deserializacionbutton = new Button();
            jsonbutton = new Button();
            dgv = new DataGridView();
            dvgjson = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgjson).BeginInit();
            SuspendLayout();
            // 
            // Serializacionbutton
            // 
            Serializacionbutton.BackColor = Color.Transparent;
            Serializacionbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Serializacionbutton.Location = new Point(89, 207);
            Serializacionbutton.Name = "Serializacionbutton";
            Serializacionbutton.Size = new Size(158, 65);
            Serializacionbutton.TabIndex = 20;
            Serializacionbutton.Text = "Serializacion Xml";
            Serializacionbutton.UseVisualStyleBackColor = false;
            Serializacionbutton.Click += Serializacionbutton_Click;
            // 
            // Serializacionjsonbutton
            // 
            Serializacionjsonbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Serializacionjsonbutton.Location = new Point(843, 211);
            Serializacionjsonbutton.Name = "Serializacionjsonbutton";
            Serializacionjsonbutton.Size = new Size(158, 65);
            Serializacionjsonbutton.TabIndex = 21;
            Serializacionjsonbutton.Text = "Serializacion Json";
            Serializacionjsonbutton.UseVisualStyleBackColor = true;
            Serializacionjsonbutton.Click += Serializacionjsonbutton_Click;
            // 
            // Deserializacionbutton
            // 
            Deserializacionbutton.BackColor = Color.Transparent;
            Deserializacionbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deserializacionbutton.Location = new Point(450, 278);
            Deserializacionbutton.Name = "Deserializacionbutton";
            Deserializacionbutton.Size = new Size(186, 69);
            Deserializacionbutton.TabIndex = 22;
            Deserializacionbutton.Text = "Deserializacion Xml";
            Deserializacionbutton.UseVisualStyleBackColor = false;
            Deserializacionbutton.Click += Deserializacionbutton_Click;
            // 
            // jsonbutton
            // 
            jsonbutton.BackColor = Color.Transparent;
            jsonbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            jsonbutton.Location = new Point(450, 517);
            jsonbutton.Name = "jsonbutton";
            jsonbutton.Size = new Size(186, 69);
            jsonbutton.TabIndex = 23;
            jsonbutton.Text = "Deserializacion Json";
            jsonbutton.UseVisualStyleBackColor = false;
            jsonbutton.Click += jsonbutton_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(263, 353);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(551, 158);
            dgv.TabIndex = 24;
            // 
            // dvgjson
            // 
            dvgjson.BackgroundColor = SystemColors.ButtonHighlight;
            dvgjson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgjson.Location = new Point(263, 592);
            dvgjson.Name = "dvgjson";
            dvgjson.RowHeadersWidth = 51;
            dvgjson.Size = new Size(551, 166);
            dvgjson.TabIndex = 25;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(938, 716);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 42);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // SerializacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 771);
            Controls.Add(btnSalir);
            Controls.Add(dvgjson);
            Controls.Add(dgv);
            Controls.Add(jsonbutton);
            Controls.Add(Deserializacionbutton);
            Controls.Add(Serializacionjsonbutton);
            Controls.Add(Serializacionbutton);
            Name = "SerializacionForm";
            Text = "SerializacionForm";
            Load += SerializacionForm_Load;
            Controls.SetChildIndex(Serializacionbutton, 0);
            Controls.SetChildIndex(Serializacionjsonbutton, 0);
            Controls.SetChildIndex(Deserializacionbutton, 0);
            Controls.SetChildIndex(jsonbutton, 0);
            Controls.SetChildIndex(dgv, 0);
            Controls.SetChildIndex(dvgjson, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgjson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Serializacionbutton;
        private Button Serializacionjsonbutton;
        private Button Deserializacionbutton;
        private Button jsonbutton;
        private DataGridView dgv;
        private DataGridView dvgjson;
        private Button btnSalir;
    }
}