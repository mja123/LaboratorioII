using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DesafioElectrodomesticosWF.Controller
{
    static class ValidacionDatos
    {
        static private bool validarPeso(int peso)
        {
            if (peso < 0)
            {
                return false;
            }
            return true;
        }
        static private bool validarPrecio(int precioBase)
        {
            if (precioBase < 0)
            {
                return false;
            }
            return true;
        }
        static private bool validarConsumo(string consumo)
        {
            String valorConsumo = consumo.ToUpper();
            if (valorConsumo != "A" && valorConsumo != "B" && valorConsumo != "C" && valorConsumo != "D"
                && valorConsumo != "E" && valorConsumo != "F" && valorConsumo != "")
            {
                return false;
            }
            return true;
        }

        static private bool validarColor(string color)
        {
            String colorIngresado = color.ToLower();

            if (colorIngresado != "negro" && colorIngresado != "rojo" && colorIngresado != "azul"
                && colorIngresado != "gris" && colorIngresado != "blanco" && colorIngresado != "")
            {
                return false;
            }

            return true;
        }

        static private bool validarResolucion(float resolucion)
        {
            if (resolucion < 0)
            {
                return false;
            }
            return true;
        }

        static private bool validarCarga(int carga)
        {
            if (carga < 0)
            {
                return false;
            }
            return true;
        }
        static public ArrayList validacionElectrodomesticos(int peso, int precioBase, string color, string consumo, ArrayList errores)
        {

            if (!ValidacionDatos.validarPeso(peso))
            {
                errores.Add("peso");
            }
            if (!ValidacionDatos.validarPrecio(precioBase))
            {
                errores.Add("precio");
            }
            if(!ValidacionDatos.validarColor(color))
            {
                errores.Add("color");
            }
            if (!validarConsumo(consumo))
            {
                errores.Add("consumo");
            }
            return errores;
        }

        static public ArrayList validacionLavadora(int peso, int precioBase, string color, string consumo, int carga, ArrayList errores)
        {

            errores = validacionElectrodomesticos(peso, precioBase, color, consumo, errores);

            if (!validarCarga(carga))
            {
                errores.Add("carga");
            }
            return errores;
        }

        static public ArrayList validacionTelevisor(int peso, int precioBase, string color, string consumo, float resolucion, ArrayList errores)
        {

            errores = validacionElectrodomesticos(peso, precioBase, color, consumo, errores);

            if (!validarResolucion(resolucion))
            {
                errores.Add("resolucion");
            }
            return errores;
        }

    }
}
