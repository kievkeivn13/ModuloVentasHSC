
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
            this.labelMoras = new System.Windows.Forms.Label();
            this.dtgTipoInventario = new System.Windows.Forms.DataGridView();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtidtinventario = new System.Windows.Forms.TextBox();
            this.txtnombretinventario = new System.Windows.Forms.TextBox();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labelnombretinventario = new System.Windows.Forms.Label();
            this.labelidtinventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoras
            // 
            this.labelMoras.AutoSize = true;
            this.labelMoras.BackColor = System.Drawing.Color.Transparent;
            this.labelMoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoras.Location = new System.Drawing.Point(362, 107);
            this.labelMoras.Name = "labelMoras";
            this.labelMoras.Size = new System.Drawing.Size(143, 20);
            this.labelMoras.TabIndex = 43;
            this.labelMoras.Text = "Tipos de Inventario";
            // 
            // dtgTipoInventario
            // 
            this.dtgTipoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoInventario.Location = new System.Drawing.Point(365, 128);
            this.dtgTipoInventario.Name = "dtgTipoInventario";
            this.dtgTipoInventario.Size = new System.Drawing.Size(419, 215);
            this.dtgTipoInventario.TabIndex = 42;
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(199, 192);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 41;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(97, 194);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 40;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(50, 292);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 31);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(149, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(149, 260);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 31);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(50, 260);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(92, 31);
            this.btnIngresar.TabIndex = 36;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtidtinventario
            // 
            this.txtidtinventario.Location = new System.Drawing.Point(97, 107);
            this.txtidtinventario.Name = "txtidtinventario";
            this.txtidtinventario.Size = new System.Drawing.Size(100, 20);
            this.txtidtinventario.TabIndex = 35;
            // 
            // txtnombretinventario
            // 
            this.txtnombretinventario.Location = new System.Drawing.Point(97, 135);
            this.txtnombretinventario.Name = "txtnombretinventario";
            this.txtnombretinventario.Size = new System.Drawing.Size(100, 20);
            this.txtnombretinventario.TabIndex = 34;
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(17, 192);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
            this.labelestadoinventario.TabIndex = 33;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labelnombretinventario
            // 
            this.labelnombretinventario.AutoSize = true;
            this.labelnombretinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelnombretinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombretinventario.Location = new System.Drawing.Point(17, 140);
            this.labelnombretinventario.Name = "labelnombretinventario";
            this.labelnombretinventario.Size = new System.Drawing.Size(69, 20);
            this.labelnombretinventario.TabIndex = 32;
            this.labelnombretinventario.Text = "Nombre:";
            // 
            // labelidtinventario
            // 
            this.labelidtinventario.AutoSize = true;
            this.labelidtinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidtinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidtinventario.Location = new System.Drawing.Point(17, 112);
            this.labelidtinventario.Name = "labelidtinventario";
            this.labelidtinventario.Size = new System.Drawing.Size(30, 20);
            this.labelidtinventario.TabIndex = 31;
            this.labelidtinventario.Text = "ID:";
            // 
            // frmMantenimientoTipoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.labelMoras);
            this.Controls.Add(this.dtgTipoInventario);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtidtinventario);
            this.Controls.Add(this.txtnombretinventario);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labelnombretinventario);
            this.Controls.Add(this.labelidtinventario);
            this.Name = "frmMantenimientoTipoInventario";
            this.Text = "frmMantenimientoTipoInventario";
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
        private System.Windows.Forms.TextBox txtidtinventario;
        private System.Windows.Forms.TextBox txtnombretinventario;
        private System.Windows.Forms.Label labelestadoinventario;
        private System.Windows.Forms.Label labelnombretinventario;
        private System.Windows.Forms.Label labelidtinventario;
    }
}