using mind_book_api.Shared.Enums;

namespace mind_book_api.Shared.Extensions
{
    public static class SearchBookParamsExtension
    {
        public static string ToLowerCaseString(this SearchBookParams searchParams) {
            return searchParams.ToString().ToLower();
        }
    }
}
