using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace NguyenDangCu.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string id)
        {
            string numPart, strPart, newkey = "", newNumPart="";
            int number;
            numPart = Regex.Match(id, @"\d+").Value;
            number = Convert.ToInt32(numPart) + 1;
            strPart = numPart = Regex.Match(id, @"\D+").Value;
            for (int i = 0; i < numPart.Length; i++)
            {

            }
            newkey = strPart + newNumPart;
            return newkey;
        }
    }
}