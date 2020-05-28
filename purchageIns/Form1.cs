using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

/*
 * 
 * https://blog.naver.com/eltaron/221509825656
 * 
 * 
 * 
 */

namespace purchageIns
{
    public partial class Form1 : Form
    {
        con_Database db;
        DataTable dt;
        Util util = new Util();
        string search_month_lable = "";
        string save_s_date = "";
        string save_e_date = "";


        public Form1()
        {
            InitializeComponent();
            //initial year combobox

            

            init_make_year();

            db = new con_Database();
            //db.ConnectDB(); // db connectSystem.

            init_make_searchPayee();

            init_selectAll_payee(); 

            Console.WriteLine(" Form1 load ");

            TabPage myTap = new TabPage("test");
            TextBox tb = new TextBox();

            tb.Name = "textBo";

            myTap.Controls.Add(new DataGridView()
            {
                Name = "dataGridView_",
                //Dock = DockStyle.Fill,
                DataSource = dt
            });

            //ckl_searchPayee.SetItemChecked (ckl_searchPayee.Items.IndexOf("All"), true);

            //cb_searchYear.SelectedIndex = cb_searchYear.Items.IndexOf("2019");
            //   comboBox1.SelectedIndex = comboBox1.Items.IndexOf("test1");

            // 1 is payee , 2 is category, 3 is payMethod
            init_make_ComboBox(1);
            // 1 is payee , 2 is category, 3 is payMethod
            init_make_ComboBox(2);
            init_make_ComboBox(3);

            // init_make_ComboBox(1);
            // 1 is payee , 2 is category, 3 is payMethod
            init_make_ComboBox2(2);
            init_make_ComboBox2(3);
        }

        private void init_make_year()
        {
            for (int i = 2018; i <= 2020; i++)
            {
                cmb_year.Items.Add(i);
            }
            cmb_year.SelectedItem = DateTime.Now.Year;

        }
        private void init_make_ComboBox(int p_code)
        {
            // cb_payee.Items.Add()
            db.ConnectDB(); // db connectSystem.
            // grid.DataSource = dt;  ,sum([gst]) as gst_sum 
            string sql2 = "";
            sql2 = sql2 + "select p_code, c_code, name  from common_code ";
            sql2 = sql2 + "where  p_code = " + p_code + "";

            // DataAdapter da = new DataAdapter(sql2, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(sql2, db.getConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (p_code == 1)
            {
                cb_payee.DataSource = dt;
                cb_payee.DisplayMember = "name";
                cb_payee.ValueMember = "c_code";


            }
            else if (p_code == 2)
            {
                cb_category.DataSource = dt;
                cb_category.DisplayMember = "name";
                cb_category.ValueMember = "c_code";

            }
            else if (p_code == 3)
            {
                cb_payMethod.DataSource = dt;
                cb_payMethod.DisplayMember = "name";
                cb_payMethod.ValueMember = "c_code";
            }
            db.CloseDB();
        }

        private void init_make_ComboBox2(int p_code)
        {
            // cb_payee.Items.Add()
            db.ConnectDB(); // db connectSystem.
            // grid.DataSource = dt;  ,sum([gst]) as gst_sum 
            string sql2 = "";
            sql2 = sql2 + "select p_code, c_code, name  from common_code ";
            sql2 = sql2 + "where  p_code = " + p_code + "";

            // DataAdapter da = new DataAdapter(sql2, db.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(sql2, db.getConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (p_code == 1)
            {
                cb_payee.DataSource = dt;
                cb_payee.DisplayMember = "name";
                cb_payee.ValueMember = "c_code";


            }
            else if (p_code == 2)
            {
                searchCategory.DataSource = dt;
                searchCategory.DisplayMember = "name";
                searchCategory.ValueMember = "c_code";

            }
            else if (p_code == 3)
            {
                searchPayMethod.DataSource = dt;
                searchPayMethod.DisplayMember = "name";
                searchPayMethod.ValueMember = "c_code";
            }
            db.CloseDB();
        }

