using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TP1_SG2
{
    class Parametros
    {
        static string connectionString = null;

        public static string getConnectionString()
        {
            if (connectionString == null)
            {
                XmlDocument datos = new XmlDocument();
                datos.Load("parametros.xml");

                XmlNodeList param = datos.GetElementsByTagName("conexion");
                            

                connectionString = "Data Source=" + param[0]["servidor"].InnerText + "; Initial Catalog=" + param[0]["database"].InnerText
                    + "; Integrated Security=yes";

            }


            return (connectionString);
        }

    }
}
