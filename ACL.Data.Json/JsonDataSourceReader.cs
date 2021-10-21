using System;
using System.Collections.Generic;
using System.Text;

namespace ACL.Data.Json
{
    /// <summary>
    /// Reader used for working with Json data sources.
    /// </summary>
    public class JsonDataSourceReader: DataSourceReader
    {
        /// <summary>
        /// Gets or sets the Json data used for querying.
        /// </summary>
        public IDictionary<string, string> Json { get; set; }

        /// <summary>
        /// If true, caches objects after deserilizing Json.
        /// </summary>
        public bool CacheObjects { get; set; } = true;

        /// <summary>
        /// The cached Json objects.
        /// </summary>
        private List<object> Cache { get; set; }

        /// <summary>
        /// Executes the query against the data source.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The query options.</param>
        /// <returns>A list of objects of type TResult retured by the query.</returns>
        //public override IList<TResult> ExecuteQuery<TResult>(ISksDataSourceQueryOptions options)
        //{
        //    //var json = Json[options.Query];
        //    //List<TResult> result;
        //    //if (CacheObjects)
        //    //{
        //    //    result = Cache?.Cast<TResult>().ToList();
        //    //    if (result == null)
        //    //    {
        //    //        result = JsonConvert.DeserializeObject<List<TResult>>(json);
        //    //        Cache = result.Cast<object>().ToList();
        //    //    }
        //    //}
        //    //else
        //    //    result = JsonConvert.DeserializeObject<List<TResult>>(json);

        //    //if (options.Parameters != null)
        //    //    result.RemoveAll(item => options.Parameters.Any(param => !(param.MatchingFunction?.Invoke(item) ?? true)));

        //    //return result;
        //    return null;
        //}
    }
}
