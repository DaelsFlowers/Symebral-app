using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace symebral
{
    public partial class SYMEBRAL : Form
    {
        public SYMEBRAL()
        {
            InitializeComponent();
        }

        private void SYMEBRAL_Load(object sender, EventArgs e)
        {
            MAIN.Focus();
            
        }

        private void MAIN_TextChanged(object sender, EventArgs e)
        {
            GAME g = new GAME();
            
            g.Show();
            Hide();
        }

        private void MAIN_Enter(object sender, EventArgs e)
        {
            SpeechSynthesizer _ss = new SpeechSynthesizer();
            _ss.Volume = 100;
            _ss.Rate = 1;
            _ss.Speak("BIENVENIDOS, PARA EMPEZAR A JUGAR PULSA CUALQUIER TECLA");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
