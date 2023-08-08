using Microsoft.Data.SqlClient;
using SaleManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.DAO
{
    public class ProductDAO : BaseDAL
    {

        //Using Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }


        public List<CategoryProduct> getAllCategoryProduct()
        {
            var list = new List<CategoryProduct>();
            string sql = "select * from [CategoryProduct]";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = new CategoryProduct(int.Parse(dr["cp_id"].ToString()), dr["cp_name"].ToString());
                    list.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return list;
        }

        public Product getProductByName(string product_name)
        {

            string sql = "select * from [Product] where product_name = N'" + product_name + "'";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = getCategoryByID(int.Parse(dr["cp_id"].ToString()));
                    Product p = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString(),
                        int.Parse(dr["quantity"].ToString()), int.Parse(dr["price"].ToString()),
                        DateTime.Parse(dr["updated_date"].ToString()), c);
                    return p;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return null;
        }


        public Product getProductByID(int id)
        {

            string sql = "select * from [Product] where product_id = '" + id + "'";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = getCategoryByID(int.Parse(dr["cp_id"].ToString()));
                    Product p = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString(),
                        int.Parse(dr["quantity"].ToString()), int.Parse(dr["price"].ToString()),
                        DateTime.Parse(dr["updated_date"].ToString()), c);
                    return p;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return null;
        }
        public Product getProductByIDInorderDetail(int id)
        {

            //string sql = "select * from [Product] where product_id = '" + id + "'";
            string sql = "select* from Order_Detail,Product where Order_Detail.product_id=Product.product_id and Product.product_id='" + id + "'";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = getCategoryByID(int.Parse(dr["cp_id"].ToString()));
                    Product p = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString(),
                        int.Parse(dr["quantity"].ToString()), int.Parse(dr["price"].ToString()),
                        DateTime.Parse(dr["updated_date"].ToString()), c);
                    return p;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return null;
        }

        public IEnumerable<Product> getAllProduct(bool instock = true)
        {

            var list = new List<Product>();
            string sql = "select * from [Product] ";

            if (instock)
            {
                sql += " where quantity > 0";
            }
            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = getCategoryByID(int.Parse(dr["cp_id"].ToString()));
                    Product p = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString(),
                        int.Parse(dr["quantity"].ToString()), int.Parse(dr["price"].ToString()),
                        DateTime.Parse(dr["updated_date"].ToString()), c);
                    list.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return list;
        }


        public IEnumerable<Product> filter(string searchKey = "", string sort = "")
        {

            var list = new List<Product>();
            string sql = "select * from [Product] ";

            sql += " where product_name like '%" + searchKey + "%'";


            if (sort != "None")
            {
                if (sort == "Price")
                {
                    sql += "  order by price asc";
                }
                else if (sort == "Newest")
                {
                    sql += "  order by updated_date asc";
                }
                else
                {
                    sql += "  order by updated_date desc";
                }
            }
            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = getCategoryByID(int.Parse(dr["cp_id"].ToString()));
                    Product p = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString(),
                        int.Parse(dr["quantity"].ToString()), int.Parse(dr["price"].ToString()),
                        DateTime.Parse(dr["updated_date"].ToString()), c);
                    list.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return list;
        }

        private CategoryProduct getCategoryByID(int v)
        {

            string sql = "select * from [CategoryProduct] where cp_id = '" + v + "'";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    CategoryProduct c = new CategoryProduct(int.Parse(dr["cp_id"].ToString()), dr["cp_name"].ToString());
                    return c;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return null;
        }

        public List<Product> GetProductsByCategory(int cp_id)
        {
            var list = new List<Product>();
            string sql = "select * from [Product] where cp_id = '" + cp_id + "' and quantity > 0";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dr.Read())
                {
                    Product c = new Product(int.Parse(dr["product_id"].ToString()), dr["product_name"].ToString());
                    list.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return list;
        }

        public void AddProduct(Product p)
        {
            try
            {

                string sqlInsert = "insert  [Product] values(@product_name, @quantity, @price, getdate(), @cp_id)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@product_name", 50, p.Product_name, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@quantity", 4, p.Quantity, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@price", 4, p.Price, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@cp_id", 4, p.Cp_id, DbType.Int32));

                dataProvider.Insert(sqlInsert, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { CloseConnection(); }
        }

        public void UpdateProduct(Product p)
        {
            try
            {
                string sqlUpdate = "update [Product] set  product_name = @product_name," +
                 " quantity = @quantity, price = @price, updated_date = getdate(),cp_id = @cp_id  where product_id = @product_id";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@product_name", 50, p.Product_name, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@quantity", 4, p.Quantity, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@price", 4, p.Price, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@cp_id", 4, p.Cp_id, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@product_id", 4, p.Product_id, DbType.Int32));

                dataProvider.Update(sqlUpdate, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }



        public CategoryProduct getCategoryByName(string text)
        {

            string sql = "select * from [CategoryProduct] where cp_name = N'" + text + "'";

            IDataReader dr = null;
            try
            {
                dr = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                if (dr.Read())
                {
                    CategoryProduct c = new CategoryProduct(int.Parse(dr["cp_id"].ToString()), dr["cp_name"].ToString());
                    return c;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Close();
                CloseConnection();
            }
            return null;
        }

        public void updateQuantity(int product_id, int quantity)
        {
            try
            {
                string sql = "update [Product] set quantity = quantity + @amount where product_id = @product_id";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@amount", 4, quantity, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@product_id", 4, product_id, DbType.Int32));
                dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
        public void removeProductByProductID(int product_id)
        {
            try
            {
                //string sql = "DELETE FROM [Order_Detail] WHERE order_id = @order_id;";
                string sql = "DELETE FROM Product WHERE product_id = @product_id;";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@product_id", 50, product_id, DbType.Int32));
                dataProvider.Delete(sql, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { CloseConnection(); }
        }
    }
}
