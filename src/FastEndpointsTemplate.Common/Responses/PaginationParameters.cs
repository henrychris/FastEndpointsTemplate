namespace FastEndpointsTemplate.Common.Responses;

public abstract class PaginationParameters
{
    const int MIN_PAGE_NUMBER = 1;
    const int MIN_PAGE_SIZE = 1;

    public int PageNumber { get; set; } = MIN_PAGE_NUMBER;
    private int _pageSize = MIN_PAGE_SIZE;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value < MIN_PAGE_SIZE ? MIN_PAGE_SIZE : value;
    }
}