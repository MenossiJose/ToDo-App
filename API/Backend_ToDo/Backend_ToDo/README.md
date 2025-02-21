# Projeto Backend ToDo

Este projeto é uma API backend para um aplicativo de lista de tarefas (ToDo) desenvolvido em ASP.NET Core 8.0.

## Estrutura do Projeto

- **`Program.cs`**: Configura e inicializa o aplicativo web. Adiciona serviços ao contêiner, configura o Swagger para documentação da API, habilita CORS e mapeia os controladores.
- **`Controllers/ToDoController.cs`**: Define um controlador de API para gerenciar tarefas. Inclui endpoints para obter, adicionar e deletar tarefas no banco de dados.
  - **`GetTasks`**: Retorna todas as tarefas.
  - **`AddTask`**: Adiciona uma nova tarefa.
  - **`DeleteTask`**: Deleta uma tarefa pelo ID.
- **`appsettings.json`** e **`appsettings.Development.json`**: Arquivos de configuração que contêm strings de conexão e configurações de logging.
- **`Backend_ToDo.csproj`**: Arquivo de projeto que define as dependências e configurações do projeto.
- **`Backend_ToDo.http`**: Arquivo para testar endpoints HTTP.

## Dependências

- **`Microsoft.AspNetCore.Mvc.NewtonsoftJson`**: Para serialização JSON.
- **`Swashbuckle.AspNetCore`**: Para gerar documentação Swagger.
- **`System.Data.SqlClient`**: Para interagir com o banco de dados SQL Server.

## Estrutura de Pastas

- **`bin`** e **`obj`**: Diretórios de saída de compilação.
- **`Properties`**: Contém configurações de lançamento.
- **`.vs/`**: Arquivos de configuração do Visual Studio.

## Funcionalidade

A API permite operações CRUD básicas em uma tabela de tarefas (`todo`) no banco de dados `mydb`. A conexão com o banco de dados é configurada em `appsettings.json`.

Para executar o projeto, você pode usar o comando `dotnet run` no terminal ou configurar o Visual Studio para iniciar o projeto. A API estará disponível em `http://localhost:8000` (ou conforme configurado em `Properties/launchSettings.json`).
