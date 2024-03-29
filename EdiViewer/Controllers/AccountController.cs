﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreApiClient;
using System.Diagnostics;
using System.Text;
using System.Net;

namespace EdiViewer.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View(new Models.ErrorModel());
        }
        [HttpGet]
        public bool MiAlive()
        {
            string CodUsr = HttpContext.Session.GetObjSession<string>("Session.CodUsr");
            if (string.IsNullOrEmpty(CodUsr)) return false;
            return true;
        }
        [HttpPost]
        public async Task<IActionResult> Login(string TxtUser, string TxtPassword) {
            try
            {
                string HashId = await ApiClientFactory.Instance.Login(TxtUser, TxtPassword);
                bool IsExtern = false;
                if (HashId.StartsWith("Error:"))
                    return View("Index", new Models.ErrorModel() { ErrorMessage = System.Net.WebUtility.HtmlEncode(HashId.Replace(Environment.NewLine, "<br />")) });
                if (string.IsNullOrEmpty(HashId))
                {
                    string UserEncrypted = ApiClientFactory.Instance.Encrypt(TxtUser);
                    string PasswordEncrypted = ApiClientFactory.Instance.Encrypt(TxtPassword);
                    HashId = await ApiClientFactory.Instance.LoginExtern(UserEncrypted, PasswordEncrypted);
                    if (string.IsNullOrEmpty(HashId))
                        return LocalRedirect("/Account/?error=USER_INCORRECT");
                    HttpContext.Session.SetObjSession("Session.IsExtern", true);
                    IsExtern = true;
                    HttpContext.Session.SetObjSession("Session.ClientId", HashId.Split('|')[1]);
                    HashId = HashId.Split('|')[0];
                } else
                {
                    HttpContext.Session.SetObjSession("Session.IsExtern", false);
                    HashId += DateTime.Now.ToString(ApplicationSettings.DateTimeFormatL);
                }
                if (HashId.StartsWith("Error:"))
                    return View("Index", new Models.ErrorModel() { ErrorMessage = System.Net.WebUtility.HtmlEncode(HashId.Replace(Environment.NewLine, "<br />")) });
                HttpContext.Session.SetObjSession("Session.HashId", HashId);
                HttpContext.Session.SetObjSession("Session.CodUsr", TxtUser);
                if (string.IsNullOrEmpty(HashId))
                    return LocalRedirect("/Account/?error=USER_INCORRECT");
                if (IsExtern)
                    return LocalRedirect("/HomeExtern/Inventario");
                else
                    return LocalRedirect("/");
            }
            catch (Exception e1)
            {
                return View("Index", new Models.ErrorModel() { ErrorMessage = e1.ToString().Replace("'", "") });
            }            
        }
    }
}