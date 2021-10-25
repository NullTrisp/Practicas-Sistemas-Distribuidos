using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class ReqHandler
    {
        public static string handleRequest(string req)
        {
            try
            {
                string res = String.Empty;
                string[] reqData = req.Split(',');

                switch (reqData[0])
                {
                    case "sum":
                        res = Calculator.Sum(reqData[1], reqData[2]);
                        break;
                    case "subs":
                        res = Calculator.Subs(reqData[1], reqData[2]);
                        break;
                    case "div":
                        res = Calculator.Div(reqData[1], reqData[2]);
                        break;
                    case "mult":
                        res = Calculator.Mult(reqData[1], reqData[2]);
                        break;
                    case "sqrRoot":
                        res = Calculator.sqrRoot(reqData[1]);
                        break;
                }
                return res;
            }
            catch (IndexOutOfRangeException)
            {
                return "There has been an error while getting your operation :(";
            }
        }
    }
}
