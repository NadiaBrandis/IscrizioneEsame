using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class Esame
    {
        public Corso corsoLaurea { get; set; }
        public Passato EsamePassato { get; set; }
        public enum Passato
        {
            si,
            no
        }
        public Esame(Corso corso,Passato passato)
        {
            corsoLaurea = corso;
            EsamePassato = passato;

        }
        public Esame()
        {

        }
    }
}
