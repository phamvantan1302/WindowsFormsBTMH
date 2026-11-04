using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBTMH.models.dashboard
{
    public class DMOrder
    {
        public string po { get; set; }
        public double slsx { get; set; }
        public double slht { get; set; }
        public string maline { get; set; }
        public string sttcdoan { get; set; }
        public string namecdoan { get; set; }
        public double slkh_cdoan { get; set; }
        public double slht_cdoan { get; set; }
        public DateTime time { get; set; }

        public DMOrder() { }

        public DMOrder(string po, double slsx, double slht, string maline,
                       string sttcdoan, string namecdoan,
                       double slkh_cdoan, double slht_cdoan, DateTime time)
        {
            this.po = po;
            this.slsx = slsx;
            this.slht = slht;
            this.maline = maline;
            this.sttcdoan = sttcdoan;
            this.namecdoan = namecdoan;
            this.slkh_cdoan = slkh_cdoan;
            this.slht_cdoan = slht_cdoan;
            this.time = time;
        }

        // Tương đương: factory DMOrder.fromJson(Map<String, dynamic> json)
        public static DMOrder FromJson(JObject json)
        {
            return new DMOrder(
                po: json["po"]?.Value<string>() ?? "",
                slsx: json["slsx"]?.Value<double?>() ?? 0,
                slht: json["slht"]?.Value<double?>() ?? 0,
                maline: json["maline"]?.Value<string>() ?? "",
                sttcdoan: json["sttcdoan"]?.Value<string>() ?? "",
                namecdoan: json["namecdoan"]?.Value<string>() ?? "",
                slkh_cdoan: json["slkh_cdoan"]?.Value<double?>() ?? 0,
                slht_cdoan: json["slht_cdoan"]?.Value<double?>() ?? 0,
                time: json["time"]?.Value<DateTime?>() ?? DateTime.MinValue
            );
        }

        // Tương đương: static List<DMOrder> fromJsonList(List list)
        public static List<DMOrder> FromJsonList(JArray list)
        {
            return list.OfType<JObject>().Select(e => FromJson(e)).ToList();
        }

        // Tiện thêm: nhận thẳng chuỗi result từ API
        public static List<DMOrder> FromJsonList(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return new List<DMOrder>();
            return FromJsonList(JArray.Parse(json));
        }

        // Tương đương: Map<String, dynamic> toJson()
        public JObject ToJson()
        {
            return new JObject
            {
                ["po"] = po,
                ["slsx"] = slsx,
                ["slht"] = slht,
                ["maline"] = maline,
                ["sttcdoan"] = sttcdoan,
                ["namecdoan"] = namecdoan,
                ["slkh_cdoan"] = slkh_cdoan,
                ["slht_cdoan"] = slht_cdoan,
                ["time"] = time
            };
        }
    }

    public class DMNumber
    {
        public string number { get; set; }
    }
}
