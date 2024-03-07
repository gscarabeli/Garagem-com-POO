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
    public partial class frmMarcaModelo : Form
    {
        SoundPlayer fundo = new SoundPlayer(@"E:\FESA\EC3\POO\Meus Exercícios\N2 - 2º Bimestre (EC3)\archive\Eminem - Lose Yourself (Lyrics).wav");

        public Marca trazMarcas;
        public frmMarcaModelo()
        {
            InitializeComponent();
            this.Activate();
            fundo.Load();
            fundo.PlayLooping();

            foreach (Marca trazMarcas in BancoDados.marcas)
            {
                cbMarca.Items.Add(trazMarcas.descricao);
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoMarca.Text) || string.IsNullOrEmpty(txtDescricaoMarca.Text))
                {
                    throw new Exception("Você deve fornecer todas as informações");
                }
                else 
                {
                    Marca m = new Marca();
                    m.codigo = Convert.ToInt32(txtCodigoMarca.Text);
                    m.descricao = txtDescricaoMarca.Text;
                    BancoDados.marcas.Add(m);
                    cbMarca.Items.Add(m.descricao);

                    txtMensagens.Text += $"m{m.codigo} = {{{m.codigo} - {m.descricao}}}" + Environment.NewLine
                        + "-------------------------------------------------------------"
                        + Environment.NewLine;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            txtCodigoMarca.Clear();
            txtDescricaoMarca.Clear();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoModelo.Text) || string.IsNullOrEmpty(txtDescricaoModelo.Text) || string.IsNullOrEmpty(cbMarca.Text))
                {
                    throw new Exception("Você deve fornecer todas as informações");
                }
                else
                {
                    Modelo mod = new Modelo();
                    Marca m = new Marca();
                    mod.codigo = Convert.ToInt32(txtCodigoModelo.Text);
                    mod.descricao = txtDescricaoModelo.Text;
                    mod.descMarca = cbMarca.Text;
                    m.descricao = cbMarca.Text;
                    BancoDados.modelos.Add(mod);

                    txtMensagens.Text += $"Mo{mod.codigo} = {{{mod.codigo} - {mod.descricao} - m{BancoDados.CodigoMarca(m.descricao)}}}" + Environment.NewLine
                        + "-------------------------------------------------------------"
                        + Environment.NewLine;

                    txtCodigoModelo.Clear();
                    txtDescricaoModelo.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            frmVeiculos frmVeiculos = new frmVeiculos();
            frmVeiculos.Show();
            this.Close();
        }

        private void btnTrazMarcas_Click(object sender, EventArgs e)
        {
            txtMensagens.Clear();
            foreach (Marca pegaMarca in BancoDados.marcas)
            {
                txtMensagens.Text += $"m{pegaMarca.codigo} = {{{pegaMarca.codigo} - {pegaMarca.descricao}}}" + Environment.NewLine
                    + "-------------------------------------------------------------"
                    + Environment.NewLine;
            }
        }

        private void btnTrazModelos_Click(object sender, EventArgs e)
        {
            txtMensagens.Clear();
            Marca m = new Marca();
            m.descricao = cbMarca.Text;
            foreach (Modelo pegaModelo in BancoDados.modelos)
            {
                if (pegaModelo.descMarca == cbMarca.Text)
                {
                    txtMensagens.Text += $"Mo{pegaModelo.codigo} = {{{pegaModelo.codigo} - {pegaModelo.descricao} - m{BancoDados.CodigoMarca(m.descricao)}}}" + Environment.NewLine
                    + "-------------------------------------------------------------"
                    + Environment.NewLine;
                }
            }

        }
    }
}
