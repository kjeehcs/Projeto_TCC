﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_tcc.Model
{
    public class UsuariosDados
    {   
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public byte[] imagem_data { get; set; }

        public UsuariosDados() 
        {
        }
    }
}
