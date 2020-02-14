using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Collection;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFePgto : GenericClone<CFePgto>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFePgto()
        {
            Pagamentos = new DFeCollection<CFePgtoMp>();
        }

        #endregion Constructors

        #region Propriedades

        [DFeCollection("MP", Id = "WA02", MinSize = 1, MaxSize = 50, Ocorrencia = Ocorrencia.Obrigatoria)]
        public DFeCollection<CFePgtoMp> Pagamentos { get; set; }

        [DFeElement(TipoCampo.De2, "vTroco", Id = "WA06", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VTroco { get; set; }

        #endregion Propriedades
    }
}