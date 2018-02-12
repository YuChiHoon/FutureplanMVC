using MemoEngine.Models;
using MemoEngine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Controls.Community
{
    public partial class CommunityWriteUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //커뮤니티 개체 가져오기
            var community = new CommunityModel();

            // Prouctivity Power Tools 2017 설치 후 Ctrl + Alt + ]
            community.CommunityName        = txtCommunityName.Value;
            community.CommunityDescription = txtCommunityDescription.Value;
            community.MeaderHtnl           = txtMeaderHtnl.Value;
            community.FooterHtnl           = txtFooterHtnl.Value;

            //저장소 클래스 가져오기
            var addRepo = new CommnityRepository();

            community = addRepo.Add(community);

            lblDisplay.Text = String.Format("{0}번 글이 저장되었습니다.", community.CommunityId);
        }
    }
}