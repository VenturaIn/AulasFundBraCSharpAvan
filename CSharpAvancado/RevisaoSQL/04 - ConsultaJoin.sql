Select a.Id, a.DataEntrada, a.Cidade, a.Estado, a.DataSaida,
	   b.Id As IdItemPedido, c.Descricao, c.ValorUnitario, b.Quantidade,
	   c.ValorUnitario * b.Quantidade As TotalPorProduto
  From Pedido a
 Inner Join ItemPedido b
	On a.Id = b.IdPedido
 Inner Join Produto c
	On b.IdProduto = c.Id