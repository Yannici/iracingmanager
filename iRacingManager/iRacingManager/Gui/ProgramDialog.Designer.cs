namespace iRacingManager.Gui
{
    partial class ProgramDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramDialog));
            this.materialLabelIcon = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextFieldPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButtonSelectApp = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelIcon
            // 
            this.materialLabelIcon.AutoSize = true;
            this.materialLabelIcon.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabelIcon.Depth = 0;
            this.materialLabelIcon.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelIcon.Location = new System.Drawing.Point(56, 0);
            this.materialLabelIcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelIcon.Name = "materialLabelIcon";
            this.materialLabelIcon.Size = new System.Drawing.Size(38, 19);
            this.materialLabelIcon.TabIndex = 1;
            this.materialLabelIcon.Text = "Icon";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Enabled = false;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(60, 22);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(229, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "Use from application";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.programBindingSource, "Icon", true));
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // materialLabelName
            // 
            this.materialLabelName.AutoSize = true;
            this.materialLabelName.Depth = 0;
            this.materialLabelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelName.Location = new System.Drawing.Point(1, 53);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(49, 19);
            this.materialLabelName.TabIndex = 3;
            this.materialLabelName.Text = "Name";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programBindingSource, "DisplayName", true));
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(5, 75);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(285, 23);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(257, 14);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "...";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextFieldPath
            // 
            this.materialSingleLineTextFieldPath.Depth = 0;
            this.materialSingleLineTextFieldPath.Enabled = false;
            this.materialSingleLineTextFieldPath.Hint = "";
            this.materialSingleLineTextFieldPath.Location = new System.Drawing.Point(12, 78);
            this.materialSingleLineTextFieldPath.MaxLength = 32767;
            this.materialSingleLineTextFieldPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldPath.Name = "materialSingleLineTextFieldPath";
            this.materialSingleLineTextFieldPath.PasswordChar = '\0';
            this.materialSingleLineTextFieldPath.SelectedText = "";
            this.materialSingleLineTextFieldPath.SelectionLength = 0;
            this.materialSingleLineTextFieldPath.SelectionStart = 0;
            this.materialSingleLineTextFieldPath.Size = new System.Drawing.Size(289, 23);
            this.materialSingleLineTextFieldPath.TabIndex = 6;
            this.materialSingleLineTextFieldPath.TabStop = false;
            this.materialSingleLineTextFieldPath.Text = "Select application ...";
            this.materialSingleLineTextFieldPath.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldPath.Click += new System.EventHandler(this.materialSingleLineTextFieldPath_Click);
            // 
            // materialFlatButtonSelectApp
            // 
            this.materialFlatButtonSelectApp.AutoSize = true;
            this.materialFlatButtonSelectApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonSelectApp.Depth = 0;
            this.materialFlatButtonSelectApp.Icon = null;
            this.materialFlatButtonSelectApp.Location = new System.Drawing.Point(269, 72);
            this.materialFlatButtonSelectApp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonSelectApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonSelectApp.Name = "materialFlatButtonSelectApp";
            this.materialFlatButtonSelectApp.Primary = false;
            this.materialFlatButtonSelectApp.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButtonSelectApp.TabIndex = 7;
            this.materialFlatButtonSelectApp.Text = "...";
            this.materialFlatButtonSelectApp.UseVisualStyleBackColor = true;
            this.materialFlatButtonSelectApp.Click += new System.EventHandler(this.materialFlatButtonSelectApp_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Controls.Add(this.materialFlatButton1);
            this.panelDetails.Controls.Add(this.pictureBoxIcon);
            this.panelDetails.Controls.Add(this.materialLabelIcon);
            this.panelDetails.Controls.Add(this.materialSingleLineTextField1);
            this.panelDetails.Controls.Add(this.materialLabelName);
            this.panelDetails.Controls.Add(this.materialSingleLineTextField2);
            this.panelDetails.Location = new System.Drawing.Point(12, 107);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(289, 230);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.Visible = false;
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(iRacingManager.Model.Program);
            // 
            // ProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 349);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.materialFlatButtonSelectApp);
            this.Controls.Add(this.materialSingleLineTextFieldPath);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 349);
            this.Name = "ProgramDialog";
            this.Text = "Add program";
            this.Load += new System.EventHandler(this.ProgramDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private MaterialSkin.Controls.MaterialLabel materialLabelIcon;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPath;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonSelectApp;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}