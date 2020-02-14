using System;

namespace Vip.Sat.Events
{
    /// <summary>
    ///     Class NumeroSessaoEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class NumeroSessaoEventArgs : EventArgs
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NumeroSessaoEventArgs" /> class.
        /// </summary>
        public NumeroSessaoEventArgs(int sessao)
        {
            Sessao = sessao;
        }

        /// <summary>
        ///     Gets or sets the sessao.
        /// </summary>
        public int Sessao { get; set; }
    }
}