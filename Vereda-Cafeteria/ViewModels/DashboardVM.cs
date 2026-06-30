using System;
using System.Collections.Generic;
using Vereda_Cafeteria.Models;

namespace Vereda_Cafeteria.ViewModels;

public class DashboardVM
{
    public decimal FaturamentoHoje { get; set; }
    public int PedidosHoje { get; set; }
    public decimal TicketMedio { get; set; }
    public string ItemMaisPedido { get; set; }
    public int QtdItemMaisPedido { get; set; }

    public decimal PercentualFaturamentoVariacao { get; set; }
    public int VariacaoPedidos { get; set; }
    public decimal VariacaoTicketMedio { get; set; }

    public List<FaturamentoDiario> FaturamentoSemana { get; set; }
    public List<TopProduto> TopProdutos { get; set; }
    public List<Pedido> PedidosConfirmados { get; set; }
}

public class FaturamentoDiario
{
    public string Dia { get; set; }
    public decimal Valor { get; set; }
}

public class TopProduto
{
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public int Quantidade { get; set; }
    public int Percentual { get; set; }
}
