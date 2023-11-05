
namespace LinkedList {
	partial class FTablaHash {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnContiene = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.btnContieneClave = new System.Windows.Forms.Button();
			this.btnEncontrar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnMinimizarCapacidad = new System.Windows.Forms.Button();
			this.btnContieneValor = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.gbElementos = new System.Windows.Forms.GroupBox();
			this.lsbElementos = new System.Windows.Forms.ListBox();
			this.pnlExtra = new System.Windows.Forms.Panel();
			this.lblDivisorCantidadCapacidad = new System.Windows.Forms.Label();
			this.tbCapacidad = new System.Windows.Forms.TextBox();
			this.tbCobertura = new System.Windows.Forms.TextBox();
			this.lblCoberturaMáxima = new System.Windows.Forms.Label();
			this.lblCoberturaCapacidad = new System.Windows.Forms.Label();
			this.pgbCoberturaMáxima = new System.Windows.Forms.ProgressBar();
			this.pgbCoberturaCapacidad = new System.Windows.Forms.ProgressBar();
			this.gbCamposTabla = new System.Windows.Forms.GroupBox();
			this.tbCantidad = new System.Windows.Forms.TextBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.tlpBotones.SuspendLayout();
			this.gbElementos.SuspendLayout();
			this.pnlExtra.SuspendLayout();
			this.gbCamposTabla.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnContiene, 0, 7);
			this.tlpBotones.Controls.Add(this.btnInsertar, 0, 0);
			this.tlpBotones.Controls.Add(this.btnContieneClave, 0, 5);
			this.tlpBotones.Controls.Add(this.btnEncontrar, 0, 3);
			this.tlpBotones.Controls.Add(this.btnLimpiar, 0, 4);
			this.tlpBotones.Controls.Add(this.btnMinimizarCapacidad, 0, 8);
			this.tlpBotones.Controls.Add(this.btnContieneValor, 0, 6);
			this.tlpBotones.Controls.Add(this.btnQuitar, 0, 1);
			this.tlpBotones.Controls.Add(this.btnBuscar, 0, 2);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpBotones.Location = new System.Drawing.Point(12, 12);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.tlpBotones.RowCount = 9;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090478F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091075F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090469F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090167F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090167F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090469F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090469F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090469F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090478F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.092295F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.093464F));
			this.tlpBotones.Size = new System.Drawing.Size(156, 417);
			this.tlpBotones.TabIndex = 0;
			// 
			// btnContiene
			// 
			this.btnContiene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContiene.Location = new System.Drawing.Point(3, 325);
			this.btnContiene.Name = "btnContiene";
			this.btnContiene.Size = new System.Drawing.Size(147, 40);
			this.btnContiene.TabIndex = 7;
			this.btnContiene.Text = "¿Contiene entrada? (...)";
			this.btnContiene.UseVisualStyleBackColor = true;
			this.btnContiene.Click += new System.EventHandler(this.BtnContiene_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInsertar.Location = new System.Drawing.Point(3, 3);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(147, 40);
			this.btnInsertar.TabIndex = 0;
			this.btnInsertar.Text = "Insertar (...)";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
			// 
			// btnContieneClave
			// 
			this.btnContieneClave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContieneClave.Location = new System.Drawing.Point(3, 233);
			this.btnContieneClave.Name = "btnContieneClave";
			this.btnContieneClave.Size = new System.Drawing.Size(147, 40);
			this.btnContieneClave.TabIndex = 5;
			this.btnContieneClave.Text = "¿Contiene clave? (...)";
			this.btnContieneClave.UseVisualStyleBackColor = true;
			this.btnContieneClave.Click += new System.EventHandler(this.BtnContieneClave_Click);
			// 
			// btnEncontrar
			// 
			this.btnEncontrar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEncontrar.Location = new System.Drawing.Point(3, 141);
			this.btnEncontrar.Name = "btnEncontrar";
			this.btnEncontrar.Size = new System.Drawing.Size(147, 40);
			this.btnEncontrar.TabIndex = 3;
			this.btnEncontrar.Text = "Encontrar (...)";
			this.btnEncontrar.UseVisualStyleBackColor = true;
			this.btnEncontrar.Click += new System.EventHandler(this.BtnEncontrar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiar.Location = new System.Drawing.Point(3, 187);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(147, 40);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnMinimizarCapacidad
			// 
			this.btnMinimizarCapacidad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMinimizarCapacidad.Location = new System.Drawing.Point(3, 371);
			this.btnMinimizarCapacidad.Name = "btnMinimizarCapacidad";
			this.btnMinimizarCapacidad.Size = new System.Drawing.Size(147, 43);
			this.btnMinimizarCapacidad.TabIndex = 8;
			this.btnMinimizarCapacidad.Text = "Minimizar Capacidad";
			this.btnMinimizarCapacidad.UseVisualStyleBackColor = true;
			this.btnMinimizarCapacidad.Click += new System.EventHandler(this.BtnMinimizarCapacidad_Click);
			// 
			// btnContieneValor
			// 
			this.btnContieneValor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContieneValor.Location = new System.Drawing.Point(3, 279);
			this.btnContieneValor.Name = "btnContieneValor";
			this.btnContieneValor.Size = new System.Drawing.Size(147, 40);
			this.btnContieneValor.TabIndex = 6;
			this.btnContieneValor.Text = "¿Contiene valor? (...)";
			this.btnContieneValor.UseVisualStyleBackColor = true;
			this.btnContieneValor.Click += new System.EventHandler(this.BtnContieneValor_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitar.Location = new System.Drawing.Point(3, 49);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(147, 40);
			this.btnQuitar.TabIndex = 1;
			this.btnQuitar.Text = "Quitar (...)";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBuscar.Location = new System.Drawing.Point(3, 95);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(147, 40);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar (...)";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// gbElementos
			// 
			this.gbElementos.Controls.Add(this.lsbElementos);
			this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbElementos.Location = new System.Drawing.Point(168, 12);
			this.gbElementos.Name = "gbElementos";
			this.gbElementos.Size = new System.Drawing.Size(288, 417);
			this.gbElementos.TabIndex = 1;
			this.gbElementos.TabStop = false;
			this.gbElementos.Text = "Los botones con (...) requieren ingresar claves o valores";
			// 
			// lsbElementos
			// 
			this.lsbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbElementos.FormattingEnabled = true;
			this.lsbElementos.IntegralHeight = false;
			this.lsbElementos.Location = new System.Drawing.Point(3, 16);
			this.lsbElementos.Name = "lsbElementos";
			this.lsbElementos.ScrollAlwaysVisible = true;
			this.lsbElementos.Size = new System.Drawing.Size(282, 398);
			this.lsbElementos.TabIndex = 1;
			// 
			// pnlExtra
			// 
			this.pnlExtra.Controls.Add(this.lblCantidad);
			this.pnlExtra.Controls.Add(this.gbCamposTabla);
			this.pnlExtra.Controls.Add(this.tbCantidad);
			this.pnlExtra.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlExtra.Location = new System.Drawing.Point(456, 12);
			this.pnlExtra.Name = "pnlExtra";
			this.pnlExtra.Size = new System.Drawing.Size(156, 417);
			this.pnlExtra.TabIndex = 2;
			// 
			// lblDivisorCantidadCapacidad
			// 
			this.lblDivisorCantidadCapacidad.Location = new System.Drawing.Point(67, 61);
			this.lblDivisorCantidadCapacidad.Name = "lblDivisorCantidadCapacidad";
			this.lblDivisorCantidadCapacidad.Size = new System.Drawing.Size(13, 20);
			this.lblDivisorCantidadCapacidad.TabIndex = 3;
			this.lblDivisorCantidadCapacidad.Text = "/";
			this.lblDivisorCantidadCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tbCapacidad
			// 
			this.tbCapacidad.Location = new System.Drawing.Point(86, 61);
			this.tbCapacidad.Name = "tbCapacidad";
			this.tbCapacidad.ReadOnly = true;
			this.tbCapacidad.Size = new System.Drawing.Size(55, 20);
			this.tbCapacidad.TabIndex = 2;
			this.tbCapacidad.TabStop = false;
			this.tbCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbCobertura
			// 
			this.tbCobertura.Location = new System.Drawing.Point(6, 61);
			this.tbCobertura.Name = "tbCobertura";
			this.tbCobertura.ReadOnly = true;
			this.tbCobertura.Size = new System.Drawing.Size(55, 20);
			this.tbCobertura.TabIndex = 2;
			this.tbCobertura.TabStop = false;
			this.tbCobertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblCoberturaMáxima
			// 
			this.lblCoberturaMáxima.Location = new System.Drawing.Point(6, 100);
			this.lblCoberturaMáxima.Name = "lblCoberturaMáxima";
			this.lblCoberturaMáxima.Size = new System.Drawing.Size(135, 13);
			this.lblCoberturaMáxima.TabIndex = 1;
			this.lblCoberturaMáxima.Text = "(Cobertura Máxima)";
			this.lblCoberturaMáxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCoberturaCapacidad
			// 
			this.lblCoberturaCapacidad.Location = new System.Drawing.Point(6, 16);
			this.lblCoberturaCapacidad.Name = "lblCoberturaCapacidad";
			this.lblCoberturaCapacidad.Size = new System.Drawing.Size(135, 13);
			this.lblCoberturaCapacidad.TabIndex = 1;
			this.lblCoberturaCapacidad.Text = "Cobertura / Capacidad";
			this.lblCoberturaCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pgbCoberturaMáxima
			// 
			this.pgbCoberturaMáxima.Location = new System.Drawing.Point(6, 87);
			this.pgbCoberturaMáxima.Name = "pgbCoberturaMáxima";
			this.pgbCoberturaMáxima.Size = new System.Drawing.Size(135, 10);
			this.pgbCoberturaMáxima.TabIndex = 0;
			// 
			// pgbCoberturaCapacidad
			// 
			this.pgbCoberturaCapacidad.Location = new System.Drawing.Point(6, 32);
			this.pgbCoberturaCapacidad.Name = "pgbCoberturaCapacidad";
			this.pgbCoberturaCapacidad.Size = new System.Drawing.Size(135, 23);
			this.pgbCoberturaCapacidad.TabIndex = 0;
			// 
			// gbCamposTabla
			// 
			this.gbCamposTabla.Controls.Add(this.lblCoberturaCapacidad);
			this.gbCamposTabla.Controls.Add(this.lblDivisorCantidadCapacidad);
			this.gbCamposTabla.Controls.Add(this.pgbCoberturaCapacidad);
			this.gbCamposTabla.Controls.Add(this.tbCapacidad);
			this.gbCamposTabla.Controls.Add(this.pgbCoberturaMáxima);
			this.gbCamposTabla.Controls.Add(this.tbCobertura);
			this.gbCamposTabla.Controls.Add(this.lblCoberturaMáxima);
			this.gbCamposTabla.Location = new System.Drawing.Point(6, 49);
			this.gbCamposTabla.Name = "gbCamposTabla";
			this.gbCamposTabla.Size = new System.Drawing.Size(147, 120);
			this.gbCamposTabla.TabIndex = 4;
			this.gbCamposTabla.TabStop = false;
			this.gbCamposTabla.Text = "Índices de Tabla";
			// 
			// tbCantidad
			// 
			this.tbCantidad.Location = new System.Drawing.Point(6, 19);
			this.tbCantidad.Name = "tbCantidad";
			this.tbCantidad.ReadOnly = true;
			this.tbCantidad.Size = new System.Drawing.Size(147, 20);
			this.tbCantidad.TabIndex = 2;
			this.tbCantidad.TabStop = false;
			this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblCantidad
			// 
			this.lblCantidad.Location = new System.Drawing.Point(6, 3);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(147, 13);
			this.lblCantidad.TabIndex = 1;
			this.lblCantidad.Text = "Entradas";
			this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FTablaHash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.gbElementos);
			this.Controls.Add(this.tlpBotones);
			this.Controls.Add(this.pnlExtra);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "FTablaHash";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Demostración de Tabla Hash con Lista Ligada";
			this.tlpBotones.ResumeLayout(false);
			this.gbElementos.ResumeLayout(false);
			this.pnlExtra.ResumeLayout(false);
			this.pnlExtra.PerformLayout();
			this.gbCamposTabla.ResumeLayout(false);
			this.gbCamposTabla.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnContiene;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.Button btnContieneClave;
		private System.Windows.Forms.Button btnEncontrar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnMinimizarCapacidad;
		private System.Windows.Forms.Button btnContieneValor;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox gbElementos;
		private System.Windows.Forms.ListBox lsbElementos;
		private System.Windows.Forms.Panel pnlExtra;
		private System.Windows.Forms.Label lblCoberturaCapacidad;
		private System.Windows.Forms.ProgressBar pgbCoberturaCapacidad;
		private System.Windows.Forms.TextBox tbCobertura;
		private System.Windows.Forms.Label lblDivisorCantidadCapacidad;
		private System.Windows.Forms.TextBox tbCapacidad;
		private System.Windows.Forms.Label lblCoberturaMáxima;
		private System.Windows.Forms.ProgressBar pgbCoberturaMáxima;
		private System.Windows.Forms.GroupBox gbCamposTabla;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox tbCantidad;
	}
}