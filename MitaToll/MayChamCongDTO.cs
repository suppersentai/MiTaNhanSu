using System;
using System.Data;

namespace MitaToll.DTO
{
	public class MayChamCongDTO
	{
		private string _MaMCC;

		private string _TenMCC;

		private int _IDMCC;

		private string _KieuKetNoi;

		private string _DiaChiIP;

		private int _Port;

		private int _CongCOM;

		private string _TocDoTruyen;

		private string _DiaChiWeb;

		private DateTime _NgayDangKyTenMien;

		private bool _SuDungWeb;

		private string _Serial;

		private string _SoDangKy;

		private bool _TrangThai;

		private string _TinhTrang;

		private int _TrangThaiMay;

		public string MaMCC
		{
			get
			{
				return this._MaMCC;
			}
			set
			{
				this._MaMCC = value;
			}
		}

		public string TenMCC
		{
			get
			{
				return this._TenMCC;
			}
			set
			{
				this._TenMCC = value;
			}
		}

		public int IDMCC
		{
			get
			{
				return this._IDMCC;
			}
			set
			{
				this._IDMCC = value;
			}
		}

		public string KieuKetNoi
		{
			get
			{
				return this._KieuKetNoi;
			}
			set
			{
				this._KieuKetNoi = value;
			}
		}

		public string DiaChiIP
		{
			get
			{
				return this._DiaChiIP;
			}
			set
			{
				this._DiaChiIP = value;
			}
		}

		public int Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				this._Port = value;
			}
		}

		public int CongCOM
		{
			get
			{
				return this._CongCOM;
			}
			set
			{
				this._CongCOM = value;
			}
		}

		public string TocDoTruyen
		{
			get
			{
				return this._TocDoTruyen;
			}
			set
			{
				this._TocDoTruyen = value;
			}
		}

		public string DiaChiWeb
		{
			get
			{
				return this._DiaChiWeb;
			}
			set
			{
				this._DiaChiWeb = value;
			}
		}
        public DateTime NgayDangKyTenMien
		{
			get
			{
				return this._NgayDangKyTenMien;
			}
			set
			{
				this._NgayDangKyTenMien = value;
			}
		}

		public bool SuDungWeb
		{
			get
			{
				return this._SuDungWeb;
			}
			set
			{
				this._SuDungWeb = value;
			}
		}

		public string Serial
		{
			get
			{
				return this._Serial;
			}
			set
			{
				this._Serial = value;
			}
		}

		public string SoDangKy
		{
			get
			{
				return this._SoDangKy;
			}
			set
			{
				this._SoDangKy = value;
			}
		}

		public bool TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				this._TrangThai = value;
			}
		}

		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				this._TinhTrang = value;
			}
		}

		public int TrangThaiMay
		{
			get
			{
				return this._TrangThaiMay;
			}
			set
			{
				this._TrangThaiMay = value;
			}
		}

		public MayChamCongDTO()
		{
		}

		public MayChamCongDTO(string _MaMCC, string _TenMCC, int _IDMCC, string _KieuKetNoi, string _DiaChiIP, int _Port, int _CongCOM, string _TocDoTruyen, string _DiaChiWeb, DateTime _NgayDangKyTenMien, bool _SuDungWeb, string _Serial, string _SoDangKy, bool _TrangThai, int _TrangThaiMay)
		{
			this.MaMCC = _MaMCC;
			this.TenMCC = _TenMCC;
			this.IDMCC = _IDMCC;
			this.KieuKetNoi = _KieuKetNoi;
			this.DiaChiIP = _DiaChiIP;
			this.Port = _Port;
			this.CongCOM = _CongCOM;
			this.TocDoTruyen = _TocDoTruyen;
			this.DiaChiWeb = _DiaChiWeb;
			this.NgayDangKyTenMien = _NgayDangKyTenMien;
			this.SuDungWeb = _SuDungWeb;
			this.Serial = _Serial;
			this.SoDangKy = _SoDangKy;
			this.TrangThai = _TrangThai;
			this.TrangThaiMay = _TrangThaiMay;
		}
	}
}
