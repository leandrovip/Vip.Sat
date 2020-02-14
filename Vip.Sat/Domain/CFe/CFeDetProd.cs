using System.ComponentModel;
using System.Globalization;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Collection;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Enum;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeDetProd : DFeParentItem<CFeDetProd, CFe>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Fields

        private bool ehConbustivel;

        #endregion Fields

        #region Constructors

        public CFeDetProd()
        {
            ObsFiscoDet = new DFeCollection<ProdObsFisco>();
            EhCombustivel = false;
        }

        public CFeDetProd(CFe parent) : this()
        {
            Parent = parent;
        }

        #endregion Constructors

        #region Propriedades

        [DFeIgnore]
        public bool EhCombustivel
        {
            get => ehConbustivel;
            set
            {
                if (value == ehConbustivel) return;

                IndRegra = value ? IndRegra.Truncamento : IndRegra.Arredondamento;
                ehConbustivel = value;
            }
        }

        [DFeElement(TipoCampo.Str, "cProd", Id = "I02", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string CProd { get; set; }

        [DFeElement(TipoCampo.Str, "cEAN", Id = "I03", Min = 8, Max = 14, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CEAN { get; set; }

        [DFeElement(TipoCampo.Str, "xProd", Id = "I04", Min = 1, Max = 120, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XProd { get; set; }

        [DFeElement(TipoCampo.Str, "NCM", Id = "I05", Min = 2, Max = 8, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string NCM { get; set; }

        [DFeElement(TipoCampo.Str, "CEST", Id = "I05w", Min = 2, Max = 7, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string CEST { get; set; }

        [DFeElement(TipoCampo.StrNumberFill, "CFOP", Id = "I06", Min = 4, Max = 4, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string CFOP { get; set; }

        [DFeElement(TipoCampo.Str, "uCom", Id = "I07", Min = 1, Max = 6, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string UCom { get; set; }

        [DFeElement(TipoCampo.De4, "qCom", Id = "I08", Min = 5, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal QCom { get; set; }

        [DFeElement(TipoCampo.Custom, "vUnCom", Id = "I09", Min = 3, Max = 15, Ocorrencia = Ocorrencia.Obrigatoria)]
        public decimal VUnCom { get; set; }

        [DFeElement(TipoCampo.De2, "vProd", Id = "I10", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VProd { get; set; }

        [DFeElement(TipoCampo.Enum, "indRegra", Id = "I11", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public IndRegra IndRegra { get; set; }

        [DFeElement(TipoCampo.De2, "vDesc", Id = "I12", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VDesc { get; set; }

        [DFeElement(TipoCampo.De2, "vOutro", Id = "I13", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VOutro { get; set; }

        [DFeElement(TipoCampo.De2, "vItem", Id = "I14", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VItem { get; set; }

        [DFeElement(TipoCampo.De2, "vRatDesc", Id = "I15", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VRatDesc { get; set; }

        [DFeElement(TipoCampo.De2, "vRatAcr", Id = "I16", Min = 3, Max = 15, Ocorrencia = Ocorrencia.MaiorQueZero)]
        public decimal VRatAcr { get; set; }

        [DFeCollection("obsFiscoDet", Id = "I18", MinSize = 0, MaxSize = 500, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public DFeCollection<ProdObsFisco> ObsFiscoDet { get; set; }

        #endregion Propriedades

        #region Methods

        private bool ShouldSerializeCEST()
        {
            return Parent != null && Parent.InfCFe.Versao > 0.08M;
        }

        private string SerializeVUnCom()
        {
            var numberFormat = CultureInfo.InvariantCulture.NumberFormat;
            var format = ehConbustivel ? "{0:0.000}" : "{0:0.00}";
            return string.Format(numberFormat, format, VUnCom);
        }

        private object DeserializeVUnCom(string value)
        {
            var decimais = value.Split('.')[1];
            EhCombustivel = decimais.Length > 2;
            var numberFormat = CultureInfo.InvariantCulture.NumberFormat;
            return decimal.Parse(value, numberFormat);
        }

        #endregion Methods
    }
}