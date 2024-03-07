using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace N2___2º_Bimestre__EC3_
{
    public partial class frmVeiculos : Form
    {
        #region Listas e Objetos
        List<Veiculo> veiculos = new List<Veiculo>();

        public Modelo trazModelos;
        Modelo mod = new Modelo();

        List<Carro> carros = new List<Carro>();
        Carro c = new Carro();

        List<Caminhao> caminhoes = new List<Caminhao>();
        Caminhao cam = new Caminhao();

        List<Onibus> onibus = new List<Onibus>();
        Onibus on = new Onibus();

        List<Moto> motos = new List<Moto>();
        Moto m = new Moto();

        List<Aviao> avioes = new List<Aviao>();
        Aviao av = new Aviao();

        List<AviaoGuerra> avioesGuerra = new List<AviaoGuerra>();
        AviaoGuerra avg = new AviaoGuerra();

        List<Trem> trens = new List<Trem>();
        Trem t = new Trem();

        List<Navio> navios = new List<Navio>();
        Navio n = new Navio();

        List<NavioGuerra> naviosGuerra = new List<NavioGuerra>();
        NavioGuerra ng = new NavioGuerra();

        List<CaminhaoCegonheira> caminhoesCegonha = new List<CaminhaoCegonheira>();
        CaminhaoCegonheira camceg = new CaminhaoCegonheira();

        SoundPlayer fundo = new SoundPlayer(@"E:\FESA\EC3\POO\Meus Exercícios\N2 - 2º Bimestre (EC3)\archive\French Montana - Writing on the Wall (Audio) ft. Post Malone, Cardi B, Rvssian.wav");
        #endregion
        public frmVeiculos()
        {
            InitializeComponent();
            this.Activate();
            fundo.Load();
            fundo.PlayLooping();

            foreach (Modelo trazModelos in BancoDados.modelos)
            {
                cbModelo.Items.Add(trazModelos.descricao);
            }

            cbTipo.Items.Add("Carro");
            cbTipo.Items.Add("Caminhão");
            cbTipo.Items.Add("Ônibus");
            cbTipo.Items.Add("Moto");
            cbTipo.Items.Add("Avião");
            cbTipo.Items.Add("Avião de Guerra");
            cbTipo.Items.Add("Trem");
            cbTipo.Items.Add("Navio");
            cbTipo.Items.Add("Navio de Guerra");
            cbTipo.Items.Add("Caminhão Cegonheira");

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtMensagens.Clear();
            foreach (Veiculo v in veiculos)
            {
                txtMensagens.Text += v.tipo + " - " + v.identificacao + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
        }

        private void btnVoltaCadastro_Click(object sender, EventArgs e)
        {
            tbVeiculos.Visible = false;

            cbTipo.Visible = true;
            txtNome.Visible = true;
            cbModelo.Visible = true;
            txtVelocidadeAtual.Visible = true;
            txtPesoDoVeiculo.Visible = true;
            lblTipo.Visible = true;
            lblNome.Visible = true;
            lblModelo.Visible = true;
            lblVelocidadeAtual.Visible = true;
            lblPesoDoVeiculo.Visible = true;
            btnCriaMarcaModelo.Visible = true;
            btnCriarVeiculo.Visible = true;

            btnVoltaCadastro.Visible = false;


            txtNome.Clear();
            txtVelocidadeAtual.ResetText();
            txtPesoDoVeiculo.ResetText();
            txtQtdPortasCar.ResetText();
            txtCapaPassCar.ResetText();

            txtQtdEixosCam.ResetText();
            txtPesoCarreCam.ResetText();
            txtCapaMaxCam.ResetText();
            txtCapaPassCam.ResetText();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        #region Veículos
        private void btnCriarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(Convert.ToString(txtPesoDoVeiculo.Value)) || string.IsNullOrEmpty(Convert.ToString(txtVelocidadeAtual.Value)) || string.IsNullOrEmpty(cbModelo.Text) || string.IsNullOrEmpty(cbTipo.Text))
                {
                    throw new Exception("Você deve fornecer todas as informações");
                }
                else
                {

                    if (cbTipo.Text == "Carro")
                    {
                        try
                        {
                            c.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            c.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            c.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                            c.tipo = cbTipo.Text;
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Caminhão")
                    {
                        try
                        {
                            cam.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            cam.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            cam.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                            cam.tipo = cbTipo.Text;
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }

                    else if (cbTipo.Text == "Ônibus")
                    {
                        try
                        {
                            on.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            on.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            on.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Moto")
                    {
                        try
                        {
                            m.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            m.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            m.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Avião")
                    {
                        try
                        {
                            av.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            av.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            av.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Avião de Guerra")
                    {
                        try
                        {
                            avg.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            avg.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            avg.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Trem")
                    {
                        try
                        {
                            t.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            t.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            t.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Navio")
                    {
                        try
                        {
                            n.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            n.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            n.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Navio de Guerra")
                    {
                        try
                        {
                            ng.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            ng.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            ng.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    else if (cbTipo.Text == "Caminhão Cegonheira")
                    {
                        try
                        {
                            camceg.identificacao = txtNome.Text;
                            mod.descricao = cbModelo.Text;
                            camceg.velocidadeAtual = Convert.ToDouble(txtVelocidadeAtual.Text);
                            camceg.peso = Convert.ToDouble(txtPesoDoVeiculo.Text);
                            camceg.tipo = cbTipo.Text;
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                        }
                    }
                    tbVeiculos.Visible = true;

                    cbTipo.Visible = false;
                    txtNome.Visible = false;
                    cbModelo.Visible = false;
                    txtVelocidadeAtual.Visible = false;
                    txtPesoDoVeiculo.Visible = false;
                    lblTipo.Visible = false;
                    lblNome.Visible = false;
                    lblModelo.Visible = false;
                    lblVelocidadeAtual.Visible = false;
                    lblPesoDoVeiculo.Visible = false;
                    btnCriaMarcaModelo.Visible = false;
                    btnCriarVeiculo.Visible = false;

                    btnVoltaCadastro.Visible = true;

                    txtMensagens.Text += "*Carcaça do Veículo Montada*" + Environment.NewLine
                            + "----------------------------------------------------------"
                            + Environment.NewLine;

                    btnCriarCar.Visible = true;
                    lblQtdPortasCar.Visible = true;
                    lblCapaPassCar.Visible = true;
                    txtQtdPortasCar.Visible = true;
                    txtCapaPassCar.Visible = true;
                    ckVeicOficial.Visible = true;

                    btnCriarCam.Visible = true;
                    lblCapaMaxCam.Visible = true;
                    lblCapaPassCam.Visible = true;
                    lblPesoCarreCam.Visible = true;
                    lblQtdEixosCam.Visible = true;
                    txtCapaMaxCam.Visible = true;
                    txtCapaPassCam.Visible = true;
                    txtPesoCarreCam.Visible = true;
                    txtQtdEixosCam.Visible = true;

                    lblCapaPassCC.Visible = true;
                    txtCapaPassCC.Visible = true;
                    btnCriarCamCeg.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCriaMarcaModelo_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            frmMarcaModelo frmMarcaModelo = new frmMarcaModelo();
            frmMarcaModelo.Show();
            this.Close();
        }
        #endregion

        #region Carro
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            c.desligaLimpador = false;
            c.ligaLimpador = true;

            txtMensagens.Text += c.ligaDesligaLimpador() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            c.ligaLimpador = false;
            c.desligaLimpador = true;

            txtMensagens.Text += c.ligaDesligaLimpador() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += c.Acelera() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;

        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (c.velocidadeAtual < 1)
                {
                    throw new Exception("Não é mais possível diminuir a velocidade");
                }
                else
                {
                    txtMensagens.Text += c.Desacelera() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;

            }
            else
            {
                c.veiculoOficial = false;

                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"{cbTipo.Text}: {c.identificacao} criado!" + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            btnCriarCar.Visible = false;
            lblQtdPortasCar.Visible = false;
            lblCapaPassCar.Visible = false;
            txtQtdPortasCar.Visible = false;
            txtCapaPassCar.Visible = false;
            ckVeicOficial.Visible = false;
        }
        #endregion

        #region Caminhão
        private void btnLigaLimpadorCam_Click(object sender, EventArgs e)
        {
            cam.desligaLimpador = false;
            cam.ligaLimpador = true;

            txtMensagens.Text += cam.ligaDesligaLimpador() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnDesligaLimpadorCam_Click(object sender, EventArgs e)
        {
            cam.ligaLimpador = false;
            cam.desligaLimpador = true;

            txtMensagens.Text += cam.ligaDesligaLimpador() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnAcelerarCam_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += cam.Acelera() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }
        private void btnDesacelerarCam_Click(object sender, EventArgs e)
        {
            try
            {
                if (cam.velocidadeAtual < 1)
                {
                    throw new Exception("Não é mais possível diminuir a velocidade");
                }
                else
                {
                    txtMensagens.Text += cam.Desacelera() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        private void btnPagarPedagioCam_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += cam.pagarPedagio() + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnCriarCam_Click(object sender, EventArgs e)
        {
            try
            {
                cam.qtdEixos = Convert.ToInt32(txtQtdEixosCam.Value);
                cam.pesoCarregado = Convert.ToInt32(txtPesoCarreCam.Value);
                cam.capacidadeMaximaCarregavel = Convert.ToInt32(txtCapaMaxCam.Value);
                cam.capacidadePassageiros = Convert.ToInt32(txtCapaPassCam.Value);
                caminhoes.Add(cam);
                veiculos.Add(cam);

                txtMensagens.Text += $"{cbTipo.Text}: {cam.identificacao} criado!" + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            btnCriarCam.Visible = false;
            lblQtdEixosCam.Visible = false;
            lblCapaPassCam.Visible = false;
            lblCapaMaxCam.Visible = false;
            lblPesoCarreCam.Visible = false;
            txtQtdEixosCam.Visible = false;
            txtCapaPassCam.Visible = false;
            txtCapaMaxCam.Visible = false;
            txtPesoCarreCam.Visible = false;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += cam.Carregar(Convert.ToDouble(txtpesoMais.Value)) + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += cam.Descarregar(Convert.ToDouble(0)) + Environment.NewLine
                + "----------------------------------------------------------"
                + Environment.NewLine;
        }
        #endregion
        /*
        #region Ônibus
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Moto
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Avião
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Avião de Guerra
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Trem
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Navio
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion

        #region Navio de Guerra
        private void btnLigaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.ligaLimpador = true;
            c.ligaDesligaLimpador();

            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnDesligaLimpadorCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            c.desligaLimpador = true;
            c.ligaDesligaLimpador();

            txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                + "--------------------------------------------------";
        }

        private void btnAcelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            foreach (var v in veiculos)
            {
                txtMensagens.Text += c.Acelera() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        private void btnDesacelerarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            txtMensagens.Text += c.Desacelera() + Environment.NewLine
                + "--------------------------------------------------";

        }
        private void btnPagarPedagioCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();

            if (ckVeicOficial.Checked == true)
            {
                c.veiculoOficial = true;

                foreach (var cs in carros)
                {
                    txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                        + "--------------------------------------------------";
                }
            }
            else
                c.veiculoOficial = false;

            foreach (var cs in carros)
            {
                txtMensagens.Text += c.pagarPedagio() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }

        private void btnCriarCar_Click(object sender, EventArgs e)
        {
            Carro c = new Carro();
            try
            {
                if (ckVeicOficial.Checked == true)
                    c.veiculoOficial = true;
                else
                    c.veiculoOficial = false;

                c.qtdPortas = Convert.ToInt32(txtQtdPortasCar.Value);
                c.capacidadePassageiros = Convert.ToInt32(txtCapaPassCar.Value);
                c.veiculoOficial = ckVeicOficial.Checked;
                carros.Add(c);
                veiculos.Add(c);

                txtMensagens.Text += $"Veículo: {c.identificacao}"
                    + Environment.NewLine
                    + $"Modelo: {c.modelo.descricao}"
                    + Environment.NewLine
                    + $"Velocidade Atual: {c.velocidadeAtual}"
                    + Environment.NewLine
                    + $"Peso: {c.peso}"
                    + Environment.NewLine
                    + $"Qtd Portas: {c.qtdPortas}"
                    + Environment.NewLine
                    + $"Capacidade de Passageiros: {c.capacidadePassageiros}"
                    + Environment.NewLine
                    + $"Veículo oficial: {c.veiculoOficial}"
                    + Environment.NewLine
                    + "--------------------------------------------------";
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }
            foreach (var cs in carros)
            {
                txtMensagens.Text += c.desligaLimpador.ToString() + Environment.NewLine
                    + "--------------------------------------------------";
            }
        }
        #endregion
        */
        #region Caminhão Cegonheira
        private void btnCriarCamCeg_Click(object sender, EventArgs e)
        {
            try
            {
                camceg.capacidadePassageiros = Convert.ToInt32(txtCapaPassCC.Value);
                caminhoesCegonha.Add(camceg);
                veiculos.Add(camceg);

                txtMensagens.Text += $"{cbTipo.Text}: {camceg.identificacao} criado!" + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
            catch (Exception erro)
            {
                txtMensagens.Text += erro.Message;
            }

            foreach (Carro trazCarros in carros)
            {
                cbVeiculos.Items.Add(trazCarros.identificacao);
            }

            lblCapaPassCC.Visible = false;
            txtCapaPassCC.Visible = false;
            btnCriarCamCeg.Visible = false;
        }
        private void btnCarregarCegonha_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{camceg.CarregarPeso()}");
        }
        #endregion

        private void btnCarregarVeic_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += $"Veículo: {cbVeiculos.Text} foi empilhado" + camceg.CarregarVeiculo(c) + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
        }

        private void btnDescarregaVeic_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += $"Veículo: {cbVeiculos.Text} foi descarregado" + camceg.DescarregarVeiculo() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
        }
        private void btnDescarregaTudo_Click(object sender, EventArgs e)
        {
            txtMensagens.Text += camceg.Descarregar() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
        }

        private void btnListarCegonha_Click(object sender, EventArgs e)
        {
            txtMensagens.Clear();
            txtMensagens.Text += camceg.Lista();
        }

        private void btnAtacarTudo_Click(object sender, EventArgs e)
        {
            foreach(Veiculo veiculo in veiculos)
            {
                if (veiculo is IAtacar)
                {
                    txtMensagens.Text += (veiculo as IAtacar).Atacar() + Environment.NewLine
                        + "----------------------------------------------------------"
                        + Environment.NewLine;                    
                }
            }
        }

        private void btnAtracarTudo_Click(object sender, EventArgs e)
        {
            foreach (Navio n in navios)
            {
                txtMensagens.Text += n.Atracar() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }

            foreach (NavioGuerra ng in naviosGuerra)
            {
                txtMensagens.Text += ng.Atracar() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
        }

        private void btnEmpinarTudo_Click(object sender, EventArgs e)
        {
            foreach (Moto moto in motos)
            {
                txtMensagens.Text += m.Empinar() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
        }

        private void btnLimpaTudo_Click(object sender, EventArgs e)
        {
            foreach (ILimpador veiculo in veiculos)
            {
                txtMensagens.Text += c.ligaDesligaLimpador() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;

                txtMensagens.Text += cam.ligaDesligaLimpador() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;

                txtMensagens.Text += on.ligaDesligaLimpador() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;

                txtMensagens.Text += av.ligaDesligaLimpador() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;

                txtMensagens.Text += t.ligaDesligaLimpador() + Environment.NewLine
                    + "----------------------------------------------------------"
                    + Environment.NewLine;
            }
        }
    }
}
