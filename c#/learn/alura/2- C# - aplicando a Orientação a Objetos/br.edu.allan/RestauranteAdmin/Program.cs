
Console.Clear();

Restaurante restauranteAllanEEster = new Restaurante();
restauranteAllanEEster.Nome = "Restaurante Allan & Ester";

Cardapio cardapioAllanEEster = new Cardapio();

Prato pratoCamaraoEmpanado = new Prato();
pratoCamaraoEmpanado.Nome = "Camarão Empanado";
pratoCamaraoEmpanado.Valor = 50;


Prato pratoSucoUva = new Prato();
pratoSucoUva.Nome = "Suco de Uva (Copo)";
pratoSucoUva.Valor = 16;

restauranteAllanEEster.Cardapio.AdicionarPrato(pratoCamaraoEmpanado);
restauranteAllanEEster.Cardapio.AdicionarPrato(pratoSucoUva);

restauranteAllanEEster.Cardapio.ExibirCardapio();


Mesa mesa1 = new Mesa();
List<Pedido> pedidosMesa1 = new List<Pedido>();

mesa1.Numero = 1;
mesa1.Liberar();

Pedido pedidoSucoUva = new Pedido();
pedidoSucoUva.Mesa = mesa1;
pedidoSucoUva.Prato = pratoSucoUva;
pedidoSucoUva.Observacao = "Sem açucar";

Pedido pedidoCamaraoEmpanado = new Pedido();
pedidoCamaraoEmpanado.Mesa = mesa1;
pedidoCamaraoEmpanado.Prato = pratoCamaraoEmpanado;
pedidoCamaraoEmpanado.Observacao = "Sem fritas";

pedidosMesa1.Add(pedidoSucoUva);
pedidosMesa1.Add(pedidoCamaraoEmpanado);


Console.WriteLine("Exibindo pedidos:\n");
foreach (var pedido in pedidosMesa1)
{
    pedido.ExibirDescricaoPedido();
}


