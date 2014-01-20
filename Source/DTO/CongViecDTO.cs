﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CongViecDTO
    {
        private string ten;
        private List<ThoiGianDienRaDTO> thoiGianDienRa;
        private string diaDiem;
        private string mieuTa;
        private ConsoleColor mauSacLich;
        private string danhSachThoiGianNhacNho;
        private List<HinhThucNhacNhoDTO> hinhThucNhacNho;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public List<ThoiGianDienRaDTO> ThoiGianDienRa
        {
            get { return thoiGianDienRa; }
            set { thoiGianDienRa = value; }
        }
        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }
        public string MieuTa
        {
            get { return mieuTa; }
            set { mieuTa = value; }
        }
        public ConsoleColor MauSacLich
        {
            get { return mauSacLich; }
            set { mauSacLich = value; }
        }
        public string DanhSachThoiGianNhacNho
        {
            get { return danhSachThoiGianNhacNho; }
            set { danhSachThoiGianNhacNho = value; }
        }
        public List<HinhThucNhacNhoDTO> HinhThucNhacNho
        {
            get { return hinhThucNhacNho; }
            set { hinhThucNhacNho = value; }
        }

        public CongViecDTO(string _Ten, List<ThoiGianDienRaDTO> _ThoiGianDienRa, string _DiaDiem, string _MieuTa, ConsoleColor _MauSac, string _DSThoiGian, List<HinhThucNhacNhoDTO> _HinhThucNhacNho)
        {
            this.ten = _Ten;
            this.thoiGianDienRa = _ThoiGianDienRa;
            this.diaDiem = _DiaDiem;
            this.mieuTa = _MieuTa;
            this.mauSacLich = _MauSac;
            this.danhSachThoiGianNhacNho = _DSThoiGian;
            this.hinhThucNhacNho = _HinhThucNhacNho;
        }

        public CongViecDTO()
        {
            this.ten = "";
            this.diaDiem = "";
            this.mieuTa = "";
            this.danhSachThoiGianNhacNho = "";
        }

    }
}
