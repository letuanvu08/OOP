using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace WindowsFormsApp
{
    [JsonObject(MemberSerialization.Fields)]
    class ServiceHistory : ISubject 
    {   
        private List<Record> listRecord;
        private List<IObserver> listObserver;
        // Implement the Subject in the OBserver Pattern:
        public void RegisterObserver(IObserver observer)
        {
            listObserver.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            listObserver.Remove(observer);
        }
        public void NotifyObserver()
        {  
            foreach(var observer in listObserver)
            {
                observer.Update(this);
            }
        }

        // Implementing the class itself
        ServiceHistory(List<Record> lst)
        {   
            this.listRecord = lst;
        }
        public ServiceHistory()
        {
            listRecord = new List<Record>();
            listObserver = new List<IObserver>();
        }
        public List<Record> GetListRecord()
        {
            return listRecord;
        }
        public void AddRecord(Record record)
        {
            listRecord.Add(record);
            NotifyObserver();
        }
   
    }

}
