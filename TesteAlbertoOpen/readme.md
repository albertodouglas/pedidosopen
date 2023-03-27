API para cadastro de Clientes, Produtos, Pedidos e Itens de Pedido

-> Banco de dados SQL Server Express
-> Utilizado Entity Framework para manipula��o dos dados
-> Uso de contexto para cria��o/altera��o de tabelas.
-> Para criar/atualizar o banco/tabelas usar, no Package Manager Console do Visual Studio, o comando "update-database", estando o projeto da API como default (ser� necess�rio alterar a connection string no appsettings)
-> A parte de Clientes foi feita utilizando MediatR
-> A API tem 3 posts e 2 gets:
	- POSTS: clientes, pedidos e produtos
	- GETS: todos os clientes e pedidos de um cliente espec�fico
-> Caso seja feito um pedido ser� verificado se foi passado um cliente e, pelo menos, um produto. Ser� verificado se o cliente existe e tamb�m se o produto existe, n�o permitindo quantidades zeradas.