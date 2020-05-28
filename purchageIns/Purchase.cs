using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchageIns
{
    class Purchase
    {
        //( @regDate,@payMethod,@checkNo,@payee,@total,@gst,@category,@etc,@createDate
        public DateTime RegDate;
        public string PayMethod;
        public string CheckNo;
        public string Payee;
        public double PayPrice;
        public float Gst;
        public string Category;
        public string Etc;
        public string CreateDate;

        public Purchase(DateTime regDate, string payMethod, string checkNo, string payee, string payPrice, string gst, string category
                , string etc, string createDate)
        {
            this.RegDate = regDate;
            this.PayMethod = payMethod;
            this.CheckNo = checkNo;
            this.Payee = payee;
            this.PayPrice = Convert.ToDouble(payPrice);
            this.Gst = float.Parse(gst);
            this.Category = category;
            this.Etc = etc;
            this.CreateDate = createDate;
        }
        /*
         * comment, two
        public string RegDate
        {
            get
            {
                return this.RegDate;
            }
            set
            {
                this.RegDate = value;
            }
        }
        */

    }
}
