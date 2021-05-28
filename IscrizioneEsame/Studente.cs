using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime AnnoNascita { get; set; }
        public Immatricolazione immatricolazione { get; set; }
        public List<Esame> Esami { get  ;  set; }=new List<Esame>();

        
        public Studente(string nome,string cognome,DateTime anno,Immatricolazione imma, List<Esame> EsamiP)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = anno;
            immatricolazione = imma;
            Esami = EsamiP;
           
            
        }
        public String InfoStudente()
        {
            
                    return $"Studente: {Nome} {Cognome}\nNato il : {AnnoNascita}\nMatricola: {immatricolazione.Matricola}\n ";
               
           
        }

        public Studente()
        {
        }
        
    }
}
