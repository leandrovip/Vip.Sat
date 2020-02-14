using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Enum;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFePgtoMp : GenericClone<CFePgtoMp>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.Enum, "cMP", Id = "WA04", Min = 2, Max = 2, Ocorrencia = Ocorrencia.Obrigatoria)]
        public CodigoMP CMp { get; set; }

        [DFeElement(TipoCampo.De2, "vMP", Id = "WA05", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VMp { get; set; }

        [DFeElement(TipoCampo.Int, "cAdmC", Id = "WA06", Min = 3, Max = 3, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public int? CAdmC { get; set; }

        #endregion Properties

        #region Methods

        private bool ShouldSerializeCAdmC()
        {
            return CAdmC != null;
        }

        #endregion Methods
    }
}