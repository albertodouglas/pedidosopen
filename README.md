# API Pedidos (Open)
API para cadastro de Clientes, Produtos e Pedidos, utilizando CQRS

<ul>
<li>Banco de dados SQL Server Express</li>
<li>Utilizado Entity Framework para manipulação dos dados</li>
<li>Uso de contexto para criação/alteração de tabelas.</li>
<li>Para criar/atualizar o banco/tabelas usar, no Package Manager Console do Visual Studio, o comando "update-database", estando o projeto da API como default (será necessário alterar a connection string no appsettings)</li>
<li>A parte de Clientes foi feita utilizando MediatR</li>
<li>A API tem 3 posts e 2 gets:</li>
 <ul>
	<li><i>POSTS:</i> clientes, pedidos e produtos</li>
	<li><i>GETS:</i> todos os clientes e pedidos de um cliente específico</li>
  </ul>
<li>Caso seja feito um pedido será verificado se foi passado um cliente e, pelo menos, um produto. Será verificado se o cliente existe e também se o produto existe, não permitindo quantidades zeradas.</li>
</ul>
