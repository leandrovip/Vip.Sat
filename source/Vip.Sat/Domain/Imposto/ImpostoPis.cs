using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    public sealed class ImpostoPIS : GenericClone<ImpostoPIS>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeItem(typeof(ImpostoPisAliq), "PISAliq")]
        [DFeItem(typeof(ImpostoPisNt), "PISNT")]
        [DFeItem(typeof(ImpostoPisOutr), "PISOutr")]
        [DFeItem(typeof(ImpostoPisQtde), "PISQtde")]
        [DFeItem(typeof(ImpostoPisSn), "PISSN")]
        public ICFePis Pis { get; set; }

        #endregion Properties
    }
}