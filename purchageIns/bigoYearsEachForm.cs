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
    public partial class bigoYearsEachForm : Form
    {
        con_Database db;
        DataTable dt;
        Util util = new Util();

        public bigoYearsEachForm()
        {
            InitializeComponent();
            db = new con_Database();


            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);

            tabControl1.TabPages[0].Text = "상세비교";
            tabControl1.TabPages[1].Text = "1월";
            tabControl1.TabPages[2].Text = "2월";
            tabControl1.TabPages[3].Text = "3월";
            tabControl1.TabPages[4].Text = "4월";
            tabControl1.TabPages[5].Text = "5월";
            tabControl1.TabPages[6].Text = "6월";
            tabControl1.TabPages[7].Text = "7월";
            tabControl1.TabPages[8].Text = "8월";
            tabControl1.TabPages[9].Text = "9월";
            tabControl1.TabPages[10].Text = "10월";
            tabControl1.TabPages[11].Text = "11월";
            tabControl1.TabPages[12].Text = "12월";

            selectList();
        }
        
        private void selectList()
        {
            //cmb_search_year.Text

            string sql = "";

            sql = " select isnull(month,'YY'), isnull(income_group, 'Total'), [2019], [2020] "
              + "    from( "
              + "    select  substring(sale_yyyymm, 5, 2) month, income_group "
              + "    , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2019' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2019' "
              + "    , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2020' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2020' "
               + "   from[summary_year_tb] "
               + "   where income not in (4152, 6000) "
               + "   group by  substring(sale_yyyymm, 5, 2),income_group "
                + "   with rollup "
                 + " ) A "
                 + " order by month, income_group desc ";


            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            //MessageBox.Show(" count :" + dt.Rows.Count);
            dataGridView1.DataSource = dt;


            //dataGridView1.DefaultCellStyle.BackColor = Color.Red;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "Total")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                    Console.WriteLine("aa : " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
                else
                {
                    Console.WriteLine("bb : " + dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }

            dataGridView1.Columns[2].ValueType = typeof(decimal);
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[3].ValueType = typeof(decimal);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";

            //setRowsLine(dataGridView1);

            dataGridView1.Update();
            db.CloseDB();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            selectList();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show("Tab  Is Selected 1 ");
            if (tabControl1.Controls[1] == tabControl1.SelectedTab)
                MessageBox.Show("Tab 1 Is Selected");*/
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl1.Controls[0] != tabControl1.SelectedTab)
            {
               // MessageBox.Show(" text :" + tabControl1.SelectedTab.Text);   
               /* DataGridView grid = new DataGridView();
                grid.Width = 700;
                grid.Height = 600;
*/

                string month = "";
                if (tabControl1.SelectedTab.Text == "1월")
                    month = "01";
                else if (tabControl1.SelectedTab.Text == "2월")
                    month = "02";
                else if (tabControl1.SelectedTab.Text == "3월")
                    month = "03";
                else if (tabControl1.SelectedTab.Text == "4월")
                    month = "04";
                else if (tabControl1.SelectedTab.Text == "5월")
                    month = "05";
                else if (tabControl1.SelectedTab.Text == "6월")
                    month = "06";
                else if (tabControl1.SelectedTab.Text == "7월")
                    month = "07";
                else if (tabControl1.SelectedTab.Text == "8월")
                    month = "08";
                else if (tabControl1.SelectedTab.Text == "9월")
                    month = "09";
                else if (tabControl1.SelectedTab.Text == "10월")
                    month = "10";
                else if (tabControl1.SelectedTab.Text == "11월")
                    month = "11";
                else if (tabControl1.SelectedTab.Text == "12월")
                    month = "12";

                string sql = "";
                sql = " select substring(sale_yyyymm, 5,2) Month, income_group, category "
               //+ "  , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2019' then total_amt end), 0) as '2019' "
                + "    , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2019' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2019' "
                + "    , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2020' then case income_group  when 'income' then total_amt else -total_amt end end) , 0) as '2020' "
               // + " , isnull(sum( case  substring(sale_yyyymm, 1, 4) when '2020' then total_amt end), 0) as '2020' "
               + "  from[summary_year_tb] where substring(sale_yyyymm, 5, 2) =  '" + month + "' "
                 + "   and income not in (4152, 6000) "
               + "  group by substring(sale_yyyymm, 5, 2), income_group, category,income "
                + "  order by substring(sale_yyyymm, 5,2), income asc ";

                db.ConnectDB(); // db connectSystem.
                dt = db.GetDBTable(sql);
                //MessageBox.Show(" count :" + dt.Rows.Count);
                dataGridView2.DataSource = dt;
                Console.WriteLine("aa:" + dataGridView2.Rows.Count);

                dataGridView2.Columns[0].Width = 70;
                dataGridView2.Columns[1].Width = 180;
                dataGridView2.Columns[2].Width = 200;
                dataGridView2.Columns[3].Width = 80;
                dataGridView2.Columns[4].Width = 80;

                setRowsLine(dataGridView2);

                dataGridView2.Columns[3].ValueType = typeof(decimal);
                dataGridView2.Columns[3].DefaultCellStyle.Format = "N2";
                dataGridView2.Columns[4].ValueType = typeof(decimal);
                dataGridView2.Columns[4].DefaultCellStyle.Format = "N2";


                double b_total_amt = 0;
                double c_total_amt = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    b_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                    c_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[4].Value);
                    Console.WriteLine("vvv:" + Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value));
                }
                DataRow dr = dt.NewRow();
                dr[0] = "Total";
                dr[1] = "";
                dr[2] = "";
                dr[3] = b_total_amt;
                dr[4] = c_total_amt;

                dt.Rows.Add(dr);
                int lastLine = dataGridView2.Rows.Count-1;
                dataGridView2.Rows[lastLine].DefaultCellStyle.BackColor = Color.YellowGreen;

                dataGridView2.Update();
                db.CloseDB();

                tabControl1.SelectedTab.Controls.Add(dataGridView2);
            }
           
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

    }
}
