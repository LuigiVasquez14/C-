using Concesionario.DTO;
using Concesionario.Model;
using Concesionario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.DAO
{
    public class VehiculosDAO : ICrud<Vehiculo,string>,ICounter
    {
        private MarcaDAO mrDao = new MarcaDAO();
        private PropietarioDAO prDao = new PropietarioDAO();

        private static List<Vehiculo> ls = new List<Vehiculo>();



        internal List<Vehiculo> GetAll()
        {////no cuenta lo que a
            throw new NotImplementedException();
        }


        public Vehiculo? GetById(string id)
        {
            return ls.Where(x=>x.Placa==id).SingleOrDefault();
        }

        public List<Vehiculo> GetAll(int id = -1)
        {
            return ls;
        }

        public bool Add(Vehiculo obj)
        {
            var m = ls.Where(x => x.Placa == obj.Placa).SingleOrDefault();
            if (m == null)
            {
                ls.Add(obj);
                return true;
            }
            return false;
        }

        public bool Update(Vehiculo obj)
        {
            var v = ls.Where(x => x.Placa == obj.Placa).SingleOrDefault();
            if (v != null)
            {
                ls.Remove(v);
                    ls.Add(obj);
                return true;
            }
            return false;
        }


        public bool Delete(string id)
        {
            var m = ls.Where(x=>x.Placa==id).SingleOrDefault();
            if(m != null)
            {
                ls.Remove(m);
                return true;
            }
            return false;
        }

        public int Count()
        {
            return ls.Count();
        }

        public int Count(DateTime dt, int days = 0)
        {
            var hoy = DateTime.Now;
            return ls.Count (x=> x.FechaCreacion <=hoy.AddDays(-days));
        }
        public List<VehiculoDTO> GetAllDTO()
        {
            var lsMar = mrDao.GetAll();
            var lsPro = prDao.GetAll();
            var ls = GetAll();

            List<VehiculoDTO> res = new List<VehiculoDTO>();
            ls.ForEach(v =>
            {
                var marca = lsMar.FirstOrDefault(m => m.Id == v.IdMarca);
                var propietario = lsPro.FirstOrDefault(p => p.Id == v.IdPropietario);

                res.Add(new VehiculoDTO()
                {
                    Placa = v.Placa,
                    Modelo = v.Modelo,
                    AnioProduccion = v.AnioProduccion,
                    Color = v.Color,
                    Marca = marca?.Nombre,
                    Propietario = propietario?.Nombre
                });
            });

            return res;
        }
    }
}
