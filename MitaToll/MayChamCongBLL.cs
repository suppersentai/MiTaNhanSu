using MitaToll.DAL;
using MitaToll.DTO;
using System;
using System.Collections;
using System.Data;

namespace MitaToll.DLL
{
	internal class MayChamCongBLL
	{
		private MayChamCongDAL _mayChamCongDAL = new MayChamCongDAL();

		public void THEMMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
		{
			this._mayChamCongDAL.ThemMayChamCong(_mayChamCongDTO);
		}

		public DataTable GETDANHSACHMCC()
		{
			return this._mayChamCongDAL.LOADMAYCHAMCONG();
		}

		public ArrayList GetAllMCC()
		{
			ArrayList arrMCC = new ArrayList();
			return this._mayChamCongDAL.SelectAllMCC();
		}

		public void SUAMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
		{
			this._mayChamCongDAL.SuaMayChamCong(_mayChamCongDTO);
		}

		public void SUAACTIVEKEY(MayChamCongDTO _mayChamCongDTO)
		{
			this._mayChamCongDAL.CapNhatActiveKey(_mayChamCongDTO);
		}

		public void DELETEMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
		{
			this._mayChamCongDAL.DELELEMAYCHAMCONG(_mayChamCongDTO);
		}

		public DataTable MayChamCongGetLoad(MayChamCongDTO _mayChamCongDTO)
		{
			return this._mayChamCongDAL.MayChamCong_getLoad(_mayChamCongDTO);
		}

		public DataTable MayChamCongGetAllByTenMCC(MayChamCongDTO _mayChamCongDTO)
		{
			return this._mayChamCongDAL.MayChamCong_getAllByTenMCC(_mayChamCongDTO);
		}

        public MayChamCongDTO GetMayChamCongTheoMa(string MaMay) {
            DataTable data = this._mayChamCongDAL.GetMayChamCongTheoMa(MaMay);
            MayChamCongDTO mayChamCong = new MayChamCongDTO();
            mayChamCong.MaMCC = data.Rows[0].ItemArray[0].ToString();
            mayChamCong.TenMCC = data.Rows[0].ItemArray[1].ToString();
            mayChamCong.IDMCC = Convert.ToInt32(data.Rows[0].ItemArray[2].ToString());
            mayChamCong.KieuKetNoi = data.Rows[0].ItemArray[3].ToString();
            mayChamCong.DiaChiIP = data.Rows[0].ItemArray[4].ToString();
            mayChamCong.Port = Convert.ToInt32(data.Rows[0].ItemArray[5].ToString());
            mayChamCong.CongCOM = Convert.ToInt32(data.Rows[0].ItemArray[6].ToString());
            mayChamCong.TocDoTruyen = data.Rows[0].ItemArray[7].ToString();
            mayChamCong.DiaChiWeb = data.Rows[0].ItemArray[8].ToString();
            mayChamCong.NgayDangKyTenMien = Convert.ToDateTime( data.Rows[0].ItemArray[9].ToString());
            mayChamCong.SuDungWeb = Convert.ToBoolean(data.Rows[0].ItemArray[10].ToString());
            mayChamCong.Serial = data.Rows[0].ItemArray[11].ToString();
            mayChamCong.SoDangKy = data.Rows[0].ItemArray[12].ToString();
            mayChamCong.TrangThai = Convert.ToBoolean(data.Rows[0].ItemArray[13].ToString());

            return mayChamCong;
        }
	}
}
