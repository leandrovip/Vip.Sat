using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum RegTribIssqn
    {
        [DFeEnum("0")] Nenhum,
        [DFeEnum("1")] MicroempresaMunicipal,
        [DFeEnum("2")] Estimativa,
        [DFeEnum("3")] SociedadeProfissionais,
        [DFeEnum("4")] Cooperativa,
        [DFeEnum("5")] MEI,
        [DFeEnum("6")] MEEPP
    }
}