
namespace CapaVista
{
	partial class frmMantenimientoInventario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoInventario));
			this.txtprecioinventario = new System.Windows.Forms.TextBox();
			this.labelprecioinventario = new System.Windows.Forms.Label();
			this.txtcostoinventario = new System.Windows.Forms.TextBox();
			this.labelcostoinventario = new System.Windows.Forms.Label();
			this.txtstockinventario = new System.Windows.Forms.TextBox();
			this.labelstockinventario = new System.Windows.Forms.Label();
			this.labelInventario = new System.Windows.Forms.Label();
			this.dtgInventario = new System.Windows.Forms.DataGridView();
			this.rbnInactivo = new System.Windows.Forms.RadioButton();
			this.rbnActivo = new System.Windows.Forms.RadioButton();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnIngresar = new System.Windows.Forms.Button();
			this.txtidinventario = new System.Windows.Forms.TextBox();
			this.txtnombreinventario = new System.Windows.Forms.TextBox();
			this.labelestadoinventario = new System.Windows.Forms.Label();
			this.labeltipoinventario = new System.Windows.Forms.Label();
			this.labelnombreinventario = new System.Windows.Forms.Label();
			this.labelidinventario = new System.Windows.Forms.Label();
			this.cbxTipoinventario = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
			this.SuspendLayout();
			// 
			// txtprecioinventario
			// 
			this.txtprecioinventario.Location = new System.Drawing.Point(131, 185);
			this.txtprecioinventario.Name = "txtprecioinventario";
			this.txtprecioinventario.Size = new System.Drawing.Size(100, 20);
			this.txtprecioinventario.TabIndex = 59;
			// 
			// labelprecioinventario
			// 
			this.labelprecioinventario.AutoSize = true;
			this.labelprecioinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelprecioinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelprecioinventario.Location = new System.Drawing.Point(17, 185);
			this.labelprecioinventario.Name = "labelprecioinventario";
			this.labelprecioinventario.Size = new System.Drawing.Size(57, 20);
			this.labelprecioinventario.TabIndex = 58;
			this.labelprecioinventario.Text = "Precio:";
			// 
			// txtcostoinventario
			// 
			this.txtcostoinventario.Location = new System.Drawing.Point(131, 159);
			this.txtcostoinventario.Name = "txtcostoinventario";
			this.txtcostoinventario.Size = new System.Drawing.Size(100, 20);
			this.txtcostoinventario.TabIndex = 57;
			// 
			// labelcostoinventario
			// 
			this.labelcostoinventario.AutoSize = true;
			this.labelcostoinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelcostoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelcostoinventario.Location = new System.Drawing.Point(17, 159);
			this.labelcostoinventario.Name = "labelcostoinventario";
			this.labelcostoinventario.Size = new System.Drawing.Size(55, 20);
			this.labelcostoinventario.TabIndex = 56;
			this.labelcostoinventario.Text = "Costo:";
			// 
			// txtstockinventario
			// 
			this.txtstockinventario.Location = new System.Drawing.Point(131, 130);
			this.txtstockinventario.Name = "txtstockinventario";
			this.txtstockinventario.Size = new System.Drawing.Size(100, 20);
			this.txtstockinventario.TabIndex = 55;
			// 
			// labelstockinventario
			// 
			this.labelstockinventario.AutoSize = true;
			this.labelstockinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelstockinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelstockinventario.Location = new System.Drawing.Point(17, 130);
			this.labelstockinventario.Name = "labelstockinventario";
			this.labelstockinventario.Size = new System.Drawing.Size(54, 20);
			this.labelstockinventario.TabIndex = 54;
			this.labelstockinventario.Text = "Stock:";
			// 
			// labelInventario
			// 
			this.labelInventario.AutoSize = true;
			this.labelInventario.BackColor = System.Drawing.Color.Transparent;
			this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInventario.Location = new System.Drawing.Point(362, 50);
			this.labelInventario.Name = "labelInventario";
			this.labelInventario.Size = new System.Drawing.Size(177, 20);
			this.labelInventario.TabIndex = 53;
			this.labelInventario.Text = "Inventarios Registrados";
			// 
			// dtgInventario
			// 
			this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgInventario.Location = new System.Drawing.Point(365, 71);
			this.dtgInventario.Name = "dtgInventario";
			this.dtgInventario.Size = new System.Drawing.Size(423, 295);
			this.dtgInventario.TabIndex = 52;
			// 
			// rbnInactivo
			// 
			this.rbnInactivo.AutoSize = true;
			this.rbnInactivo.BackColor = System.Drawing.Color.Transparent;
			this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnInactivo.Location = new System.Drawing.Point(173, 237);
			this.rbnInactivo.Name = "rbnInactivo";
			this.rbnInactivo.Size = new System.Drawing.Size(82, 24);
			this.rbnInactivo.TabIndex = 51;
			this.rbnInactivo.TabStop = true;
			this.rbnInactivo.Text = "Inactivo";
			this.rbnInactivo.UseVisualStyleBackColor = false;
			// 
			// rbnActivo
			// 
			this.rbnActivo.AutoSize = true;
			this.rbnActivo.BackColor = System.Drawing.Color.Transparent;
			this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbnActivo.Location = new System.Drawing.Point(97, 237);
			this.rbnActivo.Name = "rbnActivo";
			this.rbnActivo.Size = new System.Drawing.Size(70, 24);
			this.rbnActivo.TabIndex = 50;
			this.rbnActivo.TabStop = true;
			this.rbnActivo.Text = "Activo";
			this.rbnActivo.UseVisualStyleBackColor = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Location = new System.Drawing.Point(50, 318);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(92, 31);
			this.btnEliminar.TabIndex = 49;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(149, 318);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
			this.btnLimpiar.TabIndex = 48;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.Location = new System.Drawing.Point(149, 286);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(92, 31);
			this.btnModificar.TabIndex = 47;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnIngresar
			// 
			this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresar.Location = new System.Drawing.Point(50, 286);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(92, 31);
			this.btnIngresar.TabIndex = 46;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			// 
			// txtidinventario
			// 
			this.txtidinventario.Location = new System.Drawing.Point(133, 50);
			this.txtidinventario.Name = "txtidinventario";
			this.txtidinventario.Size = new System.Drawing.Size(100, 20);
			this.txtidinventario.TabIndex = 45;
			// 
			// txtnombreinventario
			// 
			this.txtnombreinventario.Location = new System.Drawing.Point(133, 78);
			this.txtnombreinventario.Name = "txtnombreinventario";
			this.txtnombreinventario.Size = new System.Drawing.Size(100, 20);
			this.txtnombreinventario.TabIndex = 43;
			// 
			// labelestadoinventario
			// 
			this.labelestadoinventario.AutoSize = true;
			this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelestadoinventario.Location = new System.Drawing.Point(17, 239);
			this.labelestadoinventario.Name = "labelestadoinventario";
			this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
			this.labelestadoinventario.TabIndex = 42;
			this.labelestadoinventario.Text = "Estado:";
			// 
			// labeltipoinventario
			// 
			this.labeltipoinventario.AutoSize = true;
			this.labeltipoinventario.BackColor = System.Drawing.Color.Transparent;
			this.labeltipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labeltipoinventario.Location = new System.Drawing.Point(17, 104);
			this.labeltipoinventario.Name = "labeltipoinventario";
			this.labeltipoinventario.Size = new System.Drawing.Size(117, 20);
			this.labeltipoinventario.TabIndex = 41;
			this.labeltipoinventario.Text = "Tipo Inventario:";
			// 
			// labelnombreinventario
			// 
			this.labelnombreinventario.AutoSize = true;
			this.labelnombreinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelnombreinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelnombreinventario.Location = new System.Drawing.Point(12, 78);
			this.labelnombreinventario.Name = "labelnombreinventario";
			this.labelnombreinventario.Size = new System.Drawing.Size(69, 20);
			this.labelnombreinventario.TabIndex = 40;
			this.labelnombreinventario.Text = "Nombre:";
			// 
			// labelidinventario
			// 
			this.labelidinventario.AutoSize = true;
			this.labelidinventario.BackColor = System.Drawing.Color.Transparent;
			this.labelidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelidinventario.Location = new System.Drawing.Point(12, 48);
			this.labelidinventario.Name = "labelidinventario";
			this.labelidinventario.Size = new System.Drawing.Size(30, 20);
			this.labelidinventario.TabIndex = 39;
			this.labelidinventario.Text = "ID:";
			// 
			// cbxTipoinventario
			// 
			this.cbxTipoinventario.FormattingEnabled = true;
			this.cbxTipoinventario.Location = new System.Drawing.Point(131, 106);
			this.cbxTipoinventario.Name = "cbxTipoinventario";
			this.cbxTipoinventario.Size = new System.Drawing.Size(102, 21);
			this.cbxTipoinventario.TabIndex = 62;
			// 
			// frmMantenimientoInventario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CapaVista.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 378);
			this.Controls.Add(this.cbxTipoinventario);
			this.Controls.Add(this.txtprecioinventario);
			this.Controls.Add(this.labelprecioinventario);
			this.Controls.Add(this.txtcostoinventario);
			this.Controls.Add(this.labelcostoinventario);
			this.Controls.Add(this.txtstockinventario);
			this.Controls.Add(this.labelstockinventario);
			this.Controls.Add(this.labelInventario);
			this.Controls.Add(this.dtgInventario);
			this.Controls.Add(this.rbnInactivo);
			this.Controls.Add(this.rbnActivo);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnIngresar);
			this.Controls.Add(this.txtidinventario);
			this.Controls.Add(this.txtnombreinventario);
			this.Controls.Add(this.labelestadoinventario);
			this.Controls.Add(this.labeltipoinventario);
			this.Controls.Add(this.labelnombreinventario);
			this.Controls.Add(this.labelidinventario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMantenimientoInventario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mantenimiento Inventario";
			((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtprecioinventario;
		private System.Windows.Forms.Label labelprecioinventario;
		private System.Windows.Forms.TextBox txtcostoinventario;
		private System.Windows.Forms.Label labelcostoinventario;
		private System.Windows.Forms.TextBox txtstockinventario;
		private System.Windows.Forms.Label labelstockinventario;
		private System.Windows.Forms.Label labelInventario;
		private System.Windows.Forms.DataGridView dtgInventario;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox txtidinventario;
		private System.Windows.Forms.TextBox txtnombreinventario;
		private System.Windows.Forms.Label labelestadoinventario;
		private System.Windows.Forms.Label labeltipoinventario;
		private System.Windows.Forms.Label labelnombreinventario;
		private System.Windows.Forms.Label labelidinventario;
		private System.Windows.Forms.ComboBox cbxTipoinventario;
	}
}