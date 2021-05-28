using System;
using System.Collections.Generic;
using System.Text;

namespace IscrizioneEsame
{
    public  class SegreteriaStudenti
    {
        public static List<Corso> CorsoMatematica = new List<Corso>();
        public static List<Corso> CaricaEsamiMatematica()
        {
            Corso c1 = new Corso("Geometria e Algebra", 8);
            Corso c2 = new Corso("Analisi 1", 5);
            Corso c3 = new Corso("Analisi 2", 2);
            CorsoMatematica.Add(c1);
            CorsoMatematica.Add(c2);
            CorsoMatematica.Add(c3);
            return CorsoMatematica;
        }
        public static List<Corso> CorsoFisica = new List<Corso>();
        public static List<Corso> CaricaEsamiFisica()
        {
            Corso c1 = new Corso("Termodinamica", 10);
            Corso c2 = new Corso("FluidoDunamica", 15);
            CorsoFisica.Add(c1);
            CorsoFisica.Add(c2);
            return CorsoFisica;
        }
        public static List<Corso> CorsoInformatica = new List<Corso>();
        public static List<Corso> CaricaEsamiInformatica()
        {
            Corso c1 = new Corso("Fondamenti di informatica", 7);
            Corso c2 = new Corso("programmazione in C", 15);
            CorsoInformatica.Add(c1);
            CorsoInformatica.Add(c2);
            return CorsoInformatica;
        }
        internal static Studente Iscritto(string nome, string cognome)
        {
            foreach(var item in Studenti)
            {
                if(item.Nome==nome && item.Cognome==cognome)
                {
                    
                    return item;
                }
            }return null;
        }

        public static List<Studente> Studenti = new List<Studente>();
        public static List<Studente> Iscrizione()
        {
            Studente s1 = new Studente("a", "b", new DateTime(1999,12,25),numeroMatricola1,EsamiPassatiStudente1);
            Studente s2= new Studente("c", "d", new DateTime(1998, 4, 13),numeroMatricola2,EsamiPassatiStudente2);
            Studenti.Add(s1);
            Studenti.Add(s2);
            return Studenti;

        }
        

        public static CorsoDiLaurea corso1 = new CorsoDiLaurea("matematica", 5, 120, CorsoMatematica);
        
        
         
         public static   CorsoDiLaurea corso2 = new CorsoDiLaurea("Fisica", 3, 190, CorsoFisica);
         public static  CorsoDiLaurea corso3 = new CorsoDiLaurea("Informatica", 4, 140, CorsoInformatica);
            
        public static Immatricolazione numeroMatricola1 = new Immatricolazione("1234", 130, new DateTime(2019, 9, 30),corso1, 0);
        public static Immatricolazione numeroMatricola2 = new Immatricolazione("1235", 140, new DateTime(2019, 9, 30), corso2, 0);

        public static List<Esame> EsamiPassatiStudente1 = new List<Esame>();
        public static List<Esame> EsamiPStud1()
        {
            Corso c1 = new Corso("Fondamenti di informatica", 7);
            Corso c2 = new Corso("programmazione in C", 15);
            CorsoInformatica.Add(c1);
            CorsoInformatica.Add(c2);
            return EsamiPassatiStudente1;
        }
        public static List<Esame> EsamiPassatiStudente2 = new List<Esame>();
        public static List<Esame> EsamiPStud2()
        {
            Corso c1 = new Corso("Fondamenti di informatica", 7);
           
            CorsoInformatica.Add(c1);
           
            return EsamiPassatiStudente2;
        }

    }
}
