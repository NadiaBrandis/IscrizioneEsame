using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class Corso
    {
        public string NomeCorso { get; set; }
        public int CFUcorso { get; set; }
        public Corso(string nomeCorso,int cfu)
        {
            CFUcorso = cfu;
            NomeCorso = nomeCorso;
        }
        public Corso()
        {

        }
        public string InfoCorso()
        {
            return $"{NomeCorso}, {CFUcorso}";
        }
    }
}
