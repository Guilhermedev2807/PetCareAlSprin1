# 🐾 Pet Care AI+ — Sistema de Gestão de Saúde Pet

O **Pet Care AI+** é uma API robusta desenvolvida em **.NET 10** focada no monitoramento contínuo da saúde de animais de estimação. O projeto permite o gerenciamento completo (CRUD) de pets, integrando-se a um banco de dados **Oracle** para persistência segura dos dados.

## 🚀 Tecnologias Utilizadas

*   **.NET 10 (Preview)**: Framework principal para o desenvolvimento da Web API.
*   **Entity Framework Core**: ORM para mapeamento objeto-relacional.
*   **Oracle Database**: Banco de dados relacional utilizado para persistência.
*   **Swagger (OpenAPI)**: Documentação interativa dos endpoints.
*   **C#**: Linguagem de programação.

## 🛠️ Como Executar o Projeto

1.  **Clone o repositório**:
    ```bash
    git clone [https://github.com/Guilhermedev2807/PetCareAlSprin1.git](https://github.com/Guilhermedev2807/PetCareAlSprin1.git)
    ```
2.  **Restaure as dependências**:
    ```bash
    dotnet restore
    ```
3.  **Execute a aplicação**:
    ```bash
    dotnet run
    ```
4.  **Acesse a Documentação**:
    Com o servidor rodando, abra: `http://localhost:5063/swagger/index.html`.

## 📍 Endpoints da API

| Método | Endpoint | Descrição | Retorno Sucesso |
| :--- | :--- | :--- | :--- |
| **GET** | `/api/Pets` | Lista todos os pets cadastrados | `200 OK` |
| **POST** | `/api/Pets` | Cadastra um novo pet no sistema | `201 Created` |
| **PUT** | `/api/Pets/{id}` | Atualiza os dados de um pet existente | `204 No Content` |
| **DELETE** | `/api/Pets/{id}` | Remove um pet do banco de dados | `204 No Content` |

## 📂 Estrutura do Projeto

*   **`Controllers/`**: Contém a `PetsController.cs` com a lógica dos endpoints.
*   **`Models/`**: Contém a classe `Pet.cs`, que representa a entidade no banco.
*   **`Data/`**: Contém o `AppDbContext.cs` para configuração do EF Core.
*   **`Migrations/`**: Histórico de versões do banco de dados.

Nomes: Guilherme de Andrade Martini RM566087
Raphael Gomes Mancera RM562279
Bruno Vinicius Barbosa RM566366

Sala: 2TDSPX
