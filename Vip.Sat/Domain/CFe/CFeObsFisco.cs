using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeObsFisco : GenericClone<CFeObsFisco>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeAttribute("xCampo", Id = "Z04", Min = 1, Max = 20, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XCampo { get; set; }

        [DFeElement(TipoCampo.Str, "xTexto", Id = "Z05", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XTexto { get; set; }

        #endregion Properties
    }
}