﻿namespace AvaliacaoInfnet.Domain
{
    public class Respondente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int IdPerfil { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public bool Status { get; set; }

        public string Senha { get; set; }
    }
}