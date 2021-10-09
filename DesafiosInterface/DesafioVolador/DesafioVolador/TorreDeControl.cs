using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioVolador
{
    class TorreDeControl
    {
        private List<Volador> voladores;

        public TorreDeControl()
        {
            voladores = new List<Volador>();
        }

        public void vuelenTodos()
        {
            foreach(Volador objetoVolador in voladores)
            {
                objetoVolador.volar();
            }
        }

        public void agregarVolador(Volador unVolable)
        {
            voladores.Add(unVolable);
        }
    }
}
