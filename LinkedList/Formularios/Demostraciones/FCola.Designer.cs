
namespace LinkedList {
	partial class FCola {
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
			this.btnEncolar = new System.Windows.Forms.Button();
			this.btnRevisar = new System.Windows.Forms.Button();
			this.btnDesencolar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnContiene = new System.Windows.Forms.Button();
			this.gbElementos = new System.Windows.Forms.GroupBox();
			this.lsbElementos = new System.Windows.Forms.ListBox();
			this.tlpBotones.SuspendLayout();
			this.gbElementos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpBotones
			// 
			this.tlpBotones.ColumnCount = 1;
			this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpBotones.Controls.Add(this.btnEncolar, 0, 0);
			this.tlpBotones.Controls.Add(this.btnRevisar, 0, 2);
			this.tlpBotones.Controls.Add(this.btnDesencolar, 0, 1);
			this.tlpBotones.Controls.Add(this.btnLimpiar, 0, 3);
			this.tlpBotones.Controls.Add(this.btnContiene, 0, 4);
			this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Left;
			this.tlpBotones.Location = new System.Drawing.Point(12, 12);
			this.tlpBotones.Name = "tlpBotones";
			this.tlpBotones.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.tlpBotones.RowCount = 5;
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00133F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99933F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99933F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpBotones.Size = new System.Drawing.Size(157, 257);
			this.tlpBotones.TabIndex = 0;
			// 
			// btnEncolar
			// 
			this.btnEncolar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEncolar.Location = new System.Drawing.Point(3, 3);
			this.btnEncolar.Name = "btnEncolar";
			this.btnEncolar.Size = new System.Drawing.Size(148, 45);
			this.btnEncolar.TabIndex = 0;
			this.btnEncolar.Text = "Encolar (...)";
			this.btnEncolar.UseVisualStyleBackColor = true;
			this.btnEncolar.Click += new System.EventHandler(this.BtnEncolar_Click);
			// 
			// btnRevisar
			// 
			this.btnRevisar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRevisar.Location = new System.Drawing.Point(3, 105);
			this.btnRevisar.Name = "btnRevisar";
			this.btnRevisar.Size = new System.Drawing.Size(148, 45);
			this.btnRevisar.TabIndex = 2;
			this.btnRevisar.Text = "Revisar (#)";
			this.btnRevisar.UseVisualStyleBackColor = true;
			this.btnRevisar.Click += new System.EventHandler(this.BtnRevisar_Click);
			// 
			// btnDesencolar
			// 
			this.btnDesencolar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDesencolar.Location = new System.Drawing.Point(3, 54);
			this.btnDesencolar.Name = "btnDesencolar";
			this.btnDesencolar.Size = new System.Drawing.Size(148, 45);
			this.btnDesencolar.TabIndex = 1;
			this.btnDesencolar.Text = "Desencolar (#)";
			this.btnDesencolar.UseVisualStyleBackColor = true;
			this.btnDesencolar.Click += new System.EventHandler(this.BtnDesencolar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnLimpiar.Location = new System.Drawing.Point(3, 156);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(148, 45);
			this.btnLimpiar.TabIndex = 3;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// btnContiene
			// 
			this.btnContiene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnContiene.Location = new System.Drawing.Point(3, 207);
			this.btnContiene.Name = "btnContiene";
			this.btnContiene.Size = new System.Drawing.Size(148, 47);
			this.btnContiene.TabIndex = 4;
			this.btnContiene.Text = "¿Contiene elemento? (...)";
			this.btnContiene.UseVisualStyleBackColor = true;
			this.btnContiene.Click += new System.EventHandler(this.BtnContiene_Click);
			// 
			// gbElementos
			// 
			this.gbElementos.Controls.Add(this.lsbElementos);
			this.gbElementos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbElementos.Location = new System.Drawing.Point(169, 12);
			this.gbElementos.Name = "gbElementos";
			this.gbElementos.Size = new System.Drawing.Size(323, 257);
			this.gbElementos.TabIndex = 1;
			this.gbElementos.TabStop = false;
			this.gbElementos.Text = "Los botones con (#) usan el primer elemento";
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
			this.lsbElementos.Size = new System.Drawing.Size(317, 238);
			this.lsbElementos.TabIndex = 0;
			this.lsbElementos.TabStop = false;
			// 
			// FCola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 281);
			this.Controls.Add(this.gbElementos);
			this.Controls.Add(this.tlpBotones);
			this.MinimumSize = new System.Drawing.Size(442, 240);
			this.Name = "FCola";
			this.Padding = new System.Windows.Forms.Padding(12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Demostración de Cola con Lista Ligada";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCola_FormClosed);
			this.tlpBotones.ResumeLayout(false);
			this.gbElementos.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpBotones;
		private System.Windows.Forms.Button btnEncolar;
		private System.Windows.Forms.Button btnRevisar;
		private System.Windows.Forms.Button btnDesencolar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnContiene;
		private System.Windows.Forms.GroupBox gbElementos;
		private System.Windows.Forms.ListBox lsbElementos;
	}
}