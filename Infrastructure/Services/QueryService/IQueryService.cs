
public interface IQueryService
{
    List<UserMarketDto> GetUsersWithMarketNames();
    List<ProductCategoryDto> GetProductsWithCategories();
    List<CategoryAverageRatingDto> GetAverageRatingPerCategory();
    List<UserTotalSpentDto> GetTotalAmountSpentByUsers();
}

public class UserMarketDto
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string MarketName { get; set; }
}

public class ProductCategoryDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string CategoryName { get; set; }
}

public class CategoryAverageRatingDto
{
    public string CategoryName { get; set; }
    public decimal AverageRating { get; set; }
}

public class UserTotalSpentDto
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public decimal TotalSpent { get; set; }
}

namespace Infrastructure.Services.QueryService;