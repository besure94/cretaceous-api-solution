namespace CretaceousApi.Models
{
  public class PagedResponse<T> : Response<T>
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public PagedResponse(T data, int pageNumber, int pageSize)
    {
      // TotalCount = count;
      Data = data;
      PageNumber = pageNumber;
      PageSize = pageSize;
      Message = null;
      Succeeded = true;
      Errors = null;
      // TotalPages = (int)Math.Ceiling(count / (double)pageSize);
      // AddRange(items);
    }

    // public static AnimalList<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
    // {
    //   var count = source.Count();
    //   var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

    //   return new AnimalList<T>(items, count, pageNumber, pageSize);
    // }

  }
}