using System;
using System.IO;
using System.Text;
using Vip.Sat.Domain.CFe;
using Vip.Sat.Domain.CFeCanc;
using Vip.Sat.Extensions;

namespace Vip.Sat.Response
{
    public sealed class ConsultaSessaoResposta : SatResposta
    {
        #region Constructors

        /// <inheritdoc />
        public ConsultaSessaoResposta(string retorno, Encoding encoding) : base(retorno, encoding)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (CodigoDeRetorno)
            {
                case 6000:
                    if (RetornoLst.Count < 6) return;

                    using (var stream = new MemoryStream(Convert.FromBase64String(RetornoLst[6])))
                        Venda = CFe.Load(stream, encoding);

                    QRCode = $"{RetornoLst[8].OnlyNumbers()}|{RetornoLst[7]}|{RetornoLst[9]}|{RetornoLst[10]}|{RetornoLst[11]}";
                    break;

                case 7000:
                    if (RetornoLst.Count < 6) return;

                    using (var stream = new MemoryStream(Convert.FromBase64String(RetornoLst[6])))
                        Cancelamento = CFeCanc.Load(stream, encoding);

                    QRCode = $"{RetornoLst[8].OnlyNumbers()}|{RetornoLst[7]}|{RetornoLst[9]}|{RetornoLst[10]}|{RetornoLst[11]}";
                    break;
            }
        }

        #endregion Constructors

        #region Properties

        public CFe Venda { get; private set; }

        public CFeCanc Cancelamento { get; set; }

        /// <summary>
        ///     Retorna o QRCode caso tenha sido realizado com sucesso.
        /// </summary>
        /// <value>The qr code.</value>
        public string QRCode { get; private set; }

        #endregion Properties
    }
}