        private void init_make_searchPayee()
        {

            //https://jasmintime.com/179
            // dataBinding 을 이용한 방법 예제

            // ckl_searchPayee
            db.ConnectDB(); // db connectSystem.
            // grid.DataSource = dt;  ,sum([gst]) as gst_sum 
            string sql2 = "";
            sql2 = sql2 + "select p_code, c_code, name  from common_code ";
            sql2 = sql2 + "where  p_code = @p_code order by name asc";

            using (SqlCommand cmd = new SqlCommand(sql2, db.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p_code", 1);
                //db.getConnection().Open();
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    string p_code = "";
                    string c_code = "";
                    string name = "";
                    // ckl_searchPayee.Items.Add("All");
                    //ckl_searchPayee.SetItemChecked (ckl_searchPayee.Items.IndexOf("All"), true);
                    //ckl_searchPayee.Items.Add(new PayeeListBoxItem("0", "All"));
                    //ckl_searchPayee.SetItemChecked(ckl_searchPayee.Items.IndexOf("All"), true);
                    while (dr.Read())
                    {
                        p_code = dr["p_code"].ToString();
                        c_code = dr["c_code"].ToString();
                        name = dr["name"].ToString();
                        Console.WriteLine("p_code: " + p_code);
                        Console.WriteLine("c_code: " + c_code);
                        Console.WriteLine("name: " + name);
                        ckl_searchPayee.Items.Add(new PayeeListBoxItem(c_code, name));
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            db.CloseDB();

        }

        public void Maximum_Size()
        {
            //  this.FormBorderStyle = FormBorderStyle.None;
            //int upperBound
            int width = 0, height = 0;

            Screen[] sc = Screen.AllScreens;
            //upperBound = sc.GetUpperBound();

            this.Location = new System.Drawing.Point(0, 0);
            width = sc[0].WorkingArea.Width;
            height = sc[0].WorkingArea.Height;

            this.ClientSize = new System.Drawing.Size(width, height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.Maximum_Size();
            //panel1.Visible = false;
        }

        private void purchaseListAll()
        {
            if (save_s_date != "")
            {
                pucharseList(save_s_date, save_e_date);

            }
            else
            {
                Console.WriteLine(" button_click ");
                string sql = "select id, [regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc] , delete_flag,[createDate],'Modify' as Modify from [dbo].[purchase] order by regdate desc";
                db.ConnectDB(); // db connectSystem.
                dt = db.GetDBTable(sql);
                dataGridView1.DataSource = dt;
                db.CloseDB();  // db close
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            purchaseListAll();
        }
        /*
         * [dbo].[purchase]
         * [Id] INT NOT NULL identity(1,1) PRIMARY KEY, 
            [regDate] DATETIME NULL, 
            [payMethod] NVARCHAR(50) NULL, 
            [checkNo] NVARCHAR(50) NULL, 
            [payee] NVARCHAR(50) NULL, 
            [total] NUMERIC(18, 2) NULL, 
            [gst] NUMERIC(18, 2) NULL, 
            [category] NVARCHAR(50) NULL, 
            [etc] NVARCHAR(500) NULL, 
            [createDate] DATETIME NULL
         * 
         * 
         */

        /*
         * string str = string.Format("INSERT INTO Table(ID, Name, Dates) VALUES ('{0}', '{1}', '{2:yyyy/mm/dd}');", textBox1.Text, textBox2.Text, dateTime); 
            SqlCommand cmd = new SqlCommand(str, con); 

            public class Contract
{
    public int EmployeeID { get; set; }
    public string Agency { get; set; }
    public string Role { get; set; }
    ... and so on
}var contract = new Contract {
    EmployeeID = 22,
    Agency = "unknown",
    Role = "important", 
    ...
};
newCmd.Parameters.AddWithValue("@EmployeeID", contract.EmployeeID);
            */

        private void btn_create_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" btn_create_Click ");
            //  MessageBox.Show("cb_category.Text" + cb_category.Text);
            //validation check
            if (String.IsNullOrWhiteSpace(cb_payee.Text) || cb_payee.Text == "All-payee")
            {
                MessageBox.Show("payee을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(cb_category.Text) || cb_category.Text == "All-category")
            {
                MessageBox.Show("category을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(cb_payMethod.Text) || cb_payMethod.Text == "All-paymethod")
            {
                MessageBox.Show("결제방법을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(txt_total.Text))
            {
                MessageBox.Show("txt_total을[를] 입력해주세요");
                return;
            }
            /*
            if( int.TryParse(txt_total.Text, out number1) == false)
            {
                    MessageBox.Show("txt_total 에는 숫자만 입력해주세요");
                    return;
            }
            */
            //txt_gst
            if (String.IsNullOrWhiteSpace(txt_gst.Text))
            {
                //MessageBox.Show("txt_gst 를 입력해주세요");
                //return;
                txt_gst.Text = "0";
            }

            Purchase purchase = new Purchase(dt_regDate.Value, cb_payMethod.Text, txt_checkNo.Text, cb_payee.Text, txt_total.Text,
            txt_gst.Text, cb_category.Text, txt_etc.Text, DateTime.Now.ToString());

            string delete_flag = "Y";
            if (radioButton5.Checked)
            {
                delete_flag = "";
            }
            string sql = " insert into  [dbo].[purchase] ([regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc], delete_flag,[createDate])"
                     + " values( @regDate,@payMethod,@checkNo,@payee,@total,@gst,@category,@etc, @delete_flag,@createDate) ";

            Console.WriteLine("Today: {0}", DateTime.Today);

            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regDate", dt_regDate.Value);
                    cmd.Parameters.AddWithValue("@payMethod", cb_payMethod.Text);
                    cmd.Parameters.AddWithValue("@checkNo", txt_checkNo.Text);
                    cmd.Parameters.AddWithValue("@payee", cb_payee.Text);
                    cmd.Parameters.AddWithValue("@total", System.Convert.ToDecimal(txt_total.Text));
                    cmd.Parameters.AddWithValue("@gst", System.Convert.ToDecimal(txt_gst.Text));
                    cmd.Parameters.AddWithValue("@category", cb_category.Text);
                    cmd.Parameters.AddWithValue("@etc", txt_etc.Text);
                    cmd.Parameters.AddWithValue("@delete_flag", delete_flag);
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(" 등록 완료 !!");
                    // 리스트 호출 
                    purchaseListAll();
                }
            }
            db.CloseDB();

        }
        /*
        private void btn_create_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" btn_create_Click ");
            string sql = "insert into  [dbo].[purchase] (id, name, address ) values ( 4,'4name','4address')";
            db.ConnectDB(); // db connectSystem.
            var Comm = new SqlCommand(sql, db.getConnection());
            int i = Comm.ExecuteNonQuery();
            db.CloseDB();

            if (i == 1)
            {
                MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        */

        private void txt_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (e.KeyChar != '-')) e.Handled = true;
            //if ((!Char.IsDigit(e.KeyChar)) && (e.KeyChar != '\b') && (e.KeyChar != '-')) e.Handled = true;
            Console.WriteLine("txt_total_KeyPresswww :" + e.KeyChar);
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("txt_total_KeyPress :" + e.ToString());
            if (Regex.IsMatch(txt_total.Text, "[^0-9.,-]"))
            {
                //txt_total.Text = "";
                MessageBox.Show("Only input Numberw ww ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Console.WriteLine("cb_searchYYYY_01 :" + cb_searchYYYY_01.Text);
            Console.WriteLine("cb_searchMM_01 :" + cb_searchMM_01.Text);
            string s_date = cb_searchYYYY_01.Text + cb_searchMM_01.Text;
            string e_date = cb_searchYYYY_02.Text + cb_searchMM_02.Text;

            MessageBox.Show(" wait ");
            // list
            // this.pucharseList(s_date, e_date);

        }

        private void pucharseList(string s_date, string e_date)
        {
            save_s_date = s_date;
            save_e_date = e_date;
        

            /*
            if (s_date == e_date)
            {
                MessageBox.Show(" 같은 달을 선택했읍니다");
                return;
            }
            */
            if (ckl_searchPayee.CheckedItems.Count == 0)
            {
                MessageBox.Show("선택해주세요");
                return;
            }

            string subQuery = "";
            if (searchPayMethod.Text != "All-paymethod")
            {
                subQuery += " and paymethod = '" + searchPayMethod.Text + "' ";
            }
            if (searchCategory.Text != "All-category")
            {
                subQuery += " and category = '" + searchCategory.Text + "' ";
            }


            if (radioButton1.Checked)
            {
                //subQuery += " and delete_flag = '' ";
            }
            else if (radioButton2.Checked)
            {
                subQuery += " and delete_flag != 'Y' ";
            }
            else if (radioButton3.Checked)
            {
                subQuery += " and delete_flag = 'Y' ";
            }

            subQuery += " and payee in (";

            int step = 0;
            foreach (object items in ckl_searchPayee.CheckedItems)
            {
                // PayeeListBoxItem castItem = items as PayeeListBoxItem;
                PayeeListBoxItem castItem = (PayeeListBoxItem)items;
                // Console.WriteLine("  items.p_code: " + castItem.c_code);
                //  Console.WriteLine(" items.name: " + castItem.name);
                if (step == 0)
                {
                    subQuery += "'" + castItem.name + "'";
                }
                else
                {
                    subQuery += ",'" + castItem.name + "'";
                }
                step++;
            }
            subQuery += ")";

            Console.WriteLine("subQuery :" + subQuery);

            Console.WriteLine("s_date :" + s_date);
            Console.WriteLine("e_date :" + e_date);
            Console.WriteLine(" button2_Click ");

            string sql = "";
            Console.WriteLine("s_date.Contains :" + s_date.Contains("Search"));
            Console.WriteLine("s_date.Contains :" + s_date);
            Console.WriteLine("s_date.Substring :" + s_date.Substring(0, 4));
            if (s_date.Contains("Search") == true)
            {
                search_month_lable = s_date;
                label7.Text = search_month_lable;
                label8.Text = "";

                sql += "select id,[regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc] , delete_flag,[createDate], 'Modify' as Modify from [dbo].[purchase] ";
                sql += " where   convert(varchar(4),[regDate], 112) = '" + s_date.Substring(0, 4) + "'  " + subQuery + " ";
                sql = sql + "union all ";
                sql = sql + "select  '' as id , '' as [regDate]  , '' as [payMethod], '' as [checkNo] ,'' as [payee],sum([total]) as total,sum([gst]) as gst ,'' as [category],'' as [etc] , '' as delete_flag, '' as [createDate] , 'Modify' as Modify  from purchase ";
                sql = sql + "where convert(varchar(4),[regDate], 112) = '" + s_date.Substring(0, 4) + "' " + subQuery + " ";

            }
            else if (s_date.Contains("Group") == true)
            {
                // 연도별 말고, 월별 그룹을 보고 싶을경우는 어떻게??? 월별 버튼 클릭시 해당 내용을 전역변수로 ??? 7월1일 생각 ..
                string g_name = "";
                if (s_date.Contains("Payee") == true)
                {
                    g_name = "Payee";
                }
                else if (s_date.Contains("Category") == true)
                {
                    g_name = "Category";
                }
                else
                {
                    g_name = "PayMethod";
                }

                Console.WriteLine(" label7.Text :" + label7.Text);
                Console.WriteLine(" label8.Text :" + label8.Text);

                // 월 검색 버튼을 클릭했을경우 ..
                if (label8.Text != "" && label8.Text != "Search") {
                    sql += "select " + g_name + " ,sum([total]) total ,sum([gst]) gst from [dbo].[purchase] ";
                    sql += " where   convert(varchar(6),[regDate], 112) = '" + label8.Text + "'  " + subQuery + " group by " + g_name + " ";
                }
                else
                {
                    sql += "select " + g_name + " ,sum([total]) total ,sum([gst]) gst from [dbo].[purchase] ";
                    sql += " where   convert(varchar(4),[regDate], 112) = '" + s_date.Substring(0, 4) + "'  " + subQuery + " group by " + g_name + " ";
                }
                
            }
            else
            {
                search_month_lable = s_date;
                label7.Text = "";
                label8.Text = search_month_lable;

                sql += "select id,[regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc],delete_flag ,[createDate], 'Modify' as Modify from [dbo].[purchase] ";
                sql += " where  convert(varchar(6),[regDate], 112) between '" + s_date + "' and '" + e_date + "'  " + subQuery + " ";
                sql = sql + "union all ";
                sql = sql + "select  '' as id , '' as [regDate]  , '' as [payMethod], '' as [checkNo] ,'' as [payee],sum([total]) as total,sum([gst]) as gst ,'' as [category],'' as [etc] , '' as delete_flag, '' as [createDate] , 'Modify' as Modify  from purchase ";
                sql = sql + "where convert(varchar(6),[regDate], 112) between '" + s_date + "' and '" + e_date + "' " + subQuery + " ";

            }

            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);

            // DataRow dr = dt.NewRow();
            //dr("[total]") = dt.Compute("Sum(total)", "");
            //dt.Compute("Sum(total)", "");
            //dt.Rows.Add(dr);

            dataGridView1.DataSource = dt;
            Console.WriteLine(" sql " + sql);

            // grid.DataSource = dt;  ,sum([gst]) as gst_sum 
            string sql2 = "";
            if (s_date.Contains("Search"))
            {
                sql2 = sql2 + "select sum([total]) as total_sum ,sum([gst]) as gst_sum  from purchase ";
                sql2 = sql2 + "where  convert(varchar(4),[regDate], 112) between @s_date and @e_date  " + subQuery + " ";
                s_date = s_date.Substring(0, 4);
                e_date = e_date.Substring(0, 4);
            }
            else
            {
                sql2 = sql2 + "select sum([total]) as total_sum ,sum([gst]) as gst_sum  from purchase ";
                sql2 = sql2 + "where  convert(varchar(6),[regDate], 112) between @s_date and @e_date  " + subQuery + " ";
            }
            using (SqlCommand cmd = new SqlCommand(sql2, db.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@s_date", s_date);
                cmd.Parameters.AddWithValue("@e_date", e_date);
                //db.getConnection().Open();
                try
                {
                    //object obj = cmd.ExecuteScalar();
                    /*
                    if (obj != null)
                    {
                        double total_sum = Convert.ToDouble(obj);
                        Console.WriteLine(" total_sum: " + total_sum);
                    }
                    */
                    SqlDataReader dr = cmd.ExecuteReader();
                    string total_sum = "0";
                    string gst_sum = "0";

                    while (dr.Read())
                    {
                        total_sum = dr["total_sum"].ToString();
                        gst_sum = dr["gst_sum"].ToString();
                        Console.WriteLine("total_sum: " + total_sum);
                        Console.WriteLine("gst_sum: " + gst_sum);
                    }
                    lbl_total_sum.Text = total_sum;
                    lbl_gst_sum.Text = gst_sum;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            db.CloseDB();  // db close
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < ckl_searchPayee.Items.Count; i++)
            {
                ckl_searchPayee.SetItemChecked(i, true);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < ckl_searchPayee.Items.Count; i++)
            {
                ckl_searchPayee.SetItemChecked(i, false);
            }
        }

        private void btn_searchMonth01_Click(object sender, EventArgs e)
        {

            Button monthButton = (Button)sender;
            Console.WriteLine("buttonText: " + monthButton.Text);
            Console.WriteLine(" cmb_year.Text: " + cmb_year.Text);
            Console.WriteLine("buttonText: " + cmb_year.Text + util.changeMonthString(monthButton.Text));
            // list 
            this.pucharseList(cmb_year.Text + util.changeMonthString(monthButton.Text), cmb_year.Text + util.changeMonthString(monthButton.Text));
        }



        private void btn_reset_Click(object sender, EventArgs e)
        {
            // init_make_searchPayee();
            //ckl_searchPayee

            Console.WriteLine("cb_payee.Text: " + cb_payee.Text);

            DataRowView temp = (DataRowView)cb_payee.SelectedItem;
            //MessageBox.Show(temp[0].ToString());
            //MessageBox.Show(temp[1].ToString());
            //MessageBox.Show(temp[2].ToString());
            Console.WriteLine(" items.name: " + temp[1].ToString());
            Console.WriteLine(" items.p_code: " + temp[2].ToString());
            /*
            foreach (DataRowView drv in cb_payee.Items)
            {
                // foreach 방식
                foreach (object value in drv.Row.ItemArray)
                {
                    string test = value.ToString();
                    Console.WriteLine(" items.name: " + test);
                }
            }
            */
            /*
            string value = ((KeyValuePair<string, string>)cb_payee.SelectedItem).Value;
            string key = ((KeyValuePair<string, string>)cb_payee.SelectedItem).Key;
            Console.WriteLine("valuet: " + value);
            Console.WriteLine("key: " + key);
            */
            /*
           foreach ( PayeeListBoxItem items in ckl_searchPayee.SelectedItems)
            {
                Console.WriteLine("  items.p_code: " + items.c_code);
                Console.WriteLine(" items.name: " + items.name);
            }

            int size = ckl_searchPayee.Items.Count;
            PayeeListBoxItem items;
            for (int i =0; i < size; i++)
            {
                if(ckl_searchPayee.GetItemChecked(i))
                {

                    Console.WriteLine("  items.p_code: " + ckl_searchPayee.Items[i].ToString());

                }
            }
            */



        }

        private void ckl_searchPayee_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            init_selectAll_payee();
        }

        private void init_selectAll_payee()
        {
            for (int i = 0; i < ckl_searchPayee.Items.Count; i++)
            {
                ckl_searchPayee.SetItemChecked(i, true);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            Console.WriteLine("dataGridView1_CellDoubleClick ok :" + name);
            // id,[regDate],[payMethod],[checkNo],[payee],[total],[gst],[category],[etc] ,[createDate], 'Modify' 
            /*
             cmd.Parameters.AddWithValue("@regDate", dt_regDate.Value);
             cmd.Parameters.AddWithValue("@payMethod", cb_payMethod.Text);
             cmd.Parameters.AddWithValue("@checkNo", txt_checkNo.Text);
             cmd.Parameters.AddWithValue("@payee", cb_payee.Text);
             cmd.Parameters.AddWithValue("@total", System.Convert.ToDecimal(txt_total.Text));
             cmd.Parameters.AddWithValue("@gst", System.Convert.ToDecimal(txt_gst.Text));
             cmd.Parameters.AddWithValue("@category", cb_category.Text);
             cmd.Parameters.AddWithValue("@etc", txt_etc.Text);
             cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
             */
            dt_regDate.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            cb_payMethod.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
            txt_checkNo.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            cb_payee.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            txt_total.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_gst.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cb_category.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
            txt_etc.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
            if ((string)dataGridView1.Rows[e.RowIndex].Cells[9].Value == "Y")
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton5.Checked = true;
            }
            purchaseId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            btn_create.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_backToCreate.Visible = true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 처음 등록화면으로 초기화 시켜주기..
        private void initCreateForm()
        {
            btn_create.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_backToCreate.Visible = false;
            cb_payMethod.Text = "";
            txt_checkNo.Text = "";
            cb_payee.Text = "";
            txt_total.Text = "";
            txt_gst.Text = "";
            cb_category.Text = "";
            txt_etc.Text = "";
            purchaseId.Text = "";
        }
        private void btn_backToCreate_Click(object sender, EventArgs e)
        {
            this.initCreateForm();
        }

        private void txt_total_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txt_gst_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //
            if (purchaseId.Text == "")
            {
                MessageBox.Show(" ID가 없습니다. ");
                return;
            }

            //https://agopwns.blog.me/221151062926

            var confirmResult = MessageBox.Show("정말로 삭제? "
                , "삭제 확인창"
                , MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            string sql = " delete from  [dbo].[purchase] where "
                     + " id = @puchaseId ";

            Console.WriteLine("Today: {0}", DateTime.Today);

            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@puchaseId", purchaseId.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(" 삭제처리 완료 !!");
                    // 삭제완료후 입력창 클리어 시키기 ..  7월2일 
                    this.initCreateForm();

                    // 리스트 호출 
                    purchaseListAll();
                }
            }
            db.CloseDB();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //validation check
            if (String.IsNullOrWhiteSpace(cb_payMethod.Text))
            {
                MessageBox.Show("결제방법을 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(txt_total.Text))
            {
                MessageBox.Show("txt_total를 입력해주세요");
                return;
            }
            //txt_gst
            if (String.IsNullOrWhiteSpace(txt_gst.Text))
            {
                //MessageBox.Show("txt_gst 를 입력해주세요");
                //return;
                txt_gst.Text = "0";
            }

            string delete_flag = "Y";
            if (radioButton5.Checked) // 신고 선택시,  flat "" 세팅 
            {
                delete_flag = "";
            }
            MessageBox.Show(delete_flag);
            string sql = " update  [dbo].[purchase] set [regDate] = @regDate ,[payMethod] = @payMethod ";
            sql += " ,[checkNo] = @checkNo,[payee] = @payee,[total] = @total,[gst] = @gst,[category] = @category ";
            sql += ",[etc]=@etc , delete_flag = @delete_flag, [createDate] = @createDate"
               + "  where id = @id";

            Console.WriteLine("Today: {0}", DateTime.Today);

            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regDate", dt_regDate.Value);
                    cmd.Parameters.AddWithValue("@payMethod", cb_payMethod.Text);
                    cmd.Parameters.AddWithValue("@checkNo", txt_checkNo.Text);
                    cmd.Parameters.AddWithValue("@payee", cb_payee.Text);
                    cmd.Parameters.AddWithValue("@total", System.Convert.ToDecimal(txt_total.Text));
                    cmd.Parameters.AddWithValue("@gst", System.Convert.ToDecimal(txt_gst.Text));
                    cmd.Parameters.AddWithValue("@category", cb_category.Text);
                    cmd.Parameters.AddWithValue("@etc", txt_etc.Text);
                    cmd.Parameters.AddWithValue("@delete_flag", delete_flag);
                    cmd.Parameters.AddWithValue("@createDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id", purchaseId.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show(" 수정 완료 !!");
                    // 리스트 호출 
                    purchaseListAll();
                }
            }
            db.CloseDB();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // MessageBox.Show("재민이 버튼을 클릭햇어요");
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            string sex = "";
            if (((RadioButton)sender).Checked == true)
                sex = ((RadioButton)sender).Tag.ToString();
            */
        }
        //https://blog.naver.com/newtype0096/220981541216
        private void buttonExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "거래내역_" + DateTime.Now.ToString("yyyyMMdd") + "_" +
                DateTime.Now.ToString("HHmmss") + ".xlsx";
            sfd.DefaultExt = "xlsx";
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
            sfd.InitialDirectory = "C:\\";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Accounting_Export_Excel(dataGridView1, sfd.FileName);
            }
        }

        private void Accounting_Export_Excel(DataGridView dGV, string filename)
        {
            excel.Application xlApp;
            excel.Workbook xlWorkBook;
            excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            excel.Range xlRange;

            xlApp = new excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 1; i < dGV.Columns.Count + 1; i++)
            {
                xlApp.Cells[4, i] = dGV.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dGV.Rows.Count; i++)
            {
                for (int j = 0; j < dGV.Columns.Count; j++)
                {
                    if (dGV.Rows[i].Cells[j].Value != null)
                    {
                        xlApp.Cells[i + 5, j + 1] = dGV.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            xlRange = xlWorkSheet.get_Range("b4");
            xlRange.Font.Bold = true;

            xlWorkBook.SaveAs(filename);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);

            MessageBox.Show("File created !");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            /*
            가져오기
            Bitmapbit = new Bitmap(이미지);
            Colorcolor = bit.GetPixel(5, 5);
            MessageBox.Show("R:" + color.R.ToString() + " G:" + color.G.ToString() + " B:" + color.B.ToString());
            만들기
            Bitmap bit = new Bitmap(100, 100); 1

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    bit.SetPixel(i, j, Color.Purple);
                }
            }

            */


            string[] test = new string[3];
            test[0] = "1";
            test[1] = "22";
            test[2] = "333";

            foreach (var a in test)
            {
                Console.WriteLine("a =>" + a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            1.현재창을 그대로 유지하고 두번째 창을 여는 방법(첫째창도 클릭 가능)
                Form2 showForm2 = new Form2();
                showForm2.show();
            2.현재창을 그대로 유지하고 두번째 창을 여는 방법(Modal 형식이라 첫째창 클릭 불가)
                Form2 showForm2 = new Form2();
                showForm2.showDialog();     // show를 showDialog로 바꿔줌
            3.현재창을 종료하고 두번째 창을 여는 방법
                this.Visible = false;             // 추가
                Form2 showForm2 = new Form2();
                showForm2.showDialog();

             출처: https://hunit.tistory.com/352 [Ara Blog]
                
            */
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            //orderForm.showDialog();

        }


        /*
* https://blog.naver.com/afsdzvcx123/221408895423
private void ExportToExcel()
{
   bool IsExport = false;

   // Creating a Excel object.
   Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
   Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
   Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

   //DataGridView에 불러온 Data가 아무것도 없을 경우
   if (dataGridView1.Rows.Count == 0)
   {
       MessageBox.Show("Data does not exist.", "Inform",
MessageBoxButtons.OK, MessageBoxIcon.Information);
       return;
   }

   try
   {
       worksheet = workbook.ActiveSheet;

       int cellRowIndex = 1;
       int cellColumnIndex = 1;


       for (int col = 0; col < dataGridView1.Columns.Count; col++)
       {

           if (cellRowIndex == 1)
           {
               worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[col].HeaderText;
           }
           cellColumnIndex++;
       }

       cellColumnIndex = 1;
       cellRowIndex++;

       for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
       {
           for (int col = 0; col < dataGridView1.Columns.Count; col++)
           {
               worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[row].Cells[col].Value.ToString();

               cellColumnIndex++;
           }
           cellColumnIndex = 1;
           cellRowIndex++;
       }

       SaveFileDialog saveFileDialog = GetExcelSave();

       if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
       {
           workbook.SaveAs(saveFileDialog.FileName);
           MessageBox.Show("Export Successful!!!!!");
           IsExport = true;
       }

       //Export 성공 했으면 객체들 해제
       if (IsExport)
       {
           workbook.Close();

           excel.Quit();
           workbook = null;
           excel = null;
       }
   }
   catch (System.Exception ex)
   {
       MessageBox.Show(ex.Message);
   }
}


private SaveFileDialog GetExcelSave()
{
   //Getting the location and file name of the excel to save from user.
   SaveFileDialog saveDialog = new SaveFileDialog();
   saveDialog.CheckPathExists = true;
   saveDialog.AddExtension = true;
   saveDialog.ValidateNames = true;
   saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

   saveDialog.DefaultExt = ".xlsx";
   saveDialog.Filter = "Microsoft Excel Workbook (*.xls)|*.xlsx";
   saveDialog.FileName = "StudentData".ToString();

   return saveDialog;
}
*/
    }
}
//http://net-informations.com/q/faq/combovalue.html
// combo 
