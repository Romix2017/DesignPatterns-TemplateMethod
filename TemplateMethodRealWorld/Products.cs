using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodRealWorld
{
    public class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Products");
        }
        public override void Process()
        {
            Console.WriteLine("Products ------");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
}
