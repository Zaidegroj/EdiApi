﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ComModels;

namespace CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<RetReporte> TranslateForms830()
        {
            return await GetAsync<RetReporte>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Edi/TranslateForms830")));
        }
        public async Task<IEnumerable<Rep830Info>> GetPureEdi(string HashId = "")
        {
            return await GetAsync<IEnumerable<Rep830Info>>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/GetPureEdi"), $"HashId={HashId}"));
        }        
        public async Task<IEnumerable<TsqlDespachosWmsComplex>> GetSN()
        {
            return await GetAsync<IEnumerable<TsqlDespachosWmsComplex>>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/GetSN")));
        }
        public async Task<IEnumerable<TsqlDespachosWmsComplex>> GetSN(IEnumerable<string> _ListDispatch, IEnumerable<string> _ListProducts)
        {
            return await GetAsync<IEnumerable<TsqlDespachosWmsComplex>>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/GetSNDetails"), "?ListDispatch=" + string.Join('|', _ListDispatch) + "&ListProducts=" + string.Join('|', _ListProducts)));
        }
        public async Task<FE830Data> GetFE830Data(string HashId)
        {
            return await GetAsync<FE830Data>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/GetFE830Data"), $"HashId={HashId}"));
        }
        public async Task<string> SendForm856(IEnumerable<string> _ListDispatch)
        {
            return await GetAsyncNoJson<string>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/SendForm856"), $"?listDispatch={string.Join('|', _ListDispatch)}"));
        }
        public async Task<string> UpdateLinComments(string _LinHashId, string _TxtLinComData)
        {
            return await GetAsyncNoJson<string>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/UpdateLinComments"), $"?LinHashId={_LinHashId}&TxtLinComData={_TxtLinComData}"));
        }
        public async Task<string> Login(string _User, string _Password)
        {
            return await GetAsyncNoJson<string>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/Login"), $"?User={_User}&Password={_Password}"));
        }
        public async Task<RetInfo> AutoSendInventary830(string _Force)
        {
            return await GetAsync<RetInfo>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Edi/AutoSendInventary830"), $"?Force={_Force}"));
        }
        public async Task<string> LastRep()
        {
            return await GetAsyncNoJson<string>(CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Data/LastRep")));
        }
        //public async Task<List<UsersModel>> GetUsers()
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/GetAllUsers"));
        //    return await GetAsync<List<UsersModel>>(requestUrl);
        //}

        //public async Task<Message<UsersModel>> SaveUser(UsersModel model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/SaveUser"));
        //    return await PostAsync<UsersModel>(requestUrl, model);
        //}
    }
}
