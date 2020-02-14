using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Collection;
using Vip.Sat.Domain.CFe;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFeCanc
{
    public sealed class CFeCancInfAdic : GenericClone<CFeCancInfAdic>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFeCancInfAdic()
        {
            ObsFisco = new DFeCollection<CFeObsFisco>();
        }

        #endregion Constructors

        #region Propriedades

        [DFeCollection("obsFisco", Id = "Z03", MinSize = 0, MaxSize = 10, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DFeCollection<CFeObsFisco> ObsFisco { get; set; }

        #endregion Propriedades
    }
}