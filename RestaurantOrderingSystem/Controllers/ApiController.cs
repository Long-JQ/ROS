using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using RestaurantContext;

namespace RestaurantOrderingSystem.Controllers
{
    //[EnableCors("AllowSameDomain")]
    public class ApiController<T> : Controller where T : BaseEntity, new()
    {
        /// <summary>
        /// 数据访问上下文
        /// </summary>
        public readonly RestaurantDataContext _context;
        /// <summary>
        /// 初始化DbContext
        /// </summary>
        public ApiController(RestaurantDataContext context)
        {
            _context = context;
        }
        public async Task<string> Create(T entity)
        {
            _context.Add<T>(entity);
            await _context.SaveChangesAsync();
            return "true";
        }
        public async Task<string> Delete(string id)
        {
            if (id == null)
            {
                return "false";
            }

            var entity = await _context.FindAsync<T>(id);
            if (entity == null)
            {
                return "false";
            }
            try
            {
                _context.Remove<T>(entity);
                await _context.SaveChangesAsync();
                return "true";
            }
            catch (DbUpdateException /* ex */)
            {
                return "false";
            }
        }
        public async Task<string> Get(string id)
        {
            if (id == null)
            {
                return "false";
            }
            var entity = await _context.FindAsync<T>(id);
            if (entity == null)
            {
                return "false";
            }

            return "true";
        }
        public IEnumerable<T> List(Pagination pagination)
        {
            var entityList = _context.Set<T>().ToList();
            if (entityList.Count > pagination.limit)
            {
                var result = entityList.GetRange(pagination.page * pagination.limit - 1, pagination.limit);
                return result;
            }
            return entityList;
        }
        public async Task<string> Edit(T entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntityExists(entity.Id))
                    {
                        return "false";
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return "true";
        }
        private bool EntityExists(string id)
        {
            return _context.Set<T>().Any(e => e.Id == id);
        }
    }
}