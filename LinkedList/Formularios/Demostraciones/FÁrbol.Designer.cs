
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
			this.btnAgregarPrimero = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnAgregarÚltimo = new System.Windows.Forms.Button();
			this.gbElementos = new System.Windows.Forms.GroupBox();
			this.lsbElementos = new System.Windows.Forms.ListBox();
			this.pnlRecorrido = new System.Windows.Forms.Panel();
			this.tbSubnodoDerecho = new System.Windows.Forms.TextBox();
			this.tbSubnodoIzquierdo = new System.Windows.Forms.TextBox();
			this.tbNodoActual = new System.Windows.Forms.TextBox();
			this.tbNodoSuperior = new System.Windows.Forms.TextBox();
			this.btnSubnodoDerecho = new System.Windows.Forms.Button();
			this.btnSubnodoIzquierdo = new System.Windows.Forms.Button();
			this.btnNodoActual = new System.Windows.Forms.Button();
			this.btnNodoSuperior = new System.Windows.Forms.Button();
			this.tlpBotones.SuspendLayout();
			this.gbElementos.SuspendLayout();
			this.pnlRecorrido.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnContiene, 0, 4);
			this.tlpBotones.Controls.Add(this.btnAgregarPrimero, 0, 0);
			this.tlpBotones.Controls.Add(this.btnInsertar, 0, 2);
			this.tlpBotones.Controls.Add(this.btnLimpiar, 0, 3);
			this.tlpBotones.Controls.Add(this.btnAgregarÚltimo, 0, 1);
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
			this.tlpBotones.TabIndex = 1;
			// 
			// btnContiene
			// 
			this.btnContiene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContiene.Location = new System.Drawing.Point(3, 343);
			this.btnContiene.Name = "btnContiene";
			this.btnContiene.Size = new System.Drawing.Size(148, 80);
			this.btnContiene.TabIndex = 10;
			this.btnContiene.Text = "¿Contiene elemento? (...)";
			this.btnContiene.UseVisualStyleBackColor = true;
			// 
			// btnAgregarPrimero
			// 
			this.btnAgregarPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarPrimero.Location = new System.Drawing.Point(3, 3);
			this.btnAgregarPrimero.Name = "btnAgregarPrimero";
			this.btnAgregarPrimero.Size = new System.Drawing.Size(148, 79);
			this.btnAgregarPrimero.TabIndex = 0;
			this.btnAgregarPrimero.Text = "Agregar (...)";
			this.btnAgregarPrimero.UseVisualStyleBackColor = true;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInsertar.Location = new System.Drawing.Point(3, 173);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(148, 79);
			this.btnInsertar.TabIndex = 2;
			this.btnInsertar.Text = "Quitar (...)";
			this.btnInsertar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiar.Location = new System.Drawing.Point(3, 258);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(148, 79);
			this.btnLimpiar.TabIndex = 7;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnAgregarÚltimo
			// 
			this.btnAgregarÚltimo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarÚltimo.Location = new System.Drawing.Point(3, 88);
			this.btnAgregarÚltimo.Name = "btnAgregarÚltimo";
			this.btnAgregarÚltimo.Size = new System.Drawing.Size(148, 79);
			this.btnAgregarÚltimo.TabIndex = 1;
			this.btnAgregarÚltimo.Text = "Buscar (...)";
			this.btnAgregarÚltimo.UseVisualStyleBackColor = true;
			// 
			// gbElementos
			// 
			this.gbElementos.Controls.Add(this.lsbElementos);
			this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbElementos.Location = new System.Drawing.Point(169, 12);
			this.gbElementos.Name = "gbElementos";
			this.gbElementos.Size = new System.Drawing.Size(419, 426);
			this.gbElementos.TabIndex = 3;
			this.gbElementos.TabStop = false;
			this.gbElementos.Text = "Los botones con (...) requieren ingresar datos";
			// 
			// lsbElementos
			// 
			this.lsbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbElementos.FormattingEnabled = true;
			this.lsbElementos.IntegralHeight = false;
			this.lsbElementos.Location = new System.Drawing.Point(3, 16);
			this.lsbElementos.Name = "lsbElementos";
			this.lsbElementos.ScrollAlwaysVisible = true;
			this.lsbElementos.Size = new System.Drawing.Size(413, 407);
			this.lsbElementos.TabIndex = 1;
			// 
			// pnlRecorrido
			// 
			this.pnlRecorrido.Controls.Add(this.tbSubnodoDerecho);
			this.pnlRecorrido.Controls.Add(this.tbSubnodoIzquierdo);
			this.pnlRecorrido.Controls.Add(this.tbNodoActual);
			this.pnlRecorrido.Controls.Add(this.tbNodoSuperior);
			this.pnlRecorrido.Controls.Add(this.btnSubnodoDerecho);
			this.pnlRecorrido.Controls.Add(this.btnSubnodoIzquierdo);
			this.pnlRecorrido.Controls.Add(this.btnNodoActual);
			this.pnlRecorrido.Controls.Add(this.btnNodoSuperior);
			this.pnlRecorrido.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlRecorrido.Location = new System.Drawing.Point(588, 12);
			this.pnlRecorrido.Name = "pnlRecorrido";
			this.pnlRecorrido.Size = new System.Drawing.Size(200, 426);
			this.pnlRecorrido.TabIndex = 4;
			// 
			// tbSubnodoDerecho
			// 
			this.tbSubnodoDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSubnodoDerecho.Location = new System.Drawing.Point(84, 276);
			this.tbSubnodoDerecho.Name = "tbSubnodoDerecho";
			this.tbSubnodoDerecho.ReadOnly = true;
			this.tbSubnodoDerecho.Size = new System.Drawing.Size(113, 20);
			this.tbSubnodoDerecho.TabIndex = 4;
			this.tbSubnodoDerecho.TabStop = false;
			// 
			// tbSubnodoIzquierdo
			// 
			this.tbSubnodoIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSubnodoIzquierdo.Location = new System.Drawing.Point(84, 238);
			this.tbSubnodoIzquierdo.Name = "tbSubnodoIzquierdo";
			this.tbSubnodoIzquierdo.ReadOnly = true;
			this.tbSubnodoIzquierdo.Size = new System.Drawing.Size(113, 20);
			this.tbSubnodoIzquierdo.TabIndex = 3;
			this.tbSubnodoIzquierdo.TabStop = false;
			// 
			// tbNodoActual
			// 
			this.tbNodoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNodoActual.Location = new System.Drawing.Point(64, 200);
			this.tbNodoActual.Name = "tbNodoActual";
			this.tbNodoActual.ReadOnly = true;
			this.tbNodoActual.Size = new System.Drawing.Size(113, 20);
			this.tbNodoActual.TabIndex = 2;
			this.tbNodoActual.TabStop = false;
			// 
			// tbNodoSuperior
			// 
			this.tbNodoSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbNodoSuperior.Location = new System.Drawing.Point(44, 162);
			this.tbNodoSuperior.Name = "tbNodoSuperior";
			this.tbNodoSuperior.ReadOnly = true;
			this.tbNodoSuperior.Size = new System.Drawing.Size(113, 20);
			this.tbNodoSuperior.TabIndex = 1;
			this.tbNodoSuperior.TabStop = false;
			// 
			// btnSubnodoDerecho
			// 
			this.btnSubnodoDerecho.Location = new System.Drawing.Point(46, 269);
			this.btnSubnodoDerecho.Name = "btnSubnodoDerecho";
			this.btnSubnodoDerecho.Size = new System.Drawing.Size(32, 32);
			this.btnSubnodoDerecho.TabIndex = 0;
			this.btnSubnodoDerecho.Text = "der";
			this.btnSubnodoDerecho.UseVisualStyleBackColor = true;
			// 
			// btnSubnodoIzquierdo
			// 
			this.btnSubnodoIzquierdo.Location = new System.Drawing.Point(46, 231);
			this.btnSubnodoIzquierdo.Name = "btnSubnodoIzquierdo";
			this.btnSubnodoIzquierdo.Size = new System.Drawing.Size(32, 32);
			this.btnSubnodoIzquierdo.TabIndex = 0;
			this.btnSubnodoIzquierdo.Text = "izq";
			this.btnSubnodoIzquierdo.UseVisualStyleBackColor = true;
			// 
			// btnNodoActual
			// 
			this.btnNodoActual.Location = new System.Drawing.Point(26, 193);
			this.btnNodoActual.Name = "btnNodoActual";
			this.btnNodoActual.Size = new System.Drawing.Size(32, 32);
			this.btnNodoActual.TabIndex = 0;
			this.btnNodoActual.Text = ".";
			this.btnNodoActual.UseVisualStyleBackColor = true;
			// 
			// btnNodoSuperior
			// 
			this.btnNodoSuperior.Location = new System.Drawing.Point(6, 155);
			this.btnNodoSuperior.Name = "btnNodoSuperior";
			this.btnNodoSuperior.Size = new System.Drawing.Size(32, 32);
			this.btnNodoSuperior.TabIndex = 0;
			this.btnNodoSuperior.Text = "..";
			this.btnNodoSuperior.UseVisualStyleBackColor = true;
			// 
			// FÁrbol
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gbElementos);
			this.Controls.Add(this.tlpBotones);
			this.Controls.Add(this.pnlRecorrido);
			this.MinimumSize = new System.Drawing.Size(640, 240);
			this.Name = "FÁrbol";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Demostración de Árbol Binario";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FÁrbol_FormClosed);
			this.tlpBotones.ResumeLayout(false);
			this.gbElementos.ResumeLayout(false);
			this.pnlRecorrido.ResumeLayout(false);
			this.pnlRecorrido.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnContiene;
		private System.Windows.Forms.Button btnAgregarPrimero;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnAgregarÚltimo;
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
		private System.Windows.Forms.TextBox tbNodoSuperior;
	}
}