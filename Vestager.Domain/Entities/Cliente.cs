﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vestager.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int UserID { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public  string RG { get; set; }
        public  string  CPF { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
    }
}
