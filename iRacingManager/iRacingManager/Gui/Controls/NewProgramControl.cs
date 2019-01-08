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

        protected virtual void OnProgramAdded(Model.Program program)
        {
            if (ProgramAdded != null)
            {
                ProgramAdded(this, new Model.ProgramAddedEventArgs(program));
            }
        }

        private void openAddProgramDialog()
        {
            using (ProgramDialog dialog = new ProgramDialog())
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.OnProgramAdded(dialog.Program);
                }
            }
        }

        #endregion

        #region Eventhandler

        private void materialRaisedButtonAdd_Click(object sender, EventArgs e)
        {
            this.openAddProgramDialog();
        }

        #endregion

        #region Event

        internal event EventHandler<Model.ProgramAddedEventArgs> ProgramAdded;

        #endregion

    }
}
