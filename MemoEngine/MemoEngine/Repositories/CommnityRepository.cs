using MemoEngine.Interfaces;
using MemoEngine.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper; //Micro ORM인 Dapper dot net을 사용
using System.Linq; // Dapper는 LINQ 사용하는 확장 메서드를 사용함

namespace MemoEngine.Repositories
{
    public class CommnityRepository : ICommunityRepository
    {
        //DB 개체: Context 개체
        private IDbConnection ctx = new SqlConnection(
            ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        //입력
        public CommunityModel Add(CommunityModel community)
        {
            var sql = @"
                Insert Into Communities(CommunityName, CommunityDescription, MeaderHtnl, FooterHtnl) Values(@CommunityName, @CommunityDescription, @MeaderHtnl, @FooterHtnl);
                Select Cast(SCOPE_IDENTITY() As Int);
            ";

            var id = ctx.Query<int>(sql, community).Single();

            community.CommunityId = id;

            return community;
        }


        //출력
        public List<CommunityModel> GetCommunities()
        {
            //이름 순 = "Select * From Communities Order By CommunityName Asc"
            return ctx.Query<CommunityModel>("Select * From Communities Order By CreationDate Desc").ToList();
        }

        //상세
        public CommunityModel GetCommunity(int communityId)
        {
            return ctx.Query<CommunityModel>("Select * From Communities Where CommunityId = @CommunityId",new { communityId }).SingleOrDefault();
        }

        //수정
        public CommunityModel Update(CommunityModel community)
        {
            var sql = @"
                Update Communities
                Set
                   CommunityName = @CommunityName,
                   CommunityDescription = @CommunityDescription,
                   MeaderHtnl = @MeaderHtnl,
                   FooterHtnl = @FooterHtnl
               Where
                   CommunityId = @CommunityId;
               ";

            this.ctx.Execute(sql, community);

            return community;
        }

        //삭제
        public void Remove(int communityId)
        {
            this.ctx.Execute("Delete Communities Where CommunityId = @CommunityId",new { communityId });
        }        
    }
}