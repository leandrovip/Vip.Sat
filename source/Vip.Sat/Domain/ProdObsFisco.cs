using System.ComponentModel;
using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Serializer;
using Vip.Sat.Generics;

namespace Vip.Sat.Domain
{
    /// <summary>
    ///     Class ProdObsFisco. This class cannot be inherited.
    /// </summary>
    public sealed class ProdObsFisco : GenericClone<ProdObsFisco>, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        /// <summary>
        ///     Gets or sets the x campo det.
        /// </summary>
        [DFeAttribute("xCampoDet", Id = "I18A", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XCampoDet { get; set; }

        /// <summary>
        ///     Gets or sets the x texto det.
        /// </summary>
        [DFeElement(TipoCampo.Str, "xTextoDet", Id = "I19", Min = 1, Max = 60, Ocorrencia = Ocorrencia.Obrigatoria)]
        public string XTextoDet { get; set; }

        #endregion Properties
    }
}