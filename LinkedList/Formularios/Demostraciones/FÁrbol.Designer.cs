﻿
namespace LinkedList {
	partial class FÁrbol {
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
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.gbElementos = new System.Windows.Forms.GroupBox();
			this.lsbElementos = new System.Windows.Forms.ListBox();
			this.pnlRecorrido = new System.Windows.Forms.Panel();
			this.gbRecorrido = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.rbPreOrden = new System.Windows.Forms.RadioButton();
			this.rbPostOrden = new System.Windows.Forms.RadioButton();
			this.rbInOrden = new System.Windows.Forms.RadioButton();
			this.tbSubnodoDerecho = new System.Windows.Forms.TextBox();
			this.tbSubnodoIzquierdo = new System.Windows.Forms.TextBox();
			this.tbNodoActual = new System.Windows.Forms.TextBox();
			this.tbNodoRaíz = new System.Windows.Forms.TextBox();
			this.btnSubnodoDerecho = new System.Windows.Forms.Button();
			this.btnSubnodoIzquierdo = new System.Windows.Forms.Button();
			this.btnNodoActual = new System.Windows.Forms.Button();
			this.btnNodoSuperior = new System.Windows.Forms.Button();
			this.tlpBotones.SuspendLayout();
			this.gbElementos.SuspendLayout();
			this.pnlRecorrido.SuspendLayout();
			this.gbRecorrido.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnContiene, 0, 1);
			this.tlpBotones.Controls.Add(this.btnAgregar, 0, 2);
			this.tlpBotones.Controls.Add(this.btnQuitar, 0, 3);
			this.tlpBotones.Controls.Add(this.btnLimpiar, 0, 4);
			this.tlpBotones.Controls.Add(this.btnBuscar, 0, 0);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpBotones.Location = new System.Drawing.Point(12, 12);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.tlpBotones.RowCount = 5;
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
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.Size = new System.Drawing.Size(157, 426);
			this.tlpBotones.TabIndex = 0;
			// 
			// btnContiene
			// 
			this.btnContiene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContiene.Location = new System.Drawing.Point(3, 88);
			this.btnContiene.Name = "btnContiene";
			this.btnContiene.Size = new System.Drawing.Size(148, 79);
			this.btnContiene.TabIndex = 1;
			this.btnContiene.Text = "¿Contiene elemento? (...)";
			this.btnContiene.UseVisualStyleBackColor = true;
			this.btnContiene.Click += new System.EventHandler(this.BtnContiene_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregar.Location = new System.Drawing.Point(3, 173);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(148, 79);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "Agregar (...)";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitar.Location = new System.Drawing.Point(3, 258);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(148, 79);
			this.btnQuitar.TabIndex = 3;
			this.btnQuitar.Text = "Quitar (...)";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiar.Location = new System.Drawing.Point(3, 343);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(148, 80);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBuscar.Location = new System.Drawing.Point(3, 3);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(148, 79);
			this.btnBuscar.TabIndex = 0;
			this.btnBuscar.Text = "Buscar (...)";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
			// 
			// gbElementos
			// 
			this.gbElementos.Controls.Add(this.lsbElementos);
			this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbElementos.Location = new System.Drawing.Point(169, 12);
			this.gbElementos.Name = "gbElementos";
			this.gbElementos.Size = new System.Drawing.Size(419, 426);
			this.gbElementos.TabIndex = 1;
			this.gbElementos.TabStop = false;
			this.gbElementos.Text = "Los números se ordenan por caracteres, no valor";
			// 
			// lsbElementos
			// 
			this.lsbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbElementos.FormattingEnabled = true;
			this.lsbElementos.IntegralHeight = false;
			this.lsbElementos.Location = new System.Drawing.Point(3, 16);
			this.lsbElementos.Name = "lsbElementos";
			this.lsbElementos.ScrollAlwaysVisible = true;
			this.lsbElementos.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lsbElementos.Size = new System.Drawing.Size(413, 407);
			this.lsbElementos.TabIndex = 1;
			this.lsbElementos.TabStop = false;
			// 
			// pnlRecorrido
			// 
			this.pnlRecorrido.Controls.Add(this.gbRecorrido);
			this.pnlRecorrido.Controls.Add(this.tbSubnodoDerecho);
			this.pnlRecorrido.Controls.Add(this.tbSubnodoIzquierdo);
			this.pnlRecorrido.Controls.Add(this.tbNodoActual);
			this.pnlRecorrido.Controls.Add(this.tbNodoRaíz);
			this.pnlRecorrido.Controls.Add(this.btnSubnodoDerecho);
			this.pnlRecorrido.Controls.Add(this.btnSubnodoIzquierdo);
			this.pnlRecorrido.Controls.Add(this.btnNodoActual);
			this.pnlRecorrido.Controls.Add(this.btnNodoSuperior);
			this.pnlRecorrido.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlRecorrido.Location = new System.Drawing.Point(588, 12);
			this.pnlRecorrido.Name = "pnlRecorrido";
			this.pnlRecorrido.Size = new System.Drawing.Size(200, 426);
			this.pnlRecorrido.TabIndex = 2;
			// 
			// gbRecorrido
			// 
			this.gbRecorrido.Controls.Add(this.tableLayoutPanel1);
			this.gbRecorrido.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbRecorrido.Location = new System.Drawing.Point(0, 356);
			this.gbRecorrido.Name = "gbRecorrido";
			this.gbRecorrido.Size = new System.Drawing.Size(200, 70);
			this.gbRecorrido.TabIndex = 4;
			this.gbRecorrido.TabStop = false;
			this.gbRecorrido.Text = "Recorrido";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.rbPreOrden, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.rbPostOrden, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.rbInOrden, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 51);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// rbPreOrden
			// 
			this.rbPreOrden.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbPreOrden.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbPreOrden.Location = new System.Drawing.Point(3, 3);
			this.rbPreOrden.Name = "rbPreOrden";
			this.rbPreOrden.Size = new System.Drawing.Size(58, 45);
			this.rbPreOrden.TabIndex = 0;
			this.rbPreOrden.TabStop = true;
			this.rbPreOrden.Text = "Pre\r\nOrden";
			this.rbPreOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbPreOrden.UseVisualStyleBackColor = true;
			this.rbPreOrden.CheckedChanged += new System.EventHandler(this.RbOrden_CheckedChanged);
			// 
			// rbPostOrden
			// 
			this.rbPostOrden.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbPostOrden.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbPostOrden.Location = new System.Drawing.Point(131, 3);
			this.rbPostOrden.Name = "rbPostOrden";
			this.rbPostOrden.Size = new System.Drawing.Size(60, 45);
			this.rbPostOrden.TabIndex = 2;
			this.rbPostOrden.TabStop = true;
			this.rbPostOrden.Text = "Post\r\nOrden";
			this.rbPostOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbPostOrden.UseVisualStyleBackColor = true;
			this.rbPostOrden.CheckedChanged += new System.EventHandler(this.RbOrden_CheckedChanged);
			// 
			// rbInOrden
			// 
			this.rbInOrden.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.rbInOrden.Checked = true;
			this.rbInOrden.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rbInOrden.Location = new System.Drawing.Point(67, 3);
			this.rbInOrden.Name = "rbInOrden";
			this.rbInOrden.Size = new System.Drawing.Size(58, 45);
			this.rbInOrden.TabIndex = 1;
			this.rbInOrden.TabStop = true;
			this.rbInOrden.Text = "In\r\nOrden";
			this.rbInOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rbInOrden.UseVisualStyleBackColor = true;
			this.rbInOrden.CheckedChanged += new System.EventHandler(this.RbOrden_CheckedChanged);
			// 
			// tbSubnodoDerecho
			// 
			this.tbSubnodoDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSubnodoDerecho.Location = new System.Drawing.Point(84, 125);
			this.tbSubnodoDerecho.Name = "tbSubnodoDerecho";
			this.tbSubnodoDerecho.ReadOnly = true;
			this.tbSubnodoDerecho.Size = new System.Drawing.Size(113, 20);
			this.tbSubnodoDerecho.TabIndex = 4;
			this.tbSubnodoDerecho.TabStop = false;
			// 
			// tbSubnodoIzquierdo
			// 
			this.tbSubnodoIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSubnodoIzquierdo.Location = new System.Drawing.Point(84, 86);
			this.tbSubnodoIzquierdo.Name = "tbSubnodoIzquierdo";
			this.tbSubnodoIzquierdo.ReadOnly = true;
			this.tbSubnodoIzquierdo.Size = new System.Drawing.Size(113, 20);
			this.tbSubnodoIzquierdo.TabIndex = 3;
			this.tbSubnodoIzquierdo.TabStop = false;
			// 
			// tbNodoActual
			// 
			this.tbNodoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNodoActual.Location = new System.Drawing.Point(64, 48);
			this.tbNodoActual.Name = "tbNodoActual";
			this.tbNodoActual.ReadOnly = true;
			this.tbNodoActual.Size = new System.Drawing.Size(113, 20);
			this.tbNodoActual.TabIndex = 2;
			this.tbNodoActual.TabStop = false;
			// 
			// tbNodoRaíz
			// 
			this.tbNodoRaíz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNodoRaíz.Location = new System.Drawing.Point(44, 10);
			this.tbNodoRaíz.Name = "tbNodoRaíz";
			this.tbNodoRaíz.ReadOnly = true;
			this.tbNodoRaíz.Size = new System.Drawing.Size(113, 20);
			this.tbNodoRaíz.TabIndex = 1;
			this.tbNodoRaíz.TabStop = false;
			// 
			// btnSubnodoDerecho
			// 
			this.btnSubnodoDerecho.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.btnSubnodoDerecho.Location = new System.Drawing.Point(46, 117);
			this.btnSubnodoDerecho.Name = "btnSubnodoDerecho";
			this.btnSubnodoDerecho.Size = new System.Drawing.Size(32, 32);
			this.btnSubnodoDerecho.TabIndex = 2;
			this.btnSubnodoDerecho.Text = ">";
			this.btnSubnodoDerecho.UseVisualStyleBackColor = true;
			this.btnSubnodoDerecho.Click += new System.EventHandler(this.BtnSubnodoDerecho_Click);
			// 
			// btnSubnodoIzquierdo
			// 
			this.btnSubnodoIzquierdo.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.btnSubnodoIzquierdo.Location = new System.Drawing.Point(46, 79);
			this.btnSubnodoIzquierdo.Name = "btnSubnodoIzquierdo";
			this.btnSubnodoIzquierdo.Size = new System.Drawing.Size(32, 32);
			this.btnSubnodoIzquierdo.TabIndex = 1;
			this.btnSubnodoIzquierdo.Text = "<";
			this.btnSubnodoIzquierdo.UseVisualStyleBackColor = true;
			this.btnSubnodoIzquierdo.Click += new System.EventHandler(this.BtnSubnodoIzquierdo_Click);
			// 
			// btnNodoActual
			// 
			this.btnNodoActual.Font = new System.Drawing.Font("Segoe UI", 13F);
			this.btnNodoActual.Location = new System.Drawing.Point(26, 41);
			this.btnNodoActual.Name = "btnNodoActual";
			this.btnNodoActual.Size = new System.Drawing.Size(32, 32);
			this.btnNodoActual.TabIndex = 0;
			this.btnNodoActual.Text = ".";
			this.btnNodoActual.UseVisualStyleBackColor = true;
			this.btnNodoActual.Click += new System.EventHandler(this.BtnNodoActual_Click);
			// 
			// btnNodoSuperior
			// 
			this.btnNodoSuperior.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.btnNodoSuperior.Location = new System.Drawing.Point(6, 3);
			this.btnNodoSuperior.Name = "btnNodoSuperior";
			this.btnNodoSuperior.Size = new System.Drawing.Size(32, 32);
			this.btnNodoSuperior.TabIndex = 3;
			this.btnNodoSuperior.Text = "*";
			this.btnNodoSuperior.UseVisualStyleBackColor = true;
			this.btnNodoSuperior.Click += new System.EventHandler(this.BtnNodoSuperior_Click);
			// 
			// FÁrbol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbElementos);
			this.Controls.Add(this.tlpBotones);
			this.Controls.Add(this.pnlRecorrido);
			this.MinimumSize = new System.Drawing.Size(660, 320);
			this.Name = "FÁrbol";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Demostración de Árbol Binario";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FÁrbol_FormClosed);
			this.tlpBotones.ResumeLayout(false);
			this.gbElementos.ResumeLayout(false);
			this.pnlRecorrido.ResumeLayout(false);
			this.pnlRecorrido.PerformLayout();
			this.gbRecorrido.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnContiene;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.GroupBox gbElementos;
		private System.Windows.Forms.ListBox lsbElementos;
		private System.Windows.Forms.Panel pnlRecorrido;
		private System.Windows.Forms.Button btnSubnodoDerecho;
		private System.Windows.Forms.Button btnSubnodoIzquierdo;
		private System.Windows.Forms.Button btnNodoActual;
		private System.Windows.Forms.Button btnNodoSuperior;
		private System.Windows.Forms.TextBox tbSubnodoDerecho;
		private System.Windows.Forms.TextBox tbSubnodoIzquierdo;
		private System.Windows.Forms.TextBox tbNodoActual;
		private System.Windows.Forms.TextBox tbNodoRaíz;
		private System.Windows.Forms.GroupBox gbRecorrido;
		private System.Windows.Forms.RadioButton rbPostOrden;
		private System.Windows.Forms.RadioButton rbInOrden;
		private System.Windows.Forms.RadioButton rbPreOrden;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}