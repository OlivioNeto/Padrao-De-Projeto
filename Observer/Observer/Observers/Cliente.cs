﻿using ObserverSolucao.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Observers
{
	public class Cliente : Observer
	{
		private string nome;
		private string email;

		public Cliente(string nome, string email)
		{
			this.nome = nome;
			this.email = email;
		}

		public override bool Equals(object? obj)
		{
			return obj is Cliente cliente &&
				nome == cliente.nome &&
				email == cliente.email;
		}
		public string getEmail()
		{
			return this.email;
		}

		public string getNome()
		{
			return this.nome;
		}

		public void update(string mensagem)
		{
			Email.enviarEmail(this, mensagem);
		}
	}
}
