using MemoEngine.Interfaces;
using MemoEngine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Controls.Community
{
    public partial class CommunityListUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //처음 로드시
            if(!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            ICommunityRepository repo = new CommnityRepository();

            this.grdCommunityList.DataSource = repo.GetCommunities();
            this.grdCommunityList.DataBind();
        }

        //#region 넘겨온 날짜 형식이 오늘 날짜면 시간 표시
        //// 넘겨온 날짜 형식이 오늘 날짜면 시간 표시,
        //// 그렇지 않으면 날짜표시
        //
        //protected string FuncShowTime(object objPostDate)
        //{
        //    if( objPostDate != null)
        //    {
        //        if(!String.IsNullOrEmpty(objPostDate.ToString()))
        //        {
        //            string strPostDate =
        //                Convert.ToDateTime(objPostDate).ToShortDateString();
        //            if(strPostDate == DateTime.Now.ToShortDateString())
        //            {
        //                return Convert.ToDateTime(objPostDate).ToShortDateString();
        //            }
        //            else
        //            {
        //                return strPostDate;
        //            }
        //        }
        //    }
        //    return "-";
        //}
        //#endregion
    }
}