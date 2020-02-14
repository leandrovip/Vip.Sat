using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeTotal : GenericClone<CFeTotal>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFeTotal()
        {
            ICMSTot = new CFeTotalIcms();
            ISSQNTot = new CFeTotalIssqn();
            DescAcrEntr = new CFeTotalDescAcr();
        }

        #endregion Constructors

        #region Propriedades

        [DFeElement("ICMSTot", Id = "W02", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public CFeTotalIcms ICMSTot { get; set; }

        [DFeElement(TipoCampo.De2, "vCFe", Id = "W11", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VCFe { get; set; }

        [DFeElement("ISSQNtot", Id = "W12", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public CFeTotalIssqn ISSQNTot { get; set; }

        [DFeElement("DescAcrEntr", Id = "W19", Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public CFeTotalDescAcr DescAcrEntr { get; set; }

        [DFeElement(TipoCampo.De2, "vCFeLei12741", Id = "W22", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VCFeLei12741 { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeICMSTot()
        {
            return ICMSTot.VICMS > 0 || ICMSTot.VProd > 0 ||
                   ICMSTot.VDesc > 0 || ICMSTot.VPIS > 0 ||
                   ICMSTot.VCOFINS > 0 || ICMSTot.VPISST > 0 ||
                   ICMSTot.VCOFINSST > 0 || ICMSTot.VOutro > 0;
        }

        private bool ShouldSerializeISSQNTot()
        {
            return ISSQNTot.VBC > 0 || ISSQNTot.VISS > 0 ||
                   ISSQNTot.VPIS > 0 || ISSQNTot.VCOFINS > 0 ||
                   ISSQNTot.VPISST > 0 || ISSQNTot.VCOFINSST > 0;
        }

        private bool ShouldSerializeDescAcrEntr()
        {
            return DescAcrEntr.VDescSubtot > 0 || DescAcrEntr.VAcresSubtot > 0;
        }

        #endregion Methods
    }
}