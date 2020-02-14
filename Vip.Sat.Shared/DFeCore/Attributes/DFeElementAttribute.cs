using System;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Attributes
{
    /// <summary>
    ///     Classe DFeElementAttribute.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <seealso cref="DFeBaseAttribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class DFeElementAttribute : DFeBaseAttribute
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        public DFeElementAttribute() { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tag">The Name.</param>
        public DFeElementAttribute(string tag) : this()
        {
            Name = tag;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="name">The name.</param>
        public DFeElementAttribute(TipoCampo tipo, string name) : this()
        {
            Tipo = tipo;
            Name = name;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>
        ///     Gets or sets the name space.
        /// </summary>
        /// <value>The name space.</value>
        public string Namespace { get; set; }

        /// <summary>
        /// </summary>
        public bool UseCData { get; set; }

        #endregion Propriedades
    }
}