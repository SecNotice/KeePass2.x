﻿namespace KeePass.Forms
{
	partial class TanWizardForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanWizardForm));
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_lblIntro = new System.Windows.Forms.Label();
			this.m_tbTANs = new System.Windows.Forms.TextBox();
			this.m_cbNumberTANs = new System.Windows.Forms.CheckBox();
			this.m_lblSeparator = new System.Windows.Forms.Label();
			this.m_numTANsIndex = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numTANsIndex)).BeginInit();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			resources.ApplyResources(this.m_btnOK, "m_btnOK");
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.m_btnCancel, "m_btnCancel");
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_bannerImage
			// 
			resources.ApplyResources(this.m_bannerImage, "m_bannerImage");
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.TabStop = false;
			// 
			// m_lblIntro
			// 
			resources.ApplyResources(this.m_lblIntro, "m_lblIntro");
			this.m_lblIntro.Name = "m_lblIntro";
			// 
			// m_tbTANs
			// 
			this.m_tbTANs.AcceptsReturn = true;
			this.m_tbTANs.AcceptsTab = true;
			resources.ApplyResources(this.m_tbTANs, "m_tbTANs");
			this.m_tbTANs.Name = "m_tbTANs";
			// 
			// m_cbNumberTANs
			// 
			resources.ApplyResources(this.m_cbNumberTANs, "m_cbNumberTANs");
			this.m_cbNumberTANs.Name = "m_cbNumberTANs";
			this.m_cbNumberTANs.UseVisualStyleBackColor = true;
			this.m_cbNumberTANs.CheckedChanged += new System.EventHandler(this.OnNumberTANsCheckedChanged);
			// 
			// m_lblSeparator
			// 
			this.m_lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.m_lblSeparator, "m_lblSeparator");
			this.m_lblSeparator.Name = "m_lblSeparator";
			// 
			// m_numTANsIndex
			// 
			resources.ApplyResources(this.m_numTANsIndex, "m_numTANsIndex");
			this.m_numTANsIndex.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.m_numTANsIndex.Name = "m_numTANsIndex";
			// 
			// TanWizardForm
			// 
			this.AcceptButton = this.m_btnOK;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.Controls.Add(this.m_numTANsIndex);
			this.Controls.Add(this.m_lblSeparator);
			this.Controls.Add(this.m_cbNumberTANs);
			this.Controls.Add(this.m_tbTANs);
			this.Controls.Add(this.m_lblIntro);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TanWizardForm";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.OnFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.m_numTANsIndex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Label m_lblIntro;
		private System.Windows.Forms.TextBox m_tbTANs;
		private System.Windows.Forms.CheckBox m_cbNumberTANs;
		private System.Windows.Forms.Label m_lblSeparator;
		private System.Windows.Forms.NumericUpDown m_numTANsIndex;
	}
}