using System.IO;
using System.Text;

namespace Vip.Sat
{
    /// <summary>
    ///     Classe derivada da StringWriter que aceita a mudança de encond.
    /// </summary>
    public sealed class VipStringWriter : StringWriter
    {
        #region Constructors

        /// <summary>
        ///     Inicializar uma nova instancida da classe <see cref="VipStringWriter" />.
        /// </summary>
        public VipStringWriter()
        {
            Encoding = Encoding.UTF8;
        }

        /// <summary>
        ///     Inicializar uma nova instancida da classe <see cref="VipStringWriter" />.
        /// </summary>
        /// <param name="encoding"></param>
        public VipStringWriter(Encoding encoding)
        {
            Encoding = encoding;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>Gets the <see cref="T:System.Text.Encoding" /> in which the output is written.</summary>
        /// <returns>The Encoding in which the output is written.</returns>
        /// <filterpriority>1</filterpriority>
        public override Encoding Encoding { get; }

        #endregion Propriedades
    }
}