
namespace CapaVista
{
	partial class frmMantenimientoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoCliente));
            this.labelClientes = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtapellidocliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.labelestadocliente = new System.Windows.Forms.Label();
            this.labelapellidocliente = new System.Windows.Forms.Label();
            this.labelnombrecliente = new System.Windows.Forms.Label();
            this.labelidcliente = new System.Windows.Forms.Label();
            this.labelnitcliente = new System.Windows.Forms.Label();
            this.txtnitcliente = new System.Windows.Forms.TextBox();
            this.txtelefonocliente = new System.Windows.Forms.TextBox();
            this.labeltelefonocliente = new System.Windows.Forms.Label();
            this.txtdireccioncliente = new System.Windows.Forms.TextBox();
            this.labeldireccioncliente = new System.Windows.Forms.Label();
            this.txtcorreocliente = new System.Windows.Forms.TextBox();
            this.labelcorreocliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(347, 42);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(156, 20);
            this.labelClientes.TabIndex = 30;
            this.labelClientes.Text = "Clientes Registrados";
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(350, 63);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(423, 301);
            this.dtgClientes.TabIndex = 29;
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInactivo.Location = new System.Drawing.Point(173, 252);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(82, 24);
            this.rbnInactivo.TabIndex = 28;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "Inactivo";
            this.rbnInactivo.UseVisualStyleBackColor = false;
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnActivo.Location = new System.Drawing.Point(97, 252);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(70, 24);
            this.rbnActivo.TabIndex = 27;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Activo";
            this.rbnActivo.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(50, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 31);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(149, 333);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(149, 301);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 31);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(50, 301);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 31);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(97, 65);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(100, 20);
            this.txtidcliente.TabIndex = 22;
            // 
            // txtapellidocliente
            // 
            this.txtapellidocliente.Location = new System.Drawing.Point(97, 119);
            this.txtapellidocliente.Name = "txtapellidocliente";
            this.txtapellidocliente.Size = new System.Drawing.Size(100, 20);
            this.txtapellidocliente.TabIndex = 21;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(97, 93);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(100, 20);
            this.txtnombrecliente.TabIndex = 20;
            // 
            // labelestadocliente
            // 
            this.labelestadocliente.AutoSize = true;
            this.labelestadocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelestadocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadocliente.Location = new System.Drawing.Point(17, 254);
            this.labelestadocliente.Name = "labelestadocliente";
            this.labelestadocliente.Size = new System.Drawing.Size(64, 20);
            this.labelestadocliente.TabIndex = 19;
            this.labelestadocliente.Text = "Estado:";
            // 
            // labelapellidocliente
            // 
            this.labelapellidocliente.AutoSize = true;
            this.labelapellidocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidocliente.Location = new System.Drawing.Point(17, 119);
            this.labelapellidocliente.Name = "labelapellidocliente";
            this.labelapellidocliente.Size = new System.Drawing.Size(69, 20);
            this.labelapellidocliente.TabIndex = 18;
            this.labelapellidocliente.Text = "Apellido:";
            // 
            // labelnombrecliente
            // 
            this.labelnombrecliente.AutoSize = true;
            this.labelnombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrecliente.Location = new System.Drawing.Point(12, 93);
            this.labelnombrecliente.Name = "labelnombrecliente";
            this.labelnombrecliente.Size = new System.Drawing.Size(69, 20);
            this.labelnombrecliente.TabIndex = 17;
            this.labelnombrecliente.Text = "Nombre:";
            // 
            // labelidcliente
            // 
            this.labelidcliente.AutoSize = true;
            this.labelidcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidcliente.Location = new System.Drawing.Point(12, 63);
            this.labelidcliente.Name = "labelidcliente";
            this.labelidcliente.Size = new System.Drawing.Size(30, 20);
            this.labelidcliente.TabIndex = 16;
            this.labelidcliente.Text = "ID:";
            // 
            // labelnitcliente
            // 
            this.labelnitcliente.AutoSize = true;
            this.labelnitcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnitcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnitcliente.Location = new System.Drawing.Point(17, 145);
            this.labelnitcliente.Name = "labelnitcliente";
            this.labelnitcliente.Size = new System.Drawing.Size(38, 20);
            this.labelnitcliente.TabIndex = 31;
            this.labelnitcliente.Text = "NIT:";
            // 
            // txtnitcliente
            // 
            this.txtnitcliente.Location = new System.Drawing.Point(95, 145);
            this.txtnitcliente.Name = "txtnitcliente";
            this.txtnitcliente.Size = new System.Drawing.Size(100, 20);
            this.txtnitcliente.TabIndex = 32;
            // 
            // txtelefonocliente
            // 
            this.txtelefonocliente.Location = new System.Drawing.Point(95, 174);
            this.txtelefonocliente.Name = "txtelefonocliente";
            this.txtelefonocliente.Size = new System.Drawing.Size(100, 20);
            this.txtelefonocliente.TabIndex = 34;
            // 
            // labeltelefonocliente
            // 
            this.labeltelefonocliente.AutoSize = true;
            this.labeltelefonocliente.BackColor = System.Drawing.Color.Transparent;
            this.labeltelefonocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefonocliente.Location = new System.Drawing.Point(17, 174);
            this.labeltelefonocliente.Name = "labeltelefonocliente";
            this.labeltelefonocliente.Size = new System.Drawing.Size(75, 20);
            this.labeltelefonocliente.TabIndex = 33;
            this.labeltelefonocliente.Text = "Teléfono:";
            // 
            // txtdireccioncliente
            // 
            this.txtdireccioncliente.Location = new System.Drawing.Point(95, 200);
            this.txtdireccioncliente.Name = "txtdireccioncliente";
            this.txtdireccioncliente.Size = new System.Drawing.Size(100, 20);
            this.txtdireccioncliente.TabIndex = 36;
            // 
            // labeldireccioncliente
            // 
            this.labeldireccioncliente.AutoSize = true;
            this.labeldireccioncliente.BackColor = System.Drawing.Color.Transparent;
            this.labeldireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccioncliente.Location = new System.Drawing.Point(17, 200);
            this.labeldireccioncliente.Name = "labeldireccioncliente";
            this.labeldireccioncliente.Size = new System.Drawing.Size(79, 20);
            this.labeldireccioncliente.TabIndex = 35;
            this.labeldireccioncliente.Text = "Dirección:";
            // 
            // txtcorreocliente
            // 
            this.txtcorreocliente.Location = new System.Drawing.Point(97, 226);
            this.txtcorreocliente.Name = "txtcorreocliente";
            this.txtcorreocliente.Size = new System.Drawing.Size(100, 20);
            this.txtcorreocliente.TabIndex = 38;
            // 
            // labelcorreocliente
            // 
            this.labelcorreocliente.AutoSize = true;
            this.labelcorreocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelcorreocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreocliente.Location = new System.Drawing.Point(19, 226);
            this.labelcorreocliente.Name = "labelcorreocliente";
            this.labelcorreocliente.Size = new System.Drawing.Size(61, 20);
            this.labelcorreocliente.TabIndex = 37;
            this.labelcorreocliente.Text = "Correo:";
            // 
            // frmMantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.txtcorreocliente);
            this.Controls.Add(this.labelcorreocliente);
            this.Controls.Add(this.txtdireccioncliente);
            this.Controls.Add(this.labeldireccioncliente);
            this.Controls.Add(this.txtelefonocliente);
            this.Controls.Add(this.labeltelefonocliente);
            this.Controls.Add(this.txtnitcliente);
            this.Controls.Add(this.labelnitcliente);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.rbnInactivo);
            this.Controls.Add(this.rbnActivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.txtapellidocliente);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.labelestadocliente);
            this.Controls.Add(this.labelapellidocliente);
            this.Controls.Add(this.labelnombrecliente);
            this.Controls.Add(this.labelidcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelClientes;
		private System.Windows.Forms.DataGridView dtgClientes;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox txtidcliente;
		private System.Windows.Forms.TextBox txtapellidocliente;
		private System.Windows.Forms.TextBox txtnombrecliente;
		private System.Windows.Forms.Label labelestadocliente;
		private System.Windows.Forms.Label labelapellidocliente;
		private System.Windows.Forms.Label labelnombrecliente;
		private System.Windows.Forms.Label labelidcliente;
		private System.Windows.Forms.Label labelnitcliente;
		private System.Windows.Forms.TextBox txtnitcliente;
		private System.Windows.Forms.TextBox txtelefonocliente;
		private System.Windows.Forms.Label labeltelefonocliente;
		private System.Windows.Forms.TextBox txtdireccioncliente;
		private System.Windows.Forms.Label labeldireccioncliente;
		private System.Windows.Forms.TextBox txtcorreocliente;
		private System.Windows.Forms.Label labelcorreocliente;
	}
}