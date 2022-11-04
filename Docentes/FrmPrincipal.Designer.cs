namespace Docentes
{
    partial class FrmPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelFomularios = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.gBoxDatos = new System.Windows.Forms.GroupBox();
            this.dgvCatedras = new System.Windows.Forms.DataGridView();
            this.txtBTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFomularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.gBoxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatedras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(58)))), ((int)(((byte)(19)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1184, 30);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(22)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 531);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(0, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 72);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(0, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 72);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(0, 280);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 72);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(0, 358);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(185, 72);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // panelFomularios
            // 
            this.panelFomularios.BackColor = System.Drawing.Color.White;
            this.panelFomularios.Controls.Add(this.btnActualizar);
            this.panelFomularios.Controls.Add(this.dgvProfesores);
            this.panelFomularios.Controls.Add(this.gBoxDatos);
            this.panelFomularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFomularios.Location = new System.Drawing.Point(185, 30);
            this.panelFomularios.Name = "panelFomularios";
            this.panelFomularios.Size = new System.Drawing.Size(999, 531);
            this.panelFomularios.TabIndex = 6;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(446, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(445, 40);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesores.Size = new System.Drawing.Size(542, 331);
            this.dgvProfesores.TabIndex = 1;
            this.dgvProfesores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProfesores_CellMouseDoubleClick);
            // 
            // gBoxDatos
            // 
            this.gBoxDatos.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxDatos.Controls.Add(this.dgvCatedras);
            this.gBoxDatos.Controls.Add(this.txtBTelefono);
            this.gBoxDatos.Controls.Add(this.lblTelefono);
            this.gBoxDatos.Controls.Add(this.txtEmail);
            this.gBoxDatos.Controls.Add(this.lblEmail);
            this.gBoxDatos.Controls.Add(this.txtBDni);
            this.gBoxDatos.Controls.Add(this.lblDni);
            this.gBoxDatos.Controls.Add(this.txtBApellido);
            this.gBoxDatos.Controls.Add(this.lblApellido);
            this.gBoxDatos.Controls.Add(this.txtNombre);
            this.gBoxDatos.Controls.Add(this.lblNombre);
            this.gBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDatos.Location = new System.Drawing.Point(22, 15);
            this.gBoxDatos.Name = "gBoxDatos";
            this.gBoxDatos.Size = new System.Drawing.Size(417, 504);
            this.gBoxDatos.TabIndex = 0;
            this.gBoxDatos.TabStop = false;
            this.gBoxDatos.Text = "Datos Profesores";
            // 
            // dgvCatedras
            // 
            this.dgvCatedras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatedras.Location = new System.Drawing.Point(9, 216);
            this.dgvCatedras.Name = "dgvCatedras";
            this.dgvCatedras.Size = new System.Drawing.Size(399, 282);
            this.dgvCatedras.TabIndex = 10;
            this.dgvCatedras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatedras_CellContentClick);
            // 
            // txtBTelefono
            // 
            this.txtBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBTelefono.Location = new System.Drawing.Point(95, 155);
            this.txtBTelefono.Name = "txtBTelefono";
            this.txtBTelefono.Size = new System.Drawing.Size(313, 24);
            this.txtBTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(6, 157);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(313, 24);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtBDni
            // 
            this.txtBDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBDni.Location = new System.Drawing.Point(95, 94);
            this.txtBDni.Name = "txtBDni";
            this.txtBDni.Size = new System.Drawing.Size(313, 24);
            this.txtBDni.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(6, 97);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 18);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtBApellido
            // 
            this.txtBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBApellido.Location = new System.Drawing.Point(95, 64);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(313, 24);
            this.txtBApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 18);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(95, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelFomularios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFomularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.gBoxDatos.ResumeLayout(false);
            this.gBoxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatedras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelFomularios;
        private System.Windows.Forms.GroupBox gBoxDatos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.TextBox txtBTelefono;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvCatedras;
    }
}