using Data.Models.WriteSql;
using DataAccessLayer.Connection;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.EntityManager.WriteSql
{
    public class ProductSqlManager
    {
        private List<ProductItemSql> productItemSql;
        private List<ProductItemSql> productItemSql2;


        public static ProductSqlManager Instance => new ProductSqlManager();
       public List<ProductItemSql> productItemSorgu(int id)
        {

            using var c = new Context();   
            StringBuilder sql = new StringBuilder();
            #region Sql Sorgusu
            sql.Append("select pri.*,p.ProductName,p.Likes,c.CategoryName,c.CategoryID ");
            sql.Append("from ProductItems pri , Products p, Categories c ");
            sql.Append("where new_price = ( ");
            sql.Append("select min(new_price) from ProductItems pri2  where pri.ProductID=pri2.ProductID and pri.status=1 ");
            sql.Append("group by pri2.ProductID )");
            sql.Append($"and  p.ProductID=pri.ProductID and c.CategoryID = p.CategoryID and c.CategoryID={id}");
            sql.Append("order by new_price  ");
            #endregion
            

           using (var connection = c.Database.GetDbConnection())
            {
                connection.Open();
               
                productItemSql = new List<ProductItemSql>();
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql.ToString(); // SQL SORGUMUZ ÇALIŞIYOR
                SqlDataReader reader = (SqlDataReader)command.ExecuteReader(); //SQL SORGUSUNU OKUYOR 
                while (reader.Read())
                {
                    var item = new ProductItemSql();
                    #region tek tek readerları class'a ata
                    item.price= (decimal)reader["price"];
                    item.ProductName = reader["ProductName"].ToString();
                    item.CategoryName = reader["CategoryName"].ToString();
                    item.new_price = (decimal)reader["new_price"];
                    item.old_price = (decimal)reader["old_price"];
                    item.status = (bool)reader["status"];
                    item.CategoryID = (int)reader["CategoryID"];
                    item.Color = reader["Color"].ToString();
                    item.Discount = (int)reader["Discount"];
                    item.DiscountStatus = (bool)reader["DiscountStatus"];
                    item.image = reader["image"].ToString();
                    item.Likes = (int)reader["Likes"];
                    item.ProductID = (int)reader["ProductID"];
                    item.ProductItemID = (int)reader["ProductItemID"];
                    item.Size = reader["Size"].ToString();
                    item.StokAdedi = (int)reader["StokAdedi"];
                    #endregion
                    productItemSql.Add(item); //Tek tek eklşyor



                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            return productItemSql;
            
              
        }



        public List<ProductItemSql> productItemSearch(int id ,int price1=0 , int price2=1000000000 ,string size="")
        {
            if(size=="")
            {

                #region sql sorgusu
                StringBuilder sql = new StringBuilder();
                sql.Append("Select pri.*,c.CategoryName,p.ProductName, c.CategoryID, p.Likes from ProductItems pri inner join  Products p ");
                sql.Append("on p.ProductID=pri.ProductID ");
                sql.Append("inner join Categories c ");
                sql.Append("on c.CategoryID=p.CategoryID ");
                sql.Append($"where pri.new_price BETWEEN {price1} AND {price2} ");
                sql.Append($"and c.CategoryID = {id} ");
                sql.Append("order by new_price");
                #endregion
                using var c = new Context();
                using (var connection = c.Database.GetDbConnection())
                {
                    connection.Open();
                    productItemSql2 = new List<ProductItemSql>();
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql.ToString();
                    SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
                    while (reader.Read())
                    {
                        var item = new ProductItemSql();
                        #region tek tek readerları class'a ata
                        item.price = (decimal)reader["price"];
                        item.ProductName = reader["ProductName"].ToString();
                        item.CategoryName = reader["CategoryName"].ToString();
                        item.new_price = (decimal)reader["new_price"];
                        item.old_price = (decimal)reader["old_price"];
                        item.status = (bool)reader["status"];
                        item.CategoryID = (int)reader["CategoryID"];
                        item.Color = reader["Color"].ToString();
                        item.Discount = (int)reader["Discount"];
                        item.DiscountStatus = (bool)reader["DiscountStatus"];
                        item.image = reader["image"].ToString();
                        item.Likes = (int)reader["Likes"];
                        item.ProductID = (int)reader["ProductID"];
                        item.ProductItemID = (int)reader["ProductItemID"];
                        item.Size = reader["Size"].ToString();
                        item.StokAdedi = (int)reader["StokAdedi"];
                        #endregion
                        productItemSql2.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
                return productItemSql2;
            }

            else
            {

                #region sql sorgusu
                StringBuilder sql = new StringBuilder();
                sql.Append("Select pri.*,c.CategoryName,p.ProductName, c.CategoryID, p.Likes from ProductItems pri inner join  Products p ");
                sql.Append("on p.ProductID=pri.ProductID ");
                sql.Append("inner join Categories c ");
                sql.Append("on c.CategoryID=p.CategoryID ");
                sql.Append($"where pri.Size='{size}' ");
                sql.Append($"and c.CategoryID = {id} ");
                sql.Append("order by new_price");
                #endregion
                using var c = new Context();
                using (var connection = c.Database.GetDbConnection())
                {
                    connection.Open();
                    productItemSql2 = new List<ProductItemSql>();
                    var command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql.ToString();
                    SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
                    while (reader.Read())
                    {
                        var item = new ProductItemSql();
                        #region tek tek readerları class'a ata
                        item.price = (decimal)reader["price"];
                        item.ProductName = reader["ProductName"].ToString();
                        item.CategoryName = reader["CategoryName"].ToString();
                        item.new_price = (decimal)reader["new_price"];
                        item.old_price = (decimal)reader["old_price"];
                        item.status = (bool)reader["status"];
                        item.CategoryID = (int)reader["CategoryID"];
                        item.Color = reader["Color"].ToString();
                        item.Discount = (int)reader["Discount"];
                        item.DiscountStatus = (bool)reader["DiscountStatus"];
                        item.image = reader["image"].ToString();
                        item.Likes = (int)reader["Likes"];
                        item.ProductID = (int)reader["ProductID"];
                        item.ProductItemID = (int)reader["ProductItemID"];
                        item.Size = reader["Size"].ToString();
                        item.StokAdedi = (int)reader["StokAdedi"];
                        #endregion
                        productItemSql2.Add(item);
                    }
                    reader.Close();
                    command.Dispose();
                    connection.Close();
                }
                return productItemSql2;
            }
        }





    }
}
