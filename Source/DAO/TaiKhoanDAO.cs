﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private string _xmlPath = string.Empty;
        public TaiKhoanDAO(string xmlPath)
        {
            this._xmlPath = xmlPath;
        }

        /// <summary>
        /// Đọc dữ liệu người dùng từ tập tin xml
        /// </summary>
        /// <returns></returns>
        public List<TaiKhoanDTO> ReadUsers()
        {
            List<TaiKhoanDTO> users = new List<TaiKhoanDTO>();

            XmlDocument doc = new XmlDocument();
            doc.Load(this._xmlPath);
            XmlElement root = (XmlElement)doc.DocumentElement;// <to_do_tasks>
            XmlNodeList nUsers = root.SelectNodes("user"); // <user>

            //Duyet tung user
            foreach (XmlElement nUser in nUsers)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();

                // <email>
                XmlElement n = (XmlElement)nUser.SelectNodes("email")[0];
                tk.Email = n.InnerText;

                // <name>
                n = (XmlElement)nUser.SelectNodes("name")[0];
                tk.HoTen = n.InnerText;

                // <type>
                n = (XmlElement)nUser.SelectNodes("type")[0];
                if(n.InnerText.ToLower().CompareTo("registered") == 0)
                {
                    tk.LoaiTaiKhoan = LoaiTaiKhoan.Registered;
                }
                else
                {
                    tk.LoaiTaiKhoan = LoaiTaiKhoan.Anomyous;
                }

                // <schedules>
                n = (XmlElement)nUser.SelectNodes("schedules")[0];

                // <schedule><item>
                XmlNodeList nSchedules = n.SelectNodes("item");
                List<LichLamViecDTO> schedules = new List<LichLamViecDTO>();

                // Duyệt danh sách lịch làm việc
                foreach (XmlElement nSchedule in nSchedules)
                {
                    LichLamViecDTO schedule = new LichLamViecDTO();
                    schedule.ThoiGianDongBoMoiNhat = DateTime.Parse(n.GetAttribute("lastsync"));
                    schedule.Ten = nSchedule.GetAttribute("name");

                    // <task>
                    XmlNodeList nTasks = nSchedule.SelectNodes("task");
                    List<CongViecDTO> tasks = new List<CongViecDTO>();

                    // Duyet danh sach cong viec
                    foreach (XmlElement nTask in nTasks)
                    {
                        CongViecDTO task = new CongViecDTO();

                        // <title>
                        XmlElement nn = (XmlElement)nTask.SelectNodes("title")[0];
                        task.Ten = nn.InnerText;

                        // <place>
                        nn = (XmlElement)nTask.SelectNodes("place")[0];
                        task.DiaDiem = nn.InnerText;

                        // <description>
                        nn = (XmlElement)nTask.SelectNodes("description")[0];
                        task.MieuTa = nn.InnerText;

                        // <color>
                        nn = (XmlElement)nTask.SelectNodes("color")[0];
                        task.MauSacLich = Color.FromArgb(int.Parse(nn.InnerText));

                        // <time>
                        XmlElement nTime = (XmlElement)nTask.SelectNodes("time")[0];

                        // <time><type>
                        nn = (XmlElement)nTime.SelectNodes("type")[0];
                        if(nn.InnerText.ToLower().CompareTo("repeated") == 0)
                        {
                            task.ThoiGianDienRa.Loai = LoaiThoiGianDienRa.Repeated;
                        }
                        else
                        {
                            task.ThoiGianDienRa.Loai = LoaiThoiGianDienRa.Unique;
                        }
                        
                        // <time><start>
                        nn = (XmlElement)nTime.SelectNodes("start")[0];
                        task.ThoiGianDienRa.ThoiGianBatDau = DateTime.Parse(nn.InnerText);

                        // <time><end>
                        nn = (XmlElement)nTime.SelectNodes("end")[0];
                        task.ThoiGianDienRa.ThoiGianKetThuc = DateTime.Parse(nn.InnerText);

                        // <time><repeat>
                        nn = (XmlElement)nTime.SelectNodes("repeat")[0];
                        task.ThoiGianDienRa.SoLanLap = int.Parse(nn.InnerText);

                        // <time><repeated_unit>
                        nn = (XmlElement)nTime.SelectNodes("repeated_unit")[0];
                        task.ThoiGianDienRa.DonViLap = int.Parse(nn.InnerText);

                        // <remind>
                        XmlElement nRemind = (XmlElement)nTask.SelectNodes("remind")[0];

                        // <remind><type>
                        XmlElement nRemindType = (XmlElement)nRemind.SelectNodes("type")[0];

                        // <remind><type><item>
                        XmlNodeList nRemindTypeItems = nRemindType.SelectNodes("item");
                        task.HinhThucNhacNho = new List<LoaiHinhThucNhacNho>();

                        // Duyet danh sach hinh thuc nhac nho
                        foreach(XmlElement item in nRemindTypeItems)
                        {
                            if(item.InnerText.ToLower().CompareTo("email") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if(task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.Email) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.Email);
                                }
                            }
                            else if(item.InnerText.ToLower().CompareTo("msgbox") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if (task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.MessageBox) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.MessageBox);
                                }
                            }
                            else if (item.InnerText.ToLower().CompareTo("sound") == 0)
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if (task.HinhThucNhacNho.IndexOf(LoaiHinhThucNhacNho.Sound) == -1)
                                {
                                    task.HinhThucNhacNho.Add(LoaiHinhThucNhacNho.Sound);
                                }
                            }
                        }// END Duyet danh sach hinh thuc nhac nho

                        // <remind><time>
                        XmlElement nRemindTime = (XmlElement)nRemind.SelectNodes("time")[0];

                        // <remind><time><item>
                        XmlNodeList nRemindTimeItems = nRemindTime.SelectNodes("item");
                        task.DanhSachThoiGianNhacNho = new List<int>();

                        // Duyet danh sach thoi gian nhac nho (minute)
                        foreach (XmlElement item in nRemindTimeItems)
                        {
                            int v = 0;
                            if (int.TryParse(item.InnerText, out v))
                            {
                                //Kiem tra chua ton tai thi moi them vao
                                if(task.DanhSachThoiGianNhacNho.IndexOf(v) ==-1)
                                {
                                    task.DanhSachThoiGianNhacNho.Add(v);
                                }
                            }

                        }// END Duyet danh sach thoi gian nhac nho

                        //Them cong viec vao danh sach
                        tasks.Add(task);

                    }// END Duyet danh sach cong viec

                    //Gan danh sach cong viec vao lich lam viec
                    schedule.DanhSachCongViec = tasks;

                    //Them lich lam viec vao danh sach
                    schedules.Add(schedule);

                }// END Duyệt danh sách lịch làm việc

                //Gan danh sach lich lam viec vao user
                tk.LichLamViec = schedules;

                //Them nguoi dung vao danh sach
                users.Add(tk);

            }// END Duyet tung user

            return users;
        }

    }
}
