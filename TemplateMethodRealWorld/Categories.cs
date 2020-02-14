using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodRealWorld
{
    public class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);
            dataset = new DataSet();
            dataAdapter.Fill(dataset, "Categories");
        }
        public override void Process()
        {
            Console.WriteLine("Categories -----");
            DataTable dataTable = dataset.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }
}
