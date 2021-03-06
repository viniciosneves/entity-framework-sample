﻿using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class UsuarioDao
    {
        private EntidadesContext contexto;

        public UsuarioDao()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        internal void SaveChanges()
        {
            contexto.SaveChanges();
        }

        internal void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();

        }

        public Usuario BuscaPorID(int id)
        {

            return contexto.Usuarios.FirstOrDefault(u => u.ID == id);

        }
    }
}
