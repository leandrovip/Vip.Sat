using Vip.Sat.DFeCore.Attributes;
using Vip.Sat.DFeCore.Document;
using Vip.Sat.Domain.CFe;
using Vip.Sat.Extensions;

namespace Vip.Sat.Domain.CFeCanc
{
    [DFeRoot("CFeCanc")]
    public sealed class CFeCanc : DFeDocument<CFeCanc>
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="CFe" /> class.
        /// </summary>
        public CFeCanc()
        {
            InfCFe = new CancInfCFe();
            Signature = new DFeSignature();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CFeCanc" /> class.
        /// </summary>
        /// <param name="cfe">The cfe.</param>
        public CFeCanc(CFe.CFe cfe) : this()
        {
            InfCFe.ChCanc = $"CFe{cfe.InfCFe.Id.OnlyNumbers()}";
            InfCFe.Versao = cfe.InfCFe.Versao;
            InfCFe.Ide.CNPJ = cfe.InfCFe.Ide.CNPJ;
            InfCFe.Ide.SignAC = cfe.InfCFe.Ide.SignAC;
            InfCFe.Ide.NumeroCaixa = cfe.InfCFe.Ide.NumeroCaixa;
            InfCFe.Dest.CPF = cfe.InfCFe.Dest.CPF;
            InfCFe.Dest.CNPJ = cfe.InfCFe.Dest.CNPJ;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>
        ///     Gets or sets the inf c fe.
        /// </summary>
        /// <value>The inf c fe.</value>
        [DFeElement("infCFe", Ocorrencia = Ocorrencia.Obrigatoria)]
        public CancInfCFe InfCFe { get; set; }

        /// <summary>
        ///     Gets or sets the signature.
        /// </summary>
        /// <value>The signature.</value>
        public DFeSignature Signature { get; set; }

        #endregion Propriedades

        #region Methods

        /// <summary>
        ///     Retorna o valor do QrCode
        /// </summary>
        /// <returns>Código QrCode</returns>
        public string GetQRCode()
        {
            var documento = InfCFe.Dest.CNPJ.IsNullOrEmpty() ? InfCFe.Dest.CPF.OnlyNumbers() : InfCFe.Dest.CNPJ.OnlyNumbers();
            return $"{InfCFe.Id.OnlyNumbers()}|{InfCFe.Ide.DhEmissao:yyyyMMddHHmmss}|{InfCFe.Total.VCFe:0.00}|{documento}|{InfCFe.Ide.AssinaturaQrcode}";
        }

        private bool ShouldSerializeSignature()
        {
            return !Signature.SignatureValue.IsNullOrEmpty();
        }

        #endregion Methods
    }
}