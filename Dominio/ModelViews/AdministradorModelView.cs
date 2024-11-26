using MinimalApi.Dominimio.Enuns;

namespace MinimalApi.Dominimio.ModelViews;

public record AdministradorModelView
{
    public int Id { get; set; } = default!;
    public string Email { get; set; } = default!;

    public string Perfil { get; set; } = default!;
}