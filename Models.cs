using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendTools
{
    public record table_get
    {
        public string table_name { get; set; }
    }

    public record column_get
    {
        public string column_name { get; set; }
        public string udt_name { get; set; }
        public string is_identity { get; set; }
        public bool is_nullable { get; set; }
    }

    public record column_get_full
    {
        public string column_name { get; set; }
        public string udt_name { get; set; }
        public string is_identity { get; set; }
        public string is_nullable { get; set; }
        public string character_maximum_length { get; set; }

    }

    public record function_get
    {
        public string function_name { get; set; }
        public string function_language { get; set; }
        public string return_type { get; set; }
    }

    public record argument_get
    {
        public string argument_name { get; set; }
        public string argument_type { get; set; }
    }
}
