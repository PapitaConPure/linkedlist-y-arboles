
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
			this.btnListaLigada = new System.Windows.Forms.Button();
			this.btnListaDoblementeLigada = new System.Windows.Forms.Button();
			this.btnPila = new System.Windows.Forms.Button();
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnCola = new System.Windows.Forms.Button();
			this.gbArbolBinario = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.tlpBotones.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnListaLigada
			// 
			this.btnListaLigada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnListaLigada.Location = new System.Drawing.Point(3, 3);
			this.btnListaLigada.Name = "btnListaLigada";
			this.btnListaLigada.Size = new System.Drawing.Size(274, 56);
			this.btnListaLigada.TabIndex = 0;
			this.btnListaLigada.Text = "Lista Ligada";
			this.btnListaLigada.UseVisualStyleBackColor = true;
			this.btnListaLigada.Click += new System.EventHandler(this.BtnListaLigada_Click);
			// 
			// btnListaDoblementeLigada
			// 
			this.btnListaDoblementeLigada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnListaDoblementeLigada.Location = new System.Drawing.Point(3, 65);
			this.btnListaDoblementeLigada.Name = "btnListaDoblementeLigada";
			this.btnListaDoblementeLigada.Size = new System.Drawing.Size(274, 56);
			this.btnListaDoblementeLigada.TabIndex = 1;
			this.btnListaDoblementeLigada.Text = "Lista Doblemente Ligada";
			this.btnListaDoblementeLigada.UseVisualStyleBackColor = true;
			this.btnListaDoblementeLigada.Click += new System.EventHandler(this.BtnListaDoblementeLigada_Click);
			// 
			// btnPila
			// 
			this.btnPila.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPila.Location = new System.Drawing.Point(3, 137);
			this.btnPila.Name = "btnPila";
			this.btnPila.Size = new System.Drawing.Size(274, 56);
			this.btnPila.TabIndex = 2;
			this.btnPila.Text = "Pila";
			this.btnPila.UseVisualStyleBackColor = true;
			this.btnPila.Click += new System.EventHandler(this.BtnPila_Click);
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnListaLigada, 0, 0);
			this.tlpBotones.Controls.Add(this.btnPila, 0, 3);
			this.tlpBotones.Controls.Add(this.btnListaDoblementeLigada, 0, 1);
			this.tlpBotones.Controls.Add(this.btnCola, 0, 4);
			this.tlpBotones.Controls.Add(this.gbArbolBinario, 0, 6);
			this.tlpBotones.Controls.Add(this.btnSalir, 0, 8);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpBotones.Location = new System.Drawing.Point(12, 12);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.RowCount = 9;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tlpBotones.Size = new System.Drawing.Size(280, 417);
			this.tlpBotones.TabIndex = 12;
			// 
			// btnCola
			// 
			this.btnCola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCola.Location = new System.Drawing.Point(3, 199);
			this.btnCola.Name = "btnCola";
			this.btnCola.Size = new System.Drawing.Size(274, 56);
			this.btnCola.TabIndex = 3;
			this.btnCola.Text = "Cola";
			this.btnCola.UseVisualStyleBackColor = true;
			this.btnCola.Click += new System.EventHandler(this.BtnCola_Click);
			// 
			// gbArbolBinario
			// 
			this.gbArbolBinario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbArbolBinario.Location = new System.Drawing.Point(3, 271);
			this.gbArbolBinario.Name = "gbArbolBinario";
			this.gbArbolBinario.Size = new System.Drawing.Size(274, 56);
			this.gbArbolBinario.TabIndex = 4;
			this.gbArbolBinario.Text = "Arbol Binario";
			this.gbArbolBinario.UseVisualStyleBackColor = true;
			this.gbArbolBinario.Click += new System.EventHandler(this.GbArbolBinario_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSalir.Location = new System.Drawing.Point(3, 353);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(274, 61);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// FPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 441);
			this.Controls.Add(this.tlpBotones);
			this.MinimumSize = new System.Drawing.Size(244, 278);
			this.Name = "FPrincipal";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Escoge una opción";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPrincipal_FormClosed);
			this.Load += new System.EventHandler(this.FPrincipal_Load);
			this.tlpBotones.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnListaLigada;
		private System.Windows.Forms.Button btnListaDoblementeLigada;
		private System.Windows.Forms.Button btnPila;
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnCola;
		private System.Windows.Forms.Button gbArbolBinario;
		private System.Windows.Forms.Button btnSalir;
	}
}

