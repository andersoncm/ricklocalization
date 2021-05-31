# Projeto RickLocalization

Projeto utilizando as tecnologias : Angular, Angular Material, Asp Net Core 3.1 WebApi, CQRS, Mediator,Dapper, Entity Framework, SQL Server

#Como executar o projeto

1 - >Abrir a Pasta RickLocalization e executar a solution Visual Studio 
2 - >Utilizar atraves do migration o Package Manager Console e seguir o comando update-database 
3 -> Será criado um banco de dados no SQL Server Local com nome de RickLocalization com alguns registros
4 -> Startar o projeto Asp Net Core que irá rodar em localhost:5000 e abrira a documentação do swagger
5-> Abir a pasta FrontRickLocalization no Visual Studio Code
6-> executar o comando npm i para instalar todas as dependencias do projeto
7-> rodar o comando ng serve --o para executar em localhost:4200

Na raiz do projeto tem uma pasta chamada SQL caso não queira usar o migrations com todos scripts de criação e carga inicial
