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
using System.Reflection;

namespace symebral
{
    public partial class Form3 : Form
    {

        bool opcion1 = false;
        public Form3()
        {
            InitializeComponent();
            MAIN.KeyDown += new KeyEventHandler(apretarTecla);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer _ss = new SpeechSynthesizer();
            _ss.Speak("selecciona el modo de juego con espacio, despues pulsa enter para entrar");
            MAIN.Focus();
            SendKeys.Send(" ");
        }

        void apretarTecla(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                opcion1 = !opcion1;
            }
            SpeechSynthesizer _ss = new SpeechSynthesizer();


            if (opcion1)
            {
                if (e.KeyCode == Keys.Space)
                {
                    _ss.Speak("Modo normal, escribe las palabras segun se escuchen");
                }
                   
                if (e.KeyCode == Keys.Enter)
                {
                    Form4 f = new Form4();
                    Hide();
                    f.Show();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    _ss.Speak("Modo PRACTICA, Escribe el abecedario segun se escuchen las letras");
                }
                   
                if (e.KeyCode == Keys.Enter)
                {
                    GAME f = new GAME();
                    Hide();
                    f.Show();
                }
            }
        }

        private void MAIN_TextChanged(object sender, EventArgs e)
        {
         
        }

    }
}
