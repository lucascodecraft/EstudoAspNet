using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        public readonly ApplicationContext contexto;
        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void IniciazilaDB()
        {
            contexto.Database.EnsureCreated();
        }
    }
}
