using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Enum;
using Vip.Sat.Extensions;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeEmit : GenericClone<CFeEmit>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFeEmit()
        {
            EnderEmit = new CFeEnderEmit();
        }

        #endregion Constructors

        #region Propriedades

        [DFeElement(TipoCampo.StrNumberFill, "CNPJ", Id = "C02", Min = 14, Max = 14, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string CNPJ { get; set; }

        [DFeElement(TipoCampo.Str, "xNome", Id = "C03", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XNome { get; set; }

        [DFeElement(TipoCampo.Str, "xFant", Id = "C04", Min = 1, Max = 60, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string XFant { get; set; }

        [DFeElement("enderEmit", Id = "C05", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public CFeEnderEmit EnderEmit { get; set; }

        [DFeElement(TipoCampo.Str, "IE", Id = "C12", Min = 2, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string IE { get; set; }

        [DFeElement(TipoCampo.Str, "IM", Id = "C13", Min = 1, Max = 15, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string IM { get; set; }

        [DFeElement(TipoCampo.Enum, "cRegTrib", Id = "C14", Min = 1, Max = 1, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public RegTrib? CRegTrib { get; set; }

        [DFeElement(TipoCampo.Enum, "cRegTribISSQN", Id = "C15", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public RegTribIssqn CRegTribISSQN { get; set; }

        [DFeElement(TipoCampo.Enum, "indRatISSQN", Id = "C16", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public RatIssqn IndRatISSQN { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeXNome()
        {
            return !XNome.IsNullOrEmpty();
        }

        private bool ShouldSerializeXFant()
        {
            return !XFant.IsNullOrEmpty();
        }

        private bool ShouldSerializeEnderEmit()
        {
            return !EnderEmit.CEP.IsNullOrEmpty() ||
                   !EnderEmit.Nro.IsNullOrEmpty() ||
                   !EnderEmit.XBairro.IsNullOrEmpty() ||
                   !EnderEmit.XCpl.IsNullOrEmpty() ||
                   !EnderEmit.XLgr.IsNullOrEmpty() ||
                   !EnderEmit.XMun.IsNullOrEmpty();
        }

        private bool ShouldSerializeCRegTrib()
        {
            return CRegTrib != null;
        }

        private bool ShouldSerializeIE()
        {
            return !IE.IsNullOrEmpty();
        }

        private bool ShouldSerializeIM()
        {
            return !IM.IsNullOrEmpty();
        }

        private bool ShouldSerializeCRegTribISSQN()
        {
            return !IM.IsNullOrEmpty() && CRegTribISSQN != RegTribIssqn.Nenhum;
        }

        #endregion Methods
    }
}