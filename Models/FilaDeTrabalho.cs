using System;
using System.Collections.Generic;

namespace Xperiments.DesignPatterns.Command.Models
{
    public class FilaDeTrabalho
    {
       public IList<IComando> Comandos = new List<IComando>();

       public void Adiciona(IComando comando)
       {
           this.Comandos.Add(comando);
       }

        public void Processa()
        {
            foreach (var comando in Comandos)
            {
                comando.Executa();
            }
        }
    }
}