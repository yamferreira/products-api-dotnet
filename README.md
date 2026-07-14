# products-api-dotnet

Web API REST desenvolvida em **ASP.NET Core (.NET 10)** para gerenciamento de produtos, com persistência em **PostgreSQL** via **Entity Framework Core**.

Projeto de portfólio criado para praticar o stack C#/.NET, complementando experiência prévia em Java/Spring Boot.

## 🚀 Stack técnica

- **ASP.NET Core Web API** (controller-based)
- **Entity Framework Core** + **Npgsql** (PostgreSQL)
- **Swagger UI** (Swashbuckle) para documentação/teste interativo dos endpoints
- **Docker** + **Docker Compose** para execução containerizada (API + Postgres)

## 📁 Estrutura do projeto

```
products-api-dotnet/
├── Controllers/
│   └── ProductsController.cs   # Endpoints CRUD completo
├── Data/
│   └── AppDbContext.cs         # Contexto EF Core
├── Models/
│   └── Product.cs              # Entidade Product
├── Migrations/
│   └── InitialCreate.cs        # Migration inicial
├── Dockerfile                  # Build multi-stage (SDK → runtime ASP.NET)
├── docker-compose.yml          # API + Postgres (postgres:16-alpine)
└── README.md
```

## 📦 Modelo de dados — Product

| Campo         | Tipo      | Descrição                    |
|---------------|-----------|-------------------------------|
| Id            | int       | Identificador único            |
| Name          | string    | Nome do produto                |
| Description   | string    | Descrição do produto           |
| Price         | decimal   | Preço                          |
| Stock         | int       | Quantidade em estoque          |
| CreatedAt     | DateTime  | Data de criação                |

## 🔗 Endpoints

Base URL: `/api/products`

| Método   | Rota                  | Descrição                       |
|----------|-----------------------|----------------------------------|
| `GET`    | `/api/products`       | Lista todos os produtos          |
| `GET`    | `/api/products/{id}`  | Busca um produto por ID          |
| `POST`   | `/api/products`       | Cria um novo produto             |
| `PUT`    | `/api/products/{id}`  | Atualiza um produto existente    |
| `DELETE` | `/api/products/{id}`  | Remove um produto                |

## 🐳 Como rodar

### Pré-requisitos
- [Docker](https://www.docker.com/) e Docker Compose instalados

### Passos

```bash
# clone o repositório
git clone https://github.com/yamferreira/products-api-dotnet.git
cd products-api-dotnet

# suba os containers (API + Postgres)
docker compose up -d
```

A API estará disponível em:

```
http://localhost:8080/swagger
```

Use o Swagger UI para testar todos os endpoints de forma interativa.

### Rodando localmente sem Docker

```bash
dotnet restore
dotnet ef database update
dotnet run
```

> É necessário ter uma instância local do PostgreSQL configurada e a connection string ajustada em `appsettings.json`.

## 🗄️ Banco de dados

O container Postgres utiliza a imagem `postgres:16-alpine`, com **healthcheck** e **volume persistente** configurados no `docker-compose.yml`, garantindo que os dados não sejam perdidos entre reinicializações.

A migration inicial (`InitialCreate`) já está incluída no projeto e é aplicada automaticamente ao subir os containers.

## 📝 Histórico de desenvolvimento

O projeto foi construído de forma incremental, através dos seguintes commits:

1. `gitignore` — configuração inicial do repositório
2. `scaffold do projeto` — estrutura base do ASP.NET Core
3. `modelo/DbContext` — entidade Product e contexto EF Core
4. `controller CRUD` — implementação dos endpoints
5. `migration` — geração da migration inicial
6. `Docker/Compose` — containerização da API e do banco de dados

## 👤 Autor

**Yam Ferreira**
- GitHub: [@yamferreira](https://github.com/yamferreira)
- LinkedIn: [linkedin.com/in/yamferreira](https://linkedin.com/in/yamferreira)

---

Projeto desenvolvido para fins de estudo e portfólio.
