using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeEntrega : GenericClone<CFeEntrega>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.Str, "xLgr", Id = "G02", Min = 2, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XLgr { get; set; }

        [DFeElement(TipoCampo.Str, "nro", Id = "G03", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Nro { get; set; }

        [DFeElement(TipoCampo.Str, "xCpl", Id = "G04", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XCpl { get; set; }

        [DFeElement(TipoCampo.Str, "xBairro", Id = "G05", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XBairro { get; set; }

        [DFeElement(TipoCampo.Str, "xMun", Id = "G06", Min = 2, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XMun { get; set; }

        [DFeElement(TipoCampo.Str, "UF", Id = "G07", Min = 2, Max = 2, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string UF { get; set; }

        #endregion Propriedades
    }
}