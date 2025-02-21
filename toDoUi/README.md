# Projeto ToDo-App

Este projeto é uma aplicação web simples de lista de tarefas (ToDo) desenvolvida com Angular. A seguir, uma visão geral dos principais componentes e arquivos do projeto:

## Estrutura do Projeto

- **src/**: Diretório principal do código-fonte da aplicação.
  - **app/**: Contém os componentes, serviços e arquivos de configuração da aplicação.
    - **components/**: Diretório para componentes da aplicação.
      - **task/**: Componente de tarefa individual.
        - [`src/app/components/task/task.component.ts`](src/app/components/task/task.component.ts): Lógica do componente de tarefa.
        - [`src/app/components/task/task.component.html`](src/app/components/task/task.component.html): Template HTML do componente de tarefa.
        - [`src/app/components/task/task.component.css`](src/app/components/task/task.component.css): Estilos CSS do componente de tarefa.
        - [`src/app/components/task/task.component.spec.ts`](src/app/components/task/task.component.spec.ts): Testes unitários para o componente de tarefa.
    - **services/**: Diretório para serviços da aplicação.
      - [`src/app/services/task.service.ts`](src/app/services/task.service.ts): Serviço para interagir com a API de tarefas.
      - [`src/app/services/task.service.spec.ts`](src/app/services/task.service.spec.ts): Testes unitários para o serviço de tarefas.
    - [`src/app/app.component.ts`](src/app/app.component.ts): Componente principal da aplicação.
    - [`src/app/app.component.html`](src/app/app.component.html): Template HTML do componente principal.
    - [`src/app/app.component.css`](src/app/app.component.css): Estilos CSS do componente principal.
    - [`src/app/app.component.spec.ts`](src/app/app.component.spec.ts): Testes unitários para o componente principal.
    - [`src/app/app.config.ts`](src/app/app.config.ts): Configurações da aplicação.
    - [`src/app/app.routes.ts`](src/app/app.routes.ts): Configurações de rotas da aplicação.
  - [`src/index.html`](src/index.html): Arquivo HTML principal da aplicação.
  - [`src/main.ts`](src/main.ts): Arquivo de entrada principal da aplicação.
  - [`src/styles.css`](src/styles.css): Estilos globais da aplicação.

## Arquivos de Configuração

- **angular.json**: Configurações do Angular CLI para o projeto.
- **package.json**: Dependências e scripts npm do projeto.
- **tsconfig.json**: Configurações do TypeScript.
- **tsconfig.app.json**: Configurações específicas do TypeScript para a aplicação.
- **tsconfig.spec.json**: Configurações específicas do TypeScript para testes.
- **.editorconfig**: Configurações de formatação de código.
- **.gitignore**: Arquivos e diretórios a serem ignorados pelo Git.
- **.vscode/**: Configurações específicas do Visual Studio Code.

## Funcionalidades Principais

- **Adicionar Tarefa**: Permite ao usuário adicionar uma nova tarefa à lista.
- **Listar Tarefas**: Exibe a lista de tarefas existentes.
- **Deletar Tarefa**: Permite ao usuário deletar uma tarefa da lista.

## Serviços

- **TaskService**: Serviço responsável por fazer requisições HTTP para a API de tarefas. Implementa métodos para obter, adicionar e deletar tarefas.

## Componentes

- **AppComponent**: Componente principal que gerencia a lista de tarefas e interage com o [`TaskService`](src/app/services/task.service.ts).
- **TaskComponent**: Componente que representa uma tarefa individual na lista.

## Execução

- **Servidor de Desenvolvimento**: Para iniciar o servidor de desenvolvimento, execute `ng serve`.
- **Build**: Para compilar o projeto, execute `ng build`.
- **Testes Unitários**: Para executar os testes unitários, execute `ng test`.

Para mais detalhes sobre o uso do Angular CLI e comandos disponíveis, consulte o [`README.md`](README.md).
