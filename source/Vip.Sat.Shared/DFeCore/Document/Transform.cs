using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Document
{
    public sealed class Transform
    {
        /// <summary>
        ///     XS13 - Atributos válidos Algorithm do Transform:
        ///     <para>http://www.w3.org/TR/2001/REC-xml-c14n-20010315</para>
        ///     <para>http://www.w3.org/2000/09/xmldsig#enveloped-signature</para>
        /// </summary>
        /// <value>The algorithm.</value>
        [DFeAttribute(TipoCampo.Str, "Algorithm", Id = "XS12", Min = 0, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Algorithm { get; set; }
    }
}