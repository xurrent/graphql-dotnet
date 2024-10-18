using System.Linq;
using System.Threading.Tasks;

namespace Xurrent.GraphQL
{
    /// <summary>
    /// A set of quick access methods.
    /// </summary>
    public static class XurrentClientExtension
    {
        /// <summary>
        /// Query the Xurrent web service as an asynchronous operation using the <see cref="MeQuery"/> query.
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<Person> Me(this XurrentClient client)
        {
            DataList<Person> people = await client.Get<Person>(Query.Me.SelectAll());
            return people.First();
        }

        /// <summary>
        /// Query the Xurrent web service as an asynchronous operation using the <see cref="AccountQuery"/> query.
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<Account> Account(this XurrentClient client)
        {
            DataList<Account> accounts = await client.Get<Account>(Query.Account.SelectAll());
            return accounts.First();
        }

        /// <summary>
        /// Query the Xurrent web service as an asynchronous operation using the <see cref="RateLimitQuery"/> query.
        /// <br>This returns the cost rate limit, not the request rate limit.</br>
        /// <br>More information about the different types of rate limits can be found on the <see href="https://developer.xurrent.com/graphql/#rate-limits">Xurrent developer pages</see>.</br>
        /// </summary>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public static async Task<RateLimit> RateLimit(this XurrentClient client)
        {
            DataList<RateLimit> rateLimits = await client.Get<RateLimit>(Query.RateLimit.SelectAll());
            return rateLimits.First();
        }
    }
}
