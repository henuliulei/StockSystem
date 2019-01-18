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

namespace gp.View
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
   
    public partial class Page1 : Page
    {
        public string a6 = "";
        public Page1()
        {
            InitializeComponent();
            string sql = "select user_id from users where login_name='" + selected.Person.name + "'";
            Bussiness business = new Bussiness();
            DataTable dataTable2 = new DataTable();
            dataTable2 = business.ExecuteQuery(sql);
            string userid = dataTable2.Rows[0][0].ToString();
         //   string sql = "select stock_id from user_positions where user_id in ( select user_id from users where name='" + selected.Person.name + "')";
            string sql1 = "select num_free from user_positions where user_id='" + userid + "' ";
            string sql2 = "select cny_free from users where name='" + selected.Person.name + "'";
            Bussiness s = new Bussiness();
            DataTable dataTable = new DataTable();
            DataTable dataTable1 = new DataTable();
            DataTable dataTable112 = new DataTable();
            dataTable = s.ExecuteQuery(sql1);
            if (dataTable.Rows.Count > 0)
            {
                stock_free.Text = dataTable.Rows[0][0].ToString();
                stock_free1.Text = dataTable.Rows[0][0].ToString();
            }
            else
            {
                stock_free.Text = "0";
                stock_free1.Text = "0";
            }
            string sql22 = "select cny_freezed from users where name='" + selected.Person.name + "'";
            dataTable1 = s.ExecuteQuery(sql2);
            dataTable112 = s.ExecuteQuery(sql22);
            string a1 = dataTable1.Rows[0]["cny_free"].ToString();
            string a2 = dataTable112.Rows[0]["cny_freezed"].ToString();
            decimal a3 = 0;
            decimal a4 = 0;
            decimal a5 = 0;
            a3 = decimal.Parse(a1);
            a4 = decimal.Parse(a2);
            a5 = a3 + a4;

            a6 = a5.ToString();
            money_free.Text = a5.ToString();
            money_free1.Text = a5.ToString();
           

        }
        TextBlock objChk;
        string stock;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stock = this.stockname.Text;
            string sql;
            if (stock.Equals(""))
            {
                sql = "select * from stocks";
            }
            else
            {
                sql = "select * from stocks where name='" + stock + "'";
            }
            Bussiness s = new Bussiness();
            DataTable dataTable = new DataTable();
            dataTable = s.ExecuteQuery(sql);
            dataggrid1.DataContext = dataTable;
          
        }

        private void Item_GotFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "select user_id from users where login_name='" + selected.Person.name + "'";
                Bussiness business = new Bussiness();
                DataTable dataTable = new DataTable();
                dataTable = business.ExecuteQuery(sql);
                string userid = dataTable.Rows[0][0].ToString();

                var item = (DataGridRow)sender;
                //  MessageBox.Show(item[0][0]);
                FrameworkElement objElement = dataggrid1.Columns[0].GetCellContent(item);
                FrameworkElement objElement1 = dataggrid1.Columns[1].GetCellContent(item);
                FrameworkElement objElement2 = dataggrid1.Columns[2].GetCellContent(item);
                if (objElement != null && objElement1 != null && objElement2 != null)
                {
                    price.Clear();
                    undealed.Clear();
                    totolprice.Clear();
                    objChk = (TextBlock)objElement;
                    TextBlock objChk1 = (TextBlock)objElement1;
                    TextBlock objChk2 = (TextBlock)objElement2;
                    stock = objElement.ToString();

                    stocknameid.Text = objChk.Text + " " + objChk1.Text + " " + objChk2.Text;
                    price.Text = objChk2.Text;
                    price1.Text = objChk2.Text;
                }
                string s1 = objChk.Text;
                string sqla = "select stock_id from user_positions where user_id in ( select user_id from users where name='" + selected.Person.name + "')";
                string sql11 = "select num_free from user_positions where user_id='" + userid + "'  and stock_id='" + s1 + "'";
                string sql21 = "select cny_free from users where name='" + selected.Person.name + "'";
                Bussiness s = new Bussiness();
                DataTable dataTable21 = new DataTable();
                DataTable dataTable11 = new DataTable();
                dataTable21 = s.ExecuteQuery(sql11);
                if (dataTable21.Rows.Count > 0)
                {
                    stock_free.Text = dataTable21.Rows[0][0].ToString();
                    stock_free1.Text = dataTable21.Rows[0][0].ToString();
                }
                else
                {
                    stock_free.Text = "0";
                    stock_free1.Text = "0";
                }
                string sql22 = "select cny_freezed from users where name='" + selected.Person.name + "'";
                DataTable dataTable112 = new DataTable();
                dataTable11 = s.ExecuteQuery(sql21);
                dataTable112 = s.ExecuteQuery(sql22);
                string a1 = dataTable11.Rows[0]["cny_free"].ToString();
                string a2 = dataTable112.Rows[0]["cny_freezed"].ToString();
                decimal a3 = 0;
                decimal a4 = 0;
                decimal a5 = 0;
                a3 = decimal.Parse(a1);
                a4 = decimal.Parse(a2);
                a5 = a3 + a4;

              
                money_free.Text = a5.ToString();
                money_free1.Text =a5.ToString();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal num = decimal.Parse(price.Text);
                int count = int.Parse(undealed.Text);
                decimal totolpricepp = count * num;
                totolprice.Text = totolpricepp.ToString();
                Bussiness business = new Bussiness();
                string username = selected.Person.name;

                string sql = "select user_id from users where login_name='" + username + "'";

                DataTable dataTable = new DataTable();
                dataTable = business.ExecuteQuery(sql);
                string userid = dataTable.Rows[0][0].ToString();
                string sqlinsert = "insert into orders values('" + DateTime.Now.ToString() + "','" + userid + "','" + objChk.Text + "',0,'" + num + "','" + count + "',0,0)";
                int m = business.ExecuteUpdate(sqlinsert);
                string s1 = objChk.Text;
                string sqla = "select stock_id from user_positions where user_id in ( select user_id from users where name='" + selected.Person.name + "')";
                string sql11 = "select num_free from user_positions where user_id='" + userid + "'  and stock_id='" + s1 + "'";
                string sql21 = "select cny_free from users where name='" + selected.Person.name + "'";
                Bussiness s = new Bussiness();
                DataTable dataTable21 = new DataTable();
                DataTable dataTable11 = new DataTable();
                dataTable21 = s.ExecuteQuery(sql11);
                if (dataTable21.Rows.Count > 0)
                {
                    stock_free.Text = dataTable21.Rows[0][0].ToString();
                    stock_free1.Text = dataTable21.Rows[0][0].ToString();
                }
                else
                {
                    stock_free.Text = "0";
                    stock_free1.Text = "0";
                }
                string sql22 = "select cny_freezed from users where name='" + selected.Person.name + "'";
                DataTable dataTable112 = new DataTable();
                dataTable11 = s.ExecuteQuery(sql21);
                dataTable112 = s.ExecuteQuery(sql22);
                string a1 = dataTable11.Rows[0]["cny_free"].ToString();
                string a2 = dataTable112.Rows[0]["cny_freezed"].ToString();
                decimal a3 = 0;
                decimal a4 = 0;
                decimal a5 = 0;
                a3 = decimal.Parse(a1);
                a4 = decimal.Parse(a2);
                a5 = a3 + a4;

               
                if (m > 0&& Messagebox.MyMessageBox.ShowDialog("确定下订单？", Messagebox.MyMessageBox.OKCANCLE).Value == true)
                {
                    Messagebox.MyMessageBox.Show("委托成功");
                    money_free.Text = a5.ToString();
                    money_free1.Text = a5.ToString();
                    a6 = a5.ToString();
                    this.clear();
                }
                else
                {
                    Messagebox.MyMessageBox.Show("委托失败");
                    money_free.Text = a6.ToString();
                    money_free1.Text = a6.ToString();
                    this.clear();
                }
            }
            catch
            {

                this.clear();
                this.clear();
                Messagebox.MyMessageBox.Show("请输入正确的数量格式");
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                Bussiness s = new Bussiness();
                decimal num1 = decimal.Parse(price1.Text);
                int count = int.Parse(undealed1.Text);
                decimal totolpricepp = count * num1;
                totolprice1.Text = totolpricepp.ToString();
                Bussiness business = new Bussiness();
                string username = selected.Person.name;

                string sql = "select user_id from users where login_name='" + username + "'";

                DataTable dataTable = new DataTable();
                dataTable = business.ExecuteQuery(sql);
                string userid = dataTable.Rows[0][0].ToString();
                string s1 = objChk.Text;
                string sqlqw = "select num_free from user_positions where user_id='" + userid + "' and stock_id='" + s1 + "'";
                DataTable dataTableqw = new DataTable();
                dataTableqw = s.ExecuteQuery(sqlqw);
                string qw;
                if (dataTableqw.Rows.Count > 0)
                {
                    qw = dataTableqw.Rows[0][0].ToString();
                }
                else
                {
                    qw = "0";
                }

                if (int.Parse(qw) > count)
                {


                    string sqlinsert = "insert into orders values('" + DateTime.Now.ToString() + "','" + userid + "','" + objChk.Text + "',1,'" + num1 + "','" + count + "',0,0)";
                    int m = business.ExecuteUpdate(sqlinsert);

                    string sqla = "select stock_id from user_positions where user_id in ( select user_id from users where name='" + selected.Person.name + "')";
                    string sql11 = "select num_free from user_positions where user_id='" + userid + "' and stock_id='" + s1 + "'";
                    string sql21 = "select cny_free from users where name='" + selected.Person.name + "'";

                    DataTable dataTable21 = new DataTable();
                    DataTable dataTable11 = new DataTable();
                    dataTable21 = s.ExecuteQuery(sql11);
                    if (dataTable21.Rows.Count > 0)
                    {
                        stock_free.Text = dataTable21.Rows[0][0].ToString();
                        stock_free1.Text = dataTable21.Rows[0][0].ToString();
                    }
                    else
                    {
                        stock_free.Text = "0";
                        stock_free1.Text = "0";
                    }

                    dataTable11 = s.ExecuteQuery(sql21);
                    string sql22 = "select cny_freezed from users where name='" + selected.Person.name + "'";
                    DataTable dataTable112 = new DataTable();
                    dataTable11 = s.ExecuteQuery(sql21);
                    dataTable112 = s.ExecuteQuery(sql22);
                    string a1 = dataTable11.Rows[0]["cny_free"].ToString();
                    string a2 = dataTable112.Rows[0]["cny_freezed"].ToString();
                    decimal a3 = 0;
                    decimal a4 = 0;
                    decimal a5 = 0;
                    a3 = decimal.Parse(a1);
                    a4 = decimal.Parse(a2);
                    a5 = a3 + a4;


                    
                    if (m > 0 && Messagebox.MyMessageBox.ShowDialog("确定下订单？", Messagebox.MyMessageBox.OKCANCLE).Value == true)
                    {
                        Messagebox.MyMessageBox.Show("委托成功");
                        money_free.Text = a5.ToString();
                        money_free1.Text = a5.ToString();
                        a6 = a5.ToString();
                        this.clear();
                    }
                    else
                    {
                        Messagebox.MyMessageBox.Show("委托失败");
                        money_free.Text = a6.ToString();
                        money_free1.Text = a6.ToString();
                        this.clear();
                    }
                }
                else
                {
                    Messagebox.MyMessageBox.Show("股票余额不足，无法卖出！");
                    money_free.Text = a6.ToString();
                    money_free1.Text = a6.ToString();
                    this.clear();
                }
            }
            catch
            {
                this.clear();
                this.clear();
                Messagebox.MyMessageBox.Show("请输入正确的数量格式");
              
            }
        }
        private void clear()
        {
            price.Clear();
            price1.Clear();
            undealed.Clear();
            undealed1.Clear();
            totolprice.Clear();
            totolprice1.Clear();
        }
    }
}


      
    