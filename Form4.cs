using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace symebral
{
    public partial class Form4 : Form
    {
        #region PALABRAS
        String[] arrayletras = new String[] {"Actor",
"admirador",
"afinidad",
"altitud",
"amistad",
"animosidad",
"arancel",
"ascensor",
"asesor",
"astral",
"atril",
"azul",
"barbaridad",
"bimestral",
"binocular",
"bondad",
"borrador",
"brevedad",
"cabezal",
"caducidad",
"calor",
"cantor",
"cañaveral",
"capacidad",
"capataz",
"capaz",
"capital",
"caridad",
"cartel",
"cascabeL",
"cavidad",
"central",
"color",
"comedor",
"compresor",
"continental",
"corcel",
"corral",
"costillar",
"cental",
"despertador",
"director",
"doblez",
"doctor",
"dolor",
"editor",
"emprendedor",
"escolar",
"esencial",
"febril",
"feliz",
"fragilidad",
"frivolidad",
"general",
"generosidad",
"gratitud",
"hexagonal",
"hotel",
"humedad",
"inmoral",
"integridad",
"jocosidad",
"juventud",
"latitud",
"letal",
"legitimidad",
"luminosidad",
"lugar",
"maldad",
"mantel",
"mayor",
"mejor",
"mental",
"moral",
"mortal",
"motor",
"mujer",
"mural",
"musical",
"natural",
"naturalidad",
"nariz",
"narrador",
"necedad",
"necesidad",
"obesidad",
"papel",
"pared",
"pastel",
"personal",
"poder",
"portal",
"principal",
"Reloj",
"rectangular",
"salvador",
"sanidad",
"sector",
"solar",
"tambor",
"temblor",
"terminal",
"transmisor",
"ultramar",
"unidad",
"universal",
"universidad",
"urbanidad",
"usted",
"Vapor",
"vecindad",
"veracidad",
"veraz",
"verdad",
"virtud",
"administrar",
"admirador",
"adoptar",
"adorar",
"afectar",
"alcanzar",
"animar",
"aniquilar",
"anticipar",
"ascender",
"atender",
"borrar",
"bostezar",
"cansar",
"calentar",
"comer",
"cantar",
"cazar",
"cepillar",
"circular",
"colocar",
"combatir",
"compensar",
"competir",
"consolar",
"contener",
"cruzar",
"dejar",
"depositar",
"descansar",
"desesperar",
"dominar",
"dramatizar",
"dudar",
"edificar",
"embarcar",
"empezar",
"encantar",
"encasillar",
"encontrar",
"enfocar",
"ensillar",
"entrometer",
"esconder",
"escribir",
"establecer",
"estipular",
"evadir",
"explorar",
"facilitar",
"favorecer",
"ganar",
"garantizar",
"generar",
"girar",
"hablar",
"hacer",
"humedecer",
"hundir",
"iluminar",
"implicar",
"importar",
"intentar",
"interpretar",
"intrigar",
"jalar",
"jugar",
"juntar",
"jurar",
"justificar",
"levantar",
"llamar",
"llegar",
"llevar",
"mandar",
"mentir",
"mirar",
"mudar",
"ocupar",
"ofender",
"ofrecer",
"ofrendar",
"parecer",
"patinar",
"pedir"};


        #endregion
        int count = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer _ss = new SpeechSynthesizer();
            _ss.Speak("ESCRIBE LAS PALABRAS SEGUN SE MENCIONEN, EN CASO DE EQUIVOCARTE E VOLVERA A REPETIR LA PALABRA, PARA TERMINAR PULSA ESPACIO");
            textBox1.Text = "Escribe las palabras según se mencionen, en caso de equivocarte se volverá a repetir la palabra, para terminar pulsa espacio.";
            _ss.Speak("Empezemos");
            gameon();
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
                textBox2.Text = arrayletras[count].ToString();
                
                if (MAIN.Text.ToString().Length == arrayletras[count].ToString().Length)
                {
                    if(MAIN.Text == arrayletras[count])
                    {
                        if(count >= 8)
                        {
                            count = 0;
                        }
                        count++;
                        _ss.Speak(arrayletras[count].ToString());
                        MAIN.Text = "";
                    }
                    else
                    {
                        if (count == 0)
                        {
                            _ss.Speak(arrayletras[count].ToString());
                            
                        }
                        else
                        {
                            if (MAIN.Text == "")
                            {

                            }
                            else
                            {
                                _ss.Speak(arrayletras[count].ToString());
                                MAIN.Text = "";
                            }
                        }
                    }
                }
                else 
                {
                    if(count == 0 && MAIN.Text == "")
                    {
                        _ss.Speak(arrayletras[count].ToString());
                    }
                    

                }

            }
        }

        private void MAIN_TextChanged(object sender, EventArgs e)
        {
            gameon();
        }
    }

}
