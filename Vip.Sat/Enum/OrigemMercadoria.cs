using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum OrigemMercadoria
    {
        [DFeEnum("0")] Nacional,
        [DFeEnum("1")] EstrangeiraImportacaoDireta,
        [DFeEnum("2")] EstrangeiraAdquiridaBrasil,
        [DFeEnum("3")] NacionalConteudoImportacaoSuperior40,
        [DFeEnum("4")] NacionalProcessosBasicos,
        [DFeEnum("5")] NacionalConteudoImportacaoInferiorIgual40,
        [DFeEnum("6")] EstrangeiraImportacaoDiretaSemSimilar,
        [DFeEnum("7")] EstrangeiraAdquiridaBrasilSemSimilar,
        [DFeEnum("8")] NacionalConteudoImportacaoSuperior70
    }
}