Create Table Produto
(
	Id Int Not Null Identity(1, 1),
	Descricao Varchar(100) Not Null,
	ValorUnitario Numeric(6, 2) Not Null,
	Primary Key (Id)
)

Create Table Pedido
(
	Id Int Not Null Identity(1, 1),
	DataEntrada DateTime Not Null,
	Endereco Varchar(200) Not Null,
	Cidade Varchar(200) Not Null,
	Estado Varchar(200) Not Null,
	DataSaida DateTime Null,
	Primary Key (Id)
)

Create Table ItemPedido
(
	Id Int Not Null Identity(1, 1),
	IdPedido Int Not Null,
	IdProduto Int Not Null,
	Quantidade Int Not Null,
	Primary Key (Id)
)

Alter Table ItemPedido
	Add Constraint FK_Pedido_ItemPedido
		Foreign Key (IdPedido)
		References Pedido (Id)
		On Delete Cascade

		