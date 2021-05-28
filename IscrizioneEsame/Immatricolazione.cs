using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class Immatricolazione
    {
        public string Matricola { get; set; }
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea corsoLaurea { get; set; }
        public Fuoricorso FuoriCorso { get; set; }
        //public Corso Esami { get; set; } = new Corso();
        public int CFUaccumulati { get ; set; }
        public enum Fuoricorso
        {
            si,
            no
        }
        public Immatricolazione(string matricola,int cfu,DateTime inizio,CorsoDiLaurea l,Fuoricorso fuori)
        {
            Matricola = matricola;
            CFUaccumulati = cfu;
            DataInizio = inizio;
            corsoLaurea = l;
            FuoriCorso = fuori;


        }
        public string InfoMatricola()
        {
            return $"Matricola: {Matricola}\n CFU: {CFUaccumulati} \n Corso di laurea in :{corsoLaurea} \nFuoricorso: {FuoriCorso}";
        }
    }
}
