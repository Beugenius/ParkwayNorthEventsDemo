using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IGenericRepository<T> where T : class 
    {
        // Get a single object by it's key ID 
        T GetById(int id);
        // Get a single object by it's key ID 
        T GetById(Guid id); 
        // used to get (SELECT/WHERE)
        // A Func<T, bool> represents a function that takes an object of type T and returns a bool.
        // It's commonly referred to as a predicate
        // It is used to verify a condition of an object. 
        // Expression<Func<T>> is a description of a function as an expression tree.
        // It can be compiled at runtime that generates a Func<T>
        // It can also be translated to other languages e.g. SQL in LINQ to SQL
        // NoTracking is ReadOnly Results, and Includes is Join of other objects 
        T Get(Expression<Func<T, bool>> predicate, bool asNoTracking = false, string? includes = null);
        // Get object asynchronously 
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, bool asNoTracking = false, string? includes = null);
        // Returns an enumerable list of results to iterate through 
        IEnumerable<T> List();
        // Returns an enumerable list of results to iterate through. Expression is the query, optional Order by. Optional includes join  
        IEnumerable<T> List(Expression<Func<T, bool>>? predicate, Expression<Func<T, int>>? orderBy = null, string? includes = null);
        // Returns an enumerable list of results to iterate through asynchronously. Expression is the query, optional Order by. Optional includes join  
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, int>>? orderBy = null, string? includes = null);
        // Add  a new record instance
        void Add(T entity);
        // Delete a single record instance
        void Delete(T entity);
        // Delete a multiple record instances 
        void Delete(IEnumerable<T> entities);
        // Update all changes in an object 
        void Update(T entity);

    }
}
