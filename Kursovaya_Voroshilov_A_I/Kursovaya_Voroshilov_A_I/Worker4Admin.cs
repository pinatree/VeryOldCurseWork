using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.IO;

namespace Kursovaya_Voroshilov_A_I
{
    class Worker4Admin
    {
        public bool AsAdmin = false;

        OleDbConnection Coursach_Connection = new OleDbConnection();

        internal Worker4Admin()
        {
            try
            {
                Coursach_Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + @"\Copy_of_cursach.mdb" + ";Persist Security Info=False;";
                Coursach_Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal Worker4Admin(bool AsAdmin, string path)
        {
            try
            {
                Coursach_Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Persist Security Info=False;";
                Coursach_Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            this.AsAdmin = AsAdmin;
        }

        internal Worker4Admin(bool AsAdmin, string path, string password)
        {
            try
            {
                Coursach_Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Jet OLEDB:Database Password=" + password +";";
                Coursach_Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            this.AsAdmin = AsAdmin;
        }
        

        public string ReturnChastZaprosaFromArguments(string StolbecName, string type /*value|region|perechisleniye*/, string Logic /*=|<>|~*/, string StolbecIntOrString, bool SetAnd, string[] Values, string[] between)
        {
            string Zapros = " ";

            if (SetAnd)
            {
                Zapros = " and ";
            }

            switch (type)
            {
                case ("value"):
                    {
                        #region ValueCode

                        if (StolbecIntOrString == "string")
                        {
                            Zapros = Zapros + StolbecName + Logic + "'" + Values[0] + "'";

                        }
                        else if (StolbecIntOrString == "int")
                        {
                            Zapros = Zapros + StolbecName + Logic + Values[0];
                        }
                        else if (StolbecIntOrString == "date")
                        {
                            Values[0] = Values[0].Replace('.', '-');
                            Zapros = Zapros + StolbecName + Logic + "#" + Values[0] + "#";
                        }
                        break;

                        #endregion ValueCode
                    }
                case ("region"):
                    {
                        #region RegionCode

                        if (StolbecIntOrString == "date")
                        {
                            if (Logic == "=")
                            {
                                between[0] = "#" + between[0].Replace('.', '-') + "#";
                                between[1] = "#" + between[1].Replace('.', '-') + "#";
                                Zapros = Zapros + StolbecName + " BETWEEN " + between[0] + " AND " + between[1];
                            }
                            else if (Logic == "<>")
                            {
                                between[0] = "#" + between[0].Replace('.', '-') + "#";
                                between[1] = "#" + between[1].Replace('.', '-') + "#";
                                Zapros = Zapros + StolbecName + " NOT BETWEEN " + between[0] + " AND " + between[1];
                            }
                        }
                        else if (StolbecIntOrString == "int")
                        {
                            if (Logic == "=")
                            {
                                Zapros = Zapros + StolbecName + " BETWEEN " + between[0] + " AND " + between[1];
                            }
                            else if (Logic == "<>")
                            {
                                Zapros = Zapros + StolbecName + " NOT BETWEEN " + between[0] + " AND " + between[1];
                            }

                        }

                        #endregion RegionCode
                        break;
                    }
                case ("perechisleniye"):
                    {
                        #region PerechisleniyeCode

                        if (StolbecIntOrString == "string")
                        {
                            if (Logic == "=")
                            {
                                Zapros = Zapros + StolbecName + " in (";
                            }
                            else if (Logic == "<>")
                            {
                                Zapros = Zapros + StolbecName + " not in (";
                            }

                            bool UjeWas = false;

                            foreach (string s in Values)
                            {
                                if (!UjeWas)
                                {
                                    Zapros = Zapros + "'" + s + "'";
                                    UjeWas = true;
                                }
                                else
                                {
                                    Zapros = Zapros + ", " + "'" + s + "'";
                                }
                            }
                            Zapros = Zapros + ")";
                        }
                        else if (StolbecIntOrString == "int")
                        {
                            if (Logic == "=")
                            {
                                Zapros = Zapros + StolbecName + " in (";
                            }
                            else if (Logic == "<>")
                            {
                                Zapros = Zapros + StolbecName + " not in (";
                            }

                            bool UjeWas = false;

                            foreach (string s in Values)
                            {
                                if (!UjeWas)
                                {
                                    Zapros = Zapros + s;
                                    UjeWas = true;
                                }
                                else
                                {
                                    Zapros = Zapros + ", " + s;
                                }
                            }
                            Zapros = Zapros + ")";
                        }
                        else if (StolbecIntOrString == "date")
                        {
                            if (Logic == "=")
                            {
                                Zapros = Zapros + StolbecName + " in (";
                            }
                            else if (Logic == "<>")
                            {
                                Zapros = Zapros + StolbecName + " not in (";
                            }

                            bool UjeWas = false;

                            foreach (string s in Values)
                            {
                                if (!UjeWas)
                                {
                                    Zapros = Zapros + "#" + s.Replace('.', '-') + "#";
                                    UjeWas = true;
                                }
                                else
                                {
                                    Zapros = Zapros + ", " + "#" + s.Replace('.', '-') + "#";
                                }
                            }
                            Zapros = Zapros + ")";
                        }
                        break;
                        #endregion PerechisleniyeCode
                    }
            }
            return Zapros;
        }


        public DataTable GetFullTableFromZapros(string TableName)
        {
            OleDbCommand TekCommand = new OleDbCommand();
            TekCommand.CommandText = "select * from " + TableName;
            TekCommand.Connection = Coursach_Connection;

            OleDbDataAdapter DatAdapt = new OleDbDataAdapter(TekCommand);
            DataTable TekTable = new DataTable();
            DatAdapt.Fill(TekTable);
            return TekTable;
        }

        public DataTable GetTableFromZapros(string Zapros)
        {
            OleDbCommand TekCommand = new OleDbCommand();
            TekCommand.CommandText = Zapros;
            TekCommand.Connection = Coursach_Connection;

            OleDbDataAdapter DatAdapt = new OleDbDataAdapter(TekCommand);
            DataTable TekTable = new DataTable();
            DatAdapt.Fill(TekTable);
            return TekTable;
        }

        public int SetZapros(string Zapros)
        {
            OleDbCommand TekCommand = new OleDbCommand();
            TekCommand.CommandText = Zapros;
            TekCommand.Connection = Coursach_Connection;

            return TekCommand.ExecuteNonQuery();
        }




        public OleDbConnection TekOleDbConnection
        {
            get
            {
                return Coursach_Connection;
            }
            set
            {
                Coursach_Connection = value;
            }
        }

    }
}
