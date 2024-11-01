using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnicos.Domain.DTO;

public class ClientesDto
{
    public int ClientesId { get; set; }
    public string? Nombres { get; set; }
    public string? WhapsApp { get; set; }
}
