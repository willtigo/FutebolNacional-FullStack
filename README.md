# ⚽ FutebolNacional - Full Stack

Sistema completo de estatísticas e classificação do Brasileirão (2022-2024), desenvolvido com **Blazor WebAssembly** e **ASP.NET Core Web API**.

## 🚀 Funcionalidades Principais
- **Calendário Dinâmico:** Navegação por meses baseada nas datas reais dos jogos no banco de dados.
- **Classificação por Data (Snapshot):** Cálculo em tempo real da tabela de pontos até o dia selecionado, tratando corretamente jogos atrasados ou adiantados.
- **Estatísticas de Gols:** Visualização proporcional de gols feitos e sofridos com barras de progresso dinâmicas.
- **Top 5 Artilheiros:** Pódio dinâmico (Ouro, Prata e Bronze) com os maiores goleadores da temporada.

## 🛠️ Tecnologias Utilizadas
- **Frontend:** Blazor WebAssembly, Bootstrap 5, FontAwesome, Animate.css.
- **Backend:** ASP.NET Core Web API, Dapper, Entity Framework Core.
- **Banco de Dados:** SQL Server.

## 📦 Como rodar o projeto
1. Clone o repositório: `git clone https://github.com/willtigo/FutebolNacional-FullStack`
2. Configure a ConnectionString no `appsettings.json` da API.
3. Execute a API e, em seguida, o projeto Blazor.
