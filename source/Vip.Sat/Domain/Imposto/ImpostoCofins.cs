using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    public sealed class ImpostoCofins : GenericClone<ImpostoCofins>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeItem(typeof(ImpostoCofinsAliq), "COFINSAliq")]
        [DFeItem(typeof(ImpostoCofinsNt), "COFINSNT")]
        [DFeItem(typeof(ImpostoCofinsOutr), "COFINSOutr")]
        [DFeItem(typeof(ImpostoCofinsQtde), "COFINSQtde")]
        [DFeItem(typeof(ImpostoCofinsSn), "COFINSSN")]
        public ICFeCofins Cofins { get; set; }

        #endregion Properties
    }
}