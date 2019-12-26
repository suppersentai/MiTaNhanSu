using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zkemkeeper;
using System.Windows.Forms;
using MitaToll.DLL;
using MitaToll.DTO;
using System.Threading;
using MitaToll;

namespace testmultithread
{
    public partial class NhanSu : Form
    {

        private int countMachine = 0;
        private int countConnected = 0;
        private int countNotConnect = 0;
        private int stt = 0;
        private int countAutoSync = 0;
        private int countMachineConnectting = 0;


        private MayChamCongBLL mayChamCongBLL  = new MayChamCongBLL();
        public NhanSu()
        {
            InitializeComponent();
            //  timerCountSync.Start();
            this.dgv.Columns[4].Visible = false;
            this.lbTimer.Text = "";
            this.lbTextWaitting.Text = "";
            this.countMachine = mayChamCongBLL.GetAllMCC().Count;
            this.lbCountMachine.Text = this.countMachine.ToString();


        }
        void checkSingle(object item)
        {
           
            CZKEMClass ZKEMCLASS = new CZKEMClass();
            MayChamCongDTO mcc = (MayChamCongDTO)item;
            bool stt = ZKEMCLASS.Connect_Net(mcc.DiaChiIP, mcc.Port);
            #region lưới

            string[] row = new string[] { (this.stt += 1).ToString(), mcc.MaMCC, mcc.TenMCC, stt ? "Đã đồng bộ" : "Mất kết nối", stt.ToString() };
            if (stt) this.countConnected += 1;
            else this.countNotConnect++;
            ZKEMCLASS.Disconnect();
            Invoke(new MethodInvoker(delegate ()
            {
             

                this.lbCountConnected.Text = this.countConnected.ToString();
                this.lbCountNotConnect.Text = this.countNotConnect.ToString();
                this.dgv.Rows.Add(row);
                if (dgv.Rows.Count > 0)
                    if (dgv.Rows[dgv.Rows.Count - 1].Cells[4].Value.ToString() == "True")
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Green;

                    }
                    else
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[3].Style.ForeColor = Color.Red;
                    }
                this.countMachineConnectting++;
                if (this.countMachineConnectting == this.countMachine)
                    this.lbTextWaitting.Text = "";
                else this.lbTextWaitting.Text = "Đang xử lí ... ";

            }));
            #endregion

            #region icon
            us_icon uc = new us_icon(mcc, stt);
            Invoke(new MethodInvoker(delegate ()
            {
                flowLayout.Controls.Add(uc);
            }));


            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dgv.Rows.Clear();
            mayChamCongBLL = new MayChamCongBLL();
            ArrayList listMcc = mayChamCongBLL.GetAllMCC();
            foreach (var item in listMcc)
            {
                Thread thread = new Thread(checkSingle);
                thread.Start((object)item);
            }
        }

       

        private void NhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {

            this.dgv.Rows.Clear();
            this.stt = 0;
            this.countConnected = 0;
            this.countMachine = 0;
            this.countNotConnect = 0;
            this.countMachineConnectting = 0;
            flowLayout.Controls.Clear();
            
            this.lbTextWaitting.Text = " Đang xử lí ...";
            ArrayList listMcc = mayChamCongBLL.GetAllMCC();
           this.countMachine= listMcc.Count;
            this.lbCountMachine.Text = this.countMachine.ToString();
            foreach (var item in listMcc)
            {
                Thread thread = new Thread(checkSingle);
                thread.Start((object)item);
            }


        }

       
       
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

            if (metroToggle1.Checked)
            {
                int num;
                if (int.TryParse(txtTimeSpan.Text, out num))
                {

                    timeSyncAuto.Interval = 1000;
                    timeSyncAuto.Start();
                    countAutoSync = num * 60;
                    this.txtTimeSpan.Enabled = false;
                }
                else
                {
                    lbTimer.Visible = lbTextKiemTraSau.Visible = false;
                    MessageBox.Show("Nhập thời gian ", "Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    metroToggle1.Checked = false;
                }
            }
            else
            {
                timeSyncAuto.Stop();
                this.txtTimeSpan.Enabled = true;
                lbTextKiemTraSau.Visible = false;
                lbTimer.Visible = false;
            }
        }
        string convertToTimeString(int second)
        {
            int hour = second / 3600;
            int minute = second % 3600 / 60;
            int sec = second % 3600 % 60;
            string h = hour < 10 ? "0" + hour.ToString() : hour.ToString();
            string mn = minute < 10 ? "0" + minute.ToString() : minute.ToString();
            string sc = sec < 10 ? "0" + sec.ToString() : sec.ToString();

            return h + " : " + mn + " : " + sc;
        }
        private void timeSyncAuto_Tick(object sender, EventArgs e)
        {

            if (countAutoSync >= 0)
            {
                this.lbTimer.Visible = this.lbTextKiemTraSau.Visible = true;
                lbTimer.Text = convertToTimeString(countAutoSync);
                countAutoSync--;
            }
            else
            {
                lbTimer.Visible = lbTextKiemTraSau.Visible = false;
                btnSync.PerformClick();
                countAutoSync = int.Parse(this.txtTimeSpan.Text) * 60;
            }
        }

        private void txtTimeSpan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))))
                e.Handled = true;
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void lbTimer_Click(object sender, EventArgs e)
        {

        }

        private void lbTextWaitting_Click(object sender, EventArgs e)
        {

        }
    }
}
