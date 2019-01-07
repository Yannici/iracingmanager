namespace iRacingManager.Gui.Controls
{
    partial class NewProgramControl
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialRaisedButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialRaisedButtonAdd
            // 
            this.materialRaisedButtonAdd.AutoSize = true;
            this.materialRaisedButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonAdd.Depth = 0;
            this.materialRaisedButtonAdd.Icon = global::iRacingManager.Properties.Resources.add_icon;
            this.materialRaisedButtonAdd.Location = new System.Drawing.Point(91, 50);
            this.materialRaisedButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonAdd.Name = "materialRaisedButtonAdd";
            this.materialRaisedButtonAdd.Primary = true;
            this.materialRaisedButtonAdd.Size = new System.Drawing.Size(145, 36);
            this.materialRaisedButtonAdd.TabIndex = 1;
            this.materialRaisedButtonAdd.Text = "Add program";
            this.materialRaisedButtonAdd.UseVisualStyleBackColor = true;
            this.materialRaisedButtonAdd.Click += new System.EventHandler(this.materialRaisedButtonAdd_Click);
            // 
            // NewProgramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButtonAdd);
            this.Name = "NewProgramControl";
            this.Size = new System.Drawing.Size(333, 133);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonAdd;
    }
}
