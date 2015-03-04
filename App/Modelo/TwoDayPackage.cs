using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class TwoDayPackage:Package
    {

        #region "Atributos"

        private string cuotafija;
        private string valorenvio;
        #endregion

        #region "Propiedades"

        public string CoutaEnvio
        {
            get { return cuotafija; }
            set { cuotafija = value; }
        }

        public string calculateCost
        {
            get { return valorenvio; }
            set { valorenvio = value; }
        }
        
        #endregion

        #region "Contructotres"

        public TwoDayPackage():base()
        {
            this.cuotafija = "500000";
            this.valorenvio = "100000";
        }

        public TwoDayPackage(string nombre, string direccion, string ciudad, string departamento, string codigoremitente, string codigodestinatario, string pesopaquete, string costoenvio, string cuotafija, string valorenvio)
            :base(nombre, direccion, ciudad, departamento, codigodestinatario, codigoremitente,pesopaquete, costoenvio)
        {
            this.cuotafija = cuotafija;
            this.valorenvio = valorenvio;
        }
        #endregion

        #region "Metodos Sobreescritos"

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}