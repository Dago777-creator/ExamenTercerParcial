using Modelos;

namespace Blazor.Interfaces
{
    public class IUsuarioServicio
    {
        Task<Usuario> GetPorCodigo(string codigo);
    }
}
