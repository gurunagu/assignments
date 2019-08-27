using System;
using DataLayer1;


namespace BussinessLayer
{
    public class BusinessL
    {
        DataC obj = new DataC();
        public void EnterData(string id, string name)
        {
            obj.Insert(id,name);  
        }
        public void DeleteData(string id)
        {
            obj.Delete(id);
        }
        public string[] GetNames()
        {
            return obj.GetNames();
        }
        public int[] GetNo()
        {
            return obj.GetNo();
        }
    }
}
