using System.ComponentModel;

namespace Parcial_Final
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnElimiUsua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgreUsu = new System.Windows.Forms.Button();
            this.txtFecNac = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registros = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.Internos = new System.Windows.Forms.TabPage();
            this.Empresa = new System.Windows.Forms.TabPage();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvInternos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Empleados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistros)).BeginInit();
            this.Internos.SuspendLayout();
            this.Empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvInternos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Empleados);
            this.tabControl1.Controls.Add(this.Registros);
            this.tabControl1.Controls.Add(this.Internos);
            this.tabControl1.Controls.Add(this.Empresa);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.BackColor = System.Drawing.Color.DodgerBlue;
            this.Empleados.Controls.Add(this.groupBox2);
            this.Empleados.Controls.Add(this.groupBox1);
            this.Empleados.Location = new System.Drawing.Point(4, 24);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(3);
            this.Empleados.Size = new System.Drawing.Size(895, 457);
            this.Empleados.TabIndex = 0;
            this.Empleados.Text = "Empleados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnElimiUsua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbUsuario);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(444, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // btnElimiUsua
            // 
            this.btnElimiUsua.ForeColor = System.Drawing.Color.Red;
            this.btnElimiUsua.Location = new System.Drawing.Point(135, 243);
            this.btnElimiUsua.Name = "btnElimiUsua";
            this.btnElimiUsua.Size = new System.Drawing.Size(167, 31);
            this.btnElimiUsua.TabIndex = 13;
            this.btnElimiUsua.Text = "Eliminar usuario";
            this.btnElimiUsua.UseVisualStyleBackColor = true;
            this.btnElimiUsua.Click += new System.EventHandler(this.btnElimiUsua_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(169, 167);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(189, 23);
            this.cmbUsuario.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgreUsu);
            this.groupBox1.Controls.Add(this.txtFecNac);
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbDepartamento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // btnAgreUsu
            // 
            this.btnAgreUsu.ForeColor = System.Drawing.Color.Black;
            this.btnAgreUsu.Location = new System.Drawing.Point(111, 321);
            this.btnAgreUsu.Name = "btnAgreUsu";
            this.btnAgreUsu.Size = new System.Drawing.Size(187, 28);
            this.btnAgreUsu.TabIndex = 12;
            this.btnAgreUsu.Text = "Agregar usuario";
            this.btnAgreUsu.UseVisualStyleBackColor = true;
            this.btnAgreUsu.Click += new System.EventHandler(this.btnAgreUsu_Click);
            // 
            // txtFecNac
            // 
            this.txtFecNac.Location = new System.Drawing.Point(174, 278);
            this.txtFecNac.Name = "txtFecNac";
            this.txtFecNac.Size = new System.Drawing.Size(203, 23);
            this.txtFecNac.TabIndex = 11;
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(174, 225);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(203, 23);
            this.txtDui.TabIndex = 10;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(174, 183);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(203, 23);
            this.txtContraseña.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(176, 143);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(202, 23);
            this.txtApellido.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(176, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(175, 59);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(203, 23);
            this.cmbDepartamento.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 65);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de nacimiento:\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "DUI:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Registros
            // 
            this.Registros.BackColor = System.Drawing.Color.DodgerBlue;
            this.Registros.Controls.Add(this.label8);
            this.Registros.Controls.Add(this.dgvRegistros);
            this.Registros.Location = new System.Drawing.Point(4, 22);
            this.Registros.Name = "Registros";
            this.Registros.Padding = new System.Windows.Forms.Padding(3);
            this.Registros.Size = new System.Drawing.Size(895, 459);
            this.Registros.TabIndex = 1;
            this.Registros.Text = "Registros";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(171, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(577, 43);
            this.label8.TabIndex = 1;
            this.label8.Text = "Registros de todos:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(-3, 48);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(898, 407);
            this.dgvRegistros.TabIndex = 0;
            // 
            // Internos
            // 
            this.Internos.BackColor = System.Drawing.Color.DodgerBlue;
            this.Internos.Controls.Add(this.dgvInternos);
            this.Internos.Controls.Add(this.label10);
            this.Internos.Location = new System.Drawing.Point(4, 24);
            this.Internos.Name = "Internos";
            this.Internos.Size = new System.Drawing.Size(895, 457);
            this.Internos.TabIndex = 2;
            this.Internos.Text = "Internos";
            // 
            // Empresa
            // 
            this.Empresa.BackColor = System.Drawing.Color.DodgerBlue;
            this.Empresa.Controls.Add(this.dgvEmpresa);
            this.Empresa.Controls.Add(this.label9);
            this.Empresa.Location = new System.Drawing.Point(4, 22);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(895, 459);
            this.Empresa.TabIndex = 3;
            this.Empresa.Text = "Empresa";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(3, 110);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(889, 344);
            this.dgvEmpresa.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(190, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(491, 55);
            this.label9.TabIndex = 0;
            this.label9.Text = "Departamento con más empleados";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(116, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(582, 54);
            this.label10.TabIndex = 0;
            this.label10.Text = "Internos en la compañía actualmente";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInternos
            // 
            this.dgvInternos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternos.Location = new System.Drawing.Point(2, 82);
            this.dgvInternos.Name = "dgvInternos";
            this.dgvInternos.Size = new System.Drawing.Size(892, 374);
            this.dgvInternos.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Registros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvRegistros)).EndInit();
            this.Internos.ResumeLayout(false);
            this.Empresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvInternos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Registros;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.TabPage Empresa;
        private System.Windows.Forms.TabPage Internos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.TextBox txtFecNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgreUsu;
        private System.Windows.Forms.Button btnElimiUsua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvInternos;
    }
}