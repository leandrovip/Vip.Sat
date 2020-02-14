using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Enum;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    /// <summary>
    ///     Classe para os imposto com CSOSN 102, 300 ou 500.
    /// </summary>
    public sealed class ImpostoIcmsSn102 : GenericClone<ImpostoIcmsSn102>, ICFeIcms
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.Enum, "Orig", Id = "N06", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public OrigemMercadoria Orig { get; set; }

        [DFeElement(TipoCampo.Str, "CSOSN", Id = "N10", Min = 3, Max = 3, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Csosn { get; set; }

        #endregion Properties
    }
}