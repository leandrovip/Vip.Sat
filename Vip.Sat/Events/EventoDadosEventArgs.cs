using System;

namespace Vip.Sat.Events
{
    public sealed class EventoDadosEventArgs : EventArgs
    {
        #region Property

        public string Dados { get; set; }

        public string Retorno { get; set; }

        #endregion Property
    }
}