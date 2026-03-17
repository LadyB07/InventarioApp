namespace InventarioApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnExportarTexto = new Button();
            btnRespaldoBinario = new Button();
            btnVistaPreviaMemoria = new Button();
            dgvProductos = new DataGridView();
            rtbVistaPrevia = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(71, 61);
            label1.Name = "label1";
            label1.Size = new Size(34, 17);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(36, 110);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(46, 163);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 2;
            label3.Text = "Precio :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(31, 220);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 3;
            label4.Text = "Cantidad :";
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(135, 23);
            txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(126, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 157);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(135, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(126, 214);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(135, 23);
            txtCantidad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.GrayText;
            btnAgregar.Location = new Point(36, 320);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 30);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.GrayText;
            btnEditar.Location = new Point(189, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.GrayText;
            btnEliminar.Location = new Point(345, 320);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportarTexto
            // 
            btnExportarTexto.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportarTexto.ForeColor = SystemColors.GrayText;
            btnExportarTexto.Location = new Point(31, 372);
            btnExportarTexto.Name = "btnExportarTexto";
            btnExportarTexto.Size = new Size(113, 36);
            btnExportarTexto.TabIndex = 11;
            btnExportarTexto.Text = "ExportarTexto";
            btnExportarTexto.UseVisualStyleBackColor = true;
            btnExportarTexto.Click += btnExportarTexto_Click;
            // 
            // btnRespaldoBinario
            // 
            btnRespaldoBinario.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRespaldoBinario.ForeColor = SystemColors.GrayText;
            btnRespaldoBinario.Location = new Point(175, 372);
            btnRespaldoBinario.Name = "btnRespaldoBinario";
            btnRespaldoBinario.Size = new Size(126, 36);
            btnRespaldoBinario.TabIndex = 12;
            btnRespaldoBinario.Text = "RespaldoBinario";
            btnRespaldoBinario.UseVisualStyleBackColor = true;
            btnRespaldoBinario.Click += btnRespaldoBinario_Click;
            // 
            // btnVistaPreviaMemoria
            // 
            btnVistaPreviaMemoria.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVistaPreviaMemoria.ForeColor = SystemColors.GrayText;
            btnVistaPreviaMemoria.Location = new Point(328, 372);
            btnVistaPreviaMemoria.Name = "btnVistaPreviaMemoria";
            btnVistaPreviaMemoria.Size = new Size(129, 36);
            btnVistaPreviaMemoria.TabIndex = 13;
            btnVistaPreviaMemoria.Text = "VistaPrevia";
            btnVistaPreviaMemoria.UseVisualStyleBackColor = true;
            btnVistaPreviaMemoria.Click += btnVistaPreviaMemoria_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(501, 49);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(287, 379);
            dgvProductos.TabIndex = 14;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // rtbVistaPrevia
            // 
            rtbVistaPrevia.Location = new Point(305, 49);
            rtbVistaPrevia.Name = "rtbVistaPrevia";
            rtbVistaPrevia.Size = new Size(170, 205);
            rtbVistaPrevia.TabIndex = 15;
            rtbVistaPrevia.Text = "";
            rtbVistaPrevia.Click += btnVistaPreviaMemoria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbVistaPrevia);
            Controls.Add(dgvProductos);
            Controls.Add(btnVistaPreviaMemoria);
            Controls.Add(btnRespaldoBinario);
            Controls.Add(btnExportarTexto);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += btnVistaPreviaMemoria_Click;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnExportarTexto;
        private Button btnRespaldoBinario;
        private Button btnVistaPreviaMemoria;
        private DataGridView dgvProductos;
        private RichTextBox rtbVistaPrevia;
    }
}