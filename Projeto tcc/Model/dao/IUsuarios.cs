using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_tcc.Model;

namespace Projeto_tcc.Model
{
    public interface IUsuarios
    {
        List<Usuarios> findAll();
        Usuarios findById(int id);
        void insert(Usuarios obj);
        void update(Usuarios obj);


    }
}
