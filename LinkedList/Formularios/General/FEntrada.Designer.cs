
namespace LinkedList {
	partial class FEntrada {
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
			this.lblClave = new System.Windows.Forms.Label();
			this.tbClave = new System.Windows.Forms.TextBox();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblValor = new System.Windows.Forms.Label();
			this.nudValor = new System.Windows.Forms.NumericUpDown();
			this.pnlBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
			this.SuspendLayout();
			// 
			// lblClave
			// 
			this.lblClave.AutoSize = true;
			this.lblClave.Location = new System.Drawing.Point(12, 15);
			this.lblClave.Name = "lblClave";
			this.lblClave.Size = new System.Drawing.Size(34, 13);
			this.lblClave.TabIndex = 0;
			this.lblClave.Text = "Clave";
			// 
			// tbClave
			// 
			this.tbClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbClave.Location = new System.Drawing.Point(52, 12);
			this.tbClave.Name = "tbClave";
			this.tbClave.Size = new System.Drawing.Size(240, 20);
			this.tbClave.TabIndex = 0;
			this.tbClave.Click += new System.EventHandler(this.TbClave_EnterOrFocus);
			this.tbClave.Enter += new System.EventHandler(this.TbClave_EnterOrFocus);
			// 
			// pnlBotones
			// 
			this.pnlBotones.Controls.Add(this.btnAceptar);
			this.pnlBotones.Controls.Add(this.btnCancelar);
			this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotones.Location = new System.Drawing.Point(0, 64);
			this.pnlBotones.Name = "pnlBotones";
			this.pnlBotones.Padding = new System.Windows.Forms.Padding(10, 2, 10, 10);
			this.pnlBotones.Size = new System.Drawing.Size(304, 41);
			this.pnlBotones.TabIndex = 2;
			// 
			// btnAceptar
			// 
			this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAceptar.Location = new System.Drawing.Point(144, 2);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 29);
			this.btnAceptar.TabIndex = 0;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancelar.Location = new System.Drawing.Point(219, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 29);
			this.btnCancelar.TabIndex = 1;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(12, 41);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(31, 13);
			this.lblValor.TabIndex = 0;
			this.lblValor.Text = "Valor";
			// 
			// nudValor
			// 
			this.nudValor.DecimalPlaces = 2;
			this.nudValor.Location = new System.Drawing.Point(52, 38);
			this.nudValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.nudValor.Name = "nudValor";
			this.nudValor.Size = new System.Drawing.Size(240, 20);
			this.nudValor.TabIndex = 1;
			this.nudValor.ThousandsSeparator = true;
			this.nudValor.Click += new System.EventHandler(this.NudValor_EnterOrFocus);
			this.nudValor.Enter += new System.EventHandler(this.NudValor_EnterOrFocus);
			// 
			// FEntrada
			// 
			this.AcceptButton = this.btnAceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(304, 105);
			this.ControlBox = false;
			this.Controls.Add(this.nudValor);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.pnlBotones);
			this.Controls.Add(this.lblClave);
			this.Controls.Add(this.tbClave);
			this.MaximumSize = new System.Drawing.Size(960, 144);
			this.MinimumSize = new System.Drawing.Size(196, 144);
			this.Name = "FEntrada";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Indica un elemento...";
			this.Activated += new System.EventHandler(this.FEntrada_Activated);
			this.pnlBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblClave;
		public System.Windows.Forms.TextBox tbClave;
		private System.Windows.Forms.Panel pnlBotones;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblValor;
		public System.Windows.Forms.NumericUpDown nudValor;
	}
}