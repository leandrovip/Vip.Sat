using Vip.Sat.DFeCore.Attributes;

namespace Vip.Sat.Enum
{
    public enum SegSemFio
    {
        [DFeEnum("")] None,
        [DFeEnum("WEP")] Wep,
        [DFeEnum("WPA-PERSONAL")] WpaPersonal,
        [DFeEnum("WPA-ENTERPRISE")] WpaEnterprise
    }
}