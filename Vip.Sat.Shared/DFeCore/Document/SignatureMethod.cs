using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Document
{
    public sealed class SignatureMethod
    {
        /// <summary>
        ///     XS06 - Atributo Algorithm de SignatureMethod: http://www.w3.org/2000/09/xmldsig#rsa-sha1
        /// </summary>
        /// <value>The algorithm.</value>
        [DFeAttribute(TipoCampo.Str, "Algorithm", Id = "XS06", Min = 0, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Algorithm { get; set; }
    }
}