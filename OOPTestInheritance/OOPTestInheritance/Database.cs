using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestInheritance;

internal class Database
{
    public string? Conn { get; set; } = @"Server=(LocalDB)\MSSQLLocalDB; Database=h1Tutorial001; Trusted_connection=true; TrustServerCertificate=true;";

    public string? Insert { get; set; }
    public string? Delete { get; set; }
    public bool GoodButterfly { get; set; }
    public string? query { get; set; }
    
    public void InsertDelete(string query)
    {
        Butterfly butterfly = new Butterfly();
        SqlConnection con = new SqlConnection(Conn);
        con.Open();
        if (GoodButterfly = true)
        {
            string Insert = $"insert into animal values '{butterfly.Color}','{butterfly.Age}','{butterfly.Name}','{butterfly.FirstName}','{butterfly.LastName}');";

        }
        else
        {
            string Delete = $"delete from animal where name = {butterfly.Name}";
        }
       
        SqlCommand cmd = new SqlCommand(query, con);

        cmd.ExecuteNonQuery();
    }
}
