using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeTotalIssqn : GenericClone<CFeTotalIssqn>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.De2, "vBC", Id = "W13", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VBC { get; set; }

        [DFeElement(TipoCampo.De2, "vISS", Id = "W14", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VISS { get; set; }

        [DFeElement(TipoCampo.De2, "vPIS", Id = "W15", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VPIS { get; set; }

        [DFeElement(TipoCampo.De2, "vCOFINS", Id = "W16", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VCOFINS { get; set; }

        [DFeElement(TipoCampo.De2, "vPISST", Id = "W17", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VPISST { get; set; }

        [DFeElement(TipoCampo.De2, "vCOFINSST", Id = "W18", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VCOFINSST { get; set; }

        #endregion Properties
    }
}