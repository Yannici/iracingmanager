using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingManager.Model.Settings
{
    /// <summary>
    /// Attribute to identify settings migrations
    /// </summary>
    class MigrationAttribute : Attribute
    {

        #region " Members "

        private string _MigrateVersion = null;

        #endregion

        #region " Construction "

        public MigrationAttribute(string migrateVersion)
        {
            this._MigrateVersion = migrateVersion;
        }

        #endregion

        #region " Properties "

        public Version MigrateVersion
        {
            get
            {
                return new Version(this._MigrateVersion);
            }
        }

        #endregion

    }
}
