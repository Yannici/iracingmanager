using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace iRacingManager.Gui
{
    public partial class ProgramDialog : MaterialForm
    {

        #region Members

        private Model.Program _Program = null;

        #endregion

        #region Construction

        public ProgramDialog() : base()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);

            this._Program = new Model.Program();
        }

        public ProgramDialog(Model.Program Program) : this()
        {
            this._Program = Program;
            this.materialSingleLineTextFieldPath.Text = System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName);
            this.materialFlatButtonCancel.Visible = false;

            this.Text = "Edit progam";
        }

        #endregion

        #region Methods

        private void selectApplication()
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Application (*.exe;*.bat;*.cmd)|*.exe;*.bat;*.cmd";
                openFileDialog.Title = "Select application ...";

                if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                this.materialSingleLineTextFieldPath.Text = openFileDialog.FileName;
            }
        }

        private void selectIconPath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Icon (*.ico)|*.ico|Image (*.gif;*.png;*.jpg;*.jpeg)|*.gif;*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Select icon ...";
                openFileDialog.FilterIndex = 3;

                if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                this._Program.PicturePath = openFileDialog.FileName;
                this.materialSingleLineTextFieldIconPath.Text = this._Program.PicturePath;
                this.pictureBoxIcon.Image = this._Program.Icon;
                this.materialFlatButtonUseIconFromApp.Visible = true;
            }
        }

        private void validatePath()
        {
            if (string.IsNullOrEmpty(this.materialSingleLineTextFieldPath.Text) || this.materialSingleLineTextFieldPath.Text == "Path to application ...")
            {
                return;
            }

            if (!System.IO.File.Exists(this.materialSingleLineTextFieldPath.Text))
            {
                return;
            }

            this._Program.InstallLocation = System.IO.Path.GetDirectoryName(this.materialSingleLineTextFieldPath.Text);
            this._Program.FileName = System.IO.Path.GetFileName(this.materialSingleLineTextFieldPath.Text);
            
            if (string.IsNullOrEmpty(this._Program.Name))
            {
                this._Program.Name = System.IO.Path.GetFileNameWithoutExtension(this.materialSingleLineTextFieldPath.Text);
            }

            if (string.IsNullOrEmpty(this._Program.DisplayName)) {
                this._Program.DisplayName = this._Program.Name;
            }

            this.panelDetails.Visible = true;
        }

        #endregion

        #region Eventhandler

        private void ProgramDialog_Load(object sender, EventArgs e)
        {
            this.programBindingSource.DataSource = this._Program;
            this.validatePath();
            this.materialFlatButtonUseIconFromApp.Visible = !this._Program.UseIconFromApplication;

            if (!this._Program.UseIconFromApplication)
            {
                this.materialSingleLineTextFieldIconPath.Text = this._Program.PicturePath;
            }

            this.pictureBoxIcon.InitialImage = null;
            this.pictureBoxIcon.Image = this._Program.getClonedImage();
            this.pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void materialFlatButtonSelectApp_Click(object sender, EventArgs e)
        {
            this.selectApplication();
            this.validatePath();

            if (this._Program.UseIconFromApplication)
            {
                this.pictureBoxIcon.Image = this._Program.getClonedImage();
            }
        }

        private void materialSingleLineTextFieldPath_Validated(object sender, EventArgs e)
        {
            this.validatePath();
        }

        private void materialFlatButtonSelectIcon_Click(object sender, EventArgs e)
        {
            this.selectIconPath();
        }

        private void materialFlatButtonUseIconFromApp_Click(object sender, EventArgs e)
        {
            this._Program.PicturePath = string.Empty;
            this.pictureBoxIcon.Image = this._Program.getClonedImage();
            this.materialFlatButtonUseIconFromApp.Visible = false;
            this.materialSingleLineTextFieldIconPath.Text = "Use from application";
        }

        #endregion

        #region Properties

        internal Model.Program Program
        {
            get
            {
                return this._Program;
            }
        }

        #endregion

    }
}
