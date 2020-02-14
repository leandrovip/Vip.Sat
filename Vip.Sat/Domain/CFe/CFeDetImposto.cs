using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Domain.Imposto;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeDetImposto : GenericClone<CFeDetImposto>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFeDetImposto()
        {
            CofinsSt = new ImpostoCofinsSt();
            Cofins = new ImpostoCofins();
            PisSt = new ImpostoPisSt();
            Pis = new ImpostoPIS();
        }

        #endregion Constructors

        #region Propriedades

        [DFeElement(TipoCampo.De2, "vItem12741", Id = "M02", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VItem12741 { get; set; }

        [DFeItem(typeof(ImpostoIcms), "ICMS")]
        [DFeItem(typeof(ImpostoIssqn), "ISSQN")]
        public ICFeImposto Imposto { get; set; }

        [DFeElement("PIS", Id = "Q01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public ImpostoPIS Pis { get; set; }

        [DFeElement("PISST", Id = "R01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public ImpostoPisSt PisSt { get; set; }

        [DFeElement("COFINS", Id = "S01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public ImpostoCofins Cofins { get; set; }

        [DFeElement("COFINSST", Id = "T01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public ImpostoCofinsSt CofinsSt { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeImposto()
        {
            if (Imposto is ImpostoIssqn issqn)
                return issqn.VDeducIssqn > 0 || issqn.VBc > 0 ||
                       issqn.VAliq > 0 || issqn.VIssqn > 0;

            return true;
        }

        private bool ShouldSerializePisSt()
        {
            return PisSt.PPis > 0 || PisSt.VBc > 0 ||
                   PisSt.QBcProd > 0 || PisSt.VPis > 0;
        }

        private bool ShouldSerializeCofinsSt()
        {
            return CofinsSt.PCofins > 0 || CofinsSt.VBc > 0 ||
                   CofinsSt.QBcProd > 0 || CofinsSt.VCofins > 0;
        }

        #endregion Methods
    }
}