
namespace LinkedList {
	partial class FListaLigada {
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
			this.btnAgregarPrimero = new System.Windows.Forms.Button();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.btnQuitarEn = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnÍndiceDe = new System.Windows.Forms.Button();
			this.lsbElementos = new System.Windows.Forms.ListBox();
			this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
			this.btnContiene = new System.Windows.Forms.Button();
			this.btnValorEn = new System.Windows.Forms.Button();
			this.btnAgregarÚltimo = new System.Windows.Forms.Button();
			this.btnQuitarPrimero = new System.Windows.Forms.Button();
			this.btnQuitarÚltimo = new System.Windows.Forms.Button();
			this.gbElementos = new System.Windows.Forms.GroupBox();
			this.tlpBotones.SuspendLayout();
			this.gbElementos.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarPrimero
			// 
			this.btnAgregarPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarPrimero.Location = new System.Drawing.Point(3, 3);
			this.btnAgregarPrimero.Name = "btnAgregarPrimero";
			this.btnAgregarPrimero.Size = new System.Drawing.Size(148, 36);
			this.btnAgregarPrimero.TabIndex = 0;
			this.btnAgregarPrimero.Text = "Agregar primero (...)";
			this.btnAgregarPrimero.UseVisualStyleBackColor = true;
			this.btnAgregarPrimero.Click += new System.EventHandler(this.BtnAgregarPrimero_Click);
			// 
			// btnInsertar
			// 
			this.btnInsertar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInsertar.Location = new System.Drawing.Point(3, 87);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(148, 36);
			this.btnInsertar.TabIndex = 2;
			this.btnInsertar.Text = "Insertar (...) (→)";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitar.Location = new System.Drawing.Point(3, 213);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(148, 36);
			this.btnQuitar.TabIndex = 5;
			this.btnQuitar.Text = "Quitar valor (...)";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
			// 
			// btnQuitarEn
			// 
			this.btnQuitarEn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitarEn.Location = new System.Drawing.Point(3, 255);
			this.btnQuitarEn.Name = "btnQuitarEn";
			this.btnQuitarEn.Size = new System.Drawing.Size(148, 36);
			this.btnQuitarEn.TabIndex = 6;
			this.btnQuitarEn.Text = "Quitar en (→)";
			this.btnQuitarEn.UseVisualStyleBackColor = true;
			this.btnQuitarEn.Click += new System.EventHandler(this.BtnQuitarEn_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiar.Location = new System.Drawing.Point(3, 297);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(148, 36);
			this.btnLimpiar.TabIndex = 7;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnÍndiceDe
			// 
			this.btnÍndiceDe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnÍndiceDe.Location = new System.Drawing.Point(3, 339);
			this.btnÍndiceDe.Name = "btnÍndiceDe";
			this.btnÍndiceDe.Size = new System.Drawing.Size(148, 36);
			this.btnÍndiceDe.TabIndex = 8;
			this.btnÍndiceDe.Text = "Índice de (...)";
			this.btnÍndiceDe.UseVisualStyleBackColor = true;
			this.btnÍndiceDe.Click += new System.EventHandler(this.BtnÍndiceDe_Click);
			// 
			// lsbElementos
			// 
			this.lsbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsbElementos.FormattingEnabled = true;
			this.lsbElementos.IntegralHeight = false;
			this.lsbElementos.Location = new System.Drawing.Point(3, 16);
			this.lsbElementos.Name = "lsbElementos";
			this.lsbElementos.ScrollAlwaysVisible = true;
			this.lsbElementos.Size = new System.Drawing.Size(317, 452);
			this.lsbElementos.TabIndex = 1;
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnContiene, 0, 10);
			this.tlpBotones.Controls.Add(this.btnAgregarPrimero, 0, 0);
			this.tlpBotones.Controls.Add(this.btnInsertar, 0, 2);
			this.tlpBotones.Controls.Add(this.btnÍndiceDe, 0, 8);
			this.tlpBotones.Controls.Add(this.btnQuitar, 0, 5);
			this.tlpBotones.Controls.Add(this.btnLimpiar, 0, 7);
			this.tlpBotones.Controls.Add(this.btnQuitarEn, 0, 6);
			this.tlpBotones.Controls.Add(this.btnValorEn, 0, 9);
			this.tlpBotones.Controls.Add(this.btnAgregarÚltimo, 0, 1);
			this.tlpBotones.Controls.Add(this.btnQuitarPrimero, 0, 3);
			this.tlpBotones.Controls.Add(this.btnQuitarÚltimo, 0, 4);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpBotones.Location = new System.Drawing.Point(12, 12);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.tlpBotones.RowCount = 11;
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
			this.tlpBotones.Size = new System.Drawing.Size(157, 471);
			this.tlpBotones.TabIndex = 0;
			// 
			// btnContiene
			// 
			this.btnContiene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContiene.Location = new System.Drawing.Point(3, 423);
			this.btnContiene.Name = "btnContiene";
			this.btnContiene.Size = new System.Drawing.Size(148, 45);
			this.btnContiene.TabIndex = 10;
			this.btnContiene.Text = "¿Contiene elemento? (...)";
			this.btnContiene.UseVisualStyleBackColor = true;
			this.btnContiene.Click += new System.EventHandler(this.BtnContiene_Click);
			// 
			// btnValorEn
			// 
			this.btnValorEn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnValorEn.Location = new System.Drawing.Point(3, 381);
			this.btnValorEn.Name = "btnValorEn";
			this.btnValorEn.Size = new System.Drawing.Size(148, 36);
			this.btnValorEn.TabIndex = 9;
			this.btnValorEn.Text = "Valor en (→)";
			this.btnValorEn.UseVisualStyleBackColor = true;
			this.btnValorEn.Click += new System.EventHandler(this.BtnValorEn_Click);
			// 
			// btnAgregarÚltimo
			// 
			this.btnAgregarÚltimo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAgregarÚltimo.Location = new System.Drawing.Point(3, 45);
			this.btnAgregarÚltimo.Name = "btnAgregarÚltimo";
			this.btnAgregarÚltimo.Size = new System.Drawing.Size(148, 36);
			this.btnAgregarÚltimo.TabIndex = 1;
			this.btnAgregarÚltimo.Text = "Agregar último (...)";
			this.btnAgregarÚltimo.UseVisualStyleBackColor = true;
			this.btnAgregarÚltimo.Click += new System.EventHandler(this.BtnAgregarÚltimo_Click);
			// 
			// btnQuitarPrimero
			// 
			this.btnQuitarPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitarPrimero.Location = new System.Drawing.Point(3, 129);
			this.btnQuitarPrimero.Name = "btnQuitarPrimero";
			this.btnQuitarPrimero.Size = new System.Drawing.Size(148, 36);
			this.btnQuitarPrimero.TabIndex = 3;
			this.btnQuitarPrimero.Text = "Quitar Primero";
			this.btnQuitarPrimero.UseVisualStyleBackColor = true;
			this.btnQuitarPrimero.Click += new System.EventHandler(this.BtnQuitarPrimero_Click);
			// 
			// btnQuitarÚltimo
			// 
			this.btnQuitarÚltimo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuitarÚltimo.Location = new System.Drawing.Point(3, 171);
			this.btnQuitarÚltimo.Name = "btnQuitarÚltimo";
			this.btnQuitarÚltimo.Size = new System.Drawing.Size(148, 36);
			this.btnQuitarÚltimo.TabIndex = 4;
			this.btnQuitarÚltimo.Text = "Quitar Último";
			this.btnQuitarÚltimo.UseVisualStyleBackColor = true;
			this.btnQuitarÚltimo.Click += new System.EventHandler(this.BtnQuitarÚltimo_Click);
			// 
			// gbElementos
			// 
			this.gbElementos.Controls.Add(this.lsbElementos);
			this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbElementos.Location = new System.Drawing.Point(169, 12);
			this.gbElementos.Name = "gbElementos";
			this.gbElementos.Size = new System.Drawing.Size(323, 471);
			this.gbElementos.TabIndex = 2;
			this.gbElementos.TabStop = false;
			this.gbElementos.Text = "Los botones con (→) requieren seleccionar aquí";
			// 
			// FListaLigada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 495);
			this.Controls.Add(this.gbElementos);
			this.Controls.Add(this.tlpBotones);
			this.MinimumSize = new System.Drawing.Size(442, 534);
			this.Name = "FListaLigada";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Demostración de Lista Ligada";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FListaLigada_FormClosed);
			this.tlpBotones.ResumeLayout(false);
			this.gbElementos.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAgregarPrimero;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnQuitarEn;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnÍndiceDe;
		private System.Windows.Forms.ListBox lsbElementos;
		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnValorEn;
		private System.Windows.Forms.Button btnContiene;
		private System.Windows.Forms.Button btnAgregarÚltimo;
		private System.Windows.Forms.Button btnQuitarPrimero;
		private System.Windows.Forms.Button btnQuitarÚltimo;
		private System.Windows.Forms.GroupBox gbElementos;
	}
}