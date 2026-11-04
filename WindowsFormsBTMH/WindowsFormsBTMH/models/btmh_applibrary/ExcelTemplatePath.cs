using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBTMH.models.btmh_applibrary
{
    public class ExcelTemplatePath : ConfigurationElement
    {
        [ConfigurationProperty("excelPath", DefaultValue = "Templates", IsRequired = true)]
        public string excelPath
        {
            get
            {
                return (string)this["excelPath"];
            }
            set
            {
                value = (string)this["excelPath"];
            }
        }
    }
}
