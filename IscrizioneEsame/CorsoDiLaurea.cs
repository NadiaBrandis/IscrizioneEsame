using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class CorsoDiLaurea
    {
        public string NomeCorsoDiLaurea { get; set; }
        public int AnniDiCorso { get; set; }
        public int CFUperLaurea { get; set; }
        public List<Corso> Corsi { get; set; } = new List<Corso>();
        public CorsoDiLaurea(string  nome,int anni,int cfu, List<Corso> listaCorsi)
        {
            NomeCorsoDiLaurea = nome;
            AnniDiCorso = anni;
            CFUperLaurea = cfu;
            Corsi = listaCorsi;



        }
        ////public enum CorsoLaurea
        //{
        //    matematica=0,
        //    fisica=1,
        //    informatica=2,
        //    ingegneria=3,
        //    lettere=4
        //}

    }
}
