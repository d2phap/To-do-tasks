﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Models;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Diagnostics;

namespace API.Controllers
{
    public class AccountController : ApiController
    {
        // GET api/account
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/account/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/account
        public void Post([FromBody]string value)
        {
        }

        // PUT api/account/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/account/5
        public void Delete(int id)
        {
        }


        private string SHA1(string inputString)
        {
            //Mã hoá bằng SHA1
            SHA1Managed sha1 = new SHA1Managed();

            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            var hashedBytes = sha1.ComputeHash(bytes);

            StringBuilder hashedBuilder = new StringBuilder(40);
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                hashedBuilder.Append(hashedBytes[i].ToString("x2"));
            }

            //Chuỗi sau khi mã hoá
            return hashedBuilder.ToString();
        }


        /// <summary>
        /// Xử lý đăng nhập
        /// Ví dụ: http://localhost:53456/api/account/login?email=d2phap@gmail.com&password=12345
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Mật khẩu đã được mã hoá SHA1</param>
        /// <returns></returns>
        [HttpGet, ActionName("login")]
        [AcceptVerbs("GET")]
        public bool LogIn(string email, string password)
        {
            dbToDoTasksDataContext db = new dbToDoTasksDataContext();

            //Mã hoá mật khẩu bằng SHA1
            string hashedPassword = SHA1(password);

            //Truy van kq
            var acc = db.Accounts.SingleOrDefault(a => a.email.CompareTo(email) == 0 && 
                a.password.CompareTo(hashedPassword) == 0);

            if(acc != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Đăng ký tài khoản mới
        /// Ví dụ: http://localhost:53456/api/account/register?email=d2phap@gmail.com&password=8cb2237d0679ca88db6464eac60da96345513964&name=Phap
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Mật khẩu đã mã hoá SHA1</param>
        /// <param name="name">Tên người dùng</param>
        /// <returns></returns>
        [HttpGet, HttpPost, ActionName("register")]
        [AcceptVerbs("GET", "POST")]
        public bool Register(string email, string password, string name)
        {
            dbToDoTasksDataContext db = new dbToDoTasksDataContext();

            //Mã hoá mật khẩu bằng SHA1
            string hashedPassword = SHA1(password);

            //Truy van kq
            var acc = db.Accounts.SingleOrDefault(a => a.email.CompareTo(email) == 0);

            //Neu email chua ton tai
            if (acc == null)
            {
                acc = new Account();
                acc.email = email;
                acc.password = hashedPassword;
                acc.name = name;

                try
                {
                    db.Accounts.InsertOnSubmit(acc);
                    db.SubmitChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Đồng bộ hoá dữ liệu (upload tập tin xml)
        /// </summary>
        /// <returns></returns>
        [HttpPost, HttpGet, ActionName("sync")]
        [AcceptVerbs("GET", "POST")]
        public async Task<HttpResponseMessage> Sync()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.
                foreach (MultipartFileData file in provider.FileData)
                {
                    Trace.WriteLine(file.Headers.ContentDisposition.FileName);
                    Trace.WriteLine("Server file path: " + file.LocalFileName);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }




    }
}