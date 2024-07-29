using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_de_cola
{
    public class User
    {
        private static MySqlConnection josemaria = new MySqlConnection("Server=LocalHost;DataBase=Biblioteca;Uid=root;Pwd=12345678;");
        public static string Usuario { get; set;}
        public static string Contraseña { get; set; }
        public static int Nivel { get; set; }
        private static bool a { get; set; }

        public static bool validar()
        {
            josemaria.Open();
            MySqlDataReader ola;
            MySqlCommand vali = new MySqlCommand("Select * from usuarios where usuario = '" + Usuario + "' AND Contraseña = '" + Contraseña + "';", josemaria);
            ola = vali.ExecuteReader();
            if (ola.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            josemaria.Close();
            return a;
        }
        public static bool Vusu()
        {
            josemaria.Open();
            MySqlDataReader olau;
            MySqlCommand usu = new MySqlCommand("Select * from usuarios where usuario = '" + Usuario + "';", josemaria);
            olau = usu.ExecuteReader();
            if (olau.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            josemaria.Close();
            return a;
        }
        public static bool Vcon()
        {
            josemaria.Open();
            MySqlDataReader olac;
            MySqlCommand con = new MySqlCommand("Select * from usuarios where contraseña = '" + Contraseña + "';", josemaria);
            olac = con.ExecuteReader();
            if (olac.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }    
            josemaria.Close();
            return a;
        }
        public static int Vnivel()
        {
            josemaria.Open();
            MySqlDataReader olan;
            MySqlCommand niv = new MySqlCommand("Select * from usuarios where usuario = '" + Usuario + "' AND Contraseña = '" + Contraseña + "';", josemaria);
            olan = niv.ExecuteReader();
            olan.Read();
            olan["Nivel"].ToString();
            if (olan["Nivel"].ToString() == "1")
            {
                Nivel = 1;
            }
            else if (olan["Nivel"].ToString() == "2")
            {
                Nivel = 2;
            }
            else if (olan["Nivel"].ToString() == "3")
            {
                Nivel = 3;
            }
            josemaria.Close();
            return Nivel;
        }
    }
}
