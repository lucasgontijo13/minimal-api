using MinimalApi.Dominimio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominimio.Interfaces;


public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);

}