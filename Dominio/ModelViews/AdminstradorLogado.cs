using MinimalApi.Dominimio.Enuns;

namespace MinimalApi.Dominimio.ModelViews;

public record AdministradorLogado
{
    public string Email { get; set; } = default!;

    public string Perfil { get; set; } = default!;
    public string Token { get; set; } = default!;
}