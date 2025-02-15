﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_QuanLyXeBus.DTO
{
    public class DTO_TaiKhoan
    {
        private String maTaiKhoan;
        private String tenTaiKhoan;
        private String matKhau;
        private String email;
        private String tenDayDu;
        private String soDienThoai;
        private String chucVu;
        private DateTime ngayThangNamSinh;

        public String MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public String TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public String Matkhau { get => matKhau; set => matKhau = value; }
        public String Email { get => email; set => email = value; }
        public String TenDayDu { get => tenDayDu; set => tenDayDu = value; }
        public String SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public String ChucVu { get => chucVu; set => chucVu = value; }
        public DateTime NgayThangNamSinh { get => ngayThangNamSinh; set => ngayThangNamSinh = value; }
    }
}
