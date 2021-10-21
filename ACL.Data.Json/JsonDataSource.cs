using Newtonsoft.Json;
using ACL.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.Data.Json
{
    /// <summary>
    /// Reads from a Json Data Source.
    /// </summary>
    public class JsonDataSource: QueryableDataSource<JsonDataSourceReader, IDataSourceWriter>
    {
        /// <summary>
        /// Executes a query and returns the first matching item.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>The first matching item.</returns>
        public override TResult ExecuteScalar<TResult>(IDatabaseQueryOptions<TResult> options)
        {
            return default;
        }

        /// <summary>
        /// Executes a query and returns a list of matching objects.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>a list of matching objects.</returns>
        public override IList<TResult> ExecuteQuery<TResult>(IDatabaseQueryOptions<TResult> options)
        {
            return null;
        }

        /// <summary>
        /// Executes a query and returns an IDataReader.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>a reader that can be used to read the results of the query.</returns>
        public override IDataReader ExecuteReader(IDatabaseQueryOptions<IDataReader> options)
        {
            return null;
        }

        /// <summary>
        /// Executes a query and returns a DataSet.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>a DataSet containing the results of the query.</returns>
        public override DataSet ExecuteDataSet(IDatabaseQueryOptions<IDataReader> options)
        {
            return null;
        }

        /// <summary>
        /// Executes a query and returns a DataTable.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>a DataTable containing the results of the query.</returns>
        public override DataTable ExecuteDataTable(IDatabaseQueryOptions<IDataReader> options)
        {
            var dataSet = ExecuteDataSet(options);
            if (dataSet == null)
                return new DataTable();
            return dataSet?.Tables.Cast<DataTable>().FirstOrDefault() ?? new DataTable();
        }

        /// <summary>
        /// Executes a query and returns a DayaView.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="options">The options used to execute the query.</param>
        /// <returns>a DataView containing the results of the query.</returns>
        public override DataView ExecuteDataView(IDatabaseQueryOptions<IDataReader> options)
        {
            return null;
        }

        /// <summary>
        /// Initializes a new instance of the JsonDataSource class using the specified reader and writer.
        /// </summary>
        /// <param name="reader">The reader used to read from the data source.</param>
        /// <param name="writer">The writer used to write to the data source.</param>
        public JsonDataSource(): base(new JsonDataSourceReader(), null)
        {
        }
    }
}
