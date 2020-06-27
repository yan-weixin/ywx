using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class UserService
    {
        private DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public UserDO Insert(UserDO user)
        {
            _context.Set<UserDO>().Add(user);
            _context.SaveChanges();
            return user;
        }
        public IEnumerable<UserDO> GetAll()
        {
            return _context.Set<UserDO>();
        }

        
        public bool GetByKeyword(string keyword,string key)
        {


            
            var result = _context.Set<UserDO>().FirstOrDefault(t => t.UserNumber==keyword);
            if (result == null)
            {
                throw new Exception("没有找到用户名");
               
            }   
            else
            {
                if (key == result.UserPassword)
                {
                    
                    return true;
                }
                else
                {
                    throw new Exception("密码错误");
                }

            }
            return false;


        }
    }
}
