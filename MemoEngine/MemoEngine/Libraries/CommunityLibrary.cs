using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemoEngine.Libraries
{
    // Community 관련 Core/Common/Library/Utility 코드가 들어오는 곳
    public class CommunityLibrary
    {
        #region 넘겨온 날짜 형식이 오늘 날짜면 시간 표시
        // 넘겨온 날짜 형식이 오늘 날짜면 시간 표시,
        // 그렇지 않으면 날짜표시

        public static string FuncShowTime(object objPostDate)
        {
            if (objPostDate != null)
            {
                if (!String.IsNullOrEmpty(objPostDate.ToString()))
                {
                    string strPostDate =
                        Convert.ToDateTime(objPostDate).ToShortDateString();
                    if (strPostDate == DateTime.Now.ToShortDateString())
                    {
                        return Convert.ToDateTime(objPostDate).ToShortDateString();
                    }
                    else
                    {
                        return strPostDate;
                    }
                }
            }
            return "-";
        }
        #endregion
    }
}