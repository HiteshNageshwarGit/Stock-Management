using StockEntity.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockEntity.Helper
{
    public class PriceCode
    {
        public static List<KeyValue> PriceCodeList;
        public static bool CodeLoadedFromDB;

        public const string KEY_1 = "1";
        public const string KEY_2 = "2";
        public const string KEY_3 = "3";
        public const string KEY_4 = "4";
        public const string KEY_5 = "5";
        public const string KEY_6 = "6";
        public const string KEY_7 = "7";
        public const string KEY_8 = "8";
        public const string KEY_9 = "9";
        public const string KEY_0 = "0";
        public const string KEY_DOT = ".";

        public static void InitialisePriceCode()
        {
            PriceCodeList = new List<KeyValue>();
            PriceCodeList.Add(new KeyValue { Key = KEY_1, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_2, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_3, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_4, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_5, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_6, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_7, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_8, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_9, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_0, Value = "" });
            PriceCodeList.Add(new KeyValue { Key = KEY_DOT, Value = "" });

            SetValueFromDB();
        }
        public static void SetValueFromDB()
        {
            DBRepository dB = new DBRepository();
            foreach (KeyValue keyValue in PriceCodeList)
            {
                KeyValue dbValue = dB.GetKeyValue(keyValue.Key);
                if (dbValue != null && (dbValue.Value != null || dbValue.Value.Length == 1))
                {
                    keyValue.Value = dbValue.Value;
                }
                else
                {
                    keyValue.Value = "^";
                }
            }

            PriceCodeList.Add(new KeyValue { Key = "FAKE", Value = "#" });
            CodeLoadedFromDB = true;
        }

        public static string GetPriceCodeForNumber(decimal number)
        {
            if (!CodeLoadedFromDB)
            {
                InitialisePriceCode();
            }

            if (PriceCodeList == null)
            {
                return "XXXXX";
            }

            string priceAsString = number.ToString();
            StringBuilder priceAsCode = new StringBuilder();
            foreach (char c in priceAsString)
            {
                KeyValue keyValue = PriceCodeList.Where(x => x.Key.Trim().ToLower() == c.ToString().ToLower()).FirstOrDefault();
                if (keyValue != null)
                {
                    priceAsCode.Append(keyValue.Value);
                }
            }
            return priceAsCode.ToString();
        }
        public static string GetPriceCodeForNumber(string number)
        {
            return GetPriceCodeForNumber(decimal.Parse(number));
        }
    }
}
