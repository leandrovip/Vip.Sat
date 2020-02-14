using System;
using System.Text;
using Vip.Sat.Enum;
using Vip.Sat.Service;

namespace Vip.Sat.Settings
{
    public static class SatManager
    {
        public static ISatLibrary GetLibrary(ModeloSat modelo, SatConfig config, string pathDll, Encoding encoding)
        {
            switch (modelo)
            {
                case ModeloSat.Cdecl: return new SatCdecl(config, pathDll, encoding);
                case ModeloSat.StdCall: return new SatStdCall(config, pathDll, encoding);
                default: throw new NotImplementedException("Modelo não impementado !");
            }
        }
    }
}