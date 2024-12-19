namespace FormAppFinal
{
    partial class GestionUsuarios
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
            ListClients = new ListBox();
            btnGuardar = new Button();
            btnDelete = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtTarjeta = new TextBox();
            btnEditar = new Button();
            label5 = new Label();
            lblId = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // ListClients
            // 
            ListClients.FormattingEnabled = true;
            ListClients.Location = new Point(94, 49);
            ListClients.Name = "ListClients";
            ListClients.Size = new Size(243, 229);
            ListClients.TabIndex = 0;
            ListClients.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(641, 263);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(571, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 86);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(571, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 167);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            label3.Click += label3_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(571, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(145, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 207);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 10;
            label4.Text = "Tarjeta de credito";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Location = new Point(571, 204);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.Size = new Size(145, 23);
            txtTarjeta.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(181, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 49);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 12;
            label5.Text = "ID:";
            label5.Click += label5_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(571, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 13;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(100, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(txtTarjeta);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnDelete);
            Controls.Add(btnGuardar);
            Controls.Add(ListClients);
            Name = "GestionUsuarios";
            Text = "Form2";
            Load += GestionUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListClients;
        private Button btnGuardar;
        private Button btnDelete;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtTarjeta;
        private Button btnEditar;
        private Label label5;
        private Label lblId;
        private Button btnAgregar;
    }
}