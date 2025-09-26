using Concesionario.Model;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.DAO
{
    public class PropietarioDAO : ICrud<Propietario, int>, ICounter
    {
        private static List<Propietario> ls = new List<Propietario>();
        public bool Add(Propietario obj)
        {
            var m = ls.Where(x => x.Id == obj.Id).SingleOrDefault();
            if (m == null)
            {
                ls.Add(obj);
                return true;
            }
            return false;
        }
        

        public int Count()
        {
            return ls.Count(x => x.Id !=0);
        }

        public int Count(DateTime dt, int days = 0)
        {
            var hoy = DateTime.Now;
            return ls.Count(x => x.FechaCreacion <= hoy.AddDays(-days) && x.Id != 0);
        }

        public bool Delete(int id)
        {
            VehiculosDAO vDao = new VehiculosDAO();
            List<Vehiculo> list = vDao.GetAll();

            var enc = list.Any(x => x.IdMarca == id);
            if (!enc)
            {
                var pr = ls.Where((x) => x.Id == id).SingleOrDefault();
                ls.Remove(pr);
            }
            return !enc;
        }
        

        public List<Propietario> GetAll(int id = -1)
        {
            if (id == -1)
                return ls.OrderBy(x => x.Id).ToList();
            return ls.Where(x => x.Id != id).OrderBy(x => x.Id).ToList();
        }

        public Propietario? GetById(int id)
        {
            return ls.Where(x => x.Id == id).SingleOrDefault();
        }

        public bool Update(Propietario obj)
        {
            var m = ls.Where(x => x.Id == obj.Id).SingleOrDefault();
            if (m != null)
            {
                ls.Remove(m);
                ls.Add(obj);
                return true;
            }
            return false;
        }
    }
    }

