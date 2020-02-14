using System;

namespace Vip.Sat.Events
{
    /// <summary>
    ///     Class CalcPathEventEventArgs.
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public sealed class CalcPathEventEventArgs : EventArgs
    {
        /// <summary>
        ///     Gets or sets the dados.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     Gets or sets the retorno.
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public DateTime Data { get; set; }
    }
}