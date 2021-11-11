
namespace CapaVistaMVentasCC
{
	partial class frmMantenimientoTipoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoTipoInventario));
            this.labelMoras = new System.Windows.Forms.Label();
            this.dtgTipoInventario = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labelnombretinventario = new System.Windows.Forms.Label();
            this.labelidtinventario = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtidtinventario = new System.Windows.Forms.TextBox();
            this.txtnombretinventario = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoras
            // 
            this.labelMoras.AutoSize = true;
            this.labelMoras.BackColor = System.Drawing.Color.Transparent;
            this.labelMoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoras.Location = new System.Drawing.Point(483, 294);
            this.labelMoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoras.Name = "labelMoras";
            this.labelMoras.Size = new System.Drawing.Size(178, 25);
            this.labelMoras.TabIndex = 30;
            this.labelMoras.Text = "Tipos de Inventario";
            // 
            // dtgTipoInventario
            // 
            this.dtgTipoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoInventario.Location = new System.Drawing.Point(487, 320);
            this.dtgTipoInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTipoInventario.Name = "dtgTipoInventario";
            this.dtgTipoInventario.ReadOnly = true;
            this.dtgTipoInventario.RowHeadersWidth = 51;
            this.dtgTipoInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoInventario.Size = new System.Drawing.Size(559, 265);
            this.dtgTipoInventario.TabIndex = 29;
            this.dtgTipoInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipoInventario_CellClick);
            this.dtgTipoInventario.SelectionChanged += new System.EventHandler(this.dtgTipoInventario_SelectionChanged);
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(265, 399);
            this.rbnInhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(132, 29);
            this.rbnInhabilitado.TabIndex = 28;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbnInhabilitado_MouseClick);
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(129, 401);
            this.rbnHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(119, 29);
            this.rbnHabilitado.TabIndex = 27;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnHabilitado_CheckedChanged);
            this.rbnHabilitado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbnHabilitado_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(67, 522);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 38);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(199, 522);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 38);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(199, 482);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 38);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(67, 482);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(123, 38);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(23, 399);
            this.labelestadoinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(79, 25);
            this.labelestadoinventario.TabIndex = 19;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labelnombretinventario
            // 
            this.labelnombretinventario.AutoSize = true;
            this.labelnombretinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelnombretinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombretinventario.Location = new System.Drawing.Point(23, 335);
            this.labelnombretinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnombretinventario.Name = "labelnombretinventario";
            this.labelnombretinventario.Size = new System.Drawing.Size(87, 25);
            this.labelnombretinventario.TabIndex = 17;
            this.labelnombretinventario.Text = "Nombre:";
            // 
            // labelidtinventario
            // 
            this.labelidtinventario.AutoSize = true;
            this.labelidtinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidtinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidtinventario.Location = new System.Drawing.Point(23, 300);
            this.labelidtinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidtinventario.Name = "labelidtinventario";
            this.labelidtinventario.Size = new System.Drawing.Size(37, 25);
            this.labelidtinventario.TabIndex = 16;
            this.labelidtinventario.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 1);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1561, 107);
            this.navegador1.TabIndex = 32;
            // 
            // txtidtinventario
            // 
            this.txtidtinventario.Location = new System.Drawing.Point(129, 300);
            this.txtidtinventario.Name = "txtidtinventario";
            this.txtidtinventario.Size = new System.Drawing.Size(142, 22);
            this.txtidtinventario.TabIndex = 33;
            this.txtidtinventario.Tag = "Pkid";
            // 
            // txtnombretinventario
            // 
            this.txtnombretinventario.Location = new System.Drawing.Point(129, 338);
            this.txtnombretinventario.Name = "txtnombretinventario";
            this.txtnombretinventario.Size = new System.Drawing.Size(142, 22);
            this.txtnombretinventario.TabIndex = 34;
            this.txtnombretinventario.Tag = "Nombre";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(404, 402);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(76, 22);
            this.textEstado.TabIndex = 35;
            this.textEstado.Tag = "estatus";
            // 
            // frmMantenimientoTipoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1560, 611);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.txtnombretinventario);
            this.Controls.Add(this.txtidtinventario);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelMoras);
            this.Controls.Add(this.dtgTipoInventario);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labelnombretinventario);
            this.Controls.Add(this.labelidtinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantenimientoTipoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Tipo Inventario";
            this.Load += new System.EventHandler(this.frmMantenimientoTipoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelMoras;
		private System.Windows.Forms.DataGridView dtgTipoInventario;
		private System.Windows.Forms.RadioButton rbnInhabilitado;
		private System.Windows.Forms.RadioButton rbnHabilitado;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label labelestadoinventario;
		private System.Windows.Forms.Label labelnombretinventario;
		private System.Windows.Forms.Label labelidtinventario;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtidtinventario;
        private System.Windows.Forms.TextBox txtnombretinventario;
        private System.Windows.Forms.TextBox textEstado;
    }
}