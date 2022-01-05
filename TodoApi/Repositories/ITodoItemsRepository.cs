using System.Collections.Generic;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Repositories;
public interface ITodoItemsRepository
{
    /// <summary>
    /// Get all items.
    /// </summary>
    /// <returns>The list of items.</returns>
    Task<IEnumerable<TodoItem>> GetAllAsync();

    /// <summary>
    /// Find the target item based on the id.
    /// </summary>
    /// <param name="id">The TodoItem ID.</param>
    /// <returns>The target TodoItem.</returns>
    Task<TodoItem> FindAsync(long id);

    /// <summary>
    /// Add a new item.
    /// </summary>
    /// <param name="item">The target TodoItem.</param>
    /// <returns></returns>
    Task AddAsync(TodoItem item);

    /// <summary>
    /// Remove an item.
    /// </summary>
    /// <param name="item">The target TodoItem.</param>
    /// <returns></returns>
    Task RemoveAsync(TodoItem item);

    /// <summary>
    /// Save changes.
    /// </summary>
    /// <returns></returns>
    Task SaveChangesAsync();

    /// <summary>
    /// Check if the target item exists or not.
    /// </summary>
    /// <param name="id">The TodoItem ID.</param>
    /// <returns>True if it exists.</returns>
    bool DoesItemExist(long id);
}