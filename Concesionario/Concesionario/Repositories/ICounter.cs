using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Repositories
{
    public interface ICounter
    {
        int Count();

        int Count(DateTime dt, int days = 0);
    }
}
