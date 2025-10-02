using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometriaModels.Models;

namespace GeometriaModels.DALs
{
    internal interface IFiguraDAL
    {
        
        List<FiguraModel> GetAll();
        FiguraModel GetById(int id);
        FiguraModel Add(FiguraModel model);
        FiguraModel Save(FiguraModel entidad);
        void Remove (int id);
              
    }
}
