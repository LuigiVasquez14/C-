using Concesionario.Model;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.DAO
{
    public class MarcaDAO:ICrud<Marca, int>,ICounter
    {
        private static List<Marca> ls = new List<Marca>();

        public bool Add(Marca obj)
        {
            var m = ls.Where(x=>x.Id == obj.Id).SingleOrDefault();
            if (m == null)
            {
                ls.Add(obj);
                return true;
            }
            return false;
        }

        public int Count()
        {
            return ls.Count(x=>x.Id!=0);
        }

        public int Count(DateTime dt, int days = 0)
        {
            var hoy = DateTime.Now;
            return ls.Count(x=>x.FechaCreacion<=hoy.AddDays(-days)&& x.Id!=0);
        }

        public bool Delete(int id)
        {
         VehiculosDAO vDao = new VehiculosDAO();
            List<Vehiculo> List = vDao.GetAll();

            var enc = List.Any(x => x.IdMarca== id);
            if (!enc)
            {
                var mar = ls.Where((x) => x.Id == id).SingleOrDefault();
                ls.Remove(mar);
            }
            return !enc;
        }

        public List<Marca> GetAll(int id = -1)
        {
          if (id==-1)
                return ls.OrderBy(x=>x.Id).ToList();
          return ls.Where(x=>x.Id!=id).OrderBy(x=>x.Id).ToList();
        }

        public Marca? GetById(int id)
        {
            return ls.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Update(Marca obj)
        {
            var m = ls.Where(x=> x.Id==obj.Id).SingleOrDefault();
            if (m !=null)
            {
                ls.Remove(m);
                ls.Add(obj);
                return true;
            }
            return false;
        }
    }
}
