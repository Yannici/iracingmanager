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
            this.materialFlatButtonSelectIcon = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialSingleLineTextFieldPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButtonSelectApp = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.materialLabelDelayStopSeconds = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldDelayStop = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBoxDelayStop = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabelDelaySeconds = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextFieldDelay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialCheckBoxDelayStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabelWithiRacing = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckBoxStopWithiRacing = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialSingleLineTextFieldArguments = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabelArguments = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckBoxStartWithiRacing = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButtonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButtonUseIconFromApp = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialRaisedButtonOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBoxStartHidden = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabelIcon
            // 
            this.materialLabelIcon.AutoSize = true;
            this.materialLabelIcon.Depth = 0;
            this.materialLabelIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelIcon.Location = new System.Drawing.Point(56, 0);
            this.materialLabelIcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelIcon.Name = "materialLabelIcon";
            this.materialLabelIcon.Size = new System.Drawing.Size(36, 18);
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
            this.materialLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelName.Location = new System.Drawing.Point(1, 53);
            this.materialLabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName.Name = "materialLabelName";
            this.materialLabelName.Size = new System.Drawing.Size(48, 18);
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
            this.panelDetails.Controls.Add(this.materialLabelDelayStopSeconds);
            this.panelDetails.Controls.Add(this.materialSingleLineTextFieldDelayStop);
            this.panelDetails.Controls.Add(this.materialCheckBoxDelayStop);
            this.panelDetails.Controls.Add(this.materialLabelDelaySeconds);
            this.panelDetails.Controls.Add(this.materialSingleLineTextFieldDelay);
            this.panelDetails.Controls.Add(this.materialCheckBoxDelayStart);
            this.panelDetails.Controls.Add(this.materialLabelWithiRacing);
            this.panelDetails.Controls.Add(this.materialCheckBoxStopWithiRacing);
            this.panelDetails.Controls.Add(this.materialSingleLineTextFieldArguments);
            this.panelDetails.Controls.Add(this.materialLabelArguments);
            this.panelDetails.Controls.Add(this.materialCheckBoxStartWithiRacing);
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
            this.panelDetails.Size = new System.Drawing.Size(289, 322);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.Visible = false;
            // 
            // materialLabelDelayStopSeconds
            // 
            this.materialLabelDelayStopSeconds.AutoSize = true;
            this.materialLabelDelayStopSeconds.Depth = 0;
            this.materialLabelDelayStopSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelDelayStopSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelDelayStopSeconds.Location = new System.Drawing.Point(200, 251);
            this.materialLabelDelayStopSeconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDelayStopSeconds.Name = "materialLabelDelayStopSeconds";
            this.materialLabelDelayStopSeconds.Size = new System.Drawing.Size(75, 18);
            this.materialLabelDelayStopSeconds.TabIndex = 22;
            this.materialLabelDelayStopSeconds.Text = "second(s)";
            // 
            // materialSingleLineTextFieldDelayStop
            // 
            this.materialSingleLineTextFieldDelayStop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programBindingSource, "DelayStopSeconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialSingleLineTextFieldDelayStop.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.programBindingSource, "DelayStop", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialSingleLineTextFieldDelayStop.Depth = 0;
            this.materialSingleLineTextFieldDelayStop.Hint = "";
            this.materialSingleLineTextFieldDelayStop.Location = new System.Drawing.Point(119, 247);
            this.materialSingleLineTextFieldDelayStop.MaxLength = 32767;
            this.materialSingleLineTextFieldDelayStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldDelayStop.Name = "materialSingleLineTextFieldDelayStop";
            this.materialSingleLineTextFieldDelayStop.PasswordChar = '\0';
            this.materialSingleLineTextFieldDelayStop.SelectedText = "";
            this.materialSingleLineTextFieldDelayStop.SelectionLength = 0;
            this.materialSingleLineTextFieldDelayStop.SelectionStart = 0;
            this.materialSingleLineTextFieldDelayStop.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextFieldDelayStop.TabIndex = 21;
            this.materialSingleLineTextFieldDelayStop.TabStop = false;
            this.materialSingleLineTextFieldDelayStop.UseSystemPasswordChar = false;
            // 
            // materialCheckBoxDelayStop
            // 
            this.materialCheckBoxDelayStop.AutoSize = true;
            this.materialCheckBoxDelayStop.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "DelayStop", true));
            this.materialCheckBoxDelayStop.Depth = 0;
            this.materialCheckBoxDelayStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxDelayStop.Location = new System.Drawing.Point(-3, 242);
            this.materialCheckBoxDelayStop.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxDelayStop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxDelayStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxDelayStop.Name = "materialCheckBoxDelayStop";
            this.materialCheckBoxDelayStop.Ripple = true;
            this.materialCheckBoxDelayStop.Size = new System.Drawing.Size(96, 30);
            this.materialCheckBoxDelayStop.TabIndex = 20;
            this.materialCheckBoxDelayStop.Text = "Delay Stop";
            this.materialCheckBoxDelayStop.UseVisualStyleBackColor = true;
            // 
            // materialLabelDelaySeconds
            // 
            this.materialLabelDelaySeconds.AutoSize = true;
            this.materialLabelDelaySeconds.Depth = 0;
            this.materialLabelDelaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelDelaySeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelDelaySeconds.Location = new System.Drawing.Point(200, 221);
            this.materialLabelDelaySeconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDelaySeconds.Name = "materialLabelDelaySeconds";
            this.materialLabelDelaySeconds.Size = new System.Drawing.Size(75, 18);
            this.materialLabelDelaySeconds.TabIndex = 19;
            this.materialLabelDelaySeconds.Text = "second(s)";
            // 
            // materialSingleLineTextFieldDelay
            // 
            this.materialSingleLineTextFieldDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programBindingSource, "DelayStartSeconds", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.materialSingleLineTextFieldDelay.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.programBindingSource, "DelayStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialSingleLineTextFieldDelay.Depth = 0;
            this.materialSingleLineTextFieldDelay.Hint = "";
            this.materialSingleLineTextFieldDelay.Location = new System.Drawing.Point(119, 217);
            this.materialSingleLineTextFieldDelay.MaxLength = 32767;
            this.materialSingleLineTextFieldDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldDelay.Name = "materialSingleLineTextFieldDelay";
            this.materialSingleLineTextFieldDelay.PasswordChar = '\0';
            this.materialSingleLineTextFieldDelay.SelectedText = "";
            this.materialSingleLineTextFieldDelay.SelectionLength = 0;
            this.materialSingleLineTextFieldDelay.SelectionStart = 0;
            this.materialSingleLineTextFieldDelay.Size = new System.Drawing.Size(75, 23);
            this.materialSingleLineTextFieldDelay.TabIndex = 18;
            this.materialSingleLineTextFieldDelay.TabStop = false;
            this.materialSingleLineTextFieldDelay.UseSystemPasswordChar = false;
            // 
            // materialCheckBoxDelayStart
            // 
            this.materialCheckBoxDelayStart.AutoSize = true;
            this.materialCheckBoxDelayStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "DelayStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxDelayStart.Depth = 0;
            this.materialCheckBoxDelayStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxDelayStart.Location = new System.Drawing.Point(-3, 212);
            this.materialCheckBoxDelayStart.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxDelayStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxDelayStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxDelayStart.Name = "materialCheckBoxDelayStart";
            this.materialCheckBoxDelayStart.Ripple = true;
            this.materialCheckBoxDelayStart.Size = new System.Drawing.Size(97, 30);
            this.materialCheckBoxDelayStart.TabIndex = 17;
            this.materialCheckBoxDelayStart.Text = "Delay Start";
            this.materialCheckBoxDelayStart.UseVisualStyleBackColor = true;
            // 
            // materialLabelWithiRacing
            // 
            this.materialLabelWithiRacing.AutoSize = true;
            this.materialLabelWithiRacing.Depth = 0;
            this.materialLabelWithiRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelWithiRacing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelWithiRacing.Location = new System.Drawing.Point(180, 176);
            this.materialLabelWithiRacing.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelWithiRacing.Name = "materialLabelWithiRacing";
            this.materialLabelWithiRacing.Size = new System.Drawing.Size(103, 18);
            this.materialLabelWithiRacing.TabIndex = 16;
            this.materialLabelWithiRacing.Text = "... with iRacing";
            // 
            // materialCheckBoxStopWithiRacing
            // 
            this.materialCheckBoxStopWithiRacing.AutoSize = true;
            this.materialCheckBoxStopWithiRacing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "StopWithIRacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxStopWithiRacing.Depth = 0;
            this.materialCheckBoxStopWithiRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxStopWithiRacing.Location = new System.Drawing.Point(113, 182);
            this.materialCheckBoxStopWithiRacing.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxStopWithiRacing.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxStopWithiRacing.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxStopWithiRacing.Name = "materialCheckBoxStopWithiRacing";
            this.materialCheckBoxStopWithiRacing.Ripple = true;
            this.materialCheckBoxStopWithiRacing.Size = new System.Drawing.Size(58, 30);
            this.materialCheckBoxStopWithiRacing.TabIndex = 15;
            this.materialCheckBoxStopWithiRacing.Text = "Stop";
            this.materialCheckBoxStopWithiRacing.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextFieldArguments
            // 
            this.materialSingleLineTextFieldArguments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programBindingSource, "Arguments", true));
            this.materialSingleLineTextFieldArguments.Depth = 0;
            this.materialSingleLineTextFieldArguments.Hint = "";
            this.materialSingleLineTextFieldArguments.Location = new System.Drawing.Point(5, 123);
            this.materialSingleLineTextFieldArguments.MaxLength = 32767;
            this.materialSingleLineTextFieldArguments.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldArguments.Name = "materialSingleLineTextFieldArguments";
            this.materialSingleLineTextFieldArguments.PasswordChar = '\0';
            this.materialSingleLineTextFieldArguments.SelectedText = "";
            this.materialSingleLineTextFieldArguments.SelectionLength = 0;
            this.materialSingleLineTextFieldArguments.SelectionStart = 0;
            this.materialSingleLineTextFieldArguments.Size = new System.Drawing.Size(285, 23);
            this.materialSingleLineTextFieldArguments.TabIndex = 14;
            this.materialSingleLineTextFieldArguments.TabStop = false;
            this.materialSingleLineTextFieldArguments.UseSystemPasswordChar = false;
            // 
            // materialLabelArguments
            // 
            this.materialLabelArguments.AutoSize = true;
            this.materialLabelArguments.Depth = 0;
            this.materialLabelArguments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabelArguments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelArguments.Location = new System.Drawing.Point(1, 101);
            this.materialLabelArguments.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelArguments.Name = "materialLabelArguments";
            this.materialLabelArguments.Size = new System.Drawing.Size(79, 18);
            this.materialLabelArguments.TabIndex = 13;
            this.materialLabelArguments.Text = "Arguments";
            // 
            // materialCheckBoxStartWithiRacing
            // 
            this.materialCheckBoxStartWithiRacing.AutoSize = true;
            this.materialCheckBoxStartWithiRacing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "StartWithIRacing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxStartWithiRacing.Depth = 0;
            this.materialCheckBoxStartWithiRacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxStartWithiRacing.Location = new System.Drawing.Point(113, 158);
            this.materialCheckBoxStartWithiRacing.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxStartWithiRacing.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxStartWithiRacing.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxStartWithiRacing.Name = "materialCheckBoxStartWithiRacing";
            this.materialCheckBoxStartWithiRacing.Ripple = true;
            this.materialCheckBoxStartWithiRacing.Size = new System.Drawing.Size(60, 30);
            this.materialCheckBoxStartWithiRacing.TabIndex = 12;
            this.materialCheckBoxStartWithiRacing.Text = "Start";
            this.materialCheckBoxStartWithiRacing.UseVisualStyleBackColor = true;
            // 
            // materialFlatButtonDelete
            // 
            this.materialFlatButtonDelete.AutoSize = true;
            this.materialFlatButtonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonDelete.Depth = 0;
            this.materialFlatButtonDelete.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButtonDelete.Icon")));
            this.materialFlatButtonDelete.Location = new System.Drawing.Point(188, 284);
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
            this.materialRaisedButtonOK.Location = new System.Drawing.Point(5, 284);
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
            this.materialFlatButtonCancel.Location = new System.Drawing.Point(67, 284);
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
            this.materialCheckBoxStartHidden.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.programBindingSource, "StartHidden", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxStartHidden.Depth = 0;
            this.materialCheckBoxStartHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialCheckBoxStartHidden.Location = new System.Drawing.Point(-3, 158);
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
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(iRacingManager.Model.Program);
            // 
            // ProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialFlatButtonCancel;
            this.ClientSize = new System.Drawing.Size(313, 442);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.materialFlatButtonSelectApp);
            this.Controls.Add(this.materialSingleLineTextFieldPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgramDialog";
            this.Text = "Add program";
            this.Load += new System.EventHandler(this.ProgramDialog_Load);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
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
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxStartWithiRacing;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldArguments;
        private MaterialSkin.Controls.MaterialLabel materialLabelArguments;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxStopWithiRacing;
        private MaterialSkin.Controls.MaterialLabel materialLabelWithiRacing;
        private MaterialSkin.Controls.MaterialLabel materialLabelDelaySeconds;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldDelay;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxDelayStart;
        private MaterialSkin.Controls.MaterialLabel materialLabelDelayStopSeconds;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldDelayStop;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxDelayStop;
    }
}