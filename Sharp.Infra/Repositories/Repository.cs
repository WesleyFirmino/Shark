using Sharp.Infra.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Sharp.Infra.Repositories
{
    public class Repository
    {
        public static List<UserList> SearchUser()
        {
            var listUser = new List<UserList>();

            try
            {
                var sql = @"SELECT [ClienteRoboUsuarioId],[Usuario],[Senha],[UsuarioAtivo],[ClienteRoboId],[SiteId],[MaquinaUtilizando],[UsuarioMaquina] FROM [ROBOCOB].[dbo].[ClienteRoboUsuarios] WHERE Usuario = 'E998038'";

                MySqlConnectionStringBuilder connectionStringBuilder =
                    new MySqlConnectionStringBuilder(Properties.Settings.Default.Setting);

                using (var conection = new MySqlConnection(connectionStringBuilder.ToString()))
                {
                    var command = new MySqlCommand(sql, conection);

                    try
                    {
                        conection.Open();


                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception e)
            {
                
            }

            return listUser;
        }
    }
}
