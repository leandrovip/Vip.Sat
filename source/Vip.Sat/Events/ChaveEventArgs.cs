using System;

namespace Vip.Sat.Events
{
    /// <summary>
    ///     Class ChaveEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class ChaveEventArgs : EventArgs
    {
        /// <summary>
        ///     Gets or sets the chave.
        /// </summary>
        public string Chave { get; set; }
    }
}