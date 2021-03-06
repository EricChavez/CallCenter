﻿
using System;
using System.Configuration;

namespace SoftvConfiguration
{
    public class COLONIAElement : ConfigurationElement
    {
        /// <summary>
        /// Gets assembly name for COLONIA class
        /// </summary>
        [ConfigurationProperty("Assembly")]
        public String Assembly
        {
            get
            {
                string assembly = (string)base["Assembly"];
                assembly = String.IsNullOrEmpty(assembly) ?
                SoftvSettings.Settings.Assembly :
                (string)base["Assembly"];
                return assembly;
            }
        }

        /// <summary>
        /// Gets class name for COLONIA
        ///</summary>
        [ConfigurationProperty("DataClassCOLONIA", DefaultValue = "Softv.DAO.COLONIAData")]
        public String DataClass
        {
            get { return (string)base["DataClassCOLONIA"]; }
        }

        /// <summary>
        /// Gets connection string for database COLONIA access
        ///</summary>
        [ConfigurationProperty("ConnectionString")]
        public String ConnectionString
        {
            get
            {
                string connectionString = (string)base["ConnectionString"];
                connectionString = String.IsNullOrEmpty(connectionString) ? SoftvSettings.Settings.ConnectionString : (string)base["ConnectionString"];
                return connectionString;
            }
        }
    }
}

