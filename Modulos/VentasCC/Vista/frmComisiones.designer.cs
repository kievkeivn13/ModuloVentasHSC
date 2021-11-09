
namespace CapaVistaMVentasCC
{
    partial class frmComisiones
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComisiones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtIdComision = new System.Windows.Forms.TextBox();
            this.cbxIdEmpleado = new System.Windows.Forms.ComboBox();
            this.txtComosionesmes = new System.Windows.Forms.TextBox();
            this.dtpFechaComisiones = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarEncabezado = new System.Windows.Forms.Button();
            this.btnModificarEncabezado = new System.Windows.Forms.Button();
            this.btnCancelarEncabezado = new System.Windows.Forms.Button();
            this.txtsacarid = new System.Windows.Forms.TextBox();
            this.btnEliminarEncabezado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgEncabezado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEmplead = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgDetalle = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFiltroMesAño = new System.Windows.Forms.DateTimePicker();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.cbxFactura = new System.Windows.Forms.ComboBox();
            this.cbxTipoComision = new System.Windows.Forms.ComboBox();
            this.txtMontoFactura = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnModificarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.btnLimpiarDetalle = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtIdCambio = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiltroFecha = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdTipoComision = new System.Windows.Forms.TextBox();
            this.txtIDC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.txtIdComision);
            this.panel1.Controls.Add(this.cbxIdEmpleado);
            this.panel1.Controls.Add(this.txtComosionesmes);
            this.panel1.Controls.Add(this.dtpFechaComisiones);
            this.panel1.Controls.Add(this.btnAgregarEncabezado);
            this.panel1.Controls.Add(this.btnModificarEncabezado);
            this.panel1.Controls.Add(this.btnCancelarEncabezado);
            this.panel1.Controls.Add(this.txtsacarid);
            this.panel1.Controls.Add(this.btnEliminarEncabezado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtgEncabezado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdEmplead);
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 292);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Enabled = false;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(185, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "Q";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Location = new System.Drawing.Point(396, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 66);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReporte.BackgroundImage")));
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReporte.ForeColor = System.Drawing.Color.Transparent;
            this.btnReporte.Location = new System.Drawing.Point(319, 210);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 66);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.ForeColor = System.Drawing.Color.Transparent;
            this.btnAyuda.Location = new System.Drawing.Point(5, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(35, 32);
            this.btnAyuda.TabIndex = 10;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // txtIdComision
            // 
            this.txtIdComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdComision.Location = new System.Drawing.Point(182, 47);
            this.txtIdComision.Name = "txtIdComision";
            this.txtIdComision.Size = new System.Drawing.Size(289, 26);
            this.txtIdComision.TabIndex = 0;
            this.txtIdComision.Tag = "Pkid";
            this.txtIdComision.TextChanged += new System.EventHandler(this.txtIdComision_TextChanged);
            // 
            // cbxIdEmpleado
            // 
            this.cbxIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdEmpleado.FormattingEnabled = true;
            this.cbxIdEmpleado.Location = new System.Drawing.Point(182, 78);
            this.cbxIdEmpleado.Name = "cbxIdEmpleado";
            this.cbxIdEmpleado.Size = new System.Drawing.Size(289, 28);
            this.cbxIdEmpleado.TabIndex = 2;
            this.cbxIdEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxIdEmpleado_SelectedIndexChanged);
            // 
            // txtComosionesmes
            // 
            this.txtComosionesmes.Enabled = false;
            this.txtComosionesmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComosionesmes.Location = new System.Drawing.Point(182, 108);
            this.txtComosionesmes.Name = "txtComosionesmes";
            this.txtComosionesmes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComosionesmes.Size = new System.Drawing.Size(289, 26);
            this.txtComosionesmes.TabIndex = 0;
            this.txtComosionesmes.Tag = "Comisionesmes";
            this.txtComosionesmes.Text = "0.00";
            // 
            // dtpFechaComisiones
            // 
            this.dtpFechaComisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaComisiones.Location = new System.Drawing.Point(182, 148);
            this.dtpFechaComisiones.Name = "dtpFechaComisiones";
            this.dtpFechaComisiones.Size = new System.Drawing.Size(289, 26);
            this.dtpFechaComisiones.TabIndex = 3;
            this.dtpFechaComisiones.ValueChanged += new System.EventHandler(this.dtpFechaComisiones_ValueChanged);
            // 
            // btnAgregarEncabezado
            // 
            this.btnAgregarEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarEncabezado.BackgroundImage")));
            this.btnAgregarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarEncabezado.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarEncabezado.Location = new System.Drawing.Point(7, 210);
            this.btnAgregarEncabezado.Name = "btnAgregarEncabezado";
            this.btnAgregarEncabezado.Size = new System.Drawing.Size(75, 66);
            this.btnAgregarEncabezado.TabIndex = 8;
            this.btnAgregarEncabezado.UseVisualStyleBackColor = false;
            this.btnAgregarEncabezado.Click += new System.EventHandler(this.btnAgregarEncabezado_Click);
            // 
            // btnModificarEncabezado
            // 
            this.btnModificarEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarEncabezado.BackgroundImage")));
            this.btnModificarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarEncabezado.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnModificarEncabezado.Enabled = false;
            this.btnModificarEncabezado.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificarEncabezado.Location = new System.Drawing.Point(85, 210);
            this.btnModificarEncabezado.Name = "btnModificarEncabezado";
            this.btnModificarEncabezado.Size = new System.Drawing.Size(75, 66);
            this.btnModificarEncabezado.TabIndex = 8;
            this.btnModificarEncabezado.UseVisualStyleBackColor = false;
            this.btnModificarEncabezado.Click += new System.EventHandler(this.btnModificarEncabezado_Click);
            // 
            // btnCancelarEncabezado
            // 
            this.btnCancelarEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarEncabezado.BackgroundImage")));
            this.btnCancelarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarEncabezado.Enabled = false;
            this.btnCancelarEncabezado.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelarEncabezado.Location = new System.Drawing.Point(241, 210);
            this.btnCancelarEncabezado.Name = "btnCancelarEncabezado";
            this.btnCancelarEncabezado.Size = new System.Drawing.Size(75, 66);
            this.btnCancelarEncabezado.TabIndex = 8;
            this.btnCancelarEncabezado.UseVisualStyleBackColor = false;
            this.btnCancelarEncabezado.Click += new System.EventHandler(this.btnCancelarEncabezado_Click);
            // 
            // txtsacarid
            // 
            this.txtsacarid.Enabled = false;
            this.txtsacarid.Location = new System.Drawing.Point(438, 82);
            this.txtsacarid.Name = "txtsacarid";
            this.txtsacarid.Size = new System.Drawing.Size(25, 20);
            this.txtsacarid.TabIndex = 9;
            this.txtsacarid.Visible = false;
            // 
            // btnEliminarEncabezado
            // 
            this.btnEliminarEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarEncabezado.BackgroundImage")));
            this.btnEliminarEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarEncabezado.Enabled = false;
            this.btnEliminarEncabezado.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarEncabezado.Location = new System.Drawing.Point(162, 210);
            this.btnEliminarEncabezado.Name = "btnEliminarEncabezado";
            this.btnEliminarEncabezado.Size = new System.Drawing.Size(75, 66);
            this.btnEliminarEncabezado.TabIndex = 8;
            this.btnEliminarEncabezado.UseVisualStyleBackColor = true;
            this.btnEliminarEncabezado.Click += new System.EventHandler(this.btnEliminarEncabezado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Comisiones del mes:";
            // 
            // dtgEncabezado
            // 
            this.dtgEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEncabezado.Location = new System.Drawing.Point(512, 27);
            this.dtgEncabezado.Name = "dtgEncabezado";
            this.dtgEncabezado.Size = new System.Drawing.Size(670, 263);
            this.dtgEncabezado.TabIndex = 2;
            this.dtgEncabezado.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgEncabezado_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Comisión:";
            // 
            // txtIdEmplead
            // 
            this.txtIdEmplead.Enabled = false;
            this.txtIdEmplead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmplead.Location = new System.Drawing.Point(396, 79);
            this.txtIdEmplead.Name = "txtIdEmplead";
            this.txtIdEmplead.Size = new System.Drawing.Size(26, 26);
            this.txtIdEmplead.TabIndex = 0;
            this.txtIdEmplead.Tag = "Fkidempleado";
            this.txtIdEmplead.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(182, 148);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 26);
            this.txtFecha.TabIndex = 0;
            this.txtFecha.Tag = "Fechacomisiones";
            this.txtFecha.Visible = false;
            this.txtFecha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(778, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Comisión Encabezado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fecha:";
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalle.Location = new System.Drawing.Point(512, 25);
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.Size = new System.Drawing.Size(670, 282);
            this.dtgDetalle.TabIndex = 2;
            this.dtgDetalle.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgDetalle_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.dtpFiltroMesAño);
            this.panel2.Controls.Add(this.txtIdDetalle);
            this.panel2.Controls.Add(this.cbxFactura);
            this.panel2.Controls.Add(this.cbxTipoComision);
            this.panel2.Controls.Add(this.txtMontoFactura);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.btnAgregarDetalle);
            this.panel2.Controls.Add(this.btnModificarDetalle);
            this.panel2.Controls.Add(this.btnEliminarDetalle);
            this.panel2.Controls.Add(this.btnLimpiarDetalle);
            this.panel2.Controls.Add(this.dtgDetalle);
            this.panel2.Controls.Add(this.txtCambio);
            this.panel2.Controls.Add(this.txtIdCambio);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtFiltroFecha);
            this.panel2.Controls.Add(this.txtPorcentaje);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtIDF);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtIdTipoComision);
            this.panel2.Controls.Add(this.txtIDC);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 316);
            this.panel2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Enabled = false;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(185, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Q";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Enabled = false;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(185, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Q";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Enabled = false;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(185, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Q";
            // 
            // dtpFiltroMesAño
            // 
            this.dtpFiltroMesAño.Checked = false;
            this.dtpFiltroMesAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltroMesAño.Location = new System.Drawing.Point(182, 29);
            this.dtpFiltroMesAño.Name = "dtpFiltroMesAño";
            this.dtpFiltroMesAño.Size = new System.Drawing.Size(173, 26);
            this.dtpFiltroMesAño.TabIndex = 3;
            this.dtpFiltroMesAño.Value = new System.DateTime(2021, 11, 5, 13, 56, 45, 0);
            this.dtpFiltroMesAño.ValueChanged += new System.EventHandler(this.dtpFiltroMesAño_ValueChanged);
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.Location = new System.Drawing.Point(182, 77);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(173, 26);
            this.txtIdDetalle.TabIndex = 0;
            this.txtIdDetalle.Tag = "Fechacomisiones";
            this.txtIdDetalle.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cbxFactura
            // 
            this.cbxFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFactura.FormattingEnabled = true;
            this.cbxFactura.Location = new System.Drawing.Point(182, 111);
            this.cbxFactura.Name = "cbxFactura";
            this.cbxFactura.Size = new System.Drawing.Size(173, 28);
            this.cbxFactura.TabIndex = 2;
            this.cbxFactura.SelectedIndexChanged += new System.EventHandler(this.cbxFactura_SelectedIndexChanged);
            // 
            // cbxTipoComision
            // 
            this.cbxTipoComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoComision.FormattingEnabled = true;
            this.cbxTipoComision.Location = new System.Drawing.Point(182, 147);
            this.cbxTipoComision.Name = "cbxTipoComision";
            this.cbxTipoComision.Size = new System.Drawing.Size(173, 28);
            this.cbxTipoComision.TabIndex = 2;
            this.cbxTipoComision.SelectedIndexChanged += new System.EventHandler(this.cbxTipoComision_SelectedIndexChanged);
            // 
            // txtMontoFactura
            // 
            this.txtMontoFactura.Enabled = false;
            this.txtMontoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoFactura.Location = new System.Drawing.Point(182, 191);
            this.txtMontoFactura.Name = "txtMontoFactura";
            this.txtMontoFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMontoFactura.Size = new System.Drawing.Size(173, 26);
            this.txtMontoFactura.TabIndex = 0;
            this.txtMontoFactura.Tag = "Fechacomisiones";
            this.txtMontoFactura.Text = "0.00";
            this.txtMontoFactura.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(182, 235);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(173, 26);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.Tag = "Fechacomisiones";
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(182, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(173, 26);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.Text = "0.00";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDetalle.BackgroundImage")));
            this.btnAgregarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarDetalle.Enabled = false;
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(396, 25);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 66);
            this.btnAgregarDetalle.TabIndex = 9;
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnModificarDetalle
            // 
            this.btnModificarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarDetalle.BackgroundImage")));
            this.btnModificarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificarDetalle.Enabled = false;
            this.btnModificarDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificarDetalle.Location = new System.Drawing.Point(396, 97);
            this.btnModificarDetalle.Name = "btnModificarDetalle";
            this.btnModificarDetalle.Size = new System.Drawing.Size(75, 66);
            this.btnModificarDetalle.TabIndex = 9;
            this.btnModificarDetalle.UseVisualStyleBackColor = false;
            this.btnModificarDetalle.Click += new System.EventHandler(this.btnModificarDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarDetalle.BackgroundImage")));
            this.btnEliminarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarDetalle.Enabled = false;
            this.btnEliminarDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(396, 169);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(75, 66);
            this.btnEliminarDetalle.TabIndex = 9;
            this.btnEliminarDetalle.UseVisualStyleBackColor = false;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // btnLimpiarDetalle
            // 
            this.btnLimpiarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDetalle.BackgroundImage")));
            this.btnLimpiarDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarDetalle.Enabled = false;
            this.btnLimpiarDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDetalle.Location = new System.Drawing.Point(396, 241);
            this.btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            this.btnLimpiarDetalle.Size = new System.Drawing.Size(75, 66);
            this.btnLimpiarDetalle.TabIndex = 9;
            this.btnLimpiarDetalle.UseVisualStyleBackColor = false;
            this.btnLimpiarDetalle.Click += new System.EventHandler(this.btnLimpiarDetalle_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(552, 279);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 7;
            // 
            // txtIdCambio
            // 
            this.txtIdCambio.Enabled = false;
            this.txtIdCambio.Location = new System.Drawing.Point(552, 247);
            this.txtIdCambio.Name = "txtIdCambio";
            this.txtIdCambio.Size = new System.Drawing.Size(100, 20);
            this.txtIdCambio.TabIndex = 7;
            this.txtIdCambio.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(797, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Comisión Detalle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mes y  año de factura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total Comosión:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comosión Factura:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Monto Factura:";
            // 
            // txtFiltroFecha
            // 
            this.txtFiltroFecha.Enabled = false;
            this.txtFiltroFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFecha.Location = new System.Drawing.Point(182, 29);
            this.txtFiltroFecha.Name = "txtFiltroFecha";
            this.txtFiltroFecha.Size = new System.Drawing.Size(106, 26);
            this.txtFiltroFecha.TabIndex = 0;
            this.txtFiltroFecha.Tag = "Fechacomisiones";
            this.txtFiltroFecha.Visible = false;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(553, 192);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(106, 26);
            this.txtPorcentaje.TabIndex = 0;
            this.txtPorcentaje.Tag = "Fechacomisiones";
            this.txtPorcentaje.Text = "0.00";
            this.txtPorcentaje.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tipo Comisión";
            // 
            // txtIDF
            // 
            this.txtIDF.Enabled = false;
            this.txtIDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDF.Location = new System.Drawing.Point(321, 113);
            this.txtIDF.Name = "txtIDF";
            this.txtIDF.Size = new System.Drawing.Size(29, 26);
            this.txtIDF.TabIndex = 0;
            this.txtIDF.Tag = "Fechacomisiones";
            this.txtIDF.Visible = false;
            this.txtIDF.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Factura:";
            // 
            // txtIdTipoComision
            // 
            this.txtIdTipoComision.Enabled = false;
            this.txtIdTipoComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTipoComision.Location = new System.Drawing.Point(321, 147);
            this.txtIdTipoComision.Name = "txtIdTipoComision";
            this.txtIdTipoComision.Size = new System.Drawing.Size(29, 26);
            this.txtIdTipoComision.TabIndex = 0;
            this.txtIdTipoComision.Tag = "Fechacomisiones";
            this.txtIdTipoComision.Visible = false;
            this.txtIdTipoComision.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtIDC
            // 
            this.txtIDC.Enabled = false;
            this.txtIDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDC.Location = new System.Drawing.Point(649, 102);
            this.txtIDC.Name = "txtIDC";
            this.txtIDC.Size = new System.Drawing.Size(41, 26);
            this.txtIDC.TabIndex = 0;
            this.txtIDC.Tag = "Fechacomisiones";
            this.txtIDC.Visible = false;
            this.txtIDC.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID Comision";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // frmComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1197, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3502 Comisiones Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdComision;
        private System.Windows.Forms.DateTimePicker dtpFechaComisiones;
        private System.Windows.Forms.ComboBox cbxIdEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComosionesmes;
        private System.Windows.Forms.TextBox txtIdEmplead;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxTipoComision;
        private System.Windows.Forms.ComboBox cbxFactura;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgDetalle;
        private System.Windows.Forms.DataGridView dtgEncabezado;
        private System.Windows.Forms.DateTimePicker dtpFiltroMesAño;
        private System.Windows.Forms.TextBox txtFiltroFecha;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdTipoComision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEliminarEncabezado;
        private System.Windows.Forms.Button btnModificarEncabezado;
        private System.Windows.Forms.Button btnAgregarEncabezado;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtIdCambio;
        private System.Windows.Forms.Button btnCancelarEncabezado;
        private System.Windows.Forms.Button btnModificarDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnLimpiarDetalle;
        private System.Windows.Forms.TextBox txtsacarid;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnActualizar;
    }
}