namespace CretaceousApi.Models
{
  public class AnimalParameter
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public AnimalParameter()
    {
      this.PageNumber = 1;
      this.PageSize = 10;
    }
    public AnimalParameter(int pageNumber, int pageSize)
    {
      this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
      this.PageSize = pageSize > 10 ? 10 : pageSize;
    }








    // const int maxPageSize = 50;
    // public int PageNumber { get; set; } = 1;
    // private int _pageSize = 10;
    // public int PageSize
    // {
    //   get
    //   {
    //     return _pageSize;
    //   }
    //   set
    //   {
    //     _pageSize = (value > maxPageSize) ? maxPageSize : value;
    //   }
    // }
  }
}