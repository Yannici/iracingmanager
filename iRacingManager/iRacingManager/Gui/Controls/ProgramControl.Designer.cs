namespace iRacingManager.Gui.Controls
{
    partial class ProgramControl
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
            this.components = new System.ComponentModel.Container();
            this.materialSLTPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButtonSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.materialFlatButtonModify = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialSLTPath
            // 
            this.materialSLTPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSLTPath.Depth = 0;
            this.materialSLTPath.Enabled = false;
            this.materialSLTPath.Hint = "";
            this.materialSLTPath.Location = new System.Drawing.Point(64, 42);
            this.materialSLTPath.MaxLength = 32767;
            this.materialSLTPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSLTPath.Name = "materialSLTPath";
            this.materialSLTPath.PasswordChar = '\0';
            this.materialSLTPath.SelectedText = "";
            this.materialSLTPath.SelectionLength = 0;
            this.materialSLTPath.SelectionStart = 0;
            this.materialSLTPath.Size = new System.Drawing.Size(263, 23);
            this.materialSLTPath.TabIndex = 4;
            this.materialSLTPath.TabStop = false;
            this.materialSLTPath.Text = "PATH";
            this.materialSLTPath.UseSystemPasswordChar = false;
            // 
            // materialLabelName
            // 
            this.materialLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabelName.AutoSize = true;
            this.materialLabelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programBindingSource, "DisplayName", true));
            this.materialLabelName.Depth = 0;
            this.materialLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelName.Location = new System.Drawing.Point(60, 20);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(51, 18);
            this.materialLabelName.TabIndex = 3;
            this.materialLabelName.Text = "NAME";
            // 
            // materialFlatButtonSearch
            // 
            this.materialFlatButtonSearch.AutoSize = true;
            this.materialFlatButtonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonSearch.Depth = 0;
            this.materialFlatButtonSearch.Icon = null;
            this.materialFlatButtonSearch.Location = new System.Drawing.Point(295, 29);
            this.materialFlatButtonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonSearch.Name = "materialFlatButtonSearch";
            this.materialFlatButtonSearch.Primary = false;
            this.materialFlatButtonSearch.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButtonSearch.TabIndex = 6;
            this.materialFlatButtonSearch.Text = "...";
            this.materialFlatButtonSearch.UseVisualStyleBackColor = true;
            this.materialFlatButtonSearch.Click += new System.EventHandler(this.materialFlatButtonSearch_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(5, 71);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(271, 31);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseCompatibleTextRendering = true;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseEnter += new System.EventHandler(this.buttonStart_MouseEnter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave);
            // 
            // materialFlatButtonModify
            // 
            this.materialFlatButtonModify.AutoSize = true;
            this.materialFlatButtonModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonModify.Depth = 0;
            this.materialFlatButtonModify.Icon = global::iRacingManager.Properties.Resources.streamline;
            this.materialFlatButtonModify.Location = new System.Drawing.Point(283, 70);
            this.materialFlatButtonModify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonModify.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonModify.Name = "materialFlatButtonModify";
            this.materialFlatButtonModify.Primary = false;
            this.materialFlatButtonModify.Size = new System.Drawing.Size(44, 36);
            this.materialFlatButtonModify.TabIndex = 8;
            this.materialFlatButtonModify.UseVisualStyleBackColor = true;
            this.materialFlatButtonModify.Click += new System.EventHandler(this.materialFlatButtonModify_Click);
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPicture.Location = new System.Drawing.Point(5, 16);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPicture.TabIndex = 5;
            this.pictureBoxPicture.TabStop = false;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(iRacingManager.Model.Program);
            // 
            // ProgramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButtonModify);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.materialFlatButtonSearch);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.materialSLTPath);
            this.Controls.Add(this.materialLabelName);
            this.Name = "ProgramControl";
            this.Size = new System.Drawing.Size(333, 117);
            this.Load += new System.EventHandler(this.ProgramControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPicture;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSLTPath;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonSearch;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button buttonStart;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonModify;
    }
}
