using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs
{
    internal class FiguraDAL : IFiguraDAL
    {
        List<FiguraModel> Figuras = new List<FiguraModel>();

        public FiguraModel Add(FiguraModel model)
        {
            throw new NotImplementedException();
        }

        public List<FiguraModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public FiguraModel GetById(int id)
        {
            return (from f in Figuras
                    where f.Id == id
                    select f).FirstOrDefault();

        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public FiguraModel Save(FiguraModel entidad)
        {
            var f = GetById(entidad.Id);

            if (f == null) return null;

            if (f.GetType() != entidad.GetType()) return null;

            if (entidad is RectanguloModel r)
            {
                var fr = f as RectanguloModel;
                fr.Area = r.Area;
                fr.Ancho = r.Ancho;
                fr.Largo = r.Largo;
            }
            else if (entidad is CirculoModel c)                  
            {
                var fr = f as CirculoModel;
                fr.Radio = c.Radio;
            }
            return f;

        }
    }
}
