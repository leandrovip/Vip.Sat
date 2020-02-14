﻿using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.DFeCore.Common
{
    /// <summary>
    ///     Estados brasileiros por código
    /// </summary>
    public enum DFeCodUF
    {
        /// <summary>
        ///     12 - Acre
        /// </summary>
        [DFeEnum("12")] [Description("Acre")] AC = 12,

        /// <summary>
        ///     27 - Alagoas
        /// </summary>
        [DFeEnum("27")] [Description("Alagoas")]
        AL = 27,

        /// <summary>
        ///     13 - Amazonas
        /// </summary>
        [DFeEnum("13")] [Description("Amazonas")]
        AM = 13,

        /// <summary>
        ///     16 - Amapá
        /// </summary>
        [DFeEnum("16")] [Description("Amapá")] AP = 16,

        /// <summary>
        ///     29 - Bahia
        /// </summary>
        [DFeEnum("29")] [Description("Bahia")] BA = 29,

        /// <summary>
        ///     23 - Ceará
        /// </summary>
        [DFeEnum("23")] [Description("Ceará")] CE = 23,

        /// <summary>
        ///     53 - Distrito Federal
        /// </summary>
        [DFeEnum("53")] [Description("Distrito Federal")]
        DF = 53,

        /// <summary>
        ///     32 - Espírito Santo
        /// </summary>
        [DFeEnum("32")] [Description("Espírito Santo")]
        ES = 32,

        /// <summary>
        ///     53 - Goiás
        /// </summary>
        [DFeEnum("52")] [Description("Goiás")] GO = 52,

        /// <summary>
        ///     21 - Maranhão
        /// </summary>
        [DFeEnum("21")] [Description("Maranhão")]
        MA = 21,

        /// <summary>
        ///     31 - Minas Gerais
        /// </summary>
        [DFeEnum("31")] [Description("Minas Gerais")]
        MG = 31,

        /// <summary>
        ///     50 - Mato Grosso do Sul
        /// </summary>
        [DFeEnum("50")] [Description("Mato Grosso do Sul")]
        MS = 50,

        /// <summary>
        ///     51 - Mato Grosso
        /// </summary>
        [DFeEnum("51")] [Description("Mato Grosso")]
        MT = 51,

        /// <summary>
        ///     15 - Pará
        /// </summary>
        [DFeEnum("15")] [Description("Pará")] PA = 15,

        /// <summary>
        ///     25 - Paraíba
        /// </summary>
        [DFeEnum("25")] [Description("Paraíba")]
        PB = 25,

        /// <summary>
        ///     26 - Pernambuco
        /// </summary>
        [DFeEnum("26")] [Description("Pernambuco")]
        PE = 26,

        /// <summary>
        ///     22 - Piauí
        /// </summary>
        [DFeEnum("22")] [Description("Piauí")] PI = 22,

        /// <summary>
        ///     41 - Paraná
        /// </summary>
        [DFeEnum("41")] [Description("Paraná")]
        PR = 41,

        /// <summary>
        ///     33 - Rio de Janeiro
        /// </summary>
        [DFeEnum("33")] [Description("Rio de Janeiro")]
        RJ = 33,

        /// <summary>
        ///     24 - Rio Grande do Norte
        /// </summary>
        [DFeEnum("24")] [Description("Rio Grande do Norte")]
        RN = 24,

        /// <summary>
        ///     11 - Rondônia
        /// </summary>
        [DFeEnum("11")] [Description("Rondônia")]
        RO = 11,

        /// <summary>
        ///     14 - Roraima
        /// </summary>
        [DFeEnum("14")] [Description("Roraima")]
        RR = 14,

        /// <summary>
        ///     43 - Rio Grande do Sul
        /// </summary>
        [DFeEnum("43")] [Description("Rio Grande do Sul")]
        RS = 43,

        /// <summary>
        ///     42 - Santa Catarina
        /// </summary>
        [DFeEnum("42")] [Description("Santa Catarina")]
        SC = 42,

        /// <summary>
        ///     28 - Sergipe
        /// </summary>
        [DFeEnum("28")] [Description("Sergipe")]
        SE = 28,

        /// <summary>
        ///     35 - São Paulo
        /// </summary>
        [DFeEnum("35")] [Description("São Paulo")]
        SP = 35,

        /// <summary>
        ///     17 - Tocantins
        /// </summary>
        [DFeEnum("17")] [Description("Tocantins")]
        TO = 17,

        /// <summary>
        ///     91 - Ambiente Nacional
        /// </summary>
        [DFeEnum("91")] [Description("Ambiente Nacional")]
        AN = 91,

        /// <summary>
        ///     00 - Exterior
        /// </summary>
        [DFeEnum("00")] [Description("Exterior")]
        EX = 0,

        /// <summary>
        ///     99 - Suframa
        /// </summary>
        [DFeEnum("99")] [Description("Suframa")]
        SU
    }
}