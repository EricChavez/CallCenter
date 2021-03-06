﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Softv.Entities
{
    /// <summary>
    /// Class                   : Softv.Entities.TrabajoEntity.cs
    /// Generated by            : Class Generator (c) 2014
    /// Description             : Trabajo entity
    /// File                    : TrabajoEntity.cs
    /// Creation date           : 04/05/2016
    /// Creation time           : 01:21 p. m.
    ///</summary>
    [DataContract]
    [Serializable]
    public class TrabajoEntity : BaseEntity
    {
        #region Attributes

        /// <summary>
        /// Property Clv_Trabajo
        /// </summary>
        [DataMember]
        public int? Clv_Trabajo { get; set; }
        /// <summary>
        /// Property TRABAJO
        /// </summary>
        [DataMember]
        public String TRABAJO { get; set; }
        /// <summary>
        /// Property Clv_TipSer
        /// </summary>
        [DataMember]
        public int? Clv_TipSer { get; set; }
        /// <summary>
        /// Property DESCRIPCION
        /// </summary>
        [DataMember]
        public String DESCRIPCION { get; set; }
        /// <summary>
        /// Property PUNTOS
        /// </summary>
        [DataMember]
        public Decimal? PUNTOS { get; set; }
        /// <summary>
        /// Property Cobranza
        /// </summary>
        [DataMember]
        public bool? Cobranza { get; set; }
        /// <summary>
        /// Property Tipo
        /// </summary>
        [DataMember]
        public String Tipo { get; set; }
        /// <summary>
        /// Property Prospectos
        /// </summary>
        [DataMember]
        public bool? Prospectos { get; set; }
        /// <summary>
        /// Property SICA
        /// </summary>
        [DataMember]
        public bool? SICA { get; set; }
        /// <summary>
        /// Property SeCobraMaterial
        /// </summary>
        [DataMember]
        public bool? SeCobraMaterial { get; set; }
        [DataMember]
        public LlamadaEntity Llamada { get; set; }

        #endregion
    }
}

