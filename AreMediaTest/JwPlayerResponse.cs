using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreMediaTest
{
    public class ProtectionRule
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Relationships
    {
        public ProtectionRule protection_rule { get; set; }
    }

    public class CustomParams
    {
        public string additionalProp { get; set; }
    }

    public class Metadata
    {
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public string permalink { get; set; }
        public string category { get; set; }
        public DateTime publish_start_date { get; set; }
        public DateTime publish_end_date { get; set; }
        public List<string> tags { get; set; }
        public CustomParams custom_params { get; set; }
    }

    public class JwPlayerResponse
    {
        public string id { get; set; }
        public string created { get; set; }
        public string last_modified { get; set; }
        public string type { get; set; }
        public Relationships relationships { get; set; }
        public Metadata metadata { get; set; }
        public string status { get; set; }
        public string media_type { get; set; }
        public string hosting_type { get; set; }
        public string mime_type { get; set; }
        public string error_message { get; set; }
        public int duration { get; set; }
        public string trim_in_point { get; set; }
        public string trim_out_point { get; set; }
    }


}
