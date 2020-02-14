using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Domain.Interfaces;
using Vip.Sat.Enum;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain.Imposto
{
    /// <summary>
    ///     Classe ImpostoICMS40. Classe para os imposto com Cst 40, 41, 50 ou 60.
    /// </summary>
    public sealed class ImpostoIcms40 : GenericClone<ImpostoIcms40>, ICFeIcms
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        [DFeElement(TipoCampo.Enum, "Orig", Id = "N06", Min = 1, Max = 1, Ocorrencia = Ocorrencia.Obrigatoria)]
        public OrigemMercadoria Orig { get; set; }

        [DFeElement(TipoCampo.Str, "CST", Id = "N07", Min = 2, Max = 2, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string Cst { get; set; }

        #endregion Properties
    }
}