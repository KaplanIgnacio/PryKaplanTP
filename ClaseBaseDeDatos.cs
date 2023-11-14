using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Reflection.Emit;



namespace PryTpLab2
{
    internal class ClaseBaseDeDatos
    {
        //Objetos
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Bin\\Debug\\VERDULEROS";

        public string estadoConexion = "";
        public string datosTabla;

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }
        }
        public void TraerDatos(DataGridView grilla)
        {
            //instancia un objeto en la memoria
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Productos";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("Codigo del Producto", "Codigo del Producto");
            grilla.Columns.Add("NomProducto", "NomProducto");
            grilla.Columns.Add("IDGrupo", "IDGrupo");
            grilla.Columns.Add("Precio", "Precio");
            

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {

                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7]);
                }
            }
        }

        public void BuscarPorCodigo(int codigo)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            //Que tipo de operacion quier hacer y que me traiga toda la tabla con el tabledirect
            comandoBD.CommandText = "Productos";
            //Que tabla traigo

            lectorBD = comandoBD.ExecuteReader();
            //Abre la tabla y muestra por renglón

            if (lectorBD.HasRows) //SI TIENE FILAS
            {
                bool Find = false; // bandera
                while (lectorBD.Read()) //mientras pueda leer, mostrar (leer)
                {
                    if (int.Parse(lectorBD[0].ToString()) == codigo)
                    {

                        //datosTabla += "-" + lectorBD[0]; //dato d la comlumna 0
                        MessageBox.Show("Cliente Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Find = true; // bandera
                        break;
                    }

                }
                if (Find == false)
                {
                    MessageBox.Show("NO Existente " + lectorBD[0], "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void actividadCliente(int codigo)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "Productos";

            adaptadorBD = new OleDbDataAdapter(comandoBD);
            adaptadorBD.Fill(objDataSet, "Productos");

            DataTable dt = objDataSet.Tables["Productos"];

            foreach (DataRow dr in dt.Rows)
            {

                if ((int)dr["Codigo del Producto"] == codigo)
                {
                    if ((bool)dr["ACTIVIDAD"] == false)
                    {
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = true;
                        dr.EndEdit();
                        break;
                    }
                    else if ((bool)dr["ACTIVIDAD"] == true)
                    {
                        dr.BeginEdit();
                        dr["ACTIVIDAD"] = false;
                        dr.EndEdit();
                        break;
                    }
                }
            }

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);

            adaptadorBD.Update(objDataSet, "Productos");
        }


    }
}
