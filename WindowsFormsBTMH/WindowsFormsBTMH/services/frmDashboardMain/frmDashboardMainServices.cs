using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBTMH.models.APIModels;
using WindowsFormsBTMH.models.btmh_applibrary;
using WindowsFormsBTMH.models.dashboard;

namespace WindowsFormsBTMH.services.frmDashboardMain
{
    public class frmDashboardMainServices
    {
        private static readonly HttpClient _client = new HttpClient(new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (msg, cert, chain, errors) => true
        });

        public static List<DMOrder> CallApiTest(string date)
        {
            string url = ConfigurationManager.AppSettings["ApiUrl"] + "Get_Order";
            string result;
            HttpResponseMessage response;

            using (var request = new HttpRequestMessage(HttpMethod.Post, url))
            {
                string credentials = Convert.ToBase64String(
                    Encoding.UTF8.GetBytes($"{ConfigurationManager.AppSettings["ApiUsername"]}:{ConfigurationManager.AppSettings["ApiPassword"]}"));
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Basic", credentials);

                var body = new
                {
                    Date = "date"
                };

                // Bắt buộc để tránh lỗi 415
                request.Content = new StringContent(
                    JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");

                try
                {
                    response = _client.SendAsync(request).GetAwaiter().GetResult();
                    result = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }
                catch (Exception e)
                {
                    throw new Exception($"Không gọi được API: {e.GetBaseException().Message}", e);
                }
            }

            if (!response.IsSuccessStatusCode)
                throw new Exception($"API lỗi: {(int)response.StatusCode} - {result}");

            return DMOrder.FromJsonList(result);
        }

        public static List<DMOrder> getDataOrderByStrNumber()
        {
            string sql = "";
            List<DMOrder> ret = new List<DMOrder>();
            DMOrder item = null;
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public static List<DMNumber> getDataNumberPO(DateTime date)
        {
            string sql = "";
            List<DMNumber> ret = new List<DMNumber>();
            DMNumber item = null;
            try
            {
                sql = $"select t1.number " +
                    $"from productioncounting_productiontracking t0 " +
                    $"left join orders_order t1 on t0.order_id = t1.id " +
                    $"left join technologies_technologyoperationcomponent t2 on t0.technologyoperationcomponent_id = t2.id " +
                    $"left join productionlines_productionline t3 on t1.productionline_id = t3.id " +
                    $"where t0.createdate::date = '{date.ToString("yyyy-MM-dd")}'" +
                    $"group by t1.number " +
                    $"order by t1.number";
                using (var command = new NpgsqlCommand(sql, Globals.NpgsqlConnection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            item = new DMNumber()
                            {
                                number = reader.IsDBNull(0) ? "" : reader.GetString(0),
                            };
                            ret.Add(item);
                        }
                        reader.Close();
                        command.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
    }
}
