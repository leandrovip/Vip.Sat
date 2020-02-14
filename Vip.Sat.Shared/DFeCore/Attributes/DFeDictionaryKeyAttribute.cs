using System;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DFeDictionaryKeyAttribute : DFeBaseAttribute
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeDictionaryKeyAttribute" /> class.
        /// </summary>
        public DFeDictionaryKeyAttribute()
        {
            Tipo = TipoCampo.Str;
            Id = "";
            Name = string.Empty;
            Min = 0;
            Max = 0;
            Ocorrencia = 0;
            Descricao = string.Empty;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeDictionaryKeyAttribute" /> class.
        /// </summary>
        /// <param name="tag">Nome da tag.</param>
        public DFeDictionaryKeyAttribute(string tag) : this()
        {
            Name = tag;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeDictionaryKeyAttribute" /> class.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="name">The name.</param>
        public DFeDictionaryKeyAttribute(TipoCampo tipo, string name) : this()
        {
            Tipo = tipo;
            Name = name;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeDictionaryKeyAttribute" /> class.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="name">The name.</param>
        public DFeDictionaryKeyAttribute(TipoCampo tipo, string name, bool asAttribute) : this()
        {
            Tipo = tipo;
            Name = name;
            AsAttribute = asAttribute;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeDictionaryKeyAttribute" /> class.
        /// </summary>
        public DFeDictionaryKeyAttribute(string tag, bool asAttribute) : this()
        {
            Name = tag;
            AsAttribute = asAttribute;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        ///     Gets or sets the name space.
        /// </summary>
        /// <value>The name space.</value>
        public string Namespace { get; set; }

        /// <summary>
        ///     Gets or sets the AsAttribute.
        /// </summary>
        /// <value>The AsAttribute.</value>
        public bool AsAttribute { get; set; }

        #endregion Properties
    }
}