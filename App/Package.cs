using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App
{
    public class Package
    {
        #region "Atributos"
        private string nombre;
        private string direccion;
        private string ciudad;
        private string departamento;
        private string codigoremitente;
        private string codigodestinatario;
        private string pesopaquete;
        private string costoenvio;
        #endregion

        #region "Propiedades"

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }


        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }


        public string DatosRemitente
        {
            get { return codigoremitente; }
            set { codigoremitente = value; }
        }

        public string DatosDestinatario
        {
            get { return codigodestinatario; }
            set { codigodestinatario = value; }
        }

        public string PesoPaquete
        {
            get { return pesopaquete; }
            set { pesopaquete = value; }
        }

        public string calculateCost
        {
            get { return costoenvio; }
            set { costoenvio = value; }
        }
        #endregion
    

        #region "Contructores"

   public Package()
{

    this.nombre="Nombre Y Apellidos";
    this.direccion="Barrio Nuevo Bosque";
    this.ciudad="Cartagena";
    this.departamento="Bolivar";
    this.codigoremitente="1243";
    this.codigodestinatario="00220";
    this.pesopaquete="";
    this.costoenvio="10000";

}
    public Package(string nombre, string direccion, string ciudad, string departamento, string codigoremitente, string codigodestinatario, string pesopaquete, string costoenvio)
{
    this.nombre=nombre;
    this.direccion=direccion;
    this.ciudad=ciudad;
    this.departamento=departamento;
    this.codigoremitente=codigoremitente;
    this.codigodestinatario=codigodestinatario;
    this.pesopaquete=pesopaquete;
    this.costoenvio=costoenvio;
}

    #endregion


        #region "Metodos Sobreescritos"

        public override string ToString()
{
 	 return "\n=============="+
         "Nombre:"+this.nombre+
         "Direccion:"+this.direccion+
         "Ciudad:"+this.ciudad+
         "Departamento:"+this.departamento+
         "DatosRemitente:"+this.codigoremitente+
         "DatosDestinatario:"+this.codigodestinatario+
         "PesoPaquete:"+this.pesopaquete+
         "ValorEnvio:"+this.costoenvio;


        
        public override bool Equals(object obj)
{
 	 return base.Equals(obj);

           
}
        public override int GetHashCode()
{
 	 return base.GetHashCode();
}
        
        }




        #endregion

}