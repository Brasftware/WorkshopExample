# github-instructions

## Objetivo
Projeto institucional B2B em **ASP.NET Core Razor Pages (.NET 8)** com 3 páginas públicas:
- Home
- Projetos
- Contato

## Escopo e limites
- **Sem banco de dados**
- **Sem autenticação/login**
- Formulário de contato com **validação** e **envio simulado** (sem SMTP/API externa)
- Layout responsivo usando Bootstrap e `_Layout` compartilhado

## Estrutura principal
- `GlobalWeb/Program.cs`
- `GlobalWeb/GlobalWeb.csproj`
- `GlobalWeb/Pages/Index.cshtml`
- `GlobalWeb/Pages/Projetos.cshtml`
- `GlobalWeb/Pages/Contato.cshtml`
- `GlobalWeb/Pages/Shared/_Layout.cshtml`
- `GlobalWeb/wwwroot/css/site.css`

## Convenções
- Manter páginas em Razor Pages (`.cshtml` + `.cshtml.cs`)
- Dados de projetos permanecem mockados em memória
- Mensagens e textos em português
- Mudanças devem ser objetivas e focadas no escopo institucional

## Como executar
1. Abra terminal na pasta `GlobalWeb/GlobalWeb`
2. Rode `dotnet restore`
3. Rode `dotnet run`
4. Acesse a URL indicada no terminal (ex.: `http://localhost:xxxx`)

## Checklist rápido antes de PR
- Build sem erros (`dotnet build`)
- Navegação funcionando entre Home, Projetos e Contato
- Validação de formulário de contato funcionando
- Sem inclusão de banco, login ou dependências desnecessárias
