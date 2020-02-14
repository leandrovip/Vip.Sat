using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeEnderEmit : GenericClone<CFeEnderEmit>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.Str, "xLgr", Id = "C06", Min = 2, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XLgr { get; set; }

        [DFeElement(TipoCampo.Str, "nro", Id = "C07", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Nro { get; set; }

        [DFeElement(TipoCampo.Str, "xCpl", Id = "C08", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XCpl { get; set; }

        [DFeElement(TipoCampo.Str, "xBairro", Id = "C09", Min = 2, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XBairro { get; set; }

        [DFeElement(TipoCampo.Str, "xMun", Id = "C10", Min = 2, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XMun { get; set; }

        [DFeElement(TipoCampo.StrNumber, "CEP", Id = "C11", Min = 8, Max = 8, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CEP { get; set; }

        #endregion Properties
    }
}