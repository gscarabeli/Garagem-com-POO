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
    public partial class frmHome : Form
    {
        SoundPlayer fundo = new SoundPlayer(@"E:\FESA\EC3\POO\Meus Exercícios\N2 - 2º Bimestre (EC3)\archive\10 - Bandoleros - The Fast  The Furious Tokyo Drift Soundtrack.wav");
        public frmHome()
        {
            this.Activate();
            InitializeComponent();

            fundo.Load();
            fundo.PlayLooping();
        }

        private async void btnFechar_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            btnFechar.Visible = false;
            btnCadastrar.Visible = false;
            lblTitulo.Visible = false;
            pcbLambo.Visible = true;
            SoundPlayer saida = new SoundPlayer(@"E:\FESA\EC3\POO\Meus Exercícios\N2 - 2º Bimestre (EC3)\archive\Chamillionaire - Ridin Dirty.wav");
            saida.Load();
            saida.PlayLooping();
            await Task.Delay(22000);
            this.Close();
            fundo.Stop();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            frmVeiculos frmVeiculos = new frmVeiculos();
            frmVeiculos.Show();
            this.Hide();
        }

    }
}
