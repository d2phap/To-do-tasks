﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LichLamViecDTO
    {
        private List<CongViecDTO> danhSachCongViec;
        private DateTime thoiGianDongBoMoiNhat;
        private string ten;

        #region Properties
        public List<CongViecDTO> DanhSachCongViec
        {
            get { return danhSachCongViec; }
            set { danhSachCongViec = value; }
        }
        public DateTime ThoiGianDongBoMoiNhat
        {
            get { return thoiGianDongBoMoiNhat; }
            set { thoiGianDongBoMoiNhat = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        #endregion

        public LichLamViecDTO(List<CongViecDTO> _DSCongViec)
        {
            this.DanhSachCongViec = _DSCongViec;
        }

        public LichLamViecDTO()
        {
            this.DanhSachCongViec = new List<CongViecDTO>();
            this.ThoiGianDongBoMoiNhat = DateTime.Now;
            this.Ten = "Default";
        }
    }
}
