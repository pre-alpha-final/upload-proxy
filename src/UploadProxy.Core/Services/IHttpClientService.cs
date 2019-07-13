﻿using System.Net.Http;
using System.Threading.Tasks;

namespace UploadProxy.Core.Services
{
	public interface IHttpClientService
	{
		Task<HttpResponseMessage> Get(string url);
		Task<HttpResponseMessage> Post(string url, HttpContent httpContent);
	}
}
