﻿using System;
namespace AppGourmet.Models
{
    public class Usuario
    {
		public int id { get; set; }
		public string nome { get; set; }
		public string dataNascimento { get; set; }
		public string telefone { get; set; }
		public string email { get; set; }
    }
	class ResultadoLogin
	{
		public Usuario usuario { get; set; }
	}
}
