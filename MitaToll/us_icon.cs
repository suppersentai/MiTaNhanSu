using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MitaToll.DTO;
namespace MitaToll
{
    public partial class us_icon : UserControl
    {
        public us_icon(MayChamCongDTO mcc,bool status)
        {
            InitializeComponent();
            this.lbName.Text ="Máy :  "+ mcc.TenMCC;
            this.lbIp.Text =  "Ip  :  "+mcc.DiaChiIP;
            if (status)
                panColor.BackColor = Color.Green;
            else panColor.BackColor = Color.Red;

        }
    }
}
