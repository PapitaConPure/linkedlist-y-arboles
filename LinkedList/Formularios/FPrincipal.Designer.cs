
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
			this.btnListaLigada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnListaLigada.Location = new System.Drawing.Point(4, 5);
			this.btnListaLigada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListaLigada.Name = "btnListaLigada";
			this.btnListaLigada.Size = new System.Drawing.Size(364, 60);
			this.btnListaLigada.TabIndex = 0;
			this.btnListaLigada.Text = "Lista Ligada";
			this.btnListaLigada.UseVisualStyleBackColor = true;
			this.btnListaLigada.Click += new System.EventHandler(this.BtnListaLigada_Click);
			// 
			// btnListaDoblementeLigada
			// 
			this.btnListaDoblementeLigada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnListaDoblementeLigada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnListaDoblementeLigada.Location = new System.Drawing.Point(4, 75);
			this.btnListaDoblementeLigada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnListaDoblementeLigada.Name = "btnListaDoblementeLigada";
			this.btnListaDoblementeLigada.Size = new System.Drawing.Size(364, 60);
			this.btnListaDoblementeLigada.TabIndex = 1;
			this.btnListaDoblementeLigada.Text = "Lista Doblemente Ligada";
			this.btnListaDoblementeLigada.UseVisualStyleBackColor = true;
			this.btnListaDoblementeLigada.Click += new System.EventHandler(this.BtnListaDoblementeLigada_Click);
			// 
			// btnPila
			// 
			this.btnPila.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPila.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnPila.Location = new System.Drawing.Point(4, 160);
			this.btnPila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPila.Name = "btnPila";
			this.btnPila.Size = new System.Drawing.Size(364, 60);
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
			// btnCola
			// 
			this.btnCola.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCola.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.btnCola.Location = new System.Drawing.Point(4, 230);
			this.btnCola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCola.Name = "btnCola";
			this.btnCola.Size = new System.Drawing.Size(364, 60);
			this.btnCola.TabIndex = 3;
			this.btnCola.Text = "Cola";
			this.btnCola.UseVisualStyleBackColor = true;
			this.btnCola.Click += new System.EventHandler(this.BtnCola_Click);
			// 
			// gbArbolBinario
			// 
			this.gbArbolBinario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbArbolBinario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
			this.gbArbolBinario.Location = new System.Drawing.Point(4, 315);
			this.gbArbolBinario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gbArbolBinario.Name = "gbArbolBinario";
			this.gbArbolBinario.Size = new System.Drawing.Size(364, 60);
			this.gbArbolBinario.TabIndex = 4;
			this.gbArbolBinario.Text = "Arbol Binario";
			this.gbArbolBinario.UseVisualStyleBackColor = true;
			this.gbArbolBinario.Click += new System.EventHandler(this.GbArbolBinario_Click);
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

