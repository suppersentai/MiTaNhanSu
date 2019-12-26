using MitaToll.DLL;
using MitaToll.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MitaToll.DAL
{
	internal class MayChamCongDAL : Provider
	{
		private DBHelper dbHelper;

		public MayChamCongDAL()
		{
			this.dbHelper = new DBHelper();
		}

		public void ThemMayChamCong(MayChamCongDTO _mayChamCongDTO)
		{
			base.Procedure("MAYCHAMCONG_add", new List<SqlParameter>
			{
				new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
				new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC),
				new SqlParameter("@IDMCC", _mayChamCongDTO.IDMCC),
				new SqlParameter("@KieuKetNoi", _mayChamCongDTO.KieuKetNoi),
				new SqlParameter("@DiaChiIP", _mayChamCongDTO.DiaChiIP),
				new SqlParameter("@Port", _mayChamCongDTO.Port),
				new SqlParameter("@CongCOM", _mayChamCongDTO.CongCOM),
				new SqlParameter("@TocDoTruyen", _mayChamCongDTO.TocDoTruyen),
				new SqlParameter("@DiaChiWeb", _mayChamCongDTO.DiaChiWeb),
				new SqlParameter("@NgayDangKyTenMien", _mayChamCongDTO.NgayDangKyTenMien),
				new SqlParameter("@SuDungWeb", _mayChamCongDTO.SuDungWeb),
				new SqlParameter("@Serial", _mayChamCongDTO.Serial),
				new SqlParameter("@SoDangKy", _mayChamCongDTO.SoDangKy),
				new SqlParameter("@TrangThai", _mayChamCongDTO.TrangThai),
				new SqlParameter("@TrangThaiMay", _mayChamCongDTO.TrangThaiMay)
			});
		}

		public DataTable LOADMAYCHAMCONG()
		{
			List<SqlParameter> _sqlParameter = new List<SqlParameter>();
			DataTable tb = new DataTable();
			return base.executeNonQuerya("MAYCHAMCONG_getall", _sqlParameter);
		}

		public ArrayList SelectAllMCC()
		{
			SqlDataReader rd = this.dbHelper.ExecuteQuery("MAYCHAMCONG_getall");
			ArrayList arrMCC = new ArrayList();
           
			while (rd.Read())
			{
				MayChamCongDTO _mayChamCongDTO = new MayChamCongDTO(rd.GetString(0), rd.GetString(1), rd.GetInt32(2), rd.GetString(3), rd.GetString(4), rd.GetInt32(5), rd.GetInt32(6), rd.GetString(7), rd.GetString(8), rd.GetDateTime(9), rd.GetBoolean(10), rd.GetString(11), rd.GetString(12), rd.GetBoolean(13), rd.GetInt32(14));
				arrMCC.Add(_mayChamCongDTO);
			}
			rd.Close();
			return arrMCC;
		}

		public void SuaMayChamCong(MayChamCongDTO _mayChamCongDTO)
		{
			base.Procedure("MAYCHAMCONG_update", new List<SqlParameter>
			{
				new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
				new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC),
				new SqlParameter("@IDMCC", _mayChamCongDTO.IDMCC),
				new SqlParameter("@KieuKetNoi", _mayChamCongDTO.KieuKetNoi),
				new SqlParameter("@DiaChiIP", _mayChamCongDTO.DiaChiIP),
				new SqlParameter("@Port", _mayChamCongDTO.Port),
				new SqlParameter("@CongCOM", _mayChamCongDTO.CongCOM),
				new SqlParameter("@TocDoTruyen", _mayChamCongDTO.TocDoTruyen),
				new SqlParameter("@DiaChiWeb", _mayChamCongDTO.DiaChiWeb),
				new SqlParameter("@SuDungWeb", _mayChamCongDTO.SuDungWeb),
				new SqlParameter("@TrangThai", _mayChamCongDTO.TrangThai),
				new SqlParameter("@TrangThaiMay", _mayChamCongDTO.TrangThaiMay)
			});
		}

		public void CapNhatActiveKey(MayChamCongDTO _mayChamCongDTO)
		{
			base.Procedure("MAYCHAMCONG_activeKey", new List<SqlParameter>
			{
				new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC),
				new SqlParameter("@Serial", _mayChamCongDTO.Serial),
				new SqlParameter("@SoDangKy", _mayChamCongDTO.SoDangKy)
			});
		}

		public void DELELEMAYCHAMCONG(MayChamCongDTO _mayChamCongDTO)
		{
			base.Procedure("MAYCHAMCONG_delete", new List<SqlParameter>
			{
				new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC)
			});
		}

		public DataTable MayChamCong_getLoad(MayChamCongDTO _mayChamCongDTO)
		{
			return base.executeNonQuerya("MayChamCong_get", new List<SqlParameter>
			{
				new SqlParameter("@MaMCC", _mayChamCongDTO.MaMCC)
			});
		}

		public DataTable MayChamCong_getAllByTenMCC(MayChamCongDTO _mayChamCongDTO)
		{
			return base.executeNonQuerya("MayChamCong_getAllByTenMCC", new List<SqlParameter>
			{
				new SqlParameter("@TenMCC", _mayChamCongDTO.TenMCC)
			});
		}

        public DataTable GetMayChamCongTheoMa(string MaMay) {
            return base.executeNonQuerya("MayChamCong_LayTheoMa", new List<SqlParameter> {
                new SqlParameter("@MaMay", MaMay)
            });
        }
	}
}
