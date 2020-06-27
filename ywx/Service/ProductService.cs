using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    
    public class ProductService
    {
        private DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public ProductDO Insert(ProductDO product)
        {
            _context.Set<ProductDO>().Add(product);
            _context.SaveChanges();
            return product;
        }
        public void Insertcart(CartDO product)
        {
            _context.Set<CartDO>().Add(product);
            _context.SaveChanges();
            
        }
        public void InsertLine(LineDO product)
        {
            _context.Set<LineDO>().Add(product);
            _context.SaveChanges();

        }
        public IEnumerable<CartDO> GetAllCart(string order)
        {


            if (order == "asc")
            {
                return _context.Set<CartDO>().OrderBy(t => t.Price);
            }

            return _context.Set<CartDO>().OrderByDescending(t => t.Price);
        }

        public IEnumerable<LineDO> GetAllLine()
        {
            return _context.Set<LineDO>();
        }
        public IEnumerable<CartDO> GetUserCart(string order ,string user)
        {
            var reslut = _context.Set<CartDO>().Where(t => t.UserName == user).Where(t=>t.Time=="1");
          
            if (order == "asc")
            {
                return reslut.OrderBy(t => t.Price);

            }

            return reslut.OrderByDescending(t => t.Price);
        }
        public IEnumerable<CartDO> GetAllaCart(String user)
        {

              
            
                return _context.Set<CartDO>().Where(t=>t.UserName==user).Where(t => t.Time == "1"); 
                
          
        }
        public IEnumerable<CartDO> GetAllaaCart(String user)
        {



            return _context.Set<CartDO>().Where(t => t.UserName == user).Where(t => t.Time == "2");


        }
        public IEnumerable<ProductDO> GetAll(string order)
        {
            if (order == "asc")
            {
                return _context.Set<ProductDO>().OrderBy(t => t.Price);
            }

            return _context.Set<ProductDO>().OrderByDescending(t => t.Price);
        }
        public void Delete(long id)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
                throw new Exception("没有找到指定ID的产品记录");
            _context.Set<ProductDO>().Remove(product);
            _context.SaveChanges();

        }
        //删除购物车产品
        public void DeleteCart(long id)
        {
            var product = _context.Set<CartDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
                throw new Exception("没有找到指定ID的产品记录");
            _context.Set<CartDO>().Remove(product);
            _context.SaveChanges();

        }

        public ProductDO GetById(long id)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }
            return product;

        }
        public CartDO GetByCartNumber(String number)
        {
            var product = _context.Set<CartDO>().FirstOrDefault(t => t.ProductNumber==number);
           
            return product;

        }
        public ProductDO GetByNumber(String number)
        {
            var product = _context.Set<ProductDO>().FirstOrDefault(t => t.ProductNumber==number);
            
            return product;

        }
        public CartDO GetByIdCart(long id)
        {
            var product = _context.Set<CartDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }
            return product;

        }
        public LineDO GetByIdLine(long id)
        {
            var product = _context.Set<LineDO>().FirstOrDefault(t => t.Id == id);
            if (product == null)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }
            return product;

        }
        public ProductDO Update(ProductDO product)
        {
            var productExists = _context.Set<ProductDO>().Any(t => t.Id == product.Id);
            if (!productExists)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }

            _context.Set<ProductDO>().Update(product);
            _context.SaveChanges();
            return product;
        }
        //改变用户订单状态
        public LineDO UpdateLine(LineDO product)
        {
            var productExists = _context.Set<LineDO>().Any(t => t.Id == product.Id);
            if (!productExists)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }

            _context.Set<LineDO>().Update(product);
            _context.SaveChanges();
            return product;
        }
        //改变订单产品数量
        public CartDO UpdateShu(CartDO product)
        {
            var productExists = _context.Set<CartDO>().Any(t => t.Id == product.Id);
            if (!productExists)
            {
                throw new Exception("没有找到指定ID的产品记录");
            }

            _context.Set<CartDO>().Update(product);
            _context.SaveChanges();
            return product;
        }
        public UserDO Search(String user)
        {
            var result = _context.Set<UserDO>().FirstOrDefault(t => t.UserNumber == user);
            return result;
        }
        public IEnumerable<ProductDO> GetByKeyword(string keyword)
        {
            var result = _context.Set<ProductDO>().Where(t => t.ProductName.Contains(keyword));
            return result;
        }
        public IEnumerable<ProductDO> GetByCategory(string category)
        {
            var result = _context.Set<ProductDO>().Where(t => t.ProductType == category);
            

            return result;
        }
        
    }
}
