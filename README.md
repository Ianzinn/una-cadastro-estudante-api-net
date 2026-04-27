# Cadastro Estudante API

API RESTful para cadastro de estudantes, desenvolvida com **ASP.NET Core (.NET 10)** e **Entity Framework Core** com banco de dados **SQLite**.

## Tecnologias

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core 10
- SQLite (`BancoEstudante.db`)
- Swagger / OpenAPI (Swashbuckle)

## Endpoints

Base URL: `https://localhost:{porta}/api/Estudantes`

| Método | Rota                    | Descrição                      |
|--------|-------------------------|--------------------------------|
| GET    | `/api/Estudantes`       | Lista todos os estudantes      |
| GET    | `/api/Estudantes/{id}`  | Busca um estudante por ID      |
| POST   | `/api/Estudantes`       | Cadastra um novo estudante     |
| PUT    | `/api/Estudantes/{id}`  | Atualiza um estudante existente|
| DELETE | `/api/Estudantes/{id}`  | Remove um estudante            |

### Modelo

```json
{
  "id": 1,
  "nome": "João Silva"
}
```

> O campo `nome` é obrigatório.

## Como executar

**Pré-requisitos:** [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
# Clone o repositório
git clone <url-do-repositorio>
cd CadastroEstudanteApi

# Aplique as migrations
dotnet ef database update

# Execute a aplicação
dotnet run
```

A documentação Swagger estará disponível em `https://localhost:{porta}/swagger` (ambiente de desenvolvimento).

## Estrutura do projeto

```
CadastroEstudanteApi/
├── Controllers/
│   └── EstudantesController.cs   # Endpoints da API
├── data/
│   └── AppDbContext.cs           # Contexto do EF Core
├── models/
│   └── Estudante.cs              # Modelo de domínio
├── Migrations/                   # Migrations do EF Core
└── Program.cs                    # Configuração da aplicação
```

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
