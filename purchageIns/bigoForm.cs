using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purchageIns
{
    public partial class bigoForm : Form
    {
        con_Database db;
        DataTable dt;
        Util util = new Util();
        public bigoForm()
        {
            InitializeComponent();

            db = new con_Database();

            init_make_year();
        }

        private void init_make_year()
        {

            cmb_search_year.Items.Add("Year");
            for (int i = 2018; i <= 2022; i++)
            {
                cmb_search_year.Items.Add(i);
            }
            cmb_search_year.SelectedItem = DateTime.Now.Year;
        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            salesListAll(cmb_search_year.Text);
        }

        private void salesListAll(string sale_year)
        {
            Console.WriteLine(" button_click ");
            string sql = "";
            if (sale_year != "")
            {

                sql = " select income_group, income, category "
                 + "    , isnull( sum( case substring([sale_yyyymm], 5, 2) when '01' then([total_amt]) end), 0) [1월] "
                 + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '02' then[total_amt] end), 0) [2월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '03' then[total_amt] end), 0) [3월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '04' then[total_amt] end), 0) [4월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '05' then[total_amt] end), 0) [5월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '06' then[total_amt] end), 0) [6월] "
               + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '07' then[total_amt] end), 0) [7월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '08' then[total_amt] end), 0) [8월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '09' then[total_amt] end), 0) [9월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '10' then[total_amt] end), 0) [10월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '11' then[total_amt] end), 0) [11월] "
                + "    , isnull(sum( case substring([sale_yyyymm], 5, 2) when '12' then[total_amt] end), 0) [12월] "
                + "   , isnull(sum([total_amt]), 0) [Total] "
                + "                from[summary_year_tb] "
               + " where substring([sale_yyyymm], 1,4) = '" + sale_year + "' "
                + " group by  income_group,income, category "
               + " order by income asc ";


            }

            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            //MessageBox.Show(" count :" + dt.Rows.Count);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 140;
            Console.WriteLine(" dataGridView1.Rows.Count " + dataGridView1.Rows.Count);
            int column_count = 16;
            for (int i = 3; i < column_count; i++)
            {
                Console.WriteLine(" i : " + i);
                dataGridView1.Columns[i].Width = 60;
                dataGridView1.Columns[i].ValueType = typeof(decimal);
                dataGridView1.Columns[i].DefaultCellStyle.Format = "N2";
            }
            int income = 0;
            int sum_income = 0;
            int sum_purchase = 0;
            int sum_expense = 0;
            int gross_profit = 0;
            int net_income = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Console.WriteLine(" i : " + i);
                // Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                income = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                Console.WriteLine(" income : " + income);
                if ( income > 0 && income < 4000)
                {
                    Console.WriteLine(" i : " + dataGridView1.Rows[i].Cells[15].Value);
                    sum_income += Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value);
                    if (income == 3000)
                    {
                        setTextBox(txt_sales, Convert.ToString(dataGridView1.Rows[i].Cells[15].Value));
                        Console.WriteLine(" >>>> income : " + income);
                    }
                    else
                    {

                        setTextBox(txt_lotto_sales, Convert.ToString(dataGridView1.Rows[i].Cells[15].Value));

                        Console.WriteLine(" #### income : " + income);
                    }
                }else if (income >= 4000 && income < 4030)
                {
                    sum_purchase += Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value);
                    if ( income == 4000)
                    {
                        setTextBox(txt_purchase, Convert.ToString(dataGridView1.Rows[i].Cells[15].Value));
                    }
                    else if ( income == 4001)
                    {
                        setTextBox(txt_lotto_purchase, Convert.ToString(dataGridView1.Rows[i].Cells[15].Value));
                    }

                }
                else if (income >= 4150 && income < 4900)
                {
                    if ( income != 4152) // parking ..
                    {
                        sum_expense += Convert.ToInt32(dataGridView1.Rows[i].Cells[15].Value);
                    }
                    
                }

            }

            setTextBox(txt_total_income, sum_income.ToString());

            setTextBox(txt_total_cogs, sum_purchase.ToString());
            gross_profit = sum_income - sum_purchase;
            setTextBox(txt_gross_profit, gross_profit.ToString());

            setTextBox(txt_expense, sum_expense.ToString());
            setTextBox(txt_total_expense, sum_expense.ToString());
            net_income = gross_profit - sum_expense;

            setTextBox(txt_net_income, net_income.ToString());
            //dataGridView1.Columns[0].HeaderText = "ID";

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.Update();

            db.CloseDB();  // db close
        }

        private void setTextBox(TextBox textbox, string text_value)
        {

            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.Text = text_value;
            textbox.Text = String.Format("{0:#,##0.00}", Convert.ToDouble(textbox.Text));
            textbox.SelectionStart = textbox.TextLength;
            textbox.SelectionLength = 0;
        }
    }
}
