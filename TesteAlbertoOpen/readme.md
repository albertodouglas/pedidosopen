API para cadastro de Clientes, Produtos, Pedidos e Itens de Pedido

-> Banco de dados SQL Server Express
-> Utilizado Entity Framework para manipulação dos dados
-> Uso de contexto para criação/alteração de tabelas.
-> Para criar/atualizar o banco/tabelas usar, no Package Manager Console do Visual Studio, o comando "update-database", estando o projeto da API como default (será necessário alterar a connection string no appsettings)
-> A parte de Clientes foi feita utilizando MediatR
-> A API tem 3 posts e 2 gets:
	- POSTS: clientes, pedidos e produtos
	- GETS: todos os clientes e pedidos de um cliente específico
-> Caso seja feito um pedido será verificado se foi passado um cliente e, pelo menos, um produto. Será verificado se o cliente existe e também se o produto existe, não permitindo quantidades zeradas.