Select a.DataEntrada, a.Cidade, a.Estado, a.DataSaida,
	   SUM(c.ValorUnitario * b.Quantidade) As TotalPorPedido	   
  From Pedido a
 Inner Join ItemPedido b
	On a.Id = b.IdPedido
   And (a.Cidade Like 'R%' Or CHARINDEX('o', a.Cidade) = 3)
 Inner Join Produto c
	On b.IdProduto = c.Id
 --Where a.Cidade = 'Rio de Janeiro'
 Group By a.DataEntrada, a.Cidade, a.Estado, a.DataSaida