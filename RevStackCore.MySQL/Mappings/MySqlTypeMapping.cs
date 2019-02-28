using System;
using System.Data;
using RevStackCore.Extensions.SQL;

namespace RevStackCore.MySQL
{
    public static class MySqlTypeMapping
    {
        public static MetadataSqlSchema Map(MetadataSqlSchema schema)
        {
            foreach (var column in schema.Columns)
            {
                column.DbTypeName = column.ToDbTypeName();
            }

            return schema;
        }

        private static string ToDbTypeName(this SqlDataColumn column)
        {
            if (column.DbType != default(SqlDbType))
            {
                return column.ToDbTypeNameFromSqlType();
            }
            else
            {
                return column.Type.ToDbTypeNameFromType();
            }
        }

        private static string ToDbTypeNameFromSqlType(this SqlDataColumn column)
        {
            var type = column.DbType;
            var size = column.Size;
            var precision = column.Precision;
            if (type == SqlDbType.BigInt)
            {
                return "bigint";
            }
            else if (type == SqlDbType.Bit)
            {
                return "tinyint(1)";
            }
            else if (type == SqlDbType.Binary)
            {
                return "binary";
            }
            else if (type == SqlDbType.Char)
            {
                if (size != null)
                {
                    return $"char({size})";
                }
                return "char";
            }
            else if (type == SqlDbType.Date)
            {
                return "date";
            }
            else if (type == SqlDbType.DateTime)
            {
                return "datetime";
            }
            else if (type == SqlDbType.DateTime2)
            {
                return "datetime";
            }
            else if (type == SqlDbType.DateTimeOffset)
            {
                return "datetime";
            }
            else if (type == SqlDbType.Decimal)
            {
                if (size != null && precision != null)
                {
                    return $"decimal({size},{precision})";
                }
                else if (size != null)
                {
                    return $"decimal({size})";
                }
                else
                {
                    return "decimal";
                }
            }
            else if (type == SqlDbType.Float)
            {
                if (size != null && precision != null)
                {
                    return $"float({size},{precision})";
                }
                else if (size != null)
                {
                    return $"float({size})";
                }
                else
                {
                    return "float";
                }
            }
            else if (type == SqlDbType.Image)
            {
                return "binary";
            }
            else if (type == SqlDbType.Int)
            {
                return "int";
            }
            else if (type == SqlDbType.BigInt)
            {
                if (size != null)
                {
                    return $"bigint({size})";
                }
                else
                {
                    return "bigint";
                }
            }
            else if (type == SqlDbType.Money)
            {
                return "decimal(12,2)";
            }
            else if (type == SqlDbType.NChar)
            {
                if (size != null)
                {
                    return $"char({size})";
                }
                else
                {
                    return "char";
                }
            }
            else if (type == SqlDbType.NVarChar)
            {
                if (size != null)
                {
                    return $"varchar({size})";
                }
                else
                {
                    return "varchar(100)";
                }
            }
            else if (type == SqlDbType.Real)
            {
                if (size != null && precision != null)
                {
                    return $"real({size},{precision})";
                }
                else if (size != null)
                {
                    return $"real({size})";
                }
                else
                {
                    return "real";
                }
            }
            else if (type == SqlDbType.SmallInt)
            {
                return "smallint";
            }
            else if (type == SqlDbType.SmallMoney)
            {
                return "decimal(5,2)";
            }
            else if (type == SqlDbType.SmallDateTime)
            {
                return "datetime";
            }
            else if (type == SqlDbType.Text)
            {
                return "longtext";
            }
            else if (type == SqlDbType.Time)
            {
                return "time";
            }
            else if (type == SqlDbType.TinyInt)
            {
                return "tinyint";
            }
            else if (type == SqlDbType.UniqueIdentifier)
            {
                return "timestamp";
            }
            else if (type == SqlDbType.UniqueIdentifier)
            {
                return "varchar(64)";
            }
            else if (type == SqlDbType.VarBinary)
            {
                return "varbinary";
            }
            else if (type == SqlDbType.VarChar)
            {
                if (size != null)
                {
                    return $"varchar({size})";
                }
                else
                {
                    return "varchar(100)";
                }
            }

            return type.ToString();
        }

        private static string ToDbTypeNameFromType(this Type type)
        {
            if (type == typeof(string))
            {
                return "varchar(100)";
            }
            else if (type == typeof(int))
            {
                return "int";
            }
            else if (type == typeof(short))
            {
                return "int";
            }
            else if (type == typeof(long))
            {
                return "bigint";
            }
            else if (type == typeof(decimal))
            {
                return "decimal";
            }
            else if (type == typeof(float))
            {
                return "float";
            }
            else if (type == typeof(double))
            {
                return "float";
            }
            else if (type == typeof(DateTime))
            {
                return "datetime";
            }
            else if (type == typeof(bool))
            {
                return "tinyint(1)";
            }
            else if (type == typeof(DateTimeOffset))
            {
                return "datetime";
            }
            else if (type == typeof(Byte[]))
            {
                return "binary";
            }
            else if (type == typeof(TimeSpan))
            {
                return "time";
            }
            else if (type == typeof(char[]))
            {
                return "char";
            }
            else if (type == typeof(Guid))
            {
                return "varchar(64)";
            }

            return "varchar(100)";

        }
    }
}
