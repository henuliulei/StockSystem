using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace gp.selected
{
    /// <summary>
    /// Zhanghu1.xaml 的交互逻辑
    /// </summary>
    public partial class Zhanghu1 : Page
    {
        public Zhanghu1()
        {
            
            InitializeComponent();
          
              text.Text = Person.name;
            text.Text = Person.name;
            string sql;
            string sq = "select user_id from users where name='" + selected.Person.name + "'";
            sql = "select stock_id from user_positions where user_id in ( select user_id from users where name='" + selected.Person.name + "')";
            string sql1 = "select num_free,num_freezed,user_positions.stock_id,name,price from user_positions , stocks where user_positions.stock_id=stocks.stock_id  and user_positions.stock_id in (" + sql + ") and user_positions.user_id in (" + sq + ")";
            string sql2 = "select  name,create_datetime,name,type,orders.price,undealed,dealed,canceled from orders,stocks where stocks.stock_id=orders.stock_id";
            Bussiness s = new Bussiness();
            DataTable dataTable = new DataTable();
            dataTable = s.ExecuteQuery(sql1);
            dataggrid1.DataContext = dataTable;
            dataTable = s.ExecuteQuery(sql2);
            dataggrid2.DataContext = dataTable;

            //int i = 0;
            //int m = dataTable.Rows.Count;
            //while (i<m)
            //{
            //    if (int.Parse(dataTable.Rows[i][4].ToString())>0)
            //    {
            //        Button bu = new Button();
            //        dataggrid2.RowStyle = bu.Style;
            //    }
            //    i++;
            //}
          
        }
        // Person P = new Person();

    }
}
