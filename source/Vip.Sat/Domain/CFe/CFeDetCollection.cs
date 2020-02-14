using System.ComponentModel;
using Vip.Sat.DFeCore.Collection;

namespace Vip.Sat.Domain.CFe
{
    public sealed class CFeDetCollection : DFeParentCollection<CFeDet, CFe>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        public CFeDetCollection()
        {
            Parent = null;
        }

        public CFeDetCollection(CFe parent)
        {
            Parent = parent;
        }

        #endregion Constructors
    }
}