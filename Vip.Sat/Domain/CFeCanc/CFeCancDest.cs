using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Collection;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Extensions;

namespace Vip.Sat.Domain.CFeCanc
{
    public sealed class CFeCancDest : DFeParentItem<CFeCancDest, CancInfCFe>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Propriedades

        [DFeElement(TipoCampo.StrNumberFill, "CPF", Id = "E02", Min = 11, Max = 11, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CPF { get; set; }

        [DFeElement(TipoCampo.StrNumberFill, "CNPJ", Id = "E03", Min = 14, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CNPJ { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeCPF()
        {
            return Parent.Versao < 0.07M && CNPJ.IsNullOrEmpty();
        }

        private bool ShouldSerializeCNPJ()
        {
            return Parent.Versao < 0.07M && CPF.IsNullOrEmpty();
        }

        #endregion Methods
    }
}