﻿using System;

public class Time {
    private string nome, corUniforme, grito;
    
    public Time(){}
    public Time(string nome, string corUniforme, string grito) {
        this.nome = nome;
        this.corUniforme = corUniforme;
        this.grito = grito;
    }
    public string getNome() { 
        return nome;
    }
    public string getCorUniforme() {
        return corUniforme;
    }
    public string getGrito() {
        return grito;
    }
    public void setNome(string nome) { 
        this.nome = nome;
    }
    public void setCorUniforme(string corUniforme) {
        this.corUniforme = corUniforme;
    }
    public void setGrito(string grito) {
        this.grito = grito;
    }
    
}

public class Partida {
    private Time timeA, timeB;
    private int numeroGolsTimeA, numeroGolsTimeB;
    public Random geradorGols = new Random();
    public int pontos;
    public Partida(){}
    public Partida(Time timeA, Time timeB) {
        this.timeA = timeA;
        this.timeB = timeB;
        numeroGolsTimeA = geradorGols.Next(0,5);
        numeroGolsTimeB = geradorGols.Next(0,5);

        System.Console.WriteLine("{0} x {1}", timeA.getNome(), timeB.getNome());
        System.Console.WriteLine("{0} x {1}", numeroGolsTimeA, numeroGolsTimeB);
        if (homeGanhouHuh()) {
            System.Console.WriteLine("{0} ganhou a partida!!", timeA.getNome());
            System.Console.WriteLine(timeA.getGrito());
            System.Console.WriteLine();
            pontos = 3;
        } else if (awayGanhouHuh()) {
            System.Console.WriteLine("{0} ganhou a partida!!", timeB.getNome());
            System.Console.WriteLine(timeB.getGrito());
            System.Console.WriteLine();
            pontos = 0;
        } else {
            System.Console.WriteLine("{0} e {1} empataram!!", timeA.getNome(), timeB.getNome());
            System.Console.WriteLine();
            pontos = 1;
        }
    }
    public int getNumeroGolsTimeA() {
        return numeroGolsTimeA;
    }
    public int getNumeroGolsTimeB() {
        return numeroGolsTimeB;
    }
    public Time getTimeA() {
        return timeA;
    }
    public Time getTimeB() {
        return timeB;
    }
    public int saldoDeGolsTimeA() {
        return numeroGolsTimeA - numeroGolsTimeB;
    }
    public int saldoDeGolsTimeB() {
        return numeroGolsTimeB - numeroGolsTimeA;
    }

    public bool homeGanhouHuh() {
        return (getNumeroGolsTimeA()-getNumeroGolsTimeB()) >= 1;
    }
    public bool awayGanhouHuh() {
        return (getNumeroGolsTimeB()-getNumeroGolsTimeA()) >= 1;
    }
    
    public int getPontos() {
        return pontos;
    }

}

public class Tabela {
            //  tabela
            // time a; gols 3; contra 2; saldo: 1; 
            // time b; gols 2; contra 3; saldo: -1; 
    private Partida partidaA, partidaB;

    public Tabela() {}
    public Tabela(Partida partidaA, Partida partidaB) {
        this.partidaA = partidaA;
        this.partidaB = partidaB;
        System.Console.WriteLine("Printando Tabela:");
        System.Console.WriteLine("{0,-20}; gols: {1}; contra: {2}; saldo: {3}", 
            partidaA.getTimeA().getNome(),
            partidaA.getNumeroGolsTimeA(),
            partidaA.getNumeroGolsTimeB(),
            partidaA.saldoDeGolsTimeA());
        System.Console.WriteLine("{0,-20}; gols: {1}; contra: {2}; saldo: {3,-2}", 
            partidaA.getTimeB().getNome(),
            partidaA.getNumeroGolsTimeB(),
            partidaA.getNumeroGolsTimeA(),
            partidaA.saldoDeGolsTimeB());
        System.Console.WriteLine("{0,-20}; gols: {1}; contra: {2}; saldo: {3,-2}", 
            partidaB.getTimeA().getNome(),
            partidaB.getNumeroGolsTimeA(),
            partidaB.getNumeroGolsTimeB(),
            partidaB.saldoDeGolsTimeA());
        System.Console.WriteLine("{0,-20}; gols: {1}; contra: {2}; saldo: {3,-2}", 
            partidaB.getTimeB().getNome(),
            partidaB.getNumeroGolsTimeB(),
            partidaB.getNumeroGolsTimeA(),
            partidaB.saldoDeGolsTimeB());
    }
}

namespace Futebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Les Floncs", "Azul", "Allez les Floncs!!");
            Time time2 = new Time("Plombo y Plata FC", "Prata", "Viva Pablo!!");
            Time time3 = new Time("Tabajaras FC", "Laranja", "Pose de quebrada!!");
            
            string nome, corUniforme, grito;
            System.Console.WriteLine("Bem-vindo ao Futebas!!");
            System.Console.WriteLine("[1/3] Insira o nome do seu time:");
            nome = Console.ReadLine();
            System.Console.WriteLine("[2/3] Otimo! Agora digite a cor do seu uniforme:");
            corUniforme = Console.ReadLine();
            System.Console.WriteLine("[3/3] Digite o grito da sua torcida:");
            grito = Console.ReadLine();

            Time time4 = new Time(nome, corUniforme, grito);

            Console.WriteLine("Carregando o jogo!!");
            linha(60);
            wait(5);
            linha(60);
            System.Console.WriteLine();
            System.Console.WriteLine("RODADA 1:");
            System.Console.WriteLine("Time 1 x Time 2");
            System.Console.WriteLine("Time 3 x Time 4");
            System.Console.WriteLine();
            Partida rodada1A = new Partida(time1, time2);
            Partida rodada1B = new Partida(time3, time4);
            Tabela tabela1 = new Tabela(rodada1A, rodada1B);
            System.Console.WriteLine();
            System.Console.WriteLine("RODADA 2:");
            System.Console.WriteLine("Time 2 x Time 3");
            System.Console.WriteLine("Time 1 x Time 4");
            System.Console.WriteLine();
            Partida rodada2A = new Partida(time2, time3);
            Partida rodada2B = new Partida(time1, time4);
            Tabela tabela2 = new Tabela(rodada2A, rodada2B);
            System.Console.WriteLine();
            System.Console.WriteLine("RODADA 3:");
            System.Console.WriteLine("Time 1 x Time 3");
            System.Console.WriteLine("Time 2 x Time 4");
            System.Console.WriteLine();
            Partida rodada3A = new Partida(time1, time3);
            Partida rodada3B = new Partida(time2, time4);
            Tabela tabela3 = new Tabela(rodada3A, rodada3B);
            
        }

        public static void linha(int n) {
            for (int i=0; i<n; i++) {
                Console.Write("-");
            }
            System.Console.WriteLine();
        }

        public static void wait(int seconds) {
            for (int i=0; i<Math.Exp(seconds); i++) {
                for (int j=0; j<Math.Exp(seconds); j++) {}
            }
        }
    }
}