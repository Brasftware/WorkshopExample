using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GlobalWeb.Pages;

public class ProjetosModel : PageModel
{
    public IReadOnlyList<ProjetoItem> Projetos { get; } =
    [
        new ProjetoItem(
            "Portal de Autoatendimento Corporativo",
            "Centralização de solicitações e acompanhamento de chamados para reduzir SLA interno.",
            [".NET 8", "Razor Pages", "REST API"],
            "Grupo Atlas Industrial",
            2024,
            "Concluído",
            "bg-success"),
        new ProjetoItem(
            "Plataforma de Gestão Comercial",
            "Automação do funil de vendas com integração entre CRM e ERP para ganho de produtividade.",
            ["ASP.NET Core", "Bootstrap", "Azure"],
            "Nexus Distribuição",
            2025,
            "Em andamento",
            "bg-warning text-dark"),
        new ProjetoItem(
            "Dashboard Executivo de Operações",
            "Consolidação de indicadores estratégicos em tempo real para apoiar tomada de decisão.",
            ["C#", "Razor", "Power BI Embedded"],
            "Prime Logística B2B",
            2023,
            "Concluído",
            "bg-success"),
        new ProjetoItem(
            "Modernização de Sistema Legado",
            "Reestruturação de módulos críticos com arquitetura modular e maior confiabilidade.",
            [".NET 8", "Clean Architecture", "Docker"],
            "Orbit Serviços Técnicos",
            2026,
            "Planejamento",
            "bg-secondary")
    ];

    public void OnGet()
    {
    }
}

public record ProjetoItem(
    string Nome,
    string Descricao,
    IReadOnlyList<string> Tecnologias,
    string Cliente,
    int Ano,
    string Status,
    string StatusClass);