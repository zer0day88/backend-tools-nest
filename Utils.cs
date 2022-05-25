using DapperPostgreSQL;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackendTools
{
    public static class SqlAuth
    {
        public static string uid { get; set; }
        public static string pass { get; set; }
        public static string server { get; set; }
        public static string database { get; set; }
        public static string port { get; set; }

        public static string GetConnectionString()
        {
            string conf = string.Format("Server={0};Port={1};Database={2};User Id={3};Password={4};",
               SqlAuth.server, SqlAuth.port, SqlAuth.database, SqlAuth.uid,SqlAuth.pass);
            return conf;
        }

    }

    public static class Helper
    {
        private static string blackThemeConfig = Path.GetDirectoryName(Application.ExecutablePath) + @"\BlackThemeConfig.xml";
        public static Dictionary<string, string> MapDataType { get; set; }

        public static void SetThemeEditControlOffice2016DarkGray(Syncfusion.Windows.Forms.Edit.EditControl editControl)
        {
            editControl.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016DarkGray;
            //this.BackColor = ColorTranslator.FromHtml("#444444");
            editControl.Configurator.Open(blackThemeConfig);
            editControl.ApplyConfiguration("C#");
            editControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo(ColorTranslator.FromHtml("#2d2d30"));
            editControl.IndicatorMarginBackColor = (ColorTranslator.FromHtml("#363636"));
            editControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            editControl.SelectionTextColor = ColorTranslator.FromHtml("#0173c7");
            editControl.SaveOnClose = false;
            editControl.ShowHorizontalSplitters = false;
            editControl.ShowVerticalSplitters = false;
            editControl.ShowOutliningCollapsers = false;
            editControl.Text = "";
        }

        public static void InitMapDataType()
        {
            MapDataType = new();
            MapDataType.Add("int2", "string");
            MapDataType.Add("int4", "string");
            MapDataType.Add("int8", "string");
            MapDataType.Add("json", "string");
            MapDataType.Add("varchar", "string");
            MapDataType.Add("jsonb", "string");
            MapDataType.Add("bool", "boolean");
            MapDataType.Add("timestamp", "Date");
            MapDataType.Add("bpchar", "string");
            MapDataType.Add("numeric", "Decimal");
            MapDataType.Add("time", "Date");
            MapDataType.Add("array", "string[]");
            MapDataType.Add("text", "string");
            MapDataType.Add("date", "Date");


        }

        public static string GetCSharpDataType(string PostgreDataType)
        {
            return MapDataType[PostgreDataType];
        }

        public static async Task<string> GeneratePOCOFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<column_get> ColumnList = new();
                ColumnList =await Helper.GetColumnFromTableAsList(table_name);

                sb.Append("export class " + table_name +" {"+ Environment.NewLine);
                foreach (var item in ColumnList)
                {
                    sb.Append(Helper.GenerateProperty(item.column_name, item.udt_name, item.is_nullable));
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);
                }
                sb.Append("}" + Environment.NewLine);
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }

        public static async Task<string> GenerateValidatorFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<column_get_full> ColumnList = new();
                ColumnList = await Helper.GetColumnFullFromTableAsList(table_name);

                sb.Append("public class " + table_name.Humanize().Dehumanize() + ": AbstractValidator<"+ table_name +">");
                sb.Append(Environment.NewLine);
                sb.Append("{" + Environment.NewLine);
                sb.Append("\tpublic " + table_name.Humanize().Dehumanize() + "Validator()");
                sb.Append(Environment.NewLine);
                sb.Append("\t{");
                sb.Append(Environment.NewLine);
                foreach (var item in ColumnList)
                {
                    if(item.udt_name == "varchar" || item.udt_name == "bpchar")
                    {
                        sb.Append("\t\t");
                        sb.Append(string.Format("RuleFor(m => m.{0}).NotEmpty().MaximumLength({1}); //{2}({3})",
                            item.column_name,item.character_maximum_length,item.udt_name,item.character_maximum_length));
                        sb.Append(Environment.NewLine);
                    }else
                    {
                        sb.Append("\t\t");
                        sb.Append(string.Format("RuleFor(m => m.{0}).NotEmpty(); //{1}",
                            item.column_name,item.udt_name));
                        sb.Append(Environment.NewLine);
                    }
                    

                }
                sb.Append("\t}" + Environment.NewLine);
                sb.Append("}" + Environment.NewLine);
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }

        public static string GenerateValidatorFromListView(ListView listView)
        {

            StringBuilder sb = new StringBuilder();

            

            foreach (ListViewGroup group in listView.Groups)
            {
                
                sb.Append("//from table " + group.Header);
                sb.Append(Environment.NewLine);
                sb.Append("public class " + group.Header.Humanize().Dehumanize()+ "Validator" + " : AbstractValidator<" + group.Header + ">");
                sb.Append(Environment.NewLine);
                sb.Append("{" + Environment.NewLine);
                sb.Append("\tpublic " + group.Header.Humanize().Dehumanize() + "Validator()");
                sb.Append(Environment.NewLine);
                sb.Append("\t{");
                sb.Append(Environment.NewLine);

                foreach (ListViewItem item in group.Items)
                {
                   

                    if (item.SubItems[1].Text == "varchar" || item.SubItems[1].Text == "bpchar")
                    {
                        sb.Append("\t\t");
                        sb.Append(string.Format("RuleFor(m => m.{0}).NotEmpty().MaximumLength({1}); //{2}({3})",
                            item.SubItems[0].Text, item.SubItems[4].Text, item.SubItems[1].Text, item.SubItems[4].Text));
                        sb.Append(Environment.NewLine);
                    }
                    else
                    {
                        sb.Append("\t\t");
                        sb.Append(string.Format("RuleFor(m => m.{0}).NotEmpty(); //{1}",
                            item.SubItems[0].Text, item.SubItems[1].Text));
                        sb.Append(Environment.NewLine);
                    }
                }

                sb.Append("\t}" + Environment.NewLine);
                sb.Append("}" + Environment.NewLine);
            }

            return sb.ToString();
        }

        public static async Task<string> GenerateFunctionParamFromTable(string table_name)
        {
            StringBuilder final = new StringBuilder();
            StringBuilder sb_func_param = new StringBuilder();
            StringBuilder sb_dao_param = new StringBuilder();
            StringBuilder sb_column_param = new StringBuilder();
            StringBuilder sb_record_param = new StringBuilder();
            try
            {
                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                foreach (var item in ColumnList)
                {
                    sb_func_param.Append("_"+item.column_name+ " "+item.udt_name + ",");
                    sb_func_param.Append(Environment.NewLine);

                    sb_dao_param.Append("_" + item.column_name + ":param." + item.column_name + ",");
                    sb_dao_param.Append(Environment.NewLine);

                    sb_column_param.Append(":_" + item.column_name + ",");

                    sb_record_param.Append(item.column_name + " " + item.udt_name + ",");
                    sb_record_param.Append(Environment.NewLine);
                }
                sb_func_param.Append(Environment.NewLine);
                sb_dao_param.Append(Environment.NewLine);
                sb_record_param.Append(Environment.NewLine);

                string func_parameter = sb_func_param.ToString().Trim().TrimEnd(',');
                string dao_parameter = sb_dao_param.ToString().Trim().TrimEnd(',');
                string column_parameter = sb_column_param.ToString().Trim().TrimEnd(',');
                string record_parameter = sb_record_param.ToString().Trim().TrimEnd(',');

                final.Append("//function"); 
                final.Append(Environment.NewLine);
                final.Append(func_parameter);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);

                final.Append("//dao");
                final.Append(Environment.NewLine);
                final.Append(dao_parameter);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);

                final.Append("//column");
                final.Append(Environment.NewLine);
                final.Append(column_parameter);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);

                final.Append("//record");
                final.Append(Environment.NewLine);
                final.Append(record_parameter);

                return final.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static string GenerateFunctionParamFromListView(ListView listView)
        {
            try {
                StringBuilder final = new StringBuilder();
                StringBuilder sb_func_param_final = new StringBuilder();
                StringBuilder sb_dao_param_final = new StringBuilder();
                StringBuilder sb_record_param_final = new StringBuilder();

                foreach (ListViewGroup group in listView.Groups)
                {
                    StringBuilder sb_func_param = new StringBuilder();
                    StringBuilder sb_dao_param = new StringBuilder();
                    StringBuilder sb_record_param = new StringBuilder();

                    sb_func_param.Append(Environment.NewLine);
                    sb_func_param.Append(Environment.NewLine);
                    sb_func_param.Append("//from table " + group.Header);
                    sb_func_param.Append(Environment.NewLine);

                    sb_dao_param.Append(Environment.NewLine);
                    sb_dao_param.Append(Environment.NewLine);
                    sb_dao_param.Append("//from table " + group.Header);
                    sb_dao_param.Append(Environment.NewLine);

                    sb_record_param.Append(Environment.NewLine);
                    sb_record_param.Append(Environment.NewLine);
                    sb_record_param.Append("//from table " + group.Header);
                    sb_record_param.Append(Environment.NewLine);

                    foreach (ListViewItem item in group.Items)
                    {
                        sb_func_param.Append("_" + item.SubItems[0].Text + " " + item.SubItems[1].Text + ",");
                        sb_func_param.Append(Environment.NewLine);

                        sb_dao_param.Append("_" + item.SubItems[0].Text + "=param." + item.SubItems[0].Text + ",");
                        sb_dao_param.Append(Environment.NewLine);

                        sb_record_param.Append(item.SubItems[0].Text + " " + item.SubItems[1].Text + ",");
                        sb_record_param.Append(Environment.NewLine);

                    }

                    sb_func_param_final.Append(sb_func_param.ToString().Trim().TrimEnd(','));
                    sb_func_param_final.Append(Environment.NewLine);
                    sb_func_param_final.Append(Environment.NewLine);

                    sb_dao_param_final.Append(sb_dao_param.ToString().Trim().TrimEnd(','));
                    sb_dao_param_final.Append(Environment.NewLine);
                    sb_dao_param_final.Append(Environment.NewLine);

                    sb_record_param_final.Append(sb_record_param.ToString().Trim().TrimEnd(','));
                    sb_record_param_final.Append(Environment.NewLine);
                    sb_record_param_final.Append(Environment.NewLine);

                }

                final.Append("//function");
                final.Append(Environment.NewLine);
                final.Append(sb_func_param_final);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);

                final.Append("//dao");
                final.Append(Environment.NewLine);
                final.Append(sb_dao_param_final);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);
                final.Append(Environment.NewLine);

                final.Append("//record");
                final.Append(Environment.NewLine);
                final.Append(sb_record_param_final);

                return final.ToString();


            }
            catch (Exception)
            {
                throw;
            }

        }

        public static string GeneratePOCOFromListView(ListView listView)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("export class RENAMETHIS {" + Environment.NewLine);

            foreach (ListViewGroup group in listView.Groups)
            {
                sb.Append("//from table " + group.Header);
                sb.Append(Environment.NewLine);

                foreach (ListViewItem item in group.Items)
                {
                    sb.Append(Helper.GenerateProperty(item.SubItems[0].Text, item.SubItems[1].Text, bool.Parse(item.SubItems[3].Text)));
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);
                }
            }

            sb.Append("}" + Environment.NewLine);


            return sb.ToString();
        }

        public static string GenerateProperty(string propertyName,string dataType, bool isNullable)
        {

            InitMapDataType();


            if (isNullable)
            {
            
                return string.Format("{0}?: {1} /* {2} */", propertyName, GetCSharpDataType(dataType),dataType);
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("@ApiProperty()" + Environment.NewLine);
            sb.Append("@IsNotEmpty()"+ Environment.NewLine);
            sb.Append(string.Format("{0}: {1} /* {2} */", propertyName, GetCSharpDataType(dataType),dataType));

            return sb.ToString();

        }

        public static async Task<List<column_get>> GetColumnFromTableAsList(string table_name)
        {
            try
            {
                SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());
                string query = string.Format("select column_name,udt_name,is_identity,is_nullable::bool from information_schema.columns where table_name='{0}'" +
                    " order by ordinal_position;", table_name);

                return await conn.QuerySQLtoList<column_get>(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<List<column_get_full>> GetColumnFullFromTableAsList(string table_name)
        {
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/query/", "get_table_column_full.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                string query = File.ReadAllText(pathTemplate);

                SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());
                string first = query.Replace("{{table_name}}", table_name);

                return await conn.QuerySQLtoList<column_get_full>(first);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<DataTable> GetTableAsDataTable()
        {
            SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());
            string query = @"SELECT table_name FROM INFORMATION_SCHEMA.Tables " +
                "WHERE TABLE_TYPE = 'BASE TABLE' AND table_schema = 'public'";
            var data = await conn.QuerySQLtoList<table_get>(query);
            DataTable dt = new();
            return data.ToDataTable();
        }

        public static async Task<DataTable> GetFunctionList()
        {
            
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/query/", "get_functionlist.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                string query = File.ReadAllText(pathTemplate);

                SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());
                
                var data = await conn.QuerySQLtoList<function_get>(query);
                DataTable dt = new();
                return data.ToDataTable();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<DataTable> GetArgumentDataTable(string function_name,string argument_mode)
        {

            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/query/", "get_argumentlist.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                string query = File.ReadAllText(pathTemplate);
                string first = query.Replace("{{function_name}}", function_name);
                string final = first.Replace("{{argument_mode}}", argument_mode);

                SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());

                var data = await conn.QuerySQLtoList<argument_get>(final);
                DataTable dt = new();
                return data.ToDataTable();


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<List<argument_get>> GetArgumentList(string function_name, string argument_mode)
        {

            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/query/", "get_argumentlist.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                string query = File.ReadAllText(pathTemplate);
                string first = query.Replace("{{function_name}}", function_name);
                string final = first.Replace("{{argument_mode}}", argument_mode);

                SQLConn conn = new SQLConn(SqlAuth.GetConnectionString());

                var data = await conn.QuerySQLtoList<argument_get>(final);

                return data;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> GeneratePOCOFromFunction(string function_name, string argument_mode)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                List<argument_get> argumentList = new();
                argumentList = await Helper.GetArgumentList(function_name,argument_mode);

                sb.Append("export class " + function_name + " {" + Environment.NewLine);
                sb.Append(Environment.NewLine);
                foreach (var item in argumentList)
                {

                    if(argument_mode == "i")
                    {
                       
                        sb.Append(Helper.GenerateProperty(item.argument_name.TrimStart('_'), item.argument_type, false));
                    }
                    else
                    {
                        sb.Append(Helper.GenerateProperty(item.argument_name, item.argument_type, false));
                    }

                    
                    sb.Append(Environment.NewLine);
                    sb.Append(Environment.NewLine);
                }
                sb.Append("}" + Environment.NewLine);
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }

        //========= FUNCTION

        public static async Task<string> GenerateFunctionCRUDFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(await GenerateFunctionGETALLFromTable(table_name));
            sb.Append(Environment.NewLine);sb.Append(Environment.NewLine);

            sb.Append(await GenerateFunctionGETBYIDFromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);
            
            sb.Append(await GenerateFunctionDELETEFromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);
            
            sb.Append(await GenerateFunctionUPDATEFromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);

            sb.Append(await GenerateFunctionINSERTFromTable(table_name));
            return sb.ToString();
        }

        public static async Task<string> GenerateFunctionGETALLFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/function/", "function_getall.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                string template = File.ReadAllText(pathTemplate);

                string replace_table_name = template.Replace("{{table_name}}", table_name);

                foreach (var item in ColumnList)
                {
                    sb.Append("\t");
                    sb.Append(item.column_name + " " + item.udt_name +",");
                    sb.Append(Environment.NewLine);
                }

                string replace_return_column = replace_table_name.Replace("{{return_column}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new();
                string final_table_name = "";
                string[] splittedName = table_name.Split("_");

                for (int i = 0; i < splittedName.Length; i++)
                {
                    final_table_name += splittedName[i][0].ToString();
                }

                foreach (var item in ColumnList)
                {

                    sb.Append("\t");
                    sb.Append( final_table_name+"."+item.column_name + ",");
                    sb.Append(Environment.NewLine);
                }

                string replace_select_column = replace_return_column.Replace("{{select_column}}",
                    sb.ToString().Trim().TrimEnd(','));

                return replace_select_column.Replace("{{alias}}",final_table_name);

            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public static async Task<string> GenerateFunctionGETBYIDFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/function/", "function_getbyid.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_table_name = template.Replace("{{table_name}}", table_name);
                replace_table_name = replace_table_name.Replace("{{parameter}}", key_column.column_name + " "+ key_column.udt_name);

                foreach (var item in ColumnList)
                {
                    
                    sb.Append("\t");
                    sb.Append(item.column_name + " " + item.udt_name + ",");
                    sb.Append(Environment.NewLine);
                }

                string replace_return_column = replace_table_name.Replace("{{return_column}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new();
                string final_table_name = "";
                string[] splittedName = table_name.Split("_");

                for (int i = 0; i < splittedName.Length; i++)
                {
                    final_table_name += splittedName[i][0].ToString();
                }

                foreach (var item in ColumnList)
                {
                    sb.Append("\t");
                    sb.Append(final_table_name+"."+item.column_name + ",");
                    sb.Append(Environment.NewLine);
                }

                string replace_select_column = replace_return_column.Replace("{{select_column}}",
                    sb.ToString().Trim().TrimEnd(','));

                string replace_condition = replace_select_column.Replace("{{condition}}",key_column.column_name);
                string replace_condition_value = replace_condition.Replace("{{condition_value}}", key_column.column_name);

                return replace_condition_value.Replace("{{alias}}", final_table_name); ;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public static async Task<string> GenerateFunctionDELETEFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/function/", "function_delete.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_table_name = template.Replace("{{table_name}}", table_name);
                replace_table_name = replace_table_name.Replace("{{parameter}}", key_column.column_name + " " + key_column.udt_name);

                string replace_condition = replace_table_name.Replace("{{condition}}", key_column.column_name);
                string replace_condition_value = replace_condition.Replace("{{condition_value}}", key_column.column_name);

                return replace_condition_value;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public static async Task<string> GenerateFunctionUPDATEFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/function/", "function_update.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_table_name = template.Replace("{{table_name}}", table_name);

                foreach (var item in ColumnList)
                {

                    sb.Append("\t");
                    sb.Append("_"+item.column_name + " " + item.udt_name + ",");
                    sb.Append(Environment.NewLine);
                }

                string replace_paramater = replace_table_name.Replace("{{parameter}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new();
                foreach (var item in ColumnList)
                {
                    if(item.is_identity == "NO")
                    {
                        sb.Append("\t");
                        sb.Append(item.column_name + " = _" + item.column_name + ",");
                        sb.Append(Environment.NewLine);
                    }
                    
                }

                string replace_column_update = replace_paramater.Replace("{{column_update}}",
                    sb.ToString().Trim().TrimEnd(','));

                string replace_condition = replace_column_update.Replace("{{condition}}", key_column.column_name);
                string replace_condition_value = replace_condition.Replace("{{condition_value}}", key_column.column_name);

                return replace_condition_value;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public static async Task<string> GenerateFunctionINSERTFromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/function/", "function_insert.sql");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_table_name = template.Replace("{{table_name}}", table_name);

                foreach (var item in ColumnList)
                {
                    if(item.is_identity=="NO")
                    {
                        sb.Append("\t");
                        sb.Append("_"+item.column_name + " " + item.udt_name + ",");
                        sb.Append(Environment.NewLine);
                    }
                }

                string replace_paramater = replace_table_name.Replace("{{parameter}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new();
                foreach (var item in ColumnList)
                {
                    if (item.is_identity == "NO")
                    {
                        sb.Append("\t");
                        sb.Append(item.column_name + ",");
                        sb.Append(Environment.NewLine);
                    }

                }

                string replace_insert_column = replace_paramater.Replace("{{insert_column}}",
                    sb.ToString().Trim().TrimEnd(','));


                sb = new();
                foreach (var item in ColumnList)
                {
                    if (item.is_identity == "NO")
                    {
                        sb.Append("\t");
                        sb.Append("_"+item.column_name + ",");
                        sb.Append(Environment.NewLine);
                    }

                }

                string replace_value_column = replace_insert_column.Replace("{{value_column}}",
                    sb.ToString().Trim().TrimEnd(','));

                string final = replace_value_column.Replace("{{key_column}}", key_column.column_name);

                

                return final;

            }
            catch (Exception)
            {

                throw;
            }


        }

        //========= FUNCTION

        //========= DAO

        public static async Task<string> GenerateDAO_CRUD_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(await GenerateDAO_GETALL_FromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);

            sb.Append(await GenerateDAO_GETBYID_FromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);

            sb.Append(await GenerateDAO_INSERT_FromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);
            
            sb.Append(await GenerateDAO_UPDATE_FromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);

            sb.Append(await GenerateDAO_DELETE_FromTable(table_name));
            sb.Append(Environment.NewLine); sb.Append(Environment.NewLine);


            return sb.ToString();
        }

        public static async Task<string> GenerateDAO_GETALL_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/DAO/", "dao_get.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);
                string replace_function_name = replace_model_name.Replace("{{function_name}}", table_name+"_getall");

                return replace_function_name;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> GenerateDAO_GETBYID_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/DAO/", "dao_getbyid.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);
                string replace_function_name = replace_model_name.Replace("{{function_name}}", table_name + "_getbyid");
                string replace_function_parameter = replace_function_name.Replace("{{function_parameter}}",
                   key_column.column_name +": "+ GetCSharpDataType(key_column.udt_name));
                string replace_db_parameter = replace_function_parameter.Replace("{{db_parameter}}",
                    "_" + key_column.column_name);
                string replace_function_parameter_name = replace_db_parameter.Replace("{{function_parameter_name}}",
                    key_column.column_name);

                return replace_function_parameter_name;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> GenerateDAO_INSERT_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/DAO/", "dao_insert.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);

                string replace_function_name = replace_model_name.Replace("{{function_name}}",
                    table_name + "_insert");


                foreach (var item in ColumnList)
                {
                    if (item.is_identity == "NO")
                    {
                       
                        sb.Append(":_" + item.column_name + ",");
                    }

                }

                string replace_column_name = replace_function_name.Replace("{{column_name}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new StringBuilder();
                foreach (var item in ColumnList)
                {
                    if(item.is_identity=="NO")
                    {
                        sb.Append("\t\t\t\t\t\t\t\t\t\t");
                        sb.Append("_" + item.column_name + ": param." + item.column_name + ",");
                        sb.Append(Environment.NewLine);
                    }
                    
                }

                string replace_column_insert = replace_column_name.Replace("{{column_insert}}",
                    sb.ToString().Trim().TrimEnd(','));

                return replace_column_insert;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> GenerateDAO_UPDATE_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/DAO/", "dao_update.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);

                string replace_function_name = replace_model_name.Replace("{{function_name}}",
                    table_name + "_update");

                foreach (var item in ColumnList)
                {
                    if (item.is_identity == "NO")
                    {

                        sb.Append(":_" + item.column_name + ",");
                    }

                }

                string replace_column_name = replace_function_name.Replace("{{column_name}}",
                    sb.ToString().Trim().TrimEnd(','));

                sb = new StringBuilder();

                foreach (var item in ColumnList)
                {
                    
                    sb.Append("\t\t\t\t\t\t\t\t\t\t");
                    sb.Append("_" + item.column_name + ": param." + item.column_name + ",");
                    sb.Append(Environment.NewLine);
                }

                string replace_column_update = replace_column_name.Replace("{{column_update}}",
                    sb.ToString().Trim().TrimEnd(','));

                return replace_column_update;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static async Task<string> GenerateDAO_DELETE_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/DAO/", "dao_delete.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);
                string replace_function_name = replace_model_name.Replace("{{function_name}}", table_name + "_delete");
                string replace_function_parameter = replace_function_name.Replace("{{function_parameter}}",
                    key_column.column_name + ": " + GetCSharpDataType(key_column.udt_name));
                string replace_db_parameter = replace_function_parameter.Replace("{{db_parameter}}",
                    "_" + key_column.column_name);
                string replace_function_parameter_name = replace_db_parameter.Replace("{{function_parameter_name}}",
                    key_column.column_name);

                return replace_function_parameter_name;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //========== DAO

        //========== SERVICE

        public static async Task<string> GenerateSERVICE_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/service/", "service.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);
                
                string replace_function_parameter = replace_model_name.Replace("{{function_parameter}}",
                   key_column.column_name + ": " + GetCSharpDataType(key_column.udt_name));
                
                string replace_function_parameter_name = replace_function_parameter.Replace("{{function_parameter_name}}",
                    key_column.column_name);

                return replace_function_parameter_name;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //========== SERVICE

        //========== CONTROLLER

        public static async Task<string> GenerateCONTROLLER_FromTable(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            var key_column = new column_get();
            try
            {
                string pathTemplate = Path.Combine(Application.StartupPath + "/template/controller/", "controller.ts");
                if (!File.Exists(pathTemplate))
                {
                    throw new ArgumentException("template file tidak ditemukan!");
                }

                List<column_get> ColumnList = new();
                ColumnList = await Helper.GetColumnFromTableAsList(table_name);

                key_column = ColumnList.Where(x => x.is_identity == "YES")
                    .SingleOrDefault();

                string template = File.ReadAllText(pathTemplate);

                string replace_model_name = template.Replace("{{model_name}}", table_name);

                string replace_function_parameter = replace_model_name.Replace("{{function_parameter}}",
                    key_column.column_name + ": " + GetCSharpDataType(key_column.udt_name));

                string replace_function_parameter_name = replace_function_parameter.Replace("{{function_parameter_name}}",
                    key_column.column_name);

                return replace_function_parameter_name;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        //========== CONTROLLER


    }
}
