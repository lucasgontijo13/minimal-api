using System.Data.Common;
using MinimalApi.Dominimio.Entidades;
using MinimalApi.Dominimio.Interfaces;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
namespace MinimalApi.Dominimio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = (_contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault());
        return adm;
    }


}