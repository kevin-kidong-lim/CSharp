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
    public partial class tobaccoForm : Form
    {
        con_Database db;
        DataTable dt;
        Util util = new Util();
        public tobaccoForm()
        {
            InitializeComponent();
            db = new con_Database();
        }

        private void tobaccoForm_Load(object sender, EventArgs e)
        {
            tabaccoList();
        }

        private void tabaccoList()
        {
            string sql = "";
            sql = " select sale_month"
                 + " , isnull( sum( case when sale_year = '2018' then [sales_amt]- [pos_tobacco_amt] end) , 0) as '2018' "
                 + " , isnull(sum( case when sale_year = '2019' then [sales_amt]- [pos_tobacco_amt] end) , 0) as '2019' "
                  + " , isnull(sum( case when sale_year = '2020' then [sales_amt]- [pos_tobacco_amt] end) , 0) as '2020' "
                  + " from  [dbo].sales  group by sale_month ";

            db.ConnectDB(); // db connectSystem.
            dt = db.GetDBTable(sql);
            //MessageBox.Show(" count :" + dt.Rows.Count);
            dataGridView1.DataSource = dt;

            double a_total_amt = 0;
            double b_total_amt = 0;
            double c_total_amt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                a_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                b_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                c_total_amt += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            DataRow dr = dt.NewRow();
            dr[0] = "Total";
            dr[1] = a_total_amt;
            dr[2] = b_total_amt;
            dr[3] = c_total_amt;
            dt.Rows.Add(dr);
            setRowsLine(dataGridView1);

            int lastLine = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastLine].DefaultCellStyle.BackColor = Color.YellowGreen;

            dataGridView1.Columns[1].ValueType = typeof(decimal);
            dataGridView1.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].ValueType = typeof(decimal);
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[3].ValueType = typeof(decimal);
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridView1.Update();

            sql = " select sale_month"
                 + " , isnull( sum( case when sale_year = '2018' then [pos_tobacco_amt] end) , 0) as '2018' "
                 + " , isnull(sum( case when sale_year = '2019' then [pos_tobacco_amt] end) , 0) as '2019' "
                  + " , isnull(sum( case when sale_year = '2020' then [pos_tobacco_amt] end) , 0) as '2020' "
                  + " from  [dbo].sales  group by sale_month ";
            dt = db.GetDBTable(sql);
            dataGridView2.DataSource = dt;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                a_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
                b_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                c_total_amt += Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            }
            dr = dt.NewRow();
            dr[0] = "Total";
            dr[1] = a_total_amt;
            dr[2] = b_total_amt;
            dr[3] = c_total_amt;
            dt.Rows.Add(dr);
            //gid add, minuUpdate
            setRowsLine(dataGridView2);
            lastLine = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[lastLine].DefaultCellStyle.BackColor = Color.YellowGreen;


            dataGridView2.Columns[1].ValueType = typeof(decimal);
            dataGridView2.Columns[1].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[2].ValueType = typeof(decimal);
            dataGridView2.Columns[2].DefaultCellStyle.Format = "N2";
            dataGridView2.Columns[3].ValueType = typeof(decimal);
            dataGridView2.Columns[3].DefaultCellStyle.Format = "N2";

            dataGridView2.Update();
            db.CloseDB();  // db close
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

        private void button1_Click(object sender, EventArgs e)
        {
            //https://www.it-swarm.dev/ko/c%23/datagridview-%EC%97%B4%EC%97%90-%ED%95%A9%EA%B3%84%EB%A5%BC-%ED%91%9C%EC%8B%9C%ED%95%98%EB%8A%94-%EB%B0%A9%EB%B2%95%EC%9D%80-%EB%AC%B4%EC%97%87%EC%9E%85%EB%8B%88%EA%B9%8C/971055133/
            //
        }
    }
}
