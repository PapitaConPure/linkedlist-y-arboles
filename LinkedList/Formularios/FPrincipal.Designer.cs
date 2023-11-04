
namespace LinkedList {
	partial class FPrincipal {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnSalir = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnListaLigada = new System.Windows.Forms.Button();
			this.btnListaDoblementeLigada = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPila = new System.Windows.Forms.Button();
			this.btnCola = new System.Windows.Forms.Button();
			this.gbArbolBinario = new System.Windows.Forms.Button();
			this.btnTablaHash = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tlpBotones.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tlpBotones.Controls.Add(this.btnSalir, 0, 8);
			this.tlpBotones.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tlpBotones.Controls.Add(this.gbArbolBinario, 0, 3);
			this.tlpBotones.Controls.Add(this.btnTablaHash, 0, 4);
			this.tlpBotones.Controls.Add(this.button2, 0, 6);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpBotones.Location = new System.Drawing.Point(16, 18);
			this.tlpBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.RowCount = 9;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.Size = new System.Drawing.Size(372, 485);
			this.tlpBotones.TabIndex = 12;
			// 
			// btnSalir
			// 
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnSalir.Location = new System.Drawing.Point(4, 416);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(364, 64);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnListaDoblementeLigada, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnListaLigada, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 64);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnListaLigada
			// 
			this.btnListaLigada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnListaLigada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnListaLigada.Location = new System.Drawing.Point(4, 5);
			this.btnListaLigada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListaLigada.Name = "btnListaLigada";
			this.btnListaLigada.Size = new System.Drawing.Size(175, 54);
			this.btnListaLigada.TabIndex = 0;
			this.btnListaLigada.Text = "Lista Ligada";
			this.btnListaLigada.UseVisualStyleBackColor = true;
			this.btnListaLigada.Click += new System.EventHandler(this.BtnListaLigada_Click);
			// 
			// btnListaDoblementeLigada
			// 
			this.btnListaDoblementeLigada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnListaDoblementeLigada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnListaDoblementeLigada.Location = new System.Drawing.Point(187, 5);
			this.btnListaDoblementeLigada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListaDoblementeLigada.Name = "btnListaDoblementeLigada";
			this.btnListaDoblementeLigada.Size = new System.Drawing.Size(175, 54);
			this.btnListaDoblementeLigada.TabIndex = 1;
			this.btnListaDoblementeLigada.Text = "L. L. Doble";
			this.btnListaDoblementeLigada.UseVisualStyleBackColor = true;
			this.btnListaDoblementeLigada.Click += new System.EventHandler(this.BtnListaDoblementeLigada_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btnCola, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnPila, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 73);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 64);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btnPila
			// 
			this.btnPila.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPila.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnPila.Location = new System.Drawing.Point(4, 5);
			this.btnPila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPila.Name = "btnPila";
			this.btnPila.Size = new System.Drawing.Size(175, 54);
			this.btnPila.TabIndex = 1;
			this.btnPila.Text = "Pila";
			this.btnPila.UseVisualStyleBackColor = true;
			this.btnPila.Click += new System.EventHandler(this.BtnPila_Click);
			// 
			// btnCola
			// 
			this.btnCola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCola.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCola.Location = new System.Drawing.Point(187, 5);
			this.btnCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCola.Name = "btnCola";
			this.btnCola.Size = new System.Drawing.Size(175, 54);
			this.btnCola.TabIndex = 2;
			this.btnCola.Text = "Cola";
			this.btnCola.UseVisualStyleBackColor = true;
			this.btnCola.Click += new System.EventHandler(this.BtnCola_Click);
			// 
			// gbArbolBinario
			// 
			this.gbArbolBinario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.gbArbolBinario.Location = new System.Drawing.Point(4, 160);
			this.gbArbolBinario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbArbolBinario.Name = "gbArbolBinario";
			this.gbArbolBinario.Size = new System.Drawing.Size(364, 60);
			this.gbArbolBinario.TabIndex = 2;
			this.gbArbolBinario.Text = "Arbol Binario de Búsqueda";
			this.gbArbolBinario.UseVisualStyleBackColor = true;
			this.gbArbolBinario.Click += new System.EventHandler(this.GbArbolBinario_Click);
			// 
			// btnTablaHash
			// 
			this.btnTablaHash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTablaHash.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnTablaHash.Location = new System.Drawing.Point(3, 228);
			this.btnTablaHash.Name = "btnTablaHash";
			this.btnTablaHash.Size = new System.Drawing.Size(366, 64);
			this.btnTablaHash.TabIndex = 3;
			this.btnTablaHash.Text = "Tabla de Hash";
			this.btnTablaHash.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.button2.Location = new System.Drawing.Point(3, 313);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(366, 64);
			this.button2.TabIndex = 4;
			this.button2.Text = "Diccionario";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 521);
			this.Controls.Add(this.tlpBotones);
			this.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(320, 407);
			this.Name = "FPrincipal";
			this.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Escoge una opción";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.tlpBotones.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnListaDoblementeLigada;
		private System.Windows.Forms.Button btnListaLigada;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnCola;
		private System.Windows.Forms.Button btnPila;
		private System.Windows.Forms.Button gbArbolBinario;
		private System.Windows.Forms.Button btnTablaHash;
		private System.Windows.Forms.Button button2;
	}
}

