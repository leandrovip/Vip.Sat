using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Document
{
    public sealed class X509Data
    {
        /// <summary>
        ///     XS21 - Certificado Digital X509 em Base64
        /// </summary>
        /// <value>The X509 certificate.</value>
        [DFeElement(TipoCampo.Str, "X509Certificate", Id = "XS21", Min = 0, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string X509Certificate { get; set; }
    }
}