using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaOnline.Controllers
{
    static class GlobalVariables
    {
        //BANCO DE DADOS
        public static String server_db = "localhost";
        public static String uid_db = "root"; 
        public static String pwd_db = ""; 
        public static String database_db = "bibliotecaonlinedb";

        //USUÁRIO LOGADO
        public static String userID;
        public static String userType;
        public static String userName;
        public static String userLivroAtualID = "0";
        public static String userLivroDataPegou;
        public static String userLivroExpira;
    }
}
