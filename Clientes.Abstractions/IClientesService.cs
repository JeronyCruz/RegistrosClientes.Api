using Clientes.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Abstractions;

public interface IClientesService
{
    Task<bool> Guardar(ClientesDto cliente);
    Task<bool> Eliminar(int clienteId);
    Task<ClientesDto> Buscar(int id);
    Task<List<ClientesDto>> Listar(Expression<Func<ClientesDto, bool>> criterio);
    Task<bool> ExisteCliente(int id, string nombres);
}
