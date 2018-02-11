using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace DevMvcTaskList.Models
{
    public class TaskRepository
    {
        //DB 객체
        private IDbConnection db = new SqlConnection(
            ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        //데이터 입력
        public void AddTask(Task model)
        {
            this.db.Execute("Insert Into Tasks (Title, IsCompleted) Values (@Title, Cast('false' As Bit))", model);
        }

        //데이터 출력
        public List<Task>  GetTasks()
        {
            return this.db.Query<Task>("Select * From Tasks Order By Id Desc").ToList();
        }

        //데이터 수정
        public void CompleteTask(int id)
        {
            //this.db.Execute("Update Tasks Set IsCompleted = Cast('TRUE' as Bit) Where Id = @Id", new { id });
            this.db.Execute("Update Tasks Set IsCompleted = ~IsCompleted Where Id = @Id", new { id });
        }
    }
}