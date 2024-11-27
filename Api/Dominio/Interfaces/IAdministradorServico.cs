using MinimalApi.Dominimio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominimio.Interfaces;


public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador Incluir(Administrador administrador);
    Administrador? BuscaPorId(int id);
    List<Administrador> Todos(int? pagina);

}