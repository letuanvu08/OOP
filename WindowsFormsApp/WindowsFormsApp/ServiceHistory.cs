using System;
using System.Collections.Generic;

namespace WindowsFormsApp
{
    class ServiceHistory
    {
        private List<Record> listRecord;

        ServiceHistory(List<Record> lst)
        {
            this.listRecord = lst;
        }
        public ServiceHistory()
        {
            listRecord = new List<Record>();
        }
        public List<Record> GetListRecord()
        {
            return listRecord;
        }
        public void AddRecord(Record record)
        {
            listRecord.Add(record);
            Console.WriteLine(listRecord[listRecord.Count - 1]);
            Console.WriteLine("count: " + listRecord.Count);
        }

    }

}
