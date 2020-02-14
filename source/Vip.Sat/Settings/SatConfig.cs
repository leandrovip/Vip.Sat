using System.ComponentModel;
using Vip.Sat.DFeCore.Common;
using Vip.Sat.Enum;
using Vip.Sat.Service;

namespace Vip.Sat.Settings
{
    /// <summary>
    ///     Class SATConfig. This class cannot be inherited.
    /// </summary>
    [TypeConverter(typeof(VipExpandableObjectConverter))]
    public sealed class SatConfig
    {
        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="SatConfig" /> class.
        /// </summary>
        internal SatConfig(CFeService parent)
        {
            Parent = parent;
            InfCFeVersaoDadosEnt = 0.07M;
            IdeCNPJ = "11111111111111";
            IdeNumeroCaixa = 1;
            IdeTpAmb = DFeTipoAmbiente.Homologacao;
            EmitCNPJ = @"11111111111111";
            EmitIE = string.Empty;
            EmitIM = string.Empty;
            EmitCRegTrib = RegTrib.Normal;
            EmitCRegTribISSQN = RegTribIssqn.Nenhum;
            EmitIndRatISSQN = RatIssqn.Nao;
            IsUtf8 = false;
            ValidarNumeroSessaoResposta = false;
            NumeroTentativasValidarSessao = 1;
        }

        #endregion Constructor

        #region Propriedades

        internal CFeService Parent { get; }

        public decimal InfCFeVersaoDadosEnt { get; set; }

        public string IdeCNPJ { get; set; }

        public int IdeNumeroCaixa { get; set; }

        public DFeTipoAmbiente IdeTpAmb { get; set; }

        public string EmitCNPJ { get; set; }

        public string EmitIE { get; set; }

        public string EmitIM { get; set; }

        public RegTrib EmitCRegTrib { get; set; }

        public RegTribIssqn EmitCRegTribISSQN { get; set; }

        public RatIssqn EmitIndRatISSQN { get; set; }

        public bool IsUtf8 { get; set; }

        public bool ValidarNumeroSessaoResposta { get; set; }

        public int NumeroTentativasValidarSessao { get; set; }

        public bool RemoverAcentos { get; set; }

        #endregion Propriedades
    }
}