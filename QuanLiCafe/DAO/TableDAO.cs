using QuanLiCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLiCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC dbo.USP_LoadTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;


    }
}
