using System;

namespace Vip.Sat.DFeCore.Common
{
    [Flags]
    public enum DFeSaveOptions
    {
        None = 1 << 0,
        RemoveAccents = 1 << 1,
        RemoveSpaces = 1 << 2,
        DisableFormatting = 1 << 3,
        OmitDeclaration = 1 << 4
    }
}