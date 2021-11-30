﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public NhanVienBUS()
        {
        }

        public static NhanVienBUS Intance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            set => instance = value;
        }

        public bool Login(string userName, string passWord)
        {
            return NhanVienDAO.Intance.Login(userName, passWord);
        }

        public NhanVienDTO getNVByID(string id)
        {
            return NhanVienDAO.Intance.getNVByID(id);
        }

        public DataTable getListNV()
        {
            return NhanVienDAO.Intance.getListNV();
        }

        public bool suaNV(string maNV, string tenNV, string DiaChi, string SDT)
        {
            return NhanVienDAO.Intance.suaNV(maNV, tenNV, DiaChi, SDT);
        }

        public bool xoaNV(string maNV)
        {
            return NhanVienDAO.Intance.xoaNV(maNV);
        }

        public DataTable TimKiemNV(string name)
        {
            return NhanVienDAO.Intance.TimKiemNV(name);
        }

        public string loadMaNV()
        {
            return NhanVienDAO.Intance.loadMaNV();
        }
 
        public bool themNV(string maNV, string tenNV, string Gioitinh, string DiaChi, string SDT, string Tendangnhap, string Matkhau)
        {
            return NhanVienDAO.Intance.themNV(maNV, tenNV, Gioitinh, DiaChi, SDT, Tendangnhap, Matkhau);
        }

        public bool capnhatmk(string mk, string sdt)
        {
            return NhanVienDAO.Intance.capnhatmk(mk, sdt);
        }

        public bool capnhatmk1(string mk, string tk)
        {
            return NhanVienDAO.Intance.capnhatmk1(mk, tk);
        }


    }
}








