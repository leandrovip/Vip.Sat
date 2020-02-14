using System;

namespace Vip.Sat.Events
{
    /// <summary>
    ///     Class EventoEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class EventoEventArgs : EventArgs
    {
        /// <summary>
        ///     Gets or sets the retorno.
        /// </summary>
        public string Retorno { get; set; }
    }
}