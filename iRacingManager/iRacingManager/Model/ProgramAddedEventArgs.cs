using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingManager.Model
{
    class ProgramAddedEventArgs : EventArgs
    {

        #region Members

        private Program _AddedProgram = null;

        #endregion

        #region Construction

        public ProgramAddedEventArgs(Program addedProgram)
        {
            this._AddedProgram = addedProgram;
        }

        #endregion

        #region Methods

        #endregion

        #region Properties

        internal Program AddedProgram
        {
            get
            {
                return this._AddedProgram;
            }
        }

        #endregion

    }
}
