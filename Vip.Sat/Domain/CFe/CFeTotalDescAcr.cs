using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeTotalDescAcr : GenericClone<CFeTotalDescAcr>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.De2, "vDescSubtot", Id = "W20", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VDescSubtot { get; set; }

        [DFeElement(TipoCampo.De2, "vAcresSubtot", Id = "W21", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VAcresSubtot { get; set; }

        #endregion Propriedades
    }
}