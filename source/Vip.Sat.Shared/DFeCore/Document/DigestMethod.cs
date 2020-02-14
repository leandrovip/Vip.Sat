using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Document
{
    public sealed class DigestMethod
    {
        /// <summary>
        ///     XS16 - Atributo Algorithm de DigestMethod: http://www.w3.org/2000/09/xmldsig#sha1
        /// </summary>
        /// <value>The algorithm.</value>
        [DFeAttribute(TipoCampo.Str, "Algorithm", Id = "XS16", Min = 0, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Algorithm { get; set; }
    }
}