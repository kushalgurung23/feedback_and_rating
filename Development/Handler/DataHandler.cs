using System;
using System.Data;

namespace Handler
{
    public class DataHandler
    {
        public DataSet CreateDataSet()
        {
            var ds = new DataSet();
            ds.Tables.Add(CreateCriteriaTable());
            ds.Tables.Add(CreateRatingsTable());
            ds.Tables.Add(CreateReportTable());
            return ds;
        }

        private DataTable CreateCriteriaTable()
        {
            var dt = new DataTable("Criteria");
            DataColumn dataColumn = new DataColumn("ID", typeof(int));
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 1;
            dataColumn.AutoIncrementStep = 1;

            dt.Columns.Add(dataColumn);
            dt.Columns.Add("Criteria Name", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            dt.PrimaryKey = new DataColumn[]
            {
                dt.Columns["ID"]
            };
            return dt;
        }

        private DataTable CreateRatingsTable()
        {
            var dt = new DataTable("Ratings");
            DataColumn dataColumn = new DataColumn("ID", typeof(int));
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 1;
            dataColumn.AutoIncrementStep = 1;
            dt.Columns.Add(dataColumn);

            dt.Columns.Add("Service Name", typeof(string));
            dt.Columns.Add("Customer Name", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dt.Columns.Add("Email Address", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Feedback", typeof(string));
            dt.Columns.Add("Date", typeof(string));

            dt.Columns.Add("Criteria", typeof(string));
            dt.Columns.Add("Criteria Value", typeof(string));
            dt.PrimaryKey = new DataColumn[]
            {
                dt.Columns["ID"]
            };

            return dt;
        }

        private DataTable CreateReportTable()
        {
            var dt = new DataTable("Report");
            DataColumn dataColumn = new DataColumn("ID", typeof(int));
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 1;
            dataColumn.AutoIncrementStep = 1;
            dt.Columns.Add(dataColumn);

            dt.Columns.Add("Criteria", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Excellent", typeof(string));
            dt.Columns.Add("Good", typeof(string));
            dt.Columns.Add("Average", typeof(string));
            dt.Columns.Add("Dissatisfied", typeof(string));
            dt.Columns.Add("Mean", typeof(string));
            dt.Columns.Add("Overall", typeof(string));
            
            dt.PrimaryKey = new DataColumn[]
            {
                dt.Columns["ID"]
            };

            return dt;
        }

    }
}
