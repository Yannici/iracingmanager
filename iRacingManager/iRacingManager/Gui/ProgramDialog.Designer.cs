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
            this.materialSingleLineTextFieldIconPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelName = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialFlatButtonSelectIcon = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextFieldPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButtonSelectApp = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.materialCheckBoxStartStopiRacing = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButtonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButtonUseIconFromApp = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButtonOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBoxStartHidden = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelIcon
            // 
            this.materialLabelIcon.AutoSize = true;
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
            // materialSingleLineTextFieldIconPath
            // 
            this.materialSingleLineTextFieldIconPath.BackColor = System.Drawing.Color.White;
            this.materialSingleLineTextFieldIconPath.Depth = 0;
            this.materialSingleLineTextFieldIconPath.Enabled = false;
            this.materialSingleLineTextFieldIconPath.Hint = "";
            this.materialSingleLineTextFieldIconPath.Location = new System.Drawing.Point(60, 22);
            this.materialSingleLineTextFieldIconPath.MaxLength = 32767;
            this.materialSingleLineTextFieldIconPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldIconPath.Name = "materialSingleLineTextFieldIconPath";
            this.materialSingleLineTextFieldIconPath.PasswordChar = '\0';
            this.materialSingleLineTextFieldIconPath.SelectedText = "";
            this.materialSingleLineTextFieldIconPath.SelectionLength = 0;
            this.materialSingleLineTextFieldIconPath.SelectionStart = 0;
            this.materialSingleLineTextFieldIconPath.Size = new System.Drawing.Size(229, 23);
            this.materialSingleLineTextFieldIconPath.TabIndex = 2;
            this.materialSingleLineTextFieldIconPath.TabStop = false;
            this.materialSingleLineTextFieldIconPath.Text = "Use from application";
            this.materialSingleLineTextFieldIconPath.UseSystemPasswordChar = false;
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
            // materialFlatButtonSelectIcon
            // 
            this.materialFlatButtonSelectIcon.AutoSize = true;
            this.materialFlatButtonSelectIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonSelectIcon.Depth = 0;
            this.materialFlatButtonSelectIcon.Icon = null;
            this.materialFlatButtonSelectIcon.Location = new System.Drawing.Point(257, 14);
            this.materialFlatButtonSelectIcon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonSelectIcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonSelectIcon.Name = "materialFlatButtonSelectIcon";
            this.materialFlatButtonSelectIcon.Primary = false;
            this.materialFlatButtonSelectIcon.Size = new System.Drawing.Size(32, 36);
            this.materialFlatButtonSelectIcon.TabIndex = 5;
            this.materialFlatButtonSelectIcon.Text = "...";
            this.materialFlatButtonSelectIcon.UseVisualStyleBackColor = true;
            this.materialFlatButtonSelectIcon.Click += new System.EventHandler(this.materialFlatButtonSelectIcon_Click);
            // 
            // materialSingleLineTextFieldPath
            // 
            this.materialSingleLineTextFieldPath.Depth = 0;
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
            this.materialSingleLineTextFieldPath.Text = "Path to application ...";
            this.materialSingleLineTextFieldPath.UseSystemPasswordChar = false;
            this.materialSingleLineTextFieldPath.Validated += new System.EventHandler(this.materialSingleLineTextFieldPath_Validated);
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
            this.panelDetails.Controls.Add(this.materialCheckBoxStartStopiRacing);
            this.panelDetails.Controls.Add(this.materialFlatButtonDelete);
            this.panelDetails.Controls.Add(this.materialFlatButtonUseIconFromApp);
            this.panelDetails.Controls.Add(this.materialRaisedButtonOK);
            this.panelDetails.Controls.Add(this.materialFlatButtonCancel);
            this.panelDetails.Controls.Add(this.materialCheckBoxStartHidden);
            this.panelDetails.Controls.Add(this.materialFlatButtonSelectIcon);
            this.panelDetails.Controls.Add(this.pictureBoxIcon);
            this.panelDetails.Controls.Add(this.materialLabelIcon);
            this.panelDetails.Controls.Add(this.materialSingleLineTextFieldIconPath);
            this.panelDetails.Controls.Add(this.materialLabelName);
            this.panelDetails.Controls.Add(this.materialSingleLineTextField2);
            this.panelDetails.Location = new System.Drawing.Point(12, 107);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(289, 184);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.Visible = false;
            // 
            // materialCheckBoxStartStopiRacing
            // 
            this.materialCheckBoxStartStopiRacing.AutoSize = true;
            this.materialCheckBoxStartStopiRacing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "StartStopWithIRacing", true));
            this.materialCheckBoxStartStopiRacing.Depth = 0;
            this.materialCheckBoxStartStopiRacing.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxStartStopiRacing.Location = new System.Drawing.Point(113, 101);
            this.materialCheckBoxStartStopiRacing.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxStartStopiRacing.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxStartStopiRacing.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxStartStopiRacing.Name = "materialCheckBoxStartStopiRacing";
            this.materialCheckBoxStartStopiRacing.Ripple = true;
            this.materialCheckBoxStartStopiRacing.Size = new System.Drawing.Size(172, 30);
            this.materialCheckBoxStartStopiRacing.TabIndex = 12;
            this.materialCheckBoxStartStopiRacing.Text = "Start/Stop with iRacing";
            this.materialCheckBoxStartStopiRacing.UseVisualStyleBackColor = true;
            // 
            // materialFlatButtonDelete
            // 
            this.materialFlatButtonDelete.AutoSize = true;
            this.materialFlatButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonDelete.Depth = 0;
            this.materialFlatButtonDelete.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButtonDelete.Icon")));
            this.materialFlatButtonDelete.Location = new System.Drawing.Point(188, 142);
            this.materialFlatButtonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonDelete.Name = "materialFlatButtonDelete";
            this.materialFlatButtonDelete.Primary = false;
            this.materialFlatButtonDelete.Size = new System.Drawing.Size(97, 36);
            this.materialFlatButtonDelete.TabIndex = 11;
            this.materialFlatButtonDelete.Text = "Delete";
            this.materialFlatButtonDelete.UseVisualStyleBackColor = true;
            this.materialFlatButtonDelete.Visible = false;
            this.materialFlatButtonDelete.Click += new System.EventHandler(this.materialFlatButtonDelete_Click);
            // 
            // materialFlatButtonUseIconFromApp
            // 
            this.materialFlatButtonUseIconFromApp.AutoSize = true;
            this.materialFlatButtonUseIconFromApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonUseIconFromApp.Depth = 0;
            this.materialFlatButtonUseIconFromApp.Icon = global::iRacingManager.Properties.Resources.cancel;
            this.materialFlatButtonUseIconFromApp.Location = new System.Drawing.Point(214, 14);
            this.materialFlatButtonUseIconFromApp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonUseIconFromApp.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonUseIconFromApp.Name = "materialFlatButtonUseIconFromApp";
            this.materialFlatButtonUseIconFromApp.Primary = false;
            this.materialFlatButtonUseIconFromApp.Size = new System.Drawing.Size(44, 36);
            this.materialFlatButtonUseIconFromApp.TabIndex = 10;
            this.materialFlatButtonUseIconFromApp.UseVisualStyleBackColor = true;
            this.materialFlatButtonUseIconFromApp.Click += new System.EventHandler(this.materialFlatButtonUseIconFromApp_Click);
            // 
            // materialRaisedButtonOK
            // 
            this.materialRaisedButtonOK.AutoSize = true;
            this.materialRaisedButtonOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonOK.Depth = 0;
            this.materialRaisedButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialRaisedButtonOK.Icon = null;
            this.materialRaisedButtonOK.Location = new System.Drawing.Point(5, 142);
            this.materialRaisedButtonOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonOK.Name = "materialRaisedButtonOK";
            this.materialRaisedButtonOK.Primary = true;
            this.materialRaisedButtonOK.Size = new System.Drawing.Size(55, 36);
            this.materialRaisedButtonOK.TabIndex = 9;
            this.materialRaisedButtonOK.Text = "Save";
            this.materialRaisedButtonOK.UseVisualStyleBackColor = true;
            // 
            // materialFlatButtonCancel
            // 
            this.materialFlatButtonCancel.AutoSize = true;
            this.materialFlatButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonCancel.Depth = 0;
            this.materialFlatButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialFlatButtonCancel.Icon = null;
            this.materialFlatButtonCancel.Location = new System.Drawing.Point(67, 142);
            this.materialFlatButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonCancel.Name = "materialFlatButtonCancel";
            this.materialFlatButtonCancel.Primary = false;
            this.materialFlatButtonCancel.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButtonCancel.TabIndex = 8;
            this.materialFlatButtonCancel.Text = "Cancel";
            this.materialFlatButtonCancel.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxStartHidden
            // 
            this.materialCheckBoxStartHidden.AutoSize = true;
            this.materialCheckBoxStartHidden.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "StartHidden", true));
            this.materialCheckBoxStartHidden.Depth = 0;
            this.materialCheckBoxStartHidden.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxStartHidden.Location = new System.Drawing.Point(-3, 101);
            this.materialCheckBoxStartHidden.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxStartHidden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxStartHidden.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxStartHidden.Name = "materialCheckBoxStartHidden";
            this.materialCheckBoxStartHidden.Ripple = true;
            this.materialCheckBoxStartHidden.Size = new System.Drawing.Size(105, 30);
            this.materialCheckBoxStartHidden.TabIndex = 6;
            this.materialCheckBoxStartHidden.Text = "Start hidden";
            this.materialCheckBoxStartHidden.UseVisualStyleBackColor = true;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::iRacingManager.Properties.Resources.shape_cube;
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // ProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialFlatButtonCancel;
            this.ClientSize = new System.Drawing.Size(313, 303);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.materialFlatButtonSelectApp);
            this.Controls.Add(this.materialSingleLineTextFieldPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramDialog";
            this.Text = "Add program";
            this.Load += new System.EventHandler(this.ProgramDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private MaterialSkin.Controls.MaterialLabel materialLabelIcon;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldIconPath;
        private MaterialSkin.Controls.MaterialLabel materialLabelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonSelectIcon;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldPath;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonSelectApp;
        private System.Windows.Forms.Panel panelDetails;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxStartHidden;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonOK;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonCancel;
        private System.Windows.Forms.BindingSource programBindingSource;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonUseIconFromApp;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonDelete;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxStartStopiRacing;
    }
}