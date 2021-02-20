using AmazonAutomation.Specs.Constant.ResultPage;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonAutomation.Specs.Page.ResultPage
{
    public class ResultPagePage
    {
        public static string GetURL()
        {
            return ResultPageConstants.Url;
        }
        public static int GetResultItemCount()
        {
            return ResultPageConstants.ResultItems.Count;
        }
    }
}
