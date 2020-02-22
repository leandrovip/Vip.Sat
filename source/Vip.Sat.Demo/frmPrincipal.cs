using System;
using System.Text;
using System.Windows.Forms;
using Vip.Sat.DFeCore.Common;
using Vip.Sat.Domain;
using Vip.Sat.Domain.CFe;
using Vip.Sat.Domain.Imposto;
using Vip.Sat.Enum;
using Vip.Sat.Service;

namespace Vip.Sat.Demo
{
    public partial class frmPrincipal : Form
    {
        private readonly CFeService cfeService = new CFeService();
        private CFe cfeAtual;

        public frmPrincipal()
        {
            InitializeComponent();
            ConfigurarDll();
        }

        private void GerarCfe()
        {
            var totalGeral = 0M;
            cfeAtual = cfeService.NewCFe();
            cfeAtual.InfCFe.Ide.NumeroCaixa = 1;
            cfeAtual.InfCFe.Dest.CPF = "";
            cfeAtual.InfCFe.Dest.Nome = "CONSUMIDOR";
            cfeAtual.InfCFe.Entrega.XLgr = "logradouro";
            cfeAtual.InfCFe.Entrega.Nro = "112233";
            cfeAtual.InfCFe.Entrega.XCpl = "complemento";
            cfeAtual.InfCFe.Entrega.XBairro = "bairro";
            cfeAtual.InfCFe.Entrega.XMun = "municipio";
            cfeAtual.InfCFe.Entrega.UF = "MS";
            for (var i = 0; i < 3; i++)
            {
                var det = cfeAtual.InfCFe.Det.AddNew();
                det.NItem = 1 + i;
                det.Prod.CProd = $"Vip{det.NItem:000}";
                det.Prod.CEAN = "7894900011531";
                det.Prod.XProd = "Coca cola";
                det.Prod.NCM = " 22021000";
                det.Prod.CFOP = "5102";
                det.Prod.UCom = "UN";
                det.Prod.QCom = 1;
                det.Prod.VUnCom = 120.00M;
                det.Prod.IndRegra = IndRegra.Arredondamento;
                det.Prod.VDesc = 0;

                var obs = new ProdObsFisco
                {
                    XCampoDet = "campo",
                    XTextoDet = "texto"
                };
                det.Prod.ObsFiscoDet.Add(obs);

                var totalItem = det.Prod.QCom * det.Prod.VUnCom;
                totalGeral += totalItem;
                det.Imposto.VItem12741 = totalItem * 0.12M;

                det.Imposto.Imposto = new ImpostoIcms
                {
                    Icms = new ImpostoIcms00
                    {
                        Orig = OrigemMercadoria.Nacional,
                        Cst = "00",
                        PIcms = 18
                    }
                };

                det.Imposto.Pis.Pis = new ImpostoPisAliq
                {
                    Cst = "01",
                    VBc = totalItem,
                    PPis = 0.0065M
                };

                det.Imposto.Cofins.Cofins = new ImpostoCofinsAliq
                {
                    Cst = "01",
                    VBc = totalItem,
                    PCofins = 0.0065M
                };

                det.InfAdProd = "Informacoes adicionais";
            }

            cfeAtual.InfCFe.Total.DescAcrEntr.VDescSubtot = 0;
            cfeAtual.InfCFe.Total.VCFeLei12741 = 1.23M;

            var pgto1 = cfeAtual.InfCFe.Pagto.Pagamentos.AddNew();
            pgto1.CMp = CodigoMP.CartaodeCredito;
            pgto1.VMp = totalGeral / 2;
            pgto1.CAdmC = 999;

            var pgto2 = cfeAtual.InfCFe.Pagto.Pagamentos.AddNew();
            pgto2.CMp = CodigoMP.Dinheiro;
            pgto2.VMp = totalGeral / 2 + 10;

            cfeAtual.InfCFe.InfAdic.InfCpl = "Documento emitido pelo Vip.Sat";

            webBrowser1.LoadXml(cfeAtual.GetXml());
        }

        private void ConfigurarDll()
        {
            cfeService.Configuracoes.EmitCNPJ = "61099008000141";
            cfeService.Configuracoes.EmitIE = "111111111111";
            cfeService.Configuracoes.EmitIM = "0";
            cfeService.Configuracoes.EmitCRegTrib = RegTrib.Normal;
            cfeService.Configuracoes.EmitCRegTribISSQN = RegTribIssqn.Nenhum;
            cfeService.Configuracoes.EmitIndRatISSQN = RatIssqn.Nao;

            cfeService.Configuracoes.InfCFeVersaoDadosEnt = 0.07m;
            cfeService.PathDll = @"D:\RepositorioComponentes\Vip.Sat\source\Vip.Sat.Demo\bin\Debug\dllsat.dll";
            cfeService.CodigoAtivacao = "123456789";
            cfeService.Modelo = ModeloSat.StdCall;

            cfeService.Configuracoes.IdeNumeroCaixa = 1;
            cfeService.Configuracoes.IdeTpAmb = DFeTipoAmbiente.Homologacao;
            cfeService.Configuracoes.IdeCNPJ = "16716114000172";
            cfeService.SignAC = "SGR-SAT SISTEMA DE GESTAO E RETAGUARDA DO SAT";

            cfeService.Configuracoes.IsUtf8 = true;
            cfeService.Encoding = Encoding.UTF8;
            cfeService.Configuracoes.RemoverAcentos = true;
        }

        private void btnGerarCFe_Click(object sender, EventArgs e)
        {
            GerarCfe();
        }

        private void btnEnviarCFe_Click(object sender, EventArgs e)
        {
            //if (!cfeService.Ativo) ToogleInitialize();
            cfeService.Ativar();
            var ret = cfeService.EnviarDadosVenda(cfeAtual);
            if (ret.CodigoDeRetorno != 6000)
                return;

            cfeAtual = ret.Venda;
            var teste = cfeAtual.GetQRCode();

            webBrowser1.LoadXml(ret.Venda.GetXml());
        }
    }
}