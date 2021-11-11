
namespace CapaVistaMVentasCC
{
	partial class frmMantenimientoListaDePrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoListaDePrecios));
            this.rbnTipo = new System.Windows.Forms.RadioButton();
            this.rbnGlobal = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtiFijo = new System.Windows.Forms.TextBox();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.rbnDecuento = new System.Windows.Forms.RadioButton();
            this.rbnFijo = new System.Windows.Forms.RadioButton();
            this.rbnAumento = new System.Windows.Forms.RadioButton();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            this.rbnMarca = new System.Windows.Forms.RadioButton();
            this.rbnLinea = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbnTipo
            // 
            this.rbnTipo.AutoSize = true;
            this.rbnTipo.BackColor = System.Drawing.Color.Transparent;
            this.rbnTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTipo.Location = new System.Drawing.Point(147, 32);
            this.rbnTipo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnTipo.Name = "rbnTipo";
            this.rbnTipo.Size = new System.Drawing.Size(118, 29);
            this.rbnTipo.TabIndex = 28;
            this.rbnTipo.TabStop = true;
            this.rbnTipo.Text = "Inventario";
            this.rbnTipo.UseVisualStyleBackColor = false;
            this.rbnTipo.CheckedChanged += new System.EventHandler(this.rbnTipo_CheckedChanged);
            // 
            // rbnGlobal
            // 
            this.rbnGlobal.AutoSize = true;
            this.rbnGlobal.BackColor = System.Drawing.Color.Transparent;
            this.rbnGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnGlobal.Location = new System.Drawing.Point(7, 32);
            this.rbnGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.rbnGlobal.Name = "rbnGlobal";
            this.rbnGlobal.Size = new System.Drawing.Size(89, 29);
            this.rbnGlobal.TabIndex = 27;
            this.rbnGlobal.TabStop = true;
            this.rbnGlobal.Text = "Global";
            this.rbnGlobal.UseVisualStyleBackColor = false;
            this.rbnGlobal.CheckedChanged += new System.EventHandler(this.rbnGlobal_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(370, 495);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(123, 38);
            this.btnIngresar.TabIndex = 23;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtiFijo
            // 
            this.txtiFijo.Location = new System.Drawing.Point(32, 71);
            this.txtiFijo.Margin = new System.Windows.Forms.Padding(4);
            this.txtiFijo.Name = "txtiFijo";
            this.txtiFijo.Size = new System.Drawing.Size(132, 22);
            this.txtiFijo.TabIndex = 22;
            this.txtiFijo.Visible = false;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(484, 69);
            this.txtAumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(244, 22);
            this.txtAumento.TabIndex = 21;
            this.txtAumento.Visible = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(224, 69);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(235, 22);
            this.txtDescuento.TabIndex = 20;
            this.txtDescuento.Visible = false;
            // 
            // rbnDecuento
            // 
            this.rbnDecuento.AutoSize = true;
            this.rbnDecuento.BackColor = System.Drawing.Color.Transparent;
            this.rbnDecuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDecuento.Location = new System.Drawing.Point(220, 32);
            this.rbnDecuento.Margin = new System.Windows.Forms.Padding(4);
            this.rbnDecuento.Name = "rbnDecuento";
            this.rbnDecuento.Size = new System.Drawing.Size(239, 29);
            this.rbnDecuento.TabIndex = 32;
            this.rbnDecuento.TabStop = true;
            this.rbnDecuento.Text = "Porcentaje (Descuento)";
            this.rbnDecuento.UseVisualStyleBackColor = false;
            this.rbnDecuento.CheckedChanged += new System.EventHandler(this.rbnDecuento_CheckedChanged);
            // 
            // rbnFijo
            // 
            this.rbnFijo.AutoSize = true;
            this.rbnFijo.BackColor = System.Drawing.Color.Transparent;
            this.rbnFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFijo.Location = new System.Drawing.Point(32, 34);
            this.rbnFijo.Margin = new System.Windows.Forms.Padding(4);
            this.rbnFijo.Name = "rbnFijo";
            this.rbnFijo.Size = new System.Drawing.Size(124, 29);
            this.rbnFijo.TabIndex = 31;
            this.rbnFijo.TabStop = true;
            this.rbnFijo.Text = "Precio Fijo";
            this.rbnFijo.UseVisualStyleBackColor = false;
            this.rbnFijo.CheckedChanged += new System.EventHandler(this.rbnFijo_CheckedChanged);
            // 
            // rbnAumento
            // 
            this.rbnAumento.AutoSize = true;
            this.rbnAumento.BackColor = System.Drawing.Color.Transparent;
            this.rbnAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAumento.Location = new System.Drawing.Point(484, 34);
            this.rbnAumento.Margin = new System.Windows.Forms.Padding(4);
            this.rbnAumento.Name = "rbnAumento";
            this.rbnAumento.Size = new System.Drawing.Size(224, 29);
            this.rbnAumento.TabIndex = 33;
            this.rbnAumento.TabStop = true;
            this.rbnAumento.Text = "Porcentaje (Aumento)";
            this.rbnAumento.UseVisualStyleBackColor = false;
            this.rbnAumento.CheckedChanged += new System.EventHandler(this.rbnAumento_CheckedChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(147, 68);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(188, 24);
            this.cbxTipo.TabIndex = 34;
            this.cbxTipo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbnLinea);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.rbnMarca);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.cbxLinea);
            this.groupBox1.Controls.Add(this.cbxMarca);
            this.groupBox1.Controls.Add(this.rbnGlobal);
            this.groupBox1.Controls.Add(this.cbxTipo);
            this.groupBox1.Controls.Add(this.rbnTipo);
            this.groupBox1.Location = new System.Drawing.Point(38, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 106);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplicar:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbnFijo);
            this.groupBox2.Controls.Add(this.txtDescuento);
            this.groupBox2.Controls.Add(this.rbnAumento);
            this.groupBox2.Controls.Add(this.txtAumento);
            this.groupBox2.Controls.Add(this.rbnDecuento);
            this.groupBox2.Controls.Add(this.txtiFijo);
            this.groupBox2.Location = new System.Drawing.Point(38, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 124);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de precio:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(548, 68);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(22, 22);
            this.txtMarca.TabIndex = 37;
            this.txtMarca.Visible = false;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(781, 68);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(22, 22);
            this.txtLinea.TabIndex = 38;
            this.txtLinea.Visible = false;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(353, 68);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(189, 24);
            this.cbxMarca.TabIndex = 35;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // cbxLinea
            // 
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(586, 68);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(189, 24);
            this.cbxLinea.TabIndex = 36;
            this.cbxLinea.SelectedIndexChanged += new System.EventHandler(this.cbxLinea_SelectedIndexChanged);
            // 
            // rbnMarca
            // 
            this.rbnMarca.AutoSize = true;
            this.rbnMarca.BackColor = System.Drawing.Color.Transparent;
            this.rbnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMarca.Location = new System.Drawing.Point(353, 32);
            this.rbnMarca.Margin = new System.Windows.Forms.Padding(4);
            this.rbnMarca.Name = "rbnMarca";
            this.rbnMarca.Size = new System.Drawing.Size(88, 29);
            this.rbnMarca.TabIndex = 37;
            this.rbnMarca.TabStop = true;
            this.rbnMarca.Text = "Marca";
            this.rbnMarca.UseVisualStyleBackColor = false;
            this.rbnMarca.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbnLinea
            // 
            this.rbnLinea.AutoSize = true;
            this.rbnLinea.BackColor = System.Drawing.Color.Transparent;
            this.rbnLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnLinea.Location = new System.Drawing.Point(586, 32);
            this.rbnLinea.Margin = new System.Windows.Forms.Padding(4);
            this.rbnLinea.Name = "rbnLinea";
            this.rbnLinea.Size = new System.Drawing.Size(81, 29);
            this.rbnLinea.TabIndex = 38;
            this.rbnLinea.TabStop = true;
            this.rbnLinea.Text = "Linea";
            this.rbnLinea.UseVisualStyleBackColor = false;
            this.rbnLinea.CheckedChanged += new System.EventHandler(this.rbnLinea_CheckedChanged);
            // 
            // frmMantenimientoListaDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantenimientoListaDePrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Lista de Precio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton rbnTipo;
		private System.Windows.Forms.RadioButton rbnGlobal;
		private System.Windows.Forms.Button btnIngresar;
		private System.Windows.Forms.TextBox txtiFijo;
		private System.Windows.Forms.TextBox txtAumento;
		private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.RadioButton rbnDecuento;
        private System.Windows.Forms.RadioButton rbnFijo;
        private System.Windows.Forms.RadioButton rbnAumento;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.RadioButton rbnLinea;
        private System.Windows.Forms.RadioButton rbnMarca;
        private System.Windows.Forms.ComboBox cbxLinea;
        private System.Windows.Forms.ComboBox cbxMarca;
    }
}