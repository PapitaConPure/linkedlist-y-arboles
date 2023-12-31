﻿
namespace LinkedList {
	partial class FElemento {
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
			this.lblValor = new System.Windows.Forms.Label();
			this.tbElemento = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.pnlBotones.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblValor
			// 
			this.lblValor.AutoSize = true;
			this.lblValor.Location = new System.Drawing.Point(12, 15);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(51, 13);
			this.lblValor.TabIndex = 10;
			this.lblValor.Text = "Elemento";
			// 
			// tbElemento
			// 
			this.tbElemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbElemento.Location = new System.Drawing.Point(69, 12);
			this.tbElemento.Name = "tbElemento";
			this.tbElemento.Size = new System.Drawing.Size(223, 20);
			this.tbElemento.TabIndex = 0;
			this.tbElemento.Click += new System.EventHandler(this.TbElemento_EnterOrFocus);
			this.tbElemento.Enter += new System.EventHandler(this.TbElemento_EnterOrFocus);
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
			// pnlBotones
			// 
			this.pnlBotones.Controls.Add(this.btnAceptar);
			this.pnlBotones.Controls.Add(this.btnCancelar);
			this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotones.Location = new System.Drawing.Point(0, 38);
			this.pnlBotones.Name = "pnlBotones";
			this.pnlBotones.Padding = new System.Windows.Forms.Padding(10, 2, 10, 10);
			this.pnlBotones.Size = new System.Drawing.Size(304, 41);
			this.pnlBotones.TabIndex = 1;
			// 
			// FElemento
			// 
			this.AcceptButton = this.btnAceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(304, 79);
			this.ControlBox = false;
			this.Controls.Add(this.pnlBotones);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.tbElemento);
			this.MaximumSize = new System.Drawing.Size(960, 118);
			this.MinimumSize = new System.Drawing.Size(196, 118);
			this.Name = "FElemento";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Indica un elemento...";
			this.Activated += new System.EventHandler(this.FElemento_Activated);
			this.pnlBotones.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblValor;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.TextBox tbElemento;
		private System.Windows.Forms.Panel pnlBotones;
	}
}