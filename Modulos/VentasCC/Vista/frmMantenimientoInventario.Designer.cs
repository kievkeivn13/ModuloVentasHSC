
namespace CapaVistaMVentasCC
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
            this.labelprecioinventario = new System.Windows.Forms.Label();
            this.labelcostoinventario = new System.Windows.Forms.Label();
            this.labelstockinventario = new System.Windows.Forms.Label();
            this.labelInventario = new System.Windows.Forms.Label();
            this.dtgInventario = new System.Windows.Forms.DataGridView();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labeltipoinventario = new System.Windows.Forms.Label();
            this.labelnombreinventario = new System.Windows.Forms.Label();
            this.labelidinventario = new System.Windows.Forms.Label();
            this.cbxTipoinventario = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtidinventario = new System.Windows.Forms.TextBox();
            this.txtnombreinventario = new System.Windows.Forms.TextBox();
            this.txtIdTipoInv = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtstockinventario = new System.Windows.Forms.TextBox();
            this.txtcostoinventario = new System.Windows.Forms.TextBox();
            this.txtprecioinventario = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelprecioinventario
            // 
            this.labelprecioinventario.AutoSize = true;
            this.labelprecioinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelprecioinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecioinventario.Location = new System.Drawing.Point(20, 564);
            this.labelprecioinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelprecioinventario.Name = "labelprecioinventario";
            this.labelprecioinventario.Size = new System.Drawing.Size(73, 25);
            this.labelprecioinventario.TabIndex = 58;
            this.labelprecioinventario.Text = "Precio:";
            // 
            // labelcostoinventario
            // 
            this.labelcostoinventario.AutoSize = true;
            this.labelcostoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelcostoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcostoinventario.Location = new System.Drawing.Point(20, 532);
            this.labelcostoinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcostoinventario.Name = "labelcostoinventario";
            this.labelcostoinventario.Size = new System.Drawing.Size(70, 25);
            this.labelcostoinventario.TabIndex = 56;
            this.labelcostoinventario.Text = "Costo:";
            // 
            // labelstockinventario
            // 
            this.labelstockinventario.AutoSize = true;
            this.labelstockinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelstockinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockinventario.Location = new System.Drawing.Point(20, 496);
            this.labelstockinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelstockinventario.Name = "labelstockinventario";
            this.labelstockinventario.Size = new System.Drawing.Size(68, 25);
            this.labelstockinventario.TabIndex = 54;
            this.labelstockinventario.Text = "Stock:";
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.BackColor = System.Drawing.Color.Transparent;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(416, 323);
            this.labelInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(215, 25);
            this.labelInventario.TabIndex = 53;
            this.labelInventario.Text = "Inventarios Registrados";
            // 
            // dtgInventario
            // 
            this.dtgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventario.Location = new System.Drawing.Point(421, 348);
            this.dtgInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.RowHeadersWidth = 51;
            this.dtgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventario.Size = new System.Drawing.Size(1054, 421);
            this.dtgInventario.TabIndex = 52;
            this.dtgInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventario_CellClick);
            this.dtgInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventario_CellContentClick);
            this.dtgInventario.SelectionChanged += new System.EventHandler(this.dtgInventario_SelectionChanged);
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInactivo.Location = new System.Drawing.Point(228, 609);
            this.rbnInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(100, 29);
            this.rbnInactivo.TabIndex = 51;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "Inactivo";
            this.rbnInactivo.UseVisualStyleBackColor = false;
            this.rbnInactivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbnInactivo_MouseClick);
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnActivo.Location = new System.Drawing.Point(126, 609);
            this.rbnActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(87, 29);
            this.rbnActivo.TabIndex = 50;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Activo";
            this.rbnActivo.UseVisualStyleBackColor = false;
            this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            this.rbnActivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbnActivo_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(64, 708);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 38);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(196, 708);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 38);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(196, 669);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 38);
            this.btnModificar.TabIndex = 47;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(64, 669);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(123, 38);
            this.btnIngresar.TabIndex = 46;
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
            this.labelestadoinventario.Location = new System.Drawing.Point(20, 611);
            this.labelestadoinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(79, 25);
            this.labelestadoinventario.TabIndex = 42;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labeltipoinventario
            // 
            this.labeltipoinventario.AutoSize = true;
            this.labeltipoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labeltipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipoinventario.Location = new System.Drawing.Point(20, 389);
            this.labeltipoinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltipoinventario.Name = "labeltipoinventario";
            this.labeltipoinventario.Size = new System.Drawing.Size(147, 25);
            this.labeltipoinventario.TabIndex = 41;
            this.labeltipoinventario.Text = "Tipo Inventario:";
            // 
            // labelnombreinventario
            // 
            this.labelnombreinventario.AutoSize = true;
            this.labelnombreinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelnombreinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombreinventario.Location = new System.Drawing.Point(13, 357);
            this.labelnombreinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelnombreinventario.Name = "labelnombreinventario";
            this.labelnombreinventario.Size = new System.Drawing.Size(87, 25);
            this.labelnombreinventario.TabIndex = 40;
            this.labelnombreinventario.Text = "Nombre:";
            // 
            // labelidinventario
            // 
            this.labelidinventario.AutoSize = true;
            this.labelidinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidinventario.Location = new System.Drawing.Point(13, 320);
            this.labelidinventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidinventario.Name = "labelidinventario";
            this.labelidinventario.Size = new System.Drawing.Size(37, 25);
            this.labelidinventario.TabIndex = 39;
            this.labelidinventario.Text = "ID:";
            // 
            // cbxTipoinventario
            // 
            this.cbxTipoinventario.FormattingEnabled = true;
            this.cbxTipoinventario.Location = new System.Drawing.Point(172, 391);
            this.cbxTipoinventario.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipoinventario.Name = "cbxTipoinventario";
            this.cbxTipoinventario.Size = new System.Drawing.Size(135, 24);
            this.cbxTipoinventario.TabIndex = 62;
            this.cbxTipoinventario.SelectedIndexChanged += new System.EventHandler(this.cbxTipoinventario_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(172, 426);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(135, 24);
            this.cbxMarca.TabIndex = 65;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 424);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Marca";
            // 
            // cbxLinea
            // 
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(172, 462);
            this.cbxLinea.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(135, 24);
            this.cbxLinea.TabIndex = 68;
            this.cbxLinea.SelectedIndexChanged += new System.EventHandler(this.cbxLinea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Linea";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, 3);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1585, 107);
            this.navegador1.TabIndex = 71;
            // 
            // txtidinventario
            // 
            this.txtidinventario.Location = new System.Drawing.Point(172, 320);
            this.txtidinventario.Name = "txtidinventario";
            this.txtidinventario.Size = new System.Drawing.Size(135, 22);
            this.txtidinventario.TabIndex = 72;
            this.txtidinventario.Tag = "Pkid";
            // 
            // txtnombreinventario
            // 
            this.txtnombreinventario.Location = new System.Drawing.Point(172, 357);
            this.txtnombreinventario.Name = "txtnombreinventario";
            this.txtnombreinventario.Size = new System.Drawing.Size(135, 22);
            this.txtnombreinventario.TabIndex = 73;
            this.txtnombreinventario.Tag = "Nombre";
            // 
            // txtIdTipoInv
            // 
            this.txtIdTipoInv.Location = new System.Drawing.Point(314, 392);
            this.txtIdTipoInv.Name = "txtIdTipoInv";
            this.txtIdTipoInv.Size = new System.Drawing.Size(100, 22);
            this.txtIdTipoInv.TabIndex = 74;
            this.txtIdTipoInv.Tag = "Fktipoinventario";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(314, 428);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 75;
            this.txtMarca.Tag = "Fkidmarca";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(314, 464);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 22);
            this.txtLinea.TabIndex = 76;
            this.txtLinea.Tag = "Fkidlinea";
            // 
            // txtstockinventario
            // 
            this.txtstockinventario.Location = new System.Drawing.Point(172, 500);
            this.txtstockinventario.Name = "txtstockinventario";
            this.txtstockinventario.Size = new System.Drawing.Size(135, 22);
            this.txtstockinventario.TabIndex = 77;
            this.txtstockinventario.Tag = "Stock";
            // 
            // txtcostoinventario
            // 
            this.txtcostoinventario.Location = new System.Drawing.Point(172, 536);
            this.txtcostoinventario.Name = "txtcostoinventario";
            this.txtcostoinventario.Size = new System.Drawing.Size(135, 22);
            this.txtcostoinventario.TabIndex = 78;
            this.txtcostoinventario.Tag = "Costo";
            // 
            // txtprecioinventario
            // 
            this.txtprecioinventario.Location = new System.Drawing.Point(172, 568);
            this.txtprecioinventario.Name = "txtprecioinventario";
            this.txtprecioinventario.Size = new System.Drawing.Size(135, 22);
            this.txtprecioinventario.TabIndex = 79;
            this.txtprecioinventario.Tag = "Precio";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(335, 614);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(76, 22);
            this.textEstado.TabIndex = 80;
            this.textEstado.Tag = "estatus";
            // 
            // frmMantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 797);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.txtprecioinventario);
            this.Controls.Add(this.txtcostoinventario);
            this.Controls.Add(this.txtstockinventario);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtIdTipoInv);
            this.Controls.Add(this.txtnombreinventario);
            this.Controls.Add(this.txtidinventario);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cbxLinea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTipoinventario);
            this.Controls.Add(this.labelprecioinventario);
            this.Controls.Add(this.labelcostoinventario);
            this.Controls.Add(this.labelstockinventario);
            this.Controls.Add(this.labelInventario);
            this.Controls.Add(this.dtgInventario);
            this.Controls.Add(this.rbnInactivo);
            this.Controls.Add(this.rbnActivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labeltipoinventario);
            this.Controls.Add(this.labelnombreinventario);
            this.Controls.Add(this.labelidinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantenimientoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Inventario";
            this.Load += new System.EventHandler(this.frmMantenimientoInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelprecioinventario;
		private System.Windows.Forms.Label labelcostoinventario;
		private System.Windows.Forms.Label labelstockinventario;
		private System.Windows.Forms.Label labelInventario;
		private System.Windows.Forms.DataGridView dtgInventario;
		private System.Windows.Forms.RadioButton rbnInactivo;
		private System.Windows.Forms.RadioButton rbnActivo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.Label labelestadoinventario;
		private System.Windows.Forms.Label labeltipoinventario;
		private System.Windows.Forms.Label labelnombreinventario;
		private System.Windows.Forms.Label labelidinventario;
		private System.Windows.Forms.ComboBox cbxTipoinventario;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLinea;
        private System.Windows.Forms.Label label2;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtidinventario;
        private System.Windows.Forms.TextBox txtnombreinventario;
        private System.Windows.Forms.TextBox txtIdTipoInv;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtstockinventario;
        private System.Windows.Forms.TextBox txtcostoinventario;
        private System.Windows.Forms.TextBox txtprecioinventario;
        private System.Windows.Forms.TextBox textEstado;
    }
}