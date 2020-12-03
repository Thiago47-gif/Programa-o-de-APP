using System;
using System.Collections.Generic;
using System.Text;

namespace Thiago_SA_02
{
    class Receita
    {
        public string NomeReceita { get; set; }
        public string TempoPreparacao { get; set; }
        public string GrauDificuldade { get; set; }
        public int NumPessoas { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        
        
        public Receita(string nomeReceita, string tempoPreparacao,
            string grauDificuldade, int numPessoas, string categoria,
            string descricao, string ingredientes)
        {
            NomeReceita = nomeReceita;
            TempoPreparacao = tempoPreparacao;
            GrauDificuldade = grauDificuldade;
            NumPessoas = numPessoas;
            Categoria = categoria;
            Descricao = descricao;
            Ingredientes = ingredientes;
        }

        public override string ToString()
        {
            return "Nome: " + NomeReceita +
            ", Tempo de Preparação: " + TempoPreparacao +
            ", Grau de Dificuldade: " + GrauDificuldade +
            ", Numero de Pessoas: " + NumPessoas +
            ", Categoria: " + Categoria +
            ",  Descrição: " + Descricao +
            ", Ingredientes: " + Ingredientes;
        }
    }
}
