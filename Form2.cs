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
    public partial class GAME : Form
    {

        String[] arrayletras = new String[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        int count = 0;
        public GAME()
        {
            InitializeComponent();
        }

        private void GAME_Load(object sender, EventArgs e)
        {
            MAIN.Focus();
            SpeechSynthesizer _ss = new SpeechSynthesizer();
            _ss.Speak("PARA EMPEZAR VAMOS A CONOCER EL TECLADO, PULSA LAS TECLAS EN ORDEN ALFAVETICO SEGUN SE MENCIONEN, EN CASO DE EQUIVOCARTE E VOLVERA A REPETIR LA LETRA, PARA TERMINAR COMPLETA EL ABECEDARIO O PULSA ESPACIO");
            textBox1.Text = "Para empezar, vamos a conocer el teclado, pulsa las teclas en orden alfabético según se mencionen, en caso de equivocarte e volverá a repetir la letra, para terminar completa el abecedario o pulsa espacio.";
            _ss.Speak("Empezemos");

            gameon();
        }

        private void MAIN_TextChanged(object sender, EventArgs e)
        {
            gameon();
            MAIN.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        public void gameon()
        {
            SpeechSynthesizer _ss = new SpeechSynthesizer();

            if (MAIN.Text == " ")
            {
               

                Form3 f = new Form3();
                Hide();
                f.Show();
            }
            else
            {
                if (MAIN.Text == arrayletras[count])
                {
                    textBox2.Text = (textBox2.Text.ToString() + " " +  arrayletras[count].ToString());
                    count++;
                    if (count >= 25)
                    {
                        _ss.Speak("muy bien ahora puedes pasar a jugar en otro modo para seguir practicando");
                        Form3 f = new Form3();
                        Hide();
                        f.Show();
                    }
                    else
                    {
                        _ss.Speak(arrayletras[count].ToString());
                    }
                    
                    
                }
                else
                {
                    if(count == 0)
                    {
                        _ss.Speak(arrayletras[count].ToString());
                    }
                    else
                    {
                        if(MAIN.Text == "" )
                        {

                        }
                        else
                        {
                            _ss.Speak(arrayletras[count].ToString());
                        }
                        
                    }
                   
                }
            }
        }

       
    }
}
