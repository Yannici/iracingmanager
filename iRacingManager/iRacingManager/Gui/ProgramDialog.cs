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
        private bool _Modify = false;

        #endregion

        #region Construction

        public ProgramDialog()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);

            this._Program = new Model.Program();
        }

        public ProgramDialog(Model.Program Program)
        {
            this._Program = Program;
            this._Modify = true;
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
            }
        }

        #endregion

        #region Eventhandler

        private void ProgramDialog_Load(object sender, EventArgs e)
        {
            this.programBindingSource.DataSource = this._Program;
        }

        private void materialSingleLineTextFieldPath_Click(object sender, EventArgs e)
        {
            this.selectApplication();
        }

        private void materialFlatButtonSelectApp_Click(object sender, EventArgs e)
        {
            this.selectApplication();
        }

        #endregion
    }
}
