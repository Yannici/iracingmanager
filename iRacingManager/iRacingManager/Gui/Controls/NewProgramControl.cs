using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRacingManager.Gui.Controls
{
    public partial class NewProgramControl : UserControl
    {

        #region Members

        #endregion

        #region Construction

        public NewProgramControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void openAddProgramDialog()
        {
            using (ProgramDialog dialog = new ProgramDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.ShowDialog(this);
            }
        }

        #endregion

        #region Eventhandler

        private void materialRaisedButtonAdd_Click(object sender, EventArgs e)
        {
            this.openAddProgramDialog();
        }

        #endregion

    }
}
