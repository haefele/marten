using System.Threading.Tasks;
using Marten.Testing.Documents;

namespace Marten.Testing.Examples
{
    public class QueryBySql
    {
        public void QueryForWholeDocumentByWhereClause(IQuerySession session)
        {
            #region sample_query_for_whole_document_by_where_clause

            var millers = session
                .Query<User>("where data ->> 'LastName' = 'Miller'");

            #endregion
        }

        public void QueryWithParameters(IQuerySession session)
        {
            #region sample_query_with_sql_async

            var millers = session
                .Query<User>("where data ->> 'LastName' = ?", "Miller");

            #endregion
        }

        public async Task QueryAsynchronously(IQuerySession session)
        {
            #region sample_query_with_sql_and_parameters

            var millers = await session
                .QueryAsync<User>("where data ->> 'LastName' = ?", "Miller");

            #endregion
        }

    }
}
