namespace TrabajoFinalHerramientasDeProgramacion2
{
    partial class frm_ListaUsuarios
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
            this.BtnFinal = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnPrincipio = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBucarUsuario = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.btn_Atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFinal
            // 
            this.BtnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFinal.Location = new System.Drawing.Point(617, 407);
            this.BtnFinal.Name = "BtnFinal";
            this.BtnFinal.Size = new System.Drawing.Size(49, 31);
            this.BtnFinal.TabIndex = 46;
            this.BtnFinal.Text = ">>";
            this.BtnFinal.UseVisualStyleBackColor = true;
            this.BtnFinal.Click += new System.EventHandler(this.BtnFinal_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSiguiente.Location = new System.Drawing.Point(562, 407);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(49, 31);
            this.BtnSiguiente.TabIndex = 45;
            this.BtnSiguiente.Text = ">";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAtras.Location = new System.Drawing.Point(416, 407);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(49, 31);
            this.BtnAtras.TabIndex = 44;
            this.BtnAtras.Text = "<";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnPrincipio
            // 
            this.BtnPrincipio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrincipio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrincipio.Location = new System.Drawing.Point(361, 407);
            this.BtnPrincipio.Name = "BtnPrincipio";
            this.BtnPrincipio.Size = new System.Drawing.Size(49, 31);
            this.BtnPrincipio.TabIndex = 43;
            this.BtnPrincipio.Text = "<<";
            this.BtnPrincipio.UseVisualStyleBackColor = true;
            this.BtnPrincipio.Click += new System.EventHandler(this.BtnPrincipio_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(471, 405);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(85, 32);
            this.btnVerTodo.TabIndex = 42;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(12, 274);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbTipoUsuario.TabIndex = 41;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(10, 206);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 40;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(223, 111);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(570, 288);
            this.dgvUsuarios.TabIndex = 39;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(710, 25);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 38;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(617, 25);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 37;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(137, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 20);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(32, 321);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 32);
            this.btnActualizar.TabIndex = 35;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(9, 251);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(65, 13);
            this.lblTipoUsuario.TabIndex = 34;
            this.lblTipoUsuario.Text = "Tipo usuario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(8, 190);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // lblBucarUsuario
            // 
            this.lblBucarUsuario.AutoSize = true;
            this.lblBucarUsuario.Location = new System.Drawing.Point(9, 126);
            this.lblBucarUsuario.Name = "lblBucarUsuario";
            this.lblBucarUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblBucarUsuario.TabIndex = 32;
            this.lblBucarUsuario.Text = "Buscar cedula";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(8, 145);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(123, 20);
            this.txtBuscarUsuario.TabIndex = 31;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 39);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Lista de usuarios";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(250, 12);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(296, 39);
            this.lblListaUsuarios.TabIndex = 30;
            this.lblListaUsuarios.Text = "Lista de usuarios";
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(8, 12);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(54, 49);
            this.btn_Atras.TabIndex = 28;
            this.btn_Atras.Text = "ATRÁS";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // frm_ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFinal);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnPrincipio);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblBucarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.btn_Atras);
            this.Name = "frm_ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ListaUsuarios";
            this.Load += new System.EventHandler(this.frm_ListaUsuarios_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFinal;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnPrincipio;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBucarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Button btn_Atras;
    }
}