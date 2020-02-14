using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    public sealed class ImpostoIcms : GenericClone<ImpostoIcms>, ICFeImposto
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeItem(typeof(ImpostoIcms00), "ICMS00")]
        [DFeItem(typeof(ImpostoIcms40), "ICMS40")]
        [DFeItem(typeof(ImpostoIcmsSn102), "ICMSSN102")]
        [DFeItem(typeof(ImpostoIcmsSn900), "ICMSSN900")]
        public ICFeIcms Icms { get; set; }

        #endregion Properties
    }
}