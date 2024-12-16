using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1.HomeworkClasses
{
    public class Converter
    {
        public string DecimalToBinary(int decimalNumber)
        {
            // TODO: convert decimal number to binary code using recursion
            if (decimalNumber == 0)
            {
                return "0";
            }

            if (decimalNumber < 0)
            {
                return "-" + DecimalToBinary(-decimalNumber);
            }

            // ÇÓÊÏÚÇÁ ÇáÏÇáÉ ÈÔßá ãÊßÑÑ áÍÓÇÈ ÇáÈÇÞí æÇáÊÍæíá ÈÏæä ÇáÃÕÝÇÑ ÇáÒÇÆÏÉ Ýí ÇáÈÏÇíÉ
            string result = DecimalToBinary(decimalNumber / 2);

            // ÊÌäÈ ÅÖÇÝÉ ÕÝÑ ÛíÑ ãØáæÈ Ýí ÈÏÇíÉ ÇáÓáÓáÉ ÇáäÇÊÌÉ
            if (result == "0")
            {
                result = string.Empty;
            }

            return result + (decimalNumber % 2).ToString();

        }
    }
}
