using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeTotalIcms : GenericClone<CFeTotalIcms>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.De2, "vICMS", Id = "W03", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VICMS { get; set; }

        [DFeElement(TipoCampo.De2, "vProd", Id = "W04", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VProd { get; set; }

        [DFeElement(TipoCampo.De2, "vDesc", Id = "W05", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VDesc { get; set; }

        [DFeElement(TipoCampo.De2, "vPIS", Id = "W06", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VPIS { get; set; }

        [DFeElement(TipoCampo.De2, "vCOFINS", Id = "W07", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VCOFINS { get; set; }

        [DFeElement(TipoCampo.De2, "vPISST", Id = "W08", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VPISST { get; set; }

        [DFeElement(TipoCampo.De2, "vCOFINSST", Id = "W09", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VCOFINSST { get; set; }

        [DFeElement(TipoCampo.De2, "vOutro", Id = "W10", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VOutro { get; set; }

        #endregion Properties
    }
}