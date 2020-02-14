using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum CodigoMP
    {
        [DFeEnum("01")] Dinheiro,
        [DFeEnum("02")] Cheque,
        [DFeEnum("03")] CartaodeCredito,
        [DFeEnum("04")] CartaodeDebito,
        [DFeEnum("05")] CreditoLoja,
        [DFeEnum("10")] ValeAlimentacao,
        [DFeEnum("11")] ValeRefeicao,
        [DFeEnum("12")] ValePresente,
        [DFeEnum("13")] ValeCombustivel,
        [DFeEnum("99")] Outros
    }
}