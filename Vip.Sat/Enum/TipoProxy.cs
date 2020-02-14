using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum TipoProxy
    {
        [DFeEnum("0")] None,
        [DFeEnum("1")] ProxyConfiguracao,
        [DFeEnum("2")] ProxyTransparente
    }
}