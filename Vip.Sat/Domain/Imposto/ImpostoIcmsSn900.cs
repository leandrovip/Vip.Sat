using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Enum;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    public sealed class ImpostoIcmsSn900 : GenericClone<ImpostoIcmsSn900>, ICFeIcms
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.Enum, "Orig", Id = "N06", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public OrigemMercadoria Orig { get; set; }

        [DFeElement(TipoCampo.Str, "CSOSN", Id = "N10", Min = 3, Max = 3, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Csosn { get; set; }

        [DFeElement(TipoCampo.De2, "pICMS", Id = "N08", Min = 3, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal PIcms { get; set; }

        [DFeElement(TipoCampo.De2, "vICMS", Id = "N09", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VIcms { get; set; }

        #endregion Propriedades
    }
}