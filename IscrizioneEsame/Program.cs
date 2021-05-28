using System;
using System.Collections.Generic;

namespace IscrizioneEsame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------PRENOTATI AL APPELLO--------");
            Console.Write("inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.Write("inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            Studente studente = new Studente();
            //studente = SegreteriaStudenti.Iscritto(nome, cognome);

            var Studenti = SegreteriaStudenti.Iscrizione();
            foreach (var item in Studenti)
            {
                if(item.Nome==nome && item.Cognome==cognome)
                {
                    
                    Console.WriteLine($"{item.InfoStudente()}");
                    studente = item;
                }
                else
                {
                    Console.WriteLine("Prima di dare esami devi iscriveri al università!!");
                }
            }
            string matricola = studente.immatricolazione.Matricola;
            var CDL = studente.Esami;

            string scelta;
            do
            {
                Console.WriteLine("-----UNIVERSITA-----");
                Console.WriteLine("1) Prenotati al prossimo Esame ");
                Console.WriteLine("2) Verbalizza un esame Prenotato ");
                Console.WriteLine("Fai la tua scelta");
                scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        //studente aggiunge l'esame alla lista esami se:
                        Console.WriteLine("Che Esame vuoi sostenere?");

                        var esamiCorsoDiLaurea = SegreteriaStudenti.CaricaEsamiInformatica();
                        foreach (var item in esamiCorsoDiLaurea)
                        {
                            Console.WriteLine($"{item.InfoCorso()}\n");
                        }
                        Console.Write("Inserisci il Nome del Esame che vorresti sostenere: ");
                        
                        
                        

                        //1. verificare che l'esame è presente nel corso di laurea associato
                        //utilizziamo il costrutto if-else

                       // 2. se non ha effettuato al richiesta i laurea
                       // inserendo un && nel costrutto possiamo verificare anche questa condizione

                        break;
                    case "2":
                        break;

                }

            }while(true);



           
            
            



        }
    }
}
