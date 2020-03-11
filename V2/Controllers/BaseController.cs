
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AngularWeb.Helper;
using AngularWeb.Models;
using AngularWeb.Entities;
using AutoMapper.QueryableExtensions;
using AngularWeb.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AngularWeb.V2.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;

        protected BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a paged set of results.
        /// </summary>
        /// <typeparam name="T">The type of the source IQueryable.</typeparam>
        /// <typeparam name="TReturn">The type of the returned paged results.</typeparam>
        /// <param name="queryable">The source IQueryable.</param>
        /// <param name="page">The page number you want to retrieve.</param>
        /// <param name="pageSize">The size of the page.</param>
        /// <param name="orderBy">The field or property to order by.</param>
        /// <param name="ascending">Whether or not the order should be ascending or descending.</param>
        /// <returns>Returns a paged set of results.</returns>
        protected  PagedResults<TReturn> CreatePagedResults<T, TReturn>(
            IQueryable<T> queryable,
            int page,
            int pageSize,
            string orderBy,
            bool ascending)
        {
            var skipAmount = pageSize * (page - 1);
           
            var projection =queryable
                .OrderByPropertyOrField(orderBy, ascending)
                .Skip(skipAmount)
                .Take(pageSize);

            var totalNumberOfRecords = queryable.Count();
            var results = projection.AsEnumerable();

            var mod = totalNumberOfRecords % pageSize;
            var totalPageCount = (totalNumberOfRecords / pageSize) + (mod == 0 ? 0 : 1);

            var nextPageUrl =
            page == totalPageCount
                ? null
                : Url?.Link("default", new //app.UseEndpoints in startup.cs
                {
                    page = page + 1,
                    pageSize,
                    orderBy,
                    ascending
                });

            return new PagedResults<TReturn>
            {
                Results = _mapper.Map <List<TReturn>> (results),
                PageNumber = page,
                PageSize = results.Count(),
                TotalNumberOfPages = totalPageCount,
                TotalNumberOfRecords = totalNumberOfRecords,
                NextPageUrl = nextPageUrl
            };
        }
    }
}