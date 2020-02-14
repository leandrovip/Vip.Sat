using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Extensions;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeDest : GenericClone<CFeDest>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.StrNumberFill, "CPF", Id = "E02", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CPF { get; set; }

        [DFeElement(TipoCampo.StrNumberFill, "CNPJ", Id = "E03", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CNPJ { get; set; }

        [DFeElement(TipoCampo.Str, "xNome", Id = "E04", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string Nome { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeCPF()
        {
            return CNPJ.IsNullOrEmpty();
        }

        private bool ShouldSerializeCNPJ()
        {
            return CPF.IsNullOrEmpty();
        }

        #endregion Methods
    }
}