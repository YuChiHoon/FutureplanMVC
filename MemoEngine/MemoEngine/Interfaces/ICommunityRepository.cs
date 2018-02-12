using MemoEngine.Models;
using System.Collections.Generic;

namespace MemoEngine.Interfaces
{
    public interface ICommunityRepository
    {
        //입력 (Add)
        CommunityModel Add(CommunityModel community);
        //출력 (GetXXXs)
        List<CommunityModel> GetCommunities();
        //상세 (GetXXX)
        CommunityModel GetCommunity(int communityId);
        //수정 (Update)
        CommunityModel Update(CommunityModel community);
        //삭제 (Remove)
        void Remove(int communityId);
    }
}
