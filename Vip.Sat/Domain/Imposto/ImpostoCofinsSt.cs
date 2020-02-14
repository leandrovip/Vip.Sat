using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    public sealed class ImpostoCofinsSt : GenericClone<ImpostoCofinsSt>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.De2, "vBC", Id = "T02", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VBc { get; set; }

        [DFeElement(TipoCampo.De4, "pCOFINS", Id = "T03", Min = 5, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal PCofins { get; set; }

        [DFeElement(TipoCampo.De4, "qBCProd", Id = "T04", Min = 1, Max = 16, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal QBcProd { get; set; }

        [DFeElement(TipoCampo.De4, "vAliqProd", Id = "T05", Min = 5, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VAliqProd { get; set; }

        [DFeElement(TipoCampo.De2, "vCOFINS", Id = "T06", Min = 1, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VCofins { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeVBc()
        {
            return VAliqProd == 0;
        }

        private bool ShouldSerializePCofins()
        {
            return VAliqProd == 0;
        }

        #endregion Methods
    }
}