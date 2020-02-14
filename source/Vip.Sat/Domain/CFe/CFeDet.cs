using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Collection;
using Vip.Sat.DFeCore.Serializer;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeDet : DFeParentItem<CFeDet, CFe>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Fields

        private CFeDetProd prod;

        #endregion Fields

        #region Constructors

        public CFeDet()
        {
            Imposto = new CFeDetImposto();
            Prod = new CFeDetProd();
        }

        public CFeDet(CFe parent) : this()
        {
            Parent = parent;
            Prod = new CFeDetProd(Parent);
        }

        #endregion Constructors

        #region Propriedades

        [DFeAttribute(TipoCampo.Int, "nItem", Id = "H02", Min = 1, Max = 3, Ocorrencia = Ocorrencia.Obrigatoria)]
        public int NItem { get; set; }

        [DFeElement("prod", Id = "I01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public CFeDetProd Prod
        {
            get => prod;
            set
            {
                prod = value;
                if (prod.Parent != Parent)
                    prod.Parent = Parent;
            }
        }

        [DFeElement("imposto", Id = "M01", Ocorrencia = Ocorrencia.Obrigatoria)]
        public CFeDetImposto Imposto { get; set; }

        [DFeElement(TipoCampo.Str, "infAdProd", Id = "V01", Min = 1, Max = 500, Ocorrencia = Ocorrencia.NaoObrigatoria)]
        public string InfAdProd { get; set; }

        #endregion Propriedades

        #region Methods

        protected override void OnParentChanged()
        {
            Prod.Parent = Parent;
        }

        #endregion Methods
    }
}