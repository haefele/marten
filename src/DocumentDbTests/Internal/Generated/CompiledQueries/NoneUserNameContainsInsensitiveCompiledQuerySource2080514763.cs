// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Reading.Linq.Compiled;
using Marten.Internal.CompiledQueries;
using Marten.Linq;
using Marten.Linq.QueryHandlers;
using System;

namespace Marten.Generated.CompiledQueries
{
    // START: NoneUserNameContainsInsensitiveCompiledQuery2080514763
    public class NoneUserNameContainsInsensitiveCompiledQuery2080514763 : Marten.Internal.CompiledQueries.ClonedCompiledQuery<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>, DocumentDbTests.Reading.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive>
    {
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _inner;
        private readonly DocumentDbTests.Reading.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive _query;
        private readonly Marten.Linq.QueryStatistics _statistics;
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;

        public NoneUserNameContainsInsensitiveCompiledQuery2080514763(Marten.Linq.QueryHandlers.IMaybeStatefulHandler inner, DocumentDbTests.Reading.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive query, Marten.Linq.QueryStatistics statistics, Marten.Internal.CompiledQueries.HardCodedParameters hardcoded) : base(inner, query, statistics, hardcoded)
        {
            _inner = inner;
            _query = query;
            _statistics = statistics;
            _hardcoded = hardcoded;
        }



        public override void ConfigureCommand(Weasel.Postgresql.CommandBuilder builder, Marten.Internal.IMartenSession session)
        {
            var parameters = builder.AppendWithParameters(@"select d.id, d.data from public.mt_doc_user as d where d.data ->> 'UserName' ILIKE ?");

            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Text;
            parameters[0].Value = ContainsString(_query.Fragment);
        }

    }

    // END: NoneUserNameContainsInsensitiveCompiledQuery2080514763
    
    
    // START: NoneUserNameContainsInsensitiveCompiledQuerySource2080514763
    public class NoneUserNameContainsInsensitiveCompiledQuerySource2080514763 : Marten.Internal.CompiledQueries.CompiledQuerySource<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>, DocumentDbTests.Reading.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive>
    {
        private readonly Marten.Internal.CompiledQueries.HardCodedParameters _hardcoded;
        private readonly Marten.Linq.QueryHandlers.IMaybeStatefulHandler _maybeStatefulHandler;

        public NoneUserNameContainsInsensitiveCompiledQuerySource2080514763(Marten.Internal.CompiledQueries.HardCodedParameters hardcoded, Marten.Linq.QueryHandlers.IMaybeStatefulHandler maybeStatefulHandler)
        {
            _hardcoded = hardcoded;
            _maybeStatefulHandler = maybeStatefulHandler;
        }



        public override Marten.Linq.QueryHandlers.IQueryHandler<System.Collections.Generic.IEnumerable<Marten.Testing.Documents.User>> BuildHandler(DocumentDbTests.Reading.Linq.Compiled.compiled_query_by_string_fragments.UserNameContainsInsensitive query, Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.CompiledQueries.NoneUserNameContainsInsensitiveCompiledQuery2080514763(_maybeStatefulHandler, query, null, _hardcoded);
        }

    }

    // END: NoneUserNameContainsInsensitiveCompiledQuerySource2080514763
    
    
}
