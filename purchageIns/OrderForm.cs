using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purchageIns
{
    public partial class OrderForm : Form
    {
        con_Database db;
        DataTable dt;
        Util util = new Util();

        public OrderForm()
        {
            InitializeComponent();

            db = new con_Database();

            init_make_year();
            int c_month = DateTime.Now.Month;
            string s_month = "";
            if (c_month < 10)
            {
                s_month = "0" + c_month;
            }
            else
            {
                s_month = c_month.ToString();
            }
            init_make_month(s_month);
            Console.WriteLine("month" + DateTime.Now.Month);

            // 리스트 호출 
            salesListAll(DateTime.Now.Year.ToString());

            txt_sale_id.ReadOnly = true;
            txt_sale_id.BackColor = Color.Gray;

        }

        private void init_make_year()
        {
            cmb_year.Items.Add("Year");
            for (int i = 2018; i <= 2022; i++)
            {
                cmb_year.Items.Add(i);
            }
            cmb_year.SelectedItem = DateTime.Now.Year;

            cmb_search_year.Items.Add("Year");
            for (int i = 2018; i <= 2022; i++)
            {
                cmb_search_year.Items.Add(i);
            }
            cmb_search_year.SelectedItem = DateTime.Now.Year;
        }



        private void init_make_month(string s_month)
        {
            cmb_month.Items.Add("Month");
            for (int i =1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cmb_month.Items.Add("0" + i);
                }
                else
                {
                    cmb_month.Items.Add(i);
                }
            }
            cmb_month.SelectedItem = s_month;
        }

        private void btn_search_01_Click(object sender, EventArgs e)
        {

        }
        private void txt_gst_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != '.' && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btn create click");
            //cmb_year
            //cmb_month
            //txt_pos_sales, txt_pos_lottery, txt_lottery, txt_lottery_commition

            /* [sale_year]    NVARCHAR(4)  NOT NULL,
             [sale_month]   NVARCHAR(2)  NOT NULL,
             [pos_sales_amt]   NUMERIC(18, 2) NULL,
             [pos_lottery_amt]   NUMERIC(18, 2) NULL,
             [lottery_amt]   NUMERIC(18, 2) NULL,
             [lottery_commition_amt]   NUMERIC(18, 2) NULL,
             [sales_amt]     NUMERIC(18, 2) NULL*/

            if (String.IsNullOrWhiteSpace(cmb_year.Text) || cmb_year.Text == "Year")
            {
                MessageBox.Show("Year을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(cmb_month.Text) || cmb_month.Text == "Month")
            {
                MessageBox.Show("Month을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(txt_pos_sales.Text))
            {
                txt_pos_sales.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_pos_lottery.Text))
            {
                txt_pos_lottery.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_pos_tobacco.Text))
            {
                txt_pos_tobacco.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_lottery.Text))
            {
                txt_lottery.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_lottery_commition.Text))
            {
                txt_lottery_commition.Text = "0";
            }
            int sales_amt = Convert.ToInt32(txt_pos_sales.Text) - Convert.ToInt32(txt_pos_lottery.Text);

            if ( getId(cmb_year.Text, cmb_month.Text) > 0)
            {
                MessageBox.Show(cmb_year.Text + "년" + cmb_month.Text + "월은 이미 등록되어 있습니다");
                return;
            }

            string sql = " insert into  [dbo].[sales] ([sale_year],[sale_month],[pos_sales_amt],[pos_lottery_amt],[pos_tobacco_amt], "
                     + " [lottery_amt],[lottery_commition_amt],[sales_amt])"
                    + " values( @saleYear, @saleMonth, @posSalesAmt,@posLotteryAmt,@posTobaccoAmt,"
                    + "@lotteryAmt,@lotteryCommitionAmt,@salesAmt) ";

            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@saleYear", cmb_year.Text);
                    cmd.Parameters.AddWithValue("@saleMonth", cmb_month.Text);
                    cmd.Parameters.AddWithValue("@posSalesAmt", System.Convert.ToDecimal(txt_pos_sales.Text));
                    cmd.Parameters.AddWithValue("@posLotteryAmt", System.Convert.ToDecimal(txt_pos_lottery.Text));
                    cmd.Parameters.AddWithValue("@posTobaccoAmt", System.Convert.ToDecimal(txt_pos_tobacco.Text));
                    cmd.Parameters.AddWithValue("@lotteryAmt", System.Convert.ToDecimal(txt_lottery.Text));
                    cmd.Parameters.AddWithValue("@lotteryCommitionAmt", System.Convert.ToDecimal(txt_lottery_commition.Text));
                    cmd.Parameters.AddWithValue("@salesAmt", sales_amt);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(" 등록 완료 !!");
                    // 리스트 호출 
                    salesListAll(cmb_year.Text);
                }
            }
            db.CloseDB();



        }

        private int getId(string sale_year, string sale_month)
        {
            string sql = "select id from [dbo].[sales] "
                       + " where sale_year = " + sale_year + " and sale_month = " + sale_month + "";
            Console.WriteLine("sql:" + sql);
            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            int table_count = 0;
            table_count = dt.Rows.Count;
            db.CloseDB();  // db close
            if (table_count > 0)
            {
                DataRow row = dt.Rows[0];
                Console.WriteLine("id:" + row["id"]);
                return Convert.ToInt32(row["id"]);
            }
            else
            {
                return 0;
            }

            //return table_count;
        }
        private void salesListAll(string sale_year)
        {
            Console.WriteLine(" button_click ");
            string sql = "";
            if ( sale_year != "")
            {
                           sql = "select   [sale_year] as '년도',[sale_month] as '월',[pos_sales_amt] as '[POS]REVENUE(SALES)' ,[pos_lottery_amt] as '[POS]LOTTERY(POS)'"
                            + " ,[sales_amt] as '[POS]매출(복권제외)',[pos_tobacco_amt] as '[POS]담배'"
                            + " ,[lottery_amt] as 'LOTTERY(실매출)',[lottery_commition_amt] as 'LOTTERY(커미션)',id from [dbo].[sales] "
                            + " where sale_year = '" + sale_year +"'"
                            + " order by cast(sale_year as int),cast(sale_month as int) asc";
            }
            else
            {
                sql = "select   [sale_year] as '년도',[sale_month] as '월',[pos_sales_amt] as '[POS]REVENUE(SALES)' ,[pos_lottery_amt] as '[POS]LOTTERY(POS)'"
                     + " ,[sales_amt] as '[POS]매출(복권제외)',[pos_tobacco_amt] as '[POS]담배"
                     + " ,[lottery_amt] as 'LOTTERY(실매출)',[lottery_commition_amt] as 'LOTTERY(커미션)',id from [dbo].[sales] "
                      + " order by cast(sale_year as int),cast(sale_month as int) asc";
            }
            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            //MessageBox.Show(" count :" + dt.Rows.Count);
            dataGridView1.DataSource = dt;

            this.dataGridView1.Columns["id"].Visible = false;

            double a_total_amt = 0;
            double b_total_amt = 0;
            double c_total_amt = 0;
            double d_total_amt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                a_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                b_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                c_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                d_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                Console.WriteLine("vvv:" + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
            }

            DataRow dr = dt.NewRow();
            dr[0] = "Total";
            dr[1] = "";
            dr[2] = a_total_amt;
            dr[3] = b_total_amt;
            dr[4] = c_total_amt;
            dr[5] = d_total_amt;

            dt.Rows.Add(dr);

            setRowsLine(dataGridView1);
            int lastLine = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastLine].DefaultCellStyle.BackColor = Color.YellowGreen;


            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 170;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 170;
            //dataGridView1.Columns[0].HeaderText = "ID";

            
           /* dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;*/



            dataGridView1.Columns[2].ValueType = typeof(decimal);
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[3].ValueType = typeof(decimal);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].ValueType = typeof(decimal);
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].ValueType = typeof(decimal);
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[6].ValueType = typeof(decimal);
            dataGridView1.Columns[6].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[7].ValueType = typeof(decimal);
            dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";

            dataGridView1.Update();

            dataGridView1.Visible = true;
            panel7.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;

            db.CloseDB();  // db close
        }
       

        private void btn_search_Click(object sender, EventArgs e)
        {
            salesListAll(cmb_search_year.Text);
        }

        private void setRowsLine(DataGridView dataGridView1)
        {
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           // dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
        }
        private void btn_stas_01_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = " select sale_month"
                 + " , isnull( sum( case when sale_year = '2018' then [sales_amt] end) , 0) as '2018' "
                 + " , isnull(sum( case when sale_year = '2019' then [sales_amt] end) , 0) as '2019' "
                  + " , isnull(sum( case when sale_year = '2020' then [sales_amt] end) , 0) as '2020' "
                  + " from  [dbo].sales  group by sale_month ";

            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            //MessageBox.Show(" count :" + dt.Rows.Count);
            dataGridView2.DataSource = dt;

            double a_total_amt = 0;
            double b_total_amt = 0;
            double c_total_amt = 0;
            /*foreach (DataGridViewRow r in dataGridView2.Rows)
            {
                a_total_amt += Convert.ToDouble(r.Cells[1].Value);
                b_total_amt += Convert.ToDouble(r.Cells[2].Value);
                c_total_amt += Convert.ToDouble(r.Cells[3].Value);
            }*/
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                a_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                b_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                c_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                Console.WriteLine("vvv:" + Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));
            }
            DataRow dr = dt.NewRow();
            dr[0] = "Total";
            dr[1] = a_total_amt;
            dr[2] = b_total_amt;
            dr[3] = c_total_amt;
            dt.Rows.Add(dr);

            setRowsLine(dataGridView2);

            dataGridView2.Columns[1].ValueType = typeof(decimal);
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[2].ValueType = typeof(decimal);
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[3].ValueType = typeof(decimal);
            dataGridView2.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridView2.Update();

            sql = " select sale_month"
                 + " , isnull( sum( case when sale_year = '2018' then [pos_lottery_amt] end) , 0) as '2018' "
                 + " , isnull(sum( case when sale_year = '2019' then [pos_lottery_amt] end) , 0) as '2019' "
                  + " , isnull(sum( case when sale_year = '2020' then [pos_lottery_amt] end) , 0) as '2020' "
                  + " from  [dbo].sales  group by sale_month ";
            dt = db.GetDBTable(sql);
            dataGridView3.DataSource = dt;

            a_total_amt = 0;
            b_total_amt = 0;
            c_total_amt = 0;
            foreach (DataGridViewRow r in dataGridView3.Rows)
            {
                a_total_amt += Convert.ToDouble(r.Cells[1].Value);
                b_total_amt += Convert.ToDouble(r.Cells[2].Value);
                c_total_amt += Convert.ToDouble(r.Cells[3].Value);
            }

            dr = dt.NewRow();
            dr[0] = "Total";
            dr[1] = a_total_amt;
            dr[2] = b_total_amt;
            dr[3] = c_total_amt;
            dt.Rows.Add(dr);

            setRowsLine(dataGridView3);

            dataGridView3.Columns[1].ValueType = typeof(decimal);
            dataGridView3.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[2].ValueType = typeof(decimal);
            dataGridView3.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView3.Columns[3].ValueType = typeof(decimal);
            dataGridView3.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridView3.Update();

            dataGridView1.Visible = false;
            panel7.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;

            db.CloseDB();  // db close
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //
            if (txt_sale_id.Text == "")
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

            string sql = " delete from  [dbo].[sales] where "
                    + " id = @saleId ";

            Console.WriteLine("Today: {0}", DateTime.Today);

            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@saleId", txt_sale_id.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(" 삭제처리 완료 !!");
                    // 삭제완료후 입력창 클리어 시키기 ..  7월2일 
                    this.initCreateForm();

                    // 리스트 호출 
                    salesListAll(cmb_year.Text);
                }
            }
            db.CloseDB();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(cmb_year.Text) || cmb_year.Text == "Year")
            {
                MessageBox.Show("Year을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(cmb_month.Text) || cmb_month.Text == "Month")
            {
                MessageBox.Show("Month을[를] 선택해주세요");
                return;
            }
            if (String.IsNullOrWhiteSpace(txt_pos_sales.Text))
            {
                txt_pos_sales.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_pos_lottery.Text))
            {
                txt_pos_lottery.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_pos_tobacco.Text))
            {
                txt_pos_tobacco.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_lottery.Text))
            {
                txt_lottery.Text = "0";
            }
            if (String.IsNullOrWhiteSpace(txt_lottery_commition.Text))
            {
                txt_lottery_commition.Text = "0";
            }
            decimal sales_amt = System.Convert.ToDecimal(txt_pos_sales.Text) - System.Convert.ToDecimal(txt_pos_lottery.Text);


            // 수정, 내 아이디와 다른게 있으면 안됨.
            Console.WriteLine(" 11: " + getId(cmb_year.Text, cmb_month.Text));
            Console.WriteLine(" 22: " + txt_sale_id.Text);
            if ( getId(cmb_year.Text, cmb_month.Text) != Convert.ToInt32(txt_sale_id.Text) && getId(cmb_year.Text, cmb_month.Text) > 0)
            {
                MessageBox.Show(cmb_year.Text + "년" + cmb_month.Text + "월은 이미 등록되어 있습니다1");
                return;
            }


            /* [sale_year]    NVARCHAR(4)  NOT NULL,
           [sale_month]   NVARCHAR(2)  NOT NULL,
           [pos_sales_amt]   NUMERIC(18, 2) NULL,
           [pos_lottery_amt]   NUMERIC(18, 2) NULL,
           [lottery_amt]   NUMERIC(18, 2) NULL,
           [lottery_commition_amt]   NUMERIC(18, 2) NULL,
           [sales_amt]     NUMERIC(18, 2) NULL*/

            string sql = " update  [dbo].[sales] set [sale_year] = @saleYear ,[sale_month] = @saleMonth ";
            sql += " ,[pos_sales_amt] = @posSalesAmt,[pos_lottery_amt] = @posLotteryAmt,[pos_tobacco_amt] = @posTobaccoAmt ";
            sql += " ,[lottery_amt] = @lotteryAmt,[lottery_commition_amt] = @lotteryCommitionAmt,[sales_amt] = @salesAmt ";
            sql  += "  where id = @id";
            using (SqlConnection conn = db.ConnectDB())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@saleYear", cmb_year.Text);
                    cmd.Parameters.AddWithValue("@saleMonth", cmb_month.Text);
                    cmd.Parameters.AddWithValue("@posSalesAmt", System.Convert.ToDecimal(txt_pos_sales.Text));
                    cmd.Parameters.AddWithValue("@posLotteryAmt", System.Convert.ToDecimal(txt_pos_lottery.Text));
                    cmd.Parameters.AddWithValue("@posTobaccoAmt", System.Convert.ToDecimal(txt_pos_tobacco.Text));
                    cmd.Parameters.AddWithValue("@lotteryAmt", System.Convert.ToDecimal(txt_lottery.Text));
                    cmd.Parameters.AddWithValue("@lotteryCommitionAmt", System.Convert.ToDecimal(txt_lottery_commition.Text));
                    cmd.Parameters.AddWithValue("@salesAmt", sales_amt);
                    cmd.Parameters.AddWithValue("@id", System.Convert.ToDecimal(txt_sale_id.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" 수정 완료 !!");
                    // 리스트 호출 
                    salesListAll(cmb_year.Text);
                }
            }
            db.CloseDB();
            }
        private void initCreateForm()
        {
            btn_create.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;
            btn_back.Visible = false;
            txt_sale_id.ReadOnly = true;
            txt_sale_id.BackColor = Color.Gray;
            txt_sale_id.Text = "";
            txt_pos_sales.Text = "";
            txt_pos_lottery.Text = "";
            txt_pos_tobacco.Text = "";
            txt_lottery.Text = "";
            txt_lottery_commition.Text = "";

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            initCreateForm();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cmb_year
            //cmb_month
            //txt_pos_sales, txt_pos_lottery, txt_lottery, txt_lottery_commition

            txt_sale_id.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmb_year.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            cmb_month.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            txt_pos_sales.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_pos_lottery.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_pos_tobacco.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_lottery.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_lottery_commition.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            btn_create.Visible = false;
            btn_update.Visible = true;
            btn_delete.Visible = true;
            btn_back.Visible = true;

        }

        private void 통계1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fa = new Form3();
            fa.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            initCreateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tobaccoForm tobaccoForm = new tobaccoForm();
            tobaccoForm.Show();
        }

        private void btn_show_tax_Click(object sender, EventArgs e)
        {
            bigoForm bigoForm = new bigoForm();
            bigoForm.Show();
        }

        private void cmb_search_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bigoYearsEachForm bigoYearsEachForm = new bigoYearsEachForm();
            bigoYearsEachForm.Show();
        }
    }
}
