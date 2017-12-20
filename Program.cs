using System;
using System.Linq.Expressions;
using Xperiments.DesignPatterns.Command.Models;

namespace Xperiments.DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {   
            Pedido pedido = new Pedido("Bruno Lopes", 100);
            Pedido pedidoMae = new Pedido("Mãe do Bruno Lopes", 100);
            Pedido pedidoPai = new Pedido("Pai do Bruno Lopes", 100);


            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido) );
            fila.Adiciona(new PagaPedido(pedidoMae) );

            fila.Adiciona(new FinalizaPedido(pedidoMae) );
            fila.Adiciona(new FinalizaPedido(pedidoPai) );

            fila.Processa();
            
        }
    }
}
