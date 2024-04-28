using DapperTutorial.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class ReviewRepository: IRepository<Review>
    {
        private DbConnection _dbConnection = new DbConnection();

        public int Insert(Review obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();
            return conn.Execute("Insert into Review  VALUES(@Id, @Text, @CustomerId, @ProductId)", obj);
        }

        public int DeleteById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();
            return conn.Execute("DELETE FROM Review WHERE Id=@id", new { id = id });
        }

        public int Update(Review obj)
        {
            IDbConnection conn = _dbConnection.GetConnection();
            return conn.Execute("UPDATE Review Set Text=@Text WHERE Id=@id",
            obj);
        }

        public IEnumerable<Review> GetAll()
        {
            IDbConnection conn = _dbConnection.GetConnection();
            var sql = "SELECT r.Id, r.Text, r.CustomerId, r.ProductId" +
                      " FROM Review r" +
                      "INNER JOIN Customer c ON c.Id= r.CustomerId" +
                      "INNER JOIN Product p ON p.Id= p.ProductId";
            return conn.Query<Review,Customer,Product,Review>(sql,(review,customer,product) => {
                review.Customer = customer;
                review.Product = product;
                return review;
            });

            //return conn.Query<Employee>("Select id, employeeName, age, departmentID from Employee");
        }

        public Review GetById(int id)
        {
            IDbConnection conn = _dbConnection.GetConnection();
            var sql = "SELECT r.Id, r.Text, r.CustomerId, r.ProductId" +
                      " FROM Review r" +
                      "INNER JOIN Customer c ON c.Id= r.CustomerId" +
                      "INNER JOIN Product p ON p.Id= p.ProductId"+
                      "WHERE Id = @id";
            var q = conn.Query<Review, Customer, Product, Review>(sql, (review, customer, product) => {
                review.Customer = customer;
                review.Product = product;
                return review;
            }, new { Id = id});
            return q.First();
        }
    }
}
