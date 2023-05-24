namespace TrabajoFinalHerramientasDeProgramacion2
{
    partial class frm_Entrega
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEntregados = new System.Windows.Forms.DataGridView();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.btn_Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Cantidad";
            // 
            // btnEntregar
            // 
            this.btnEntregar.Location = new System.Drawing.Point(365, 198);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(63, 31);
            this.btnEntregar.TabIndex = 19;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Cedula beneficiario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(434, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 31);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(305, 79);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(123, 20);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.Text = "Nombre del producto";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(59, 245);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(63, 31);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "ATRÁS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvEntregados
            // 
            this.dgvEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregados.Location = new System.Drawing.Point(507, 79);
            this.dgvEntregados.Name = "dgvEntregados";
            this.dgvEntregados.Size = new System.Drawing.Size(240, 150);
            this.dgvEntregados.TabIndex = 13;
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(59, 79);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.Size = new System.Drawing.Size(240, 150);
            this.dgvDisponibles.TabIndex = 12;
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(14, 14);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(54, 49);
            this.btn_Atras.TabIndex = 11;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // frm_Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnEntregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEntregados);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.btn_Atras);
            this.Name = "frm_Entrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Entrega";
            this.Load += new System.EventHandler(this.frm_Entrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEntregados;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Button btn_Atras;
    }
}