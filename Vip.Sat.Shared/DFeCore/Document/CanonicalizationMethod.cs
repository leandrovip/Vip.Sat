// ***********************************************************************
// Assembly         : ACBr.Net.DFe.Core

using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.DFeCore.Document
{
    public sealed class CanonicalizationMethod
    {
        /// <summary>
        ///     XS04 - Atributo Algorithm de CanonicalizationMethod: http://www.w3.org/TR/2001/REC-xml-c14n-20010315
        /// </summary>
        /// <value>The algorithm.</value>
        [DFeAttribute(TipoCampo.Str, "Algorithm", Id = "XS04", Min = 0, Max = 999, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Algorithm { get; set; }
    }
}