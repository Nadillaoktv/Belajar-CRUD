﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belajar_CRUD
{
    internal class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;PWD=;Database=db_siswa");
    }
}
