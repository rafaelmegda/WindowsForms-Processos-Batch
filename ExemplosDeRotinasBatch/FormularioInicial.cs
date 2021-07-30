using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosDeRotinasBatch
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processo = new ProcessStartInfo();
            processo.FileName = "cmd.exe";
            Process startarProcesso = new Process();
            startarProcesso.StartInfo = processo;
            startarProcesso.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"C:\Usuario\Rafael\Desktop\arquivo.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String listaFavoritos = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            Process.Start("firefox.exe");
            Process.Start(listaFavoritos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startProcesso = new ProcessStartInfo("IExplore.exe");
            startProcesso.WindowStyle = ProcessWindowStyle.Minimized;
            startProcesso.Arguments = "www.google.com";
            Process.Start(startProcesso);
        }

        private void FormularioInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
