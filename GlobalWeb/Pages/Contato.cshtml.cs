using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GlobalWeb.Pages;

public class ContatoModel : PageModel
{
    [BindProperty]
    public ContatoInputModel FormData { get; set; } = new();

    public bool EnvioSimuladoComSucesso { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        EnvioSimuladoComSucesso = true;
        FormData = new ContatoInputModel();
        ModelState.Clear();

        return Page();
    }
}

public class ContatoInputModel
{
    [Required(ErrorMessage = "Informe seu nome.")]
    [Display(Name = "Nome")]
    [StringLength(120, ErrorMessage = "O nome deve ter no máximo 120 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe seu e-mail.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
    [Display(Name = "E-mail")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe sua empresa.")]
    [Display(Name = "Empresa")]
    [StringLength(120, ErrorMessage = "A empresa deve ter no máximo 120 caracteres.")]
    public string Empresa { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descreva sua necessidade.")]
    [Display(Name = "Mensagem")]
    [StringLength(1200, MinimumLength = 10, ErrorMessage = "A mensagem deve ter entre 10 e 1200 caracteres.")]
    public string Mensagem { get; set; } = string.Empty;
}