namespace CapaPresentacion
{
    partial class Empleados
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lineVertical = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.txtFApellido = new System.Windows.Forms.TextBox();
            this.lblFApellido = new System.Windows.Forms.Label();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.lblSApellido = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.lblOficio = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.btnSveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(255, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(344, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Información de empleados CITY WALK S.A";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(2, 57);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(969, 208);
            this.dtgEmpleados.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(2, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 26);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Eliminar Empleado";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(2, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 26);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Actualizar Información";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(2, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 26);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Agregar Empleado";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 279);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(265, 18);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Debe elegir un empleado de la lista";
            this.lblInfo.Visible = false;
            // 
            // lineVertical
            // 
            this.lineVertical.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lineVertical.Name = "lineVertical";
            this.lineVertical.Visible = false;
            this.lineVertical.X1 = 450;
            this.lineVertical.X2 = 450;
            this.lineVertical.Y1 = 133;
            this.lineVertical.Y2 = 572;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineVertical});
            this.shapeContainer1.Size = new System.Drawing.Size(983, 578);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.Maroon;
            this.txtFirstName.Location = new System.Drawing.Point(579, 281);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 20);
            this.txtFirstName.TabIndex = 41;
            this.txtFirstName.Visible = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(456, 284);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 13);
            this.lblFirstName.TabIndex = 40;
            this.lblFirstName.Text = "Primer Nombre:";
            this.lblFirstName.Visible = false;
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSecondName.ForeColor = System.Drawing.Color.Maroon;
            this.txtSecondName.Location = new System.Drawing.Point(579, 309);
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(136, 20);
            this.txtSecondName.TabIndex = 43;
            this.txtSecondName.Visible = false;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.ForeColor = System.Drawing.Color.White;
            this.lblSecondName.Location = new System.Drawing.Point(456, 312);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(108, 13);
            this.lblSecondName.TabIndex = 42;
            this.lblSecondName.Text = "Segundo Nombre:";
            this.lblSecondName.Visible = false;
            // 
            // txtFApellido
            // 
            this.txtFApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFApellido.ForeColor = System.Drawing.Color.Maroon;
            this.txtFApellido.Location = new System.Drawing.Point(579, 338);
            this.txtFApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtFApellido.Name = "txtFApellido";
            this.txtFApellido.Size = new System.Drawing.Size(136, 20);
            this.txtFApellido.TabIndex = 45;
            this.txtFApellido.Visible = false;
            // 
            // lblFApellido
            // 
            this.lblFApellido.AutoSize = true;
            this.lblFApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFApellido.ForeColor = System.Drawing.Color.White;
            this.lblFApellido.Location = new System.Drawing.Point(456, 341);
            this.lblFApellido.Name = "lblFApellido";
            this.lblFApellido.Size = new System.Drawing.Size(95, 13);
            this.lblFApellido.TabIndex = 44;
            this.lblFApellido.Text = "Primer Apellido:";
            this.lblFApellido.Visible = false;
            // 
            // txtSApellido
            // 
            this.txtSApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSApellido.ForeColor = System.Drawing.Color.Maroon;
            this.txtSApellido.Location = new System.Drawing.Point(579, 370);
            this.txtSApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(136, 20);
            this.txtSApellido.TabIndex = 47;
            this.txtSApellido.Visible = false;
            // 
            // lblSApellido
            // 
            this.lblSApellido.AutoSize = true;
            this.lblSApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSApellido.ForeColor = System.Drawing.Color.White;
            this.lblSApellido.Location = new System.Drawing.Point(456, 373);
            this.lblSApellido.Name = "lblSApellido";
            this.lblSApellido.Size = new System.Drawing.Size(110, 13);
            this.lblSApellido.TabIndex = 46;
            this.lblSApellido.Text = "Segundo Apellido:";
            this.lblSApellido.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUserName.ForeColor = System.Drawing.Color.Maroon;
            this.txtUserName.Location = new System.Drawing.Point(579, 398);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 20);
            this.txtUserName.TabIndex = 49;
            this.txtUserName.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(456, 401);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 13);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "Nombre de usuario";
            this.lblUserName.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPass.ForeColor = System.Drawing.Color.Maroon;
            this.txtPass.Location = new System.Drawing.Point(579, 426);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(136, 20);
            this.txtPass.TabIndex = 51;
            this.txtPass.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(456, 429);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(75, 13);
            this.lblPass.TabIndex = 50;
            this.lblPass.Text = "Contraseña:";
            this.lblPass.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEmail.ForeColor = System.Drawing.Color.Maroon;
            this.txtEmail.Location = new System.Drawing.Point(579, 456);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 53;
            this.txtEmail.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(456, 456);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 13);
            this.lblEmail.TabIndex = 52;
            this.lblEmail.Text = "Correo Personal:";
            this.lblEmail.Visible = false;
            // 
            // txtOficio
            // 
            this.txtOficio.BackColor = System.Drawing.Color.White;
            this.txtOficio.Enabled = false;
            this.txtOficio.ForeColor = System.Drawing.Color.Maroon;
            this.txtOficio.Location = new System.Drawing.Point(579, 484);
            this.txtOficio.Margin = new System.Windows.Forms.Padding(4);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(136, 20);
            this.txtOficio.TabIndex = 55;
            this.txtOficio.Visible = false;
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficio.ForeColor = System.Drawing.Color.White;
            this.lblOficio.Location = new System.Drawing.Point(456, 484);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(44, 13);
            this.lblOficio.TabIndex = 54;
            this.lblOficio.Text = "Oficio:";
            this.lblOficio.Visible = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(462, 515);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(71, 13);
            this.lblRol.TabIndex = 57;
            this.lblRol.Text = "Nuevo Rol:";
            this.lblRol.Visible = false;
            // 
            // cboxRoles
            // 
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.Location = new System.Drawing.Point(579, 511);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(136, 21);
            this.cboxRoles.TabIndex = 56;
            this.cboxRoles.Visible = false;
            // 
            // btnSveChanges
            // 
            this.btnSveChanges.BackColor = System.Drawing.Color.Maroon;
            this.btnSveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSveChanges.FlatAppearance.BorderSize = 0;
            this.btnSveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSveChanges.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSveChanges.Location = new System.Drawing.Point(579, 540);
            this.btnSveChanges.Name = "btnSveChanges";
            this.btnSveChanges.Size = new System.Drawing.Size(152, 26);
            this.btnSveChanges.TabIndex = 58;
            this.btnSveChanges.Text = "Guardar Cambios";
            this.btnSveChanges.UseVisualStyleBackColor = false;
            this.btnSveChanges.Visible = false;
            this.btnSveChanges.Click += new System.EventHandler(this.btnSveChanges_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(983, 578);
            this.Controls.Add(this.btnSveChanges);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.cboxRoles);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.lblSApellido);
            this.Controls.Add(this.txtFApellido);
            this.Controls.Add(this.lblFApellido);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInfo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineVertical;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox txtFApellido;
        private System.Windows.Forms.Label lblFApellido;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.Label lblSApellido;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboxRoles;
        private System.Windows.Forms.Button btnSveChanges;
    }
}