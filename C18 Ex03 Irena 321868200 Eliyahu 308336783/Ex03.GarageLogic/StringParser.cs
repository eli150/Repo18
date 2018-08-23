using System;
using System.Text;

namespace Ex03.GarageLogic
{
    public class StringParser
    {
        public static object StringToEnum(string i_StrValue, Type i_EnumType)
        {
            object tempParse = Enum.Parse(i_EnumType, i_StrValue);
            if (tempParse == null)
            {
                throw new FormatException(string.Format("Invalid input for enum: {0}", i_EnumType.Name));
            }

            return tempParse;
        }

        public static float StringToFloat(string i_StrValue)
        {
            float floatVal;
            if (!float.TryParse(i_StrValue, out floatVal))
            {
                throw new FormatException("Input value  cannot be parsed as float");
            }

            return floatVal;
        }

        public static int StringToInt(string i_StrValue)
        {
            int intVal;
            if (!int.TryParse(i_StrValue, out intVal))
            {
                throw new FormatException("Input value  cannot be parsed as int");
            }

            return intVal;
        }

        public static bool StringToBool(string i_StrValue)
        {
            if (i_StrValue != "Y" && i_StrValue != "N")
            {
                throw new FormatException("Invalid input. Allowed input is Y or N");
            }

            return i_StrValue == "Y";
        }

        public static string EnumToOptions(Type i_EnumType)
        {
            int idx = 1;
            StringBuilder sb = new StringBuilder();
            string[] enumValues = Enum.GetNames(i_EnumType);

            foreach (string enumValue in enumValues)
            {
                sb.AppendLine(string.Format(" {0} ---> {1}", idx++, enumValue));
            }

            return sb.ToString();
        }
    }
}

