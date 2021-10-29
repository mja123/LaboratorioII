using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioElectrodomesticosWF.Controller
{
    class ControllerMain
    {
        public int precioPrueba, constructorIngresado;
        private int peso, precioBase, carga;
        private string color, consumo;
        private string tipo = "";
        private float resolucion;
        private bool sintonizador;
        private Model.Electrodomestico electrodomestico;
        private Model.Lavadora lavadora;
        private Model.Televisor televisor;
        public ControllerMain(string peso, string color, string consumo, string precioBase, string resolucion, bool sintonizador) : this(peso, color, consumo, precioBase)
        {
            
            if (eleccionConstructor(peso, color, consumo, precioBase, carga : "", resolucion, sintonizador) == 0)
            {
                televisor = new Model.Televisor();
                constructorIngresado = 0;
            }
            else
            {
                this.peso = DesafioElectrodomesticos.Utiles.validacionInt(peso);
                this.precioBase = DesafioElectrodomesticos.Utiles.validacionInt(precioBase);

                if (eleccionConstructor(peso, color, consumo, precioBase, carga: "", resolucion, sintonizador) == 2)
                {
                    televisor = new Model.Televisor(this.precioBase, this.peso);
                    constructorIngresado = 2;
                } else
                {
                    this.sintonizador = sintonizador;
                    this.resolucion = DesafioElectrodomesticos.Utiles.validacionFloat(resolucion);
                    this.color = color;
                    this.consumo = consumo;
                    televisor = new Model.Televisor(this.precioBase, this.color, this.consumo, this.peso, this.resolucion, this.sintonizador);
                    constructorIngresado = 4;
                }
            }

            this.tipo = "tele";           
        }

        public ControllerMain(string peso, string color, string consumo, string precioBase, string carga) : this(peso, color, consumo, precioBase)
        {
            if (eleccionConstructor(peso, color, consumo, precioBase, carga) == 0)
            {
                lavadora = new Model.Lavadora();
                constructorIngresado = 0;
            } else
            {
                this.precioBase = DesafioElectrodomesticos.Utiles.validacionInt(precioBase);
                this.peso = DesafioElectrodomesticos.Utiles.validacionInt(peso);

                if (eleccionConstructor(peso, color, consumo, precioBase, carga) == 2)
                {
                    lavadora = new Model.Lavadora(this.precioBase, this.peso);
                    constructorIngresado = 2;

                } else
                {
                    this.carga = DesafioElectrodomesticos.Utiles.validacionInt(carga);
                    this.color = color;
                    this.consumo = consumo;
                    lavadora = new Model.Lavadora(this.precioBase, this.color, this.consumo, this.peso, this.carga);
                    constructorIngresado = 4;
                }
            }
            this.tipo = "lavadora";
        }

        public ControllerMain(string peso, string color, string consumo, string precioBase)
        {
            if (eleccionConstructor(peso, color, consumo, precioBase) == 0)
            {
                electrodomestico = new Model.Electrodomestico();
                constructorIngresado = 0;
            } else
            {
                this.peso = DesafioElectrodomesticos.Utiles.validacionInt(peso);
                this.precioBase = DesafioElectrodomesticos.Utiles.validacionInt(precioBase);
                if ((eleccionConstructor(peso, color, consumo, precioBase) == 2))
                {
                    electrodomestico = new Model.Electrodomestico(this.precioBase, this.peso);
                    constructorIngresado = 2;
                } else
                {
                    this.color = color;
                    this.consumo = consumo;
                    electrodomestico = new Model.Electrodomestico(this.precioBase, this.color, this.consumo, this.peso);
                    constructorIngresado = 4;
                }
            }
            this.tipo = "electro";
            this.precioPrueba = this.precioBase;
        }

        public int eleccionConstructor(string peso, string color, string consumo, string precioBase,
            string carga = null, string resolucion = null, bool sintonizador = false)
        {
            
            if (precioBase == "" && peso == "")
                return 0;


            if (color != String.Empty && consumo != String.Empty && precioBase == String.Empty && precioBase == String.Empty)
                return 2;
            else
            {
                if (carga != null)
                    return 5;
                else if (resolucion != null)
                    return 6;
                else
                    return 4;
            }
        }
        public ArrayList errores()
        {
            ArrayList errores = new ArrayList();
            if (constructorIngresado != 0 && constructorIngresado != 2)
            {
                if (this.tipo == "electro")
                {
                    return ValidacionDatos.validacionElectrodomesticos(peso, precioBase, color, consumo, errores);
                }
                else if (this.tipo == "lavadora")
                {
                    return ValidacionDatos.validacionLavadora(peso, precioBase, color, consumo, carga, errores);
                }
                else
                {
                    return ValidacionDatos.validacionTelevisor(peso, precioBase, color, consumo, resolucion, errores);
                }
            }
            return errores;
           
        }
        public int calcularTotal()
        {

            if (this.tipo == "electro")
            { 
              
                 return electrodomestico.precioFinal();
                
            } if (this.tipo == "lavadora")
            {
                
                return lavadora.precioFinal();
            
            }
            else
            {               
            
                return televisor.precioFinal();

            }

        }
     
    }
}
