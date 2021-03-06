﻿
using System;
using System.Configuration;

namespace SoftvConfiguration
{
    public class ResOpcMultsElement : ConfigurationElement
    {
        /// <summary>
        /// Gets assembly name for ResOpcMults class
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
        /// Gets class name for ResOpcMults
        ///</summary>
        [ConfigurationProperty("DataClassResOpcMults", DefaultValue = "Softv.DAO.ResOpcMultsData")]
        public String DataClass
        {
            get { return (string)base["DataClassResOpcMults"]; }
        }

        /// <summary>
        /// Gets connection string for database ResOpcMults access
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

