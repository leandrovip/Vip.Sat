using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Vip.Sat.Domain.CFeCanc;
using Vip.Sat.Extensions;

namespace Vip.Sat.Response
{
    /// <summary>
    ///     Classe que retorna a resposta do Sat quando usado o metodo de cancelamento.
    /// </summary>
    /// <seealso cref="SatResposta" />
    public sealed class CancelamentoSatResposta : SatResposta, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Constructors

        /// <summary>
        ///     Inicializar uma nova instancida da classe <see cref="CancelamentoSatResposta" />.
        /// </summary>
        public CancelamentoSatResposta(string retorno, Encoding encoding) : base(retorno, encoding)
        {
            if (CodigoDeRetorno != 7000 || RetornoLst.Count < 6) return;

            using (var stream = new MemoryStream(Convert.FromBase64String(RetornoLst[6]))) Cancelamento = CFeCanc.Load(stream, encoding);

            QRCode = $"{RetornoLst[8].OnlyNumbers()}|{RetornoLst[7]}|{RetornoLst[9]}|{RetornoLst[10]}|{RetornoLst[11]}";
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        ///     Retorna o cancelamento caso tenha ocorrido com sucesso.
        /// </summary>
        public CFeCanc Cancelamento { get; private set; }

        /// <summary>
        ///     Retorna o QRCode caso tenha sido realizado com sucesso.
        /// </summary>
        public string QRCode { get; private set; }

        #endregion Properties
    }
}