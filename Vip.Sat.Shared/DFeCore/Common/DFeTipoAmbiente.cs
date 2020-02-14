using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.DFeCore.Common
{
	/// <summary>
	///     Identificação do Ambiente
	///     <para>1 - Produção</para>
	///     <para>2 - Homologação</para>
	/// </summary>
	public enum DFeTipoAmbiente : byte
    {
	    /// <summary>
	    ///     Produção
	    /// </summary>
	    [DFeEnum("1")] [Description("Produção")]
        Producao = 1,

	    /// <summary>
	    ///     Homologação
	    /// </summary>
	    [DFeEnum("2")] [Description("Homologação")]
        Homologacao = 2
    }
}