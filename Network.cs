using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Vizsgafeladat
{
	internal class Network : IDisposable
	{
		HttpClient _client;
		public void Dispose()
		{
			_client?.Dispose();
		}

		public Network()
		{
			_client = new HttpClient();
		}

		public async Task<T> GetAsync<T>(string url) where T : class
		{
			HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, $"{Program.BaseUrl}/{url}");
			HttpResponseMessage response = await _client.SendAsync(message);
			string content = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				return JsonConvert.DeserializeObject<T>(content);
			}
			else
			{
				throw new Exception($"Access code: {response.StatusCode}, Message: {content}");
			}
		}

		public async Task PostAsync<T>(string url, T data) where T : class
		{
			HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, $"{Program.BaseUrl}/{url}");
			message.Content = new StringContent(JsonConvert.SerializeObject(data));
			message.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
			HttpResponseMessage response = await _client.SendAsync(message);
			if (!response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				throw new Exception($"Access code: {response.StatusCode}, Message: {content}");
			}
		}
	}
}
