using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum TipoLan
    {
        [DFeEnum("DHCP")] DHCP,
        [DFeEnum("PPPoE")] PPPoE,
        [DFeEnum("IPFIX")] IPFIX
    }
